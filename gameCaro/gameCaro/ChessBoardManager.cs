using GameCaro;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


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


        private bool isMyTurn;
        public bool IsMyTurn
        {
            get { return isMyTurn; }
            set { isMyTurn = value; }
        }

        private int count = 0;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private List<List<Button>> matrix;

        private List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        private event EventHandler<ButtonClickEvent> playerMarked;
        public event EventHandler<ButtonClickEvent> PlayerMarked
        {
            add
            {
                playerMarked += value;
            }
            remove
            {
                playerMarked -= value;
            }
        }
        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }

        private Stack<Playinfo> playTimeLine;

        public Stack<Playinfo> PlayTimeLine
        {
            get { return playTimeLine; }
            set { playTimeLine = value; }
        }

        #endregion

        #region Initialize
        public ChessBoardManager(Panel chessBoard, TextBox playerName, PictureBox mark) // cons khởi tạo bàn cờ caro với panel,playername,mark
        {

            this.ChessBoard = chessBoard;
            this.PlayerName1 = playerName;
            this.PlayerMark = mark;
            string projectPath = Directory.GetParent(Application.StartupPath).Parent.FullName; // Lấy đường dẫn thư mục gốc của dự án
            string resourcePath = Path.Combine(projectPath, "Resources"); // Đường dẫn đến thư mục Resources

            this.Player = new List<Player>()
            {
                new Player("Player1", Image.FromFile(Path.Combine(resourcePath, "dau_o.png"))), // Đường dẫn chính xác
                new Player("Player2", Image.FromFile(Path.Combine(resourcePath, "dau_x.png")))
            };
            
        }

        #endregion

        #region Methods
        public void DrawChessBoard()// phương pháp vẽ bàn cờ caro
        {
            ChessBoard.Enabled = true;// bàn cờ caro có thể chơi
            ChessBoard.Controls.Clear();// xóa các button cũ trên bàn cờ caro

            //PlayTimeLine = new Stack<Playinfo>();// khởi tạo stack lưu trữ lịch sử đánh cờ

            CurrentPlayer = 0;
            ChangePlayer(); // đổi lượt chơi cho người khác

            Matrix = new List<List<Button>>();

            for (int i = 0; i < Cons.CHESS_BOARD_HEIGHT; i++) // sửa lại điều kiện logic 
            {
                Matrix.Add(new List<Button>());

                for (int j = 0; j < Cons.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(j * Cons.CHESS_WIDTH, i * Cons.CHESS_HEIGHT), //xác định vị trí chuẩn từng button
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };

                    btn.Click += btn_Click;

                    ChessBoard.Controls.Add(btn);
                    Matrix[i].Add(btn);
                }
            }
        }
        
        void btn_Click(object sender, EventArgs e)
        {
            //Button btn = sender as Button; // Ép kiểu sender về Button (nút được nhấn)

            //if (btn.BackgroundImage != null) // Kiểm tra nếu nút đã có hình (đã được đánh dấu) thì không làm gì cả
            //   return;

            if (!IsMyTurn) // Kiểm tra xem có phải lượt của người chơi không
            {
                return;
            }
            Button btn = sender as Button; // Lấy button được nhấp
            if (btn.BackgroundImage != null) // Nếu button đã có hình nền
                return; // Không làm gì

            Mark(btn); // Đánh dấu ô cờ với hình tương ứng của người chơi hiện tại

            IsMyTurn = false;
           // PlayTimeLine.Push(new Playinfo(GetChessPoint(btn), CurrentPlayer));

           // CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;// sài toán tử ba ngôi dùng để chuyên lượt chơi người này sang người chơi khác (ternary operator)

            ChangePlayer(); // Chuyển lượt sang người chơi tiếp theo
             
            if (playerMarked != null)
                playerMarked(this, new ButtonClickEvent(GetChessPoint(btn)));

            if (isEndGame(btn))
            {
                EndGame();
                MessageBox.Show("Bạn đã thắng!");
                return;
            }

            if (count == Cons.CHESS_BOARD_HEIGHT * Cons.CHESS_BOARD_WIDTH - 1)
            {
                count = 0;
                EndGame();
                MessageBox.Show("Bạn cờ để hết. Hòa!");
            }
            else
            {
                count++;
            }
        }
        public void OtherPlayerMark(Point point) // Đánh dấu ô cờ của người chơi khác
        {
            Button btn = Matrix[point.Y][point.X];
            if (btn.BackgroundImage != null)
                return;

            Mark(btn);
           // PlayTimeLine.Push(new Playinfo(point, CurrentPlayer));
           // CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
            ChangePlayer();
    
            if (isEndGame(btn))
            {
                EndGame();
                MessageBox.Show("Bạn đã thua, đừng nản lòng, làm ván mới nhé!");
                return;
            }

            if (count == Cons.CHESS_BOARD_HEIGHT * Cons.CHESS_BOARD_WIDTH - 1)
            {
                count = 0;
                EndGame();
                MessageBox.Show("Bạn cờ để hết. Hòa!");
            }
            else
            {
                count++;
            }
        }

        public void EndGame() // Hộp thoại thông báo 
        {
            if (endedGame != null)
                endedGame(this, new EventArgs());
        }

       // public bool Reset() 
        //{
        //    if (PlayTimeLine.Count <= 0)
        //        return false;
        //
        //    Playinfo oldPoint = PlayTimeLine.Pop();
        ///    Button btn = Matrix[oldPoint.Point.Y][oldPoint.Point.X];
