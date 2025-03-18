namespace Game_Caro_lan
{
    public partial class Form1 : Form
    {
        #region Properties;
        Chessbroadmanager ChessBroad;
        #endregion
        public Form1()
        {
            InitializeComponent();

            ChessBroad = new Chessbroadmanager(panelchessbroad);
            ChessBroad.Drawchessbroad();
        }
    }
}
