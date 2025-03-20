using GameCaro;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameCaro
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard; // panel chứa bàn caro pnlChessBoard

        private List<Player> player; // danh sách người chơi

        private int _currentPlayer;// số người chơi hiện tại 

        private PictureBox PlayerMark;// hình ảnh biểu tượng của người chơi hiện lên pictureBox_infoplayer

        private TextBox PlayerName; // ô nhập tên người chơi textBox_playername


        // các thuộc tính truy cập nếu muốn làm y chăng bấm phím tắt ctr + r + e là ra 
        public PictureBox PlayerMark1 { get => PlayerMark; set => PlayerMark = value; }
        
        public Panel ChessBoard { get => chessBoard; set => chessBoard = value; }
        public List<Player> Player { get => player; set => player = value; }
        public int CurrentPlayer { get => _currentPlayer; set => _currentPlayer = value; }
        public TextBox PlayerName1 { get => PlayerName; set => PlayerName = value; }






        #endregion

        #region Initialize
        public ChessBoardManager(Panel chessBoard, TextBox playerName, PictureBox mark) // cons khởi tạo bàn cờ caro với panel,playername,mark
        {
            this.ChessBoard = chessBoard;
            this.PlayerName1 = playerName;
            this.PlayerMark = mark;
            this.Player = new List<Player>()
            {
                new Player("Huy", Image.FromFile(Application.StartupPath + "\\Resources\\dau_o.png")),// trích dẫn file resources
                new Player("Tâm", Image.FromFile(Application.StartupPath + "\\Resources\\dau_x.png"))
            };

            CurrentPlayer = 0;
            ChangePlayer(); // đổi lượt chơi cho người khác 
        }

        #endregion

        #region Methods
        public void DrawChessBoard()// phương pháp vẽ bàn cờ caro
        {
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };//tạo mới button để xác đinnh vị trí ban đầu bàn cơ caro


            for (int i = 0; i < Cons.CHESS_BOARD_HEIGHT; i++)// lặp qua từng hàng chieu cao của bàn cơ caro
            {
                for (int j = 0; j < Cons.CHESS_BOARD_WIDTH; j++)// lặp qua từng hàng chieu rong của bàn cơ caro
                {
                    Button btn = new Button()//tạo một button mới đại diện cho một ô của bàn caro
                    {
                        Width = Cons.CHESS_WIDTH,// độ rộng của ô
                        Height = Cons.CHESS_HEIGHT,// chiều cao của ô
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),// xác định vị trí ô của bàn caro
                        BackgroundImageLayout = ImageLayout.Stretch // thêm code này để hình ảnh png trong file resources vừa khích kích thước button 

                    };

                    btn.Click += btn_Click; // bắt sự kiện click vào button ô cờ 

                    ChessBoard.Controls.Add(btn);// thêm button vào bàn caro

                    oldButton = btn;// cập nhật button cũ để tính toán vị trí tiếp theo
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Cons.CHESS_HEIGHT);// khi hết một hàng, thì xác định lại vị trí của button
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
            MessageBox.Show("Bàn cờ caro đã được tạo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); // hiện lên thông báo khi tạo bàn cơ caro
        }
        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button; // Ép kiểu sender về Button (nút được nhấn)

            if (btn.BackgroundImage != null) // Kiểm tra nếu nút đã có hình (đã được đánh dấu) thì không làm gì cả
                return;

            Mark(btn); // Đánh dấu ô cờ với hình tương ứng của người chơi hiện tại

            ChangePlayer(); // Chuyển lượt sang người chơi tiếp theo

        }


        private void Mark(Button btn) // đánh dấu ô click lên button người chơi 
        {
            btn.BackgroundImage = Player[CurrentPlayer].Mark;

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;// sài toán tử ba ngôi dùng để chuyên lượt chơi người này sang người chơi khác (ternary operator)
        }

        private void ChangePlayer() // chuyển lượt người chơi
        {
            PlayerName1.Text = Player[CurrentPlayer].Name;// hiện thị lên tên người chơi trên textBox_playername

            PlayerMark.Image = player[CurrentPlayer].Mark; // hiện lên hình ảnh pictureBox_infoplayer
        }

        #endregion

    }
}
