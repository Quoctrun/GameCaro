namespace gameCaro
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelChat;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.Button btnLAN;
        private System.Windows.Forms.Button btnReset;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panelChat = new System.Windows.Forms.Panel();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.btnLAN = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.Location = new System.Drawing.Point(12, 12);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(600, 600);
            this.pnlChessBoard.TabIndex = 0;
            // 
            // panelInfo
            // 
            this.panelInfo.Location = new System.Drawing.Point(620, 12);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(200, 150);
            this.panelInfo.TabIndex = 1;
            // 
            // panelChat
            // 
            this.panelChat.Location = new System.Drawing.Point(620, 170);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(200, 300);
            this.panelChat.TabIndex = 2;
            // 
            // txbIP
            // 
            this.txbIP.Location = new System.Drawing.Point(620, 480);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(100, 22);
            this.txbIP.TabIndex = 3;
            // 
            // btnLAN
            // 
            this.btnLAN.Location = new System.Drawing.Point(730, 480);
            this.btnLAN.Name = "btnLAN";
            this.btnLAN.Size = new System.Drawing.Size(90, 23);
            this.btnLAN.TabIndex = 4;
            this.btnLAN.Text = "LAN Connect";
            this.btnLAN.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(620, 510);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(200, 30);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset Game";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1052, 630);
            this.Controls.Add(this.pnlChessBoard);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelChat);
            this.Controls.Add(this.txbIP);
            this.Controls.Add(this.btnLAN);
            this.Controls.Add(this.btnReset);
            this.Name = "Form1";
            this.Text = "Game Caro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
