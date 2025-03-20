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
        private System.Windows.Forms.TextBox textbox_IP;
        private System.Windows.Forms.Button BtnLAN;
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChat = new System.Windows.Forms.Panel();
            this.progressBar_cooldown = new System.Windows.Forms.ProgressBar();
            this.textBox_playername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_infoplayer = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.BtnLAN = new System.Windows.Forms.Button();
            this.textbox_IP = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_infoplayer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChessBoard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlChessBoard.BackColor = System.Drawing.Color.White;
            this.pnlChessBoard.Location = new System.Drawing.Point(12, 12);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(991, 657);
            this.pnlChessBoard.TabIndex = 0;
            this.pnlChessBoard.TabStop = true;
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.Controls.Add(this.pictureBox_infoplayer);
            this.panelInfo.Location = new System.Drawing.Point(1009, 199);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(193, 175);
            this.panelInfo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::gameCaro.Properties.Resources.thi_dau_co_caro;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelChat
            // 
            this.panelChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelChat.Controls.Add(this.progressBar_cooldown);
            this.panelChat.Controls.Add(this.label1);
            this.panelChat.Controls.Add(this.textBox_playername);
            this.panelChat.Controls.Add(this.btnReset);
            this.panelChat.Controls.Add(this.BtnLAN);
            this.panelChat.Controls.Add(this.textbox_IP);
            this.panelChat.Location = new System.Drawing.Point(1208, 15);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(230, 654);
            this.panelChat.TabIndex = 2;
            // 
            // progressBar_cooldown
            // 
            this.progressBar_cooldown.Location = new System.Drawing.Point(14, 58);
            this.progressBar_cooldown.Name = "progressBar_cooldown";
            this.progressBar_cooldown.Size = new System.Drawing.Size(194, 23);
            this.progressBar_cooldown.TabIndex = 9;
            // 
            // textBox_playername
            // 
            this.textBox_playername.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_playername.Location = new System.Drawing.Point(14, 102);
            this.textBox_playername.Name = "textBox_playername";
            this.textBox_playername.ReadOnly = true;
            this.textBox_playername.Size = new System.Drawing.Size(197, 22);
            this.textBox_playername.TabIndex = 8;
            this.textBox_playername.Text = "player name";
            this.textBox_playername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "5 in a line to win";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_infoplayer
            // 
            this.pictureBox_infoplayer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox_infoplayer.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_infoplayer.Name = "pictureBox_infoplayer";
            this.pictureBox_infoplayer.Size = new System.Drawing.Size(187, 169);
            this.pictureBox_infoplayer.TabIndex = 6;
            this.pictureBox_infoplayer.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(14, 233);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(200, 30);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset Game";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // BtnLAN
            // 
            this.BtnLAN.Location = new System.Drawing.Point(14, 187);
            this.BtnLAN.Name = "BtnLAN";
            this.BtnLAN.Size = new System.Drawing.Size(200, 23);
            this.BtnLAN.TabIndex = 4;
            this.BtnLAN.Text = "LAN Connect";
            this.BtnLAN.UseVisualStyleBackColor = true;
            // 
            // textbox_IP
            // 
            this.textbox_IP.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_IP.Location = new System.Drawing.Point(14, 143);
            this.textbox_IP.Name = "textbox_IP";
            this.textbox_IP.Size = new System.Drawing.Size(200, 22);
            this.textbox_IP.TabIndex = 3;
            this.textbox_IP.Text = "IP";
            this.textbox_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1009, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 178);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1433, 679);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlChessBoard);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelChat);
            this.Name = "Form1";
            this.Text = "Game Caro";
            this.panelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChat.ResumeLayout(false);
            this.panelChat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_infoplayer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox_infoplayer;
        private System.Windows.Forms.TextBox textBox_playername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar_cooldown;
        private System.Windows.Forms.Panel panel1;
    }
}
