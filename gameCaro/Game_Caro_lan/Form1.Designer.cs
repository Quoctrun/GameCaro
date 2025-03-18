namespace Game_Caro_lan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelchessbroad = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            button_lan = new Button();
            textBox_ip = new TextBox();
            pictureBox1 = new PictureBox();
            progressBar_cooldown = new ProgressBar();
            textBox_player_name = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelchessbroad
            // 
            panelchessbroad.BackColor = SystemColors.ControlLightLight;
            panelchessbroad.Location = new Point(12, 12);
            panelchessbroad.Name = "panelchessbroad";
            panelchessbroad.Size = new Size(571, 554);
            panelchessbroad.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(589, 17);
            panel2.Name = "panel2";
            panel2.Size = new Size(357, 257);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Enabled = false;
            pictureBox2.Image = Properties.Resources.thi_dau_co_caro;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(351, 251);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(button_lan);
            panel3.Controls.Add(textBox_ip);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(progressBar_cooldown);
            panel3.Controls.Add(textBox_player_name);
            panel3.Location = new Point(607, 288);
            panel3.Name = "panel3";
            panel3.Size = new Size(339, 278);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 213);
            label1.Name = "label1";
            label1.Size = new Size(244, 39);
            label1.TabIndex = 5;
            label1.Text = "5 in a line to win";
            // 
            // button_lan
            // 
            button_lan.Location = new Point(16, 158);
            button_lan.Name = "button_lan";
            button_lan.Size = new Size(164, 29);
            button_lan.TabIndex = 4;
            button_lan.Text = "LAN";
            button_lan.UseVisualStyleBackColor = true;
            // 
            // textBox_ip
            // 
            textBox_ip.Location = new Point(16, 109);
            textBox_ip.Name = "textBox_ip";
            textBox_ip.Size = new Size(164, 27);
            textBox_ip.TabIndex = 3;
            textBox_ip.Text = "127.0.0.1";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Location = new Point(186, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 119);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // progressBar_cooldown
            // 
            progressBar_cooldown.Location = new Point(16, 63);
            progressBar_cooldown.Name = "progressBar_cooldown";
            progressBar_cooldown.Size = new Size(164, 29);
            progressBar_cooldown.TabIndex = 1;
            // 
            // textBox_player_name
            // 
            textBox_player_name.Location = new Point(16, 17);
            textBox_player_name.Name = "textBox_player_name";
            textBox_player_name.ReadOnly = true;
            textBox_player_name.Size = new Size(164, 27);
            textBox_player_name.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 578);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panelchessbroad);
            Name = "Form1";
            Text = "Game Caro LAN";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelchessbroad;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Button button_lan;
        private TextBox textBox_ip;
        private PictureBox pictureBox1;
        private ProgressBar progressBar_cooldown;
        private TextBox textBox_player_name;
        private PictureBox pictureBox2;
    }
}
