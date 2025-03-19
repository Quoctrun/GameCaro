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
        ChessBroadManager ChessBoard;
        #endregion
        public Form1()
        {
            InitializeComponent();

            ChessBoard = new ChessBroadManager(panelChessBoard);

            ChessBoard.DrawChessBoard();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
