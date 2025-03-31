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

        }
    
        #region
        void EndGame()
        {
            tmcooldown.Stop();// Dừng đếm thời gian
            pnlChessBoard.Enabled = false;// Không cho người chơi đánh tiếp
            resetToolStripMenuItem.Enabled = false;// Không cho phép quay lại
            MessageBox.Show("Kết thúc");
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
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                Application.Exit();// Thoát ứng dụng           
        }

        void Reset()
        {
            ChessBoard.Reset();// Đặt lại bàn cờ
        }
        private void ChessBoard_PlayerMarked(object sender, ButtonClickEvent e)
        {
            tmcooldown.Start();// Bắt đầu đếm thời gian
            pnlChessBoard.Enabled = false;// Không cho người chơi đánh tiếp
            progressBar_cooldown.Value = 0;// Đặt giá trị ban đầu của progressbar
            socket.Send(new SocketData((int)SocketCommand.SEND_POINT, "", e.ClickedPoint));


            Listen();
        }
        private void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
        }
                  
        private void progressBar_cooldown_Click(object sender, EventArgs e)
        {

        }

        private void tmcooldown_Tick(object sender, EventArgs e)
        {
            progressBar_cooldown.PerformStep();// Cập nhật giá trị của progressbar
            
            if (progressBar_cooldown.Value >= progressBar_cooldown.Maximum)
            {
                
                EndGame();// Kết thúc game
            }
        }

        private void panelChat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox_infoplayer_Click(object sender, EventArgs e)
        {

        }

        private void textbox_IP_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_playername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
        }
      
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
                      e.Cancel = true;
        }

        #endregion

        private void BtnLAN_Click(object sender, EventArgs e)
        {
            socket.IP = textbox_IP.Text;

            if (!socket.ConnectServer())
            { 
                socket.isServer = true;
                pnlChessBoard.Enabled = true;
                socket.CreateServer();

            }
            else
            {
                socket.isServer = false;
                pnlChessBoard.Enabled = false;
                Listen();

            }

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
                    break;
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                     progressBar_cooldown.Value = 0;
                     pnlChessBoard.Enabled = true;
                     tmcooldown.Start();
                     ChessBoard.OtherPlayerMark(data.Point);
                    }));
                    break;
                case (int)SocketCommand.UNDO:
                    break;
                case (int)SocketCommand.END_GAME:
                    break;
                case (int)SocketCommand.QUIT:
                    break;
                default:
                    break;
            }

            Listen();
        }

    }
}
