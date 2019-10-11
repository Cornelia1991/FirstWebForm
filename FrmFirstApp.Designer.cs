namespace FirstApp
{
    partial class FrmFirstApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFirstApp));
            this.LblTitle = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.PicOne = new System.Windows.Forms.PictureBox();
            this.PicTwo = new System.Windows.Forms.PictureBox();
            this.BtnHello = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GrpMood = new System.Windows.Forms.GroupBox();
            this.GrpOther = new System.Windows.Forms.GroupBox();
            this.BtnHappy = new System.Windows.Forms.RadioButton();
            this.BtnSad = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.PicHappy = new System.Windows.Forms.PictureBox();
            this.PicSad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTwo)).BeginInit();
            this.GrpMood.SuspendLayout();
            this.GrpOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicHappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSad)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(123, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(277, 25);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Welcome To My First Program";
            this.LblTitle.Click += new System.EventHandler(this.Label1_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(177, 70);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(208, 22);
            this.TxtName.TabIndex = 1;
            // 
            // PicOne
            // 
            this.PicOne.Image = global::FirstApp.Properties.Resources.cherryBlossom__2_;
            this.PicOne.Location = new System.Drawing.Point(44, 111);
            this.PicOne.Name = "PicOne";
            this.PicOne.Size = new System.Drawing.Size(202, 159);
            this.PicOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicOne.TabIndex = 2;
            this.PicOne.TabStop = false;
            // 
            // PicTwo
            // 
            this.PicTwo.Image = ((System.Drawing.Image)(resources.GetObject("PicTwo.Image")));
            this.PicTwo.Location = new System.Drawing.Point(315, 111);
            this.PicTwo.Name = "PicTwo";
            this.PicTwo.Size = new System.Drawing.Size(204, 159);
            this.PicTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTwo.TabIndex = 3;
            this.PicTwo.TabStop = false;
            // 
            // BtnHello
            // 
            this.BtnHello.Location = new System.Drawing.Point(73, 333);
            this.BtnHello.Name = "BtnHello";
            this.BtnHello.Size = new System.Drawing.Size(137, 36);
            this.BtnHello.TabIndex = 4;
            this.BtnHello.Text = "Hello";
            this.BtnHello.UseVisualStyleBackColor = true;
            this.BtnHello.Click += new System.EventHandler(this.BtnHello_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(371, 333);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(125, 36);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // GrpMood
            // 
            this.GrpMood.Controls.Add(this.BtnSad);
            this.GrpMood.Controls.Add(this.BtnHappy);
            this.GrpMood.Location = new System.Drawing.Point(620, 70);
            this.GrpMood.Name = "GrpMood";
            this.GrpMood.Size = new System.Drawing.Size(147, 159);
            this.GrpMood.TabIndex = 6;
            this.GrpMood.TabStop = false;
            this.GrpMood.Text = "Moods";
            // 
            // GrpOther
            // 
            this.GrpOther.Controls.Add(this.radioButton4);
            this.GrpOther.Controls.Add(this.radioButton3);
            this.GrpOther.Location = new System.Drawing.Point(620, 291);
            this.GrpOther.Name = "GrpOther";
            this.GrpOther.Size = new System.Drawing.Size(146, 109);
            this.GrpOther.TabIndex = 7;
            this.GrpOther.TabStop = false;
            this.GrpOther.Text = "groupBox1";
            // 
            // BtnHappy
            // 
            this.BtnHappy.AutoSize = true;
            this.BtnHappy.Location = new System.Drawing.Point(16, 25);
            this.BtnHappy.Name = "BtnHappy";
            this.BtnHappy.Size = new System.Drawing.Size(70, 21);
            this.BtnHappy.TabIndex = 0;
            this.BtnHappy.TabStop = true;
            this.BtnHappy.Text = "Happy";
            this.BtnHappy.UseVisualStyleBackColor = true;
            this.BtnHappy.CheckedChanged += new System.EventHandler(this.BtnHappy_CheckedChanged);
            // 
            // BtnSad
            // 
            this.BtnSad.AutoSize = true;
            this.BtnSad.Location = new System.Drawing.Point(16, 63);
            this.BtnSad.Name = "BtnSad";
            this.BtnSad.Size = new System.Drawing.Size(54, 21);
            this.BtnSad.TabIndex = 1;
            this.BtnSad.TabStop = true;
            this.BtnSad.Text = "Sad";
            this.BtnSad.UseVisualStyleBackColor = true;
            this.BtnSad.CheckedChanged += new System.EventHandler(this.BtnSad_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(20, 31);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(110, 21);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(23, 71);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(110, 21);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // PicHappy
            // 
            this.PicHappy.Image = ((System.Drawing.Image)(resources.GetObject("PicHappy.Image")));
            this.PicHappy.Location = new System.Drawing.Point(828, 80);
            this.PicHappy.Name = "PicHappy";
            this.PicHappy.Size = new System.Drawing.Size(90, 61);
            this.PicHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicHappy.TabIndex = 8;
            this.PicHappy.TabStop = false;
            this.PicHappy.Visible = false;
            // 
            // PicSad
            // 
            this.PicSad.Image = ((System.Drawing.Image)(resources.GetObject("PicSad.Image")));
            this.PicSad.Location = new System.Drawing.Point(827, 161);
            this.PicSad.Name = "PicSad";
            this.PicSad.Size = new System.Drawing.Size(91, 55);
            this.PicSad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSad.TabIndex = 9;
            this.PicSad.TabStop = false;
            this.PicSad.Visible = false;
            // 
            // FrmFirstApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(970, 568);
            this.Controls.Add(this.PicSad);
            this.Controls.Add(this.PicHappy);
            this.Controls.Add(this.GrpOther);
            this.Controls.Add(this.GrpMood);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnHello);
            this.Controls.Add(this.PicTwo);
            this.Controls.Add(this.PicOne);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblTitle);
            this.Name = "FrmFirstApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "First App";
            this.Load += new System.EventHandler(this.FrmFirstApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTwo)).EndInit();
            this.GrpMood.ResumeLayout(false);
            this.GrpMood.PerformLayout();
            this.GrpOther.ResumeLayout(false);
            this.GrpOther.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicHappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.PictureBox PicOne;
        private System.Windows.Forms.PictureBox PicTwo;
        private System.Windows.Forms.Button BtnHello;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox GrpMood;
        private System.Windows.Forms.GroupBox GrpOther;
        private System.Windows.Forms.RadioButton BtnSad;
        private System.Windows.Forms.RadioButton BtnHappy;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.PictureBox PicHappy;
        private System.Windows.Forms.PictureBox PicSad;
    }
}