/////
        //    btn.BackgroundImage = null;
//
        //    if (PlayTimeLine.Count <= 0)                
        //        {                   
        //            CurrentPlayer = 0;
        //        }
         //       else
        //        {
        //            oldPoint = PlayTimeLine.Peek();
        ////            CurrentPlayer = oldPoint.CurrentPlayer == 1 ? 0 : 1;
        //        }
        //
        //    ChangePlayer();
        //
        //    return false;
        //}

        private bool isEndGame(Button btn)
        {
            return isEndHorizontal(btn) || isEndVertical(btn) || isEndPrimary(btn) || isEndSub(btn);
        }

        private Point GetChessPoint(Button btn)
        {

            int vertical = Convert.ToInt32(btn.Tag); // Lấy tọa độ theo dòng
            int horizontal = Matrix[vertical].IndexOf(btn); // Lấy tọa độ theo cột

            Point point = new Point(horizontal, vertical);

            return point;
        }

        private bool isEndHorizontal(Button btn)
        {
            Point point = GetChessPoint(btn); // Lấy điểm của button
            int countLeft = 0; // Đếm số ô liên tiếp sang trái
            for (int i = point.X; i >= 0; i--) // Lặp từ cột hiện tại sang trái
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage) // Nếu ô cùng biểu tượng
                {
                    countLeft++; // Tăng đếm
                }
                else
                    break; // Dừng nếu không giống
            }
            int countRight = 0; // Đếm số ô liên tiếp sang phải
            for (int i = point.X + 1; i < Cons.CHESS_BOARD_WIDTH; i++) // Lặp từ cột hiện tại sang phải
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage) // Nếu ô cùng biểu tượng
                {
                    countRight++; // Tăng đếm
                }
                else
                    break; // Dừng nếu không giống
            }
            return countLeft + countRight == 5; // Trả về true nếu tổng bằng 5
        }

        // Kiểm tra xem có đủ 5 ô liên tiếp theo chiều dọc không
        private bool isEndVertical(Button btn)
        {
            Point point = GetChessPoint(btn); // Lấy điểm của button
            int countTop = 0; // Đếm số ô liên tiếp phía trên
            for (int i = point.Y; i >= 0; i--) // Lặp từ hàng hiện tại lên trên
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage) // Nếu ô cùng biểu tượng
                {
                    countTop++; // Tăng đếm
                }
                else
                    break; // Dừng nếu không giống
            }
            int countBottom = 0; // Đếm số ô liên tiếp phía dưới
            for (int i = point.Y + 1; i < Cons.CHESS_BOARD_HEIGHT; i++) // Lặp từ hàng hiện tại xuống dưới
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage) // Nếu ô cùng biểu tượng
                {
                    countBottom++; // Tăng đếm
                }
                else
                    break; // Dừng nếu không giống
            }
            return countTop + countBottom == 5; // Trả về true nếu tổng bằng 5
        }

        // Kiểm tra xem có đủ 5 ô liên tiếp theo đường chéo chính không
        private bool isEndPrimary(Button btn)
        {
            Point point = GetChessPoint(btn); // Lấy điểm của button
            int countTop = 0; // Đếm số ô liên tiếp trên đường chéo chính
            for (int i = 0; i <= point.X; i++) // Lặp từ vị trí hiện tại đi lên trên và sang phải
            {
                if (point.X + i >= Cons.CHESS_BOARD_WIDTH || point.Y - i < 0) // Kiểm tra giới hạn
                    break;

                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage) // Nếu ô cùng biểu tượng
                {
                    countTop++; // Tăng đếm
                }
                else
                    break; // Dừng nếu không giống
            }
            int countBottom = 0; // Đếm số ô liên tiếp dưới đường chéo chính
            for (int i = 1; i <= Cons.CHESS_BOARD_WIDTH - point.X; i++) // Lặp từ vị trí hiện tại đi xuống dưới và sang trái
            {
                // Kiểm tra giới hạn hàng và cột
                if (point.Y + i >= Cons.CHESS_BOARD_HEIGHT || point.X - i < 0)
                    break;

                // Nếu ô cùng biểu tượng
                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++; // Tăng đếm
                }
                else
                    break; // Dừng nếu không giống
            }

            return countTop + countBottom == 5; // Trả về true nếu tổng bằng 5
        }

        // Kiểm tra xem có đủ 5 ô liên tiếp theo đường chéo phụ không
        private bool isEndSub(Button btn)
        {
            Point point = GetChessPoint(btn); // Lấy điểm của button
            int countTop = 0; // Đếm số ô liên tiếp trên đường chéo phụ
            for (int i = 0; i <= point.X; i++) // Lặp từ vị trí hiện tại đi lên trên và sang trái
            {
                if (point.X - i < 0 || point.Y - i < 0) // Kiểm tra giới hạn
                    break;

                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage) // Nếu ô cùng biểu tượng
                {
                    countTop++; // Tăng đếm
                }
                else
                    break; // Dừng nếu không giống
            }
            int countBottom = 0; // Đếm số ô liên tiếp dưới đường chéo phụ
            for (int i = 1; i <= Cons.CHESS_BOARD_WIDTH - point.X; i++) // Lặp từ vị trí hiện tại đi xuống dưới và sang phải
            {
                if (point.Y + i >= Cons.CHESS_BOARD_HEIGHT || point.X + i >= Cons.CHESS_BOARD_WIDTH) // Kiểm tra giới hạn
                    break;
                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage) // Nếu ô cùng biểu tượng
                {
                    countBottom++; // Tăng đếm
                }
                else
                    break; // Dừng nếu không giống
            }
            return countTop + countBottom == 5; // Trả về true nếu tổng bằng 5
        }


        private void Mark(Button btn) // đánh dấu ô click lên button người chơi 
        {
            btn.BackgroundImage = Player[CurrentPlayer].Mark;
            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;

        }

        private void ChangePlayer() // chuyển lượt người chơi
        {
            PlayerName1.Text = Player[CurrentPlayer].Name;// hiện thị lên tên người chơi trên textBox_playername

            PlayerMark.Image = player[CurrentPlayer].Mark; // hiện lên hình ảnh pictureBox_infoplayer
        }

        #endregion

    }
    public class ButtonClickEvent : EventArgs
    {
        private Point clickedPoint;

        public Point ClickedPoint
        {
            get { return clickedPoint; }
            set { clickedPoint = value; }
        }

        public ButtonClickEvent(Point point)
        {
            this.ClickedPoint = point;
        }
    }
}