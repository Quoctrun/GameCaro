using GameCaro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameCaro
{
    public partial class Form1 : Form
    {
        #region Properties
        ChessBoardManager ChessBoard; // Khai báo một đối tượng quản lý bàn cờ Caro
        #endregion
        public Form1()
        {
            InitializeComponent();// Khởi tạo các thành phần giao diện của Form

            ChessBoard = new ChessBoardManager(pnlChessBoard);// Khởi tạo đối tượng quản lý bàn cờ với Panel chứa bàn cờ (pnlChessBoard)


            ChessBoard.DrawChessBoard();// Vẽ bàn cờ khi Form được khởi tạo
        }
   


    }
}
