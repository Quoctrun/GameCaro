using GameCaro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gameCaro
{
    public partial class Form1 : Form
    {

        #region Properties
        ChessBoardManager ChessBoard; // Khai báo một đối tượng quản lý bàn cờ Caro
        SocketManager socket;
        // Cờ để đánh dấu liệu đang trong quá trình kết nối hay không
        bool isConnecting = false;
        #endregion
        public Form1()
        {
            InitializeComponent();// Khởi tạo các thành phần giao diện của Form

            Control.CheckForIllegalCrossThreadCalls = false;// Không kiểm tra lỗi giao diện

            ChessBoard = new ChessBoardManager(pnlChessBoard, textBox_playername, pictureBox_infoplayer);// Khởi tạo đối tượng quản lý bàn cờ với Panelchess,playername,picture_info
            ChessBoard.EndedGame += ChessBoard_EndedGame;// Gán sự kiện kết thúc game cho bàn cờ
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;// Gán sự kiện đánh cờ cho bàn cờ 


            progressBar_cooldown.Step = Cons.COOL_DOWN_STEP;// Đặt giá trị bước nhảy của progressbar
            progressBar_cooldown.Maximum = Cons.COOL_DOWN_TIME;// Đặt giá trị lớn nhất của progressbar
            progressBar_cooldown.Value = 0;// Đặt giá trị ban đầu của progressbar

            tmcooldown.Interval = Cons.COOL_DOWN_INTERVAL;// Đặt thời gian cập nhật của progressbar

            ChessBoard.DrawChessBoard();// Vẽ bàn cờ khi Form được khởi tạo

            socket = new SocketManager();// Khởi tạo đối tượng socket   
            NewGame();

            // Đăng ký sự kiện khi khách hàng kết nối
            socket.OnClientConnected += (message) =>
            {
                // Đảm bảo cập nhật giao diện người dùng trên luồng chính
                this.Invoke((MethodInvoker)(() =>
                {
                    rtbChatBox.AppendText(message + Environment.NewLine);
                    Listen(); // Bắt đầu lắng nghe dữ liệu đến
                }));

            };
        }
    
        #region
        void EndGame()
        {
            tmcooldown.Stop();// Dừng đếm thời gian
            pnlChessBoard.Enabled = false;// Không cho người chơi đánh tiếp
            //resetToolStripMenuItem.Enabled = false;// Không cho phép quay lại
            ChessBoard.IsMyTurn = false;
        }

        void NewGame()
        {
            progressBar_cooldown.Value = 0;// Đặt giá trị ban đầu của progressbar
            tmcooldown.Stop();// Dừng đếm thời gian
            resetToolStripMenuItem.Enabled = true;// Cho phép quay lại
            ChessBoard.DrawChessBoard();// Vẽ lại bàn cờ
        }

        void Quit()
        {
            //if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                Application.Exit();// Thoát ứng dụng           
        }

        //void Reset()
        //{
        //    ChessBoard.Reset();// Đặt lại bàn cờ
        //}
        private void ChessBoard_PlayerMarked(object sender, ButtonClickEvent e)
        {
            tmcooldown.Start();// Bắt đầu đếm thời gian
            //pnlChessBoard.Enabled = false;// Không cho người chơi đánh tiếp
            ChessBoard.IsMyTurn = false;
            progressBar_cooldown.Value = 0;// Đặt giá trị ban đầu của progressbar
            socket.Send(new SocketData((int)SocketCommand.SEND_POINT, "", e.ClickedPoint));
            Listen();
        }
        private void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
            socket.Send(new SocketData((int)SocketCommand.END_GAME, "", new Point()));
        }

        private void progressBar_cooldown_Click(object sender, EventArgs e)
        {

        }

        private void tmcooldown_Tick(object sender, EventArgs e)
        {
            progressBar_cooldown.PerformStep();// Cập nhật giá trị của progressbar
            
            if (progressBar_cooldown.Value >= progressBar_cooldown.Maximum && ChessBoard.IsMyTurn)
            {
                
                EndGame();// Kết thúc game
                MessageBox.Show("Bạn đã thua do hết thời gian!");
                socket.Send(new SocketData((int)SocketCommand.TIME_OUT, "", new Point()));
            }
        }

        private void panelChat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox_infoplayer_Click(object sender, EventArgs e)
        {

        }
        private void txt_result_TextChanged(object sender, EventArgs e)
        {
            // Chưa có hành động được định nghĩa
        }
        private void textbox_IP_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_playername_TextChanged(object sender, EventArgs e)
        {

        }


        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
            socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
            //pnlChessBoard.Enabled = true;
            ChessBoard.IsMyTurn = true;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Reset();
        }
      
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    if (!socket.IsConnected) return;

                    socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                }
                catch { }
            }
        }

        #endregion
        private void BtnLAN_Click_1(object sender, EventArgs e)
        {
            //socket.IP = textbox_IP.Text; // Lấy IP từ TextBox

            //if (!socket.ConnectServer()) // Nếu không thể kết nối, tạo server
            ///{
            //    socket.isServer = true;
            //     pnlChessBoard.Enabled = true; // Bật bàn cờ cho người tạo server
            //     socket.CreateServer(); // Tạo server
            //     MessageBox.Show("Server đã được tạo!");
            // }
            // else // Nếu kết nối thành công
            // {
            //     socket.isServer = false;
            ////      pnlChessBoard.Enabled = false; // Đối thủ chờ lượt
            //     MessageBox.Show("Kết nối thành công!");
            // }

            // Gọi hàm Listen ngay sau khi kết nối thành công
            //  Listen();

            if (socket.IsConnected) // Kiểm tra xem đã kết nối chưa
            {
                MessageBox.Show("Đã kết nối rồi");
                return;
            }
            else if (isConnecting)
            {
                MessageBox.Show("Đang trong quá trình kết nối. Vui lòng đợi...");
                return;
            }
            isConnecting = true; // Đặt cờ đang kết nối
            socket.IP = textbox_IP.Text; // Lấy địa chỉ IP từ textbox

            if (!socket.ConnectServer()) // Cố gắng kết nối như một client
            {
                // Nếu kết nối thất bại, trở thành server
                socket.isServer = true;
                //pnlBanCo.Enabled = true; // Kích hoạt bảng cờ cho server
                ChessBoard.IsMyTurn = false;
                socket.CreateServer(); // Tạo socket server
                rtbChatBox.AppendText("Server đang chờ kết nối..." + Environment.NewLine); // "Server is waiting for connection..."
            }
            else
            {
                // Kết nối thành công như một client
                socket.isServer = false;
                //pnlBanCo.Enabled = false; // Vô hiệu hóa bảng cờ cho đến khi đối thủ di chuyển
                ChessBoard.IsMyTurn = true;
                rtbChatBox.AppendText("Đã kết nối với server." + Environment.NewLine); // "Connected to server."
                Listen(); // Bắt đầu lắng nghe dữ liệu đến
            }
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            textbox_IP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);

            if (string.IsNullOrEmpty(textbox_IP.Text))
            {
                textbox_IP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
        }

        void Listen()
        {
                Thread listenThread = new Thread(() =>
                {
                    try
                    {
                        SocketData data = (SocketData)socket.Receive();
                        ProcessData(data);
                    }
                catch (Exception e  )
                    { }
                });
                listenThread.IsBackground = true;
                listenThread.Start();
          
        }
        private void ProcessData(SocketData data)
        {
            switch (data.Command)
            {
                case (int)SocketCommand.NOTIFY:
                    MessageBox.Show(data.Message);
                    break;
                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        //pnlChessBoard.Enabled = false;
                    }));
                    break;
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                     progressBar_cooldown.Value = 0;
                     //pnlChessBoard.Enabled = true;
                     tmcooldown.Start();
                     ChessBoard.OtherPlayerMark(data.Point);
                        ChessBoard.IsMyTurn = true;
                    }));
                    break;
                    
                case (int)SocketCommand.SEND_MESSAGE: // Xử lý tin nhắn nhận được
                    this.Invoke((MethodInvoker)(() =>
                    {
                        rtbChatBox.AppendText("Opponent: " + data.Message + Environment.NewLine);
                    }));
                    break;

                case (int)SocketCommand.END_GAME:
                    //MessageBox.Show("Đã 5 con trên 1 hàng");
                    break;
                case (int)SocketCommand.TIME_OUT:
                    EndGame();
                    MessageBox.Show("Bạn đã thắng! Đối thủ hết thời gian.");
                    break;
                case (int)SocketCommand.QUIT:
                    tmcooldown.Stop();
                    MessageBox.Show("Người chơi đã thoát");
                    break;
                default:
                    break;
            }

            Listen();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChatInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSendChat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtChatInput.Text)) // Nếu tin nhắn không rỗng
            {
                // Hiển thị tin nhắn trong RichTextBox
                rtbChatBox.AppendText("You: " + txtChatInput.Text + Environment.NewLine);

                // Gửi tin nhắn qua socket
                socket.Send(new SocketData(
                    (int)SocketCommand.SEND_MESSAGE, // Lệnh gửi tin nhắn
                    txtChatInput.Text,               // Nội dung tin nhắn
                    new Point()                      // Không cần tọa độ
                ));

                // Xóa nội dung trong ô nhập
                txtChatInput.Clear();
            }
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
    
  
}
