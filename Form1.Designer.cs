namespace DIP_Coins_Activity
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
            Button button1;
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            countCoinsToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label6 = new Label();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Poppins ExtraBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.AliceBlue;
            button1.Location = new Point(249, 41);
            button1.Name = "button1";
            button1.Size = new Size(117, 43);
            button1.TabIndex = 10;
            button1.Text = "Count!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, countCoinsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1464, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // countCoinsToolStripMenuItem
            // 
            countCoinsToolStripMenuItem.Name = "countCoinsToolStripMenuItem";
            countCoinsToolStripMenuItem.Size = new Size(14, 24);
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(8, 110);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(694, 809);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(708, 110);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(694, 809);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(160, 34);
            label2.Name = "label2";
            label2.Size = new Size(24, 27);
            label2.TabIndex = 5;
            label2.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 10.8F, FontStyle.Bold);
            label1.Location = new Point(22, 34);
            label1.Name = "label1";
            label1.Size = new Size(132, 32);
            label1.TabIndex = 6;
            label1.Text = "Coint Count: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 10.8F, FontStyle.Bold);
            label4.Location = new Point(22, 68);
            label4.Name = "label4";
            label4.Size = new Size(115, 32);
            label4.TabIndex = 8;
            label4.Text = "Coin Total: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(160, 68);
            label5.Name = "label5";
            label5.Size = new Size(24, 27);
            label5.TabIndex = 9;
            label5.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold);
            label3.Location = new Point(406, 67);
            label3.Name = "label3";
            label3.Size = new Size(118, 26);
            label3.TabIndex = 11;
            label3.Text = "5 Peso Count:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold);
            label7.Location = new Point(559, 67);
            label7.Name = "label7";
            label7.Size = new Size(113, 26);
            label7.TabIndex = 13;
            label7.Text = "1 Peso Count:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold);
            label8.Location = new Point(708, 67);
            label8.Name = "label8";
            label8.Size = new Size(136, 26);
            label8.TabIndex = 14;
            label8.Text = "25 Cents Count:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold);
            label9.Location = new Point(880, 67);
            label9.Name = "label9";
            label9.Size = new Size(132, 26);
            label9.TabIndex = 15;
            label9.Text = "10 Cents Count:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold);
            label10.Location = new Point(1046, 67);
            label10.Name = "label10";
            label10.Size = new Size(127, 26);
            label10.TabIndex = 16;
            label10.Text = "5 Cents Count:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(530, 68);
            label11.Name = "label11";
            label11.Size = new Size(17, 20);
            label11.TabIndex = 17;
            label11.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(678, 67);
            label12.Name = "label12";
            label12.Size = new Size(17, 20);
            label12.TabIndex = 18;
            label12.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(850, 68);
            label13.Name = "label13";
            label13.Size = new Size(17, 20);
            label13.TabIndex = 19;
            label13.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(1018, 68);
            label14.Name = "label14";
            label14.Size = new Size(17, 20);
            label14.TabIndex = 20;
            label14.Text = "0";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(1179, 68);
            label15.Name = "label15";
            label15.Size = new Size(17, 20);
            label15.TabIndex = 21;
            label15.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(406, 41);
            label6.Name = "label6";
            label6.Size = new Size(204, 26);
            label6.TabIndex = 22;
            label6.Text = "INDIVIDUAL COINS COUNT";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1464, 975);
            Controls.Add(label6);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ToolStripMenuItem countCoinsToolStripMenuItem;
        private Label label2;
        private SaveFileDialog saveFileDialog1;
        private Label label1;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label label3;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label6;
    }
}
