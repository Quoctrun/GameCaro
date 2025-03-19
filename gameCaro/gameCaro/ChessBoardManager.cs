using GameCaro;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameCaro
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;// pane; chưa bàn cờ caro

        public Panel Chessboard
        {
            get { return chessBoard; }// trả về panel chứa bàn cờ caro
            set { chessBoard = value; }// gán giá trị cho panel bàn cơ caro
        }
        #endregion

        #region Initialize
        public ChessBoardManager(Panel chessBoard) // cons khởi tạo bàn cờ caro với panel của caro
        {
            this.Chessboard = chessBoard;
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
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y)// xác định vị trí ô của bàn caro
                    };

                    Chessboard.Controls.Add(btn);// them button vào bàn caro

                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Cons.CHESS_HEIGHT);// khi hết một hàng, thì xác định lại vị trí của button
                oldButton.Width = 0;
            }
            MessageBox.Show("Bàn cờ caro đã được tạo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); // hiện lên thông báo khi tạo bàn cơ caro
        }
        #endregion
    }
}
