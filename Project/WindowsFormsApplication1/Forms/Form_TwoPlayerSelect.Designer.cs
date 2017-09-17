namespace WindowsFormsApplication1
{
    partial class Form_TwoPlayerOptions
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_PlayerOneChoose = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_PlayerTwoChoose = new System.Windows.Forms.Button();
            this.textBox_PlayerTwoName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Play = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_PlayerOneChoose);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textBox_Name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player 1 :";
            // 
            // button_PlayerOneChoose
            // 
            this.button_PlayerOneChoose.Location = new System.Drawing.Point(56, 59);
            this.button_PlayerOneChoose.Name = "button_PlayerOneChoose";
            this.button_PlayerOneChoose.Size = new System.Drawing.Size(197, 28);
            this.button_PlayerOneChoose.TabIndex = 3;
            this.button_PlayerOneChoose.Text = "Choose";
            this.button_PlayerOneChoose.UseVisualStyleBackColor = true;
            this.button_PlayerOneChoose.Click += new System.EventHandler(this.button_PlayerOneChoose_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(56, 28);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(197, 20);
            this.textBox_Name.TabIndex = 1;
            this.textBox_Name.Text = "Red";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_PlayerTwoChoose);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.textBox_PlayerTwoName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player 2 :";
            // 
            // button_PlayerTwoChoose
            // 
            this.button_PlayerTwoChoose.Location = new System.Drawing.Point(56, 59);
            this.button_PlayerTwoChoose.Name = "button_PlayerTwoChoose";
            this.button_PlayerTwoChoose.Size = new System.Drawing.Size(197, 28);
            this.button_PlayerTwoChoose.TabIndex = 3;
            this.button_PlayerTwoChoose.Text = "Choose";
            this.button_PlayerTwoChoose.UseVisualStyleBackColor = true;
            this.button_PlayerTwoChoose.Click += new System.EventHandler(this.button_PlayerTwoChoose_Click);
            // 
            // textBox_PlayerTwoName
            // 
            this.textBox_PlayerTwoName.Location = new System.Drawing.Point(56, 28);
            this.textBox_PlayerTwoName.Name = "textBox_PlayerTwoName";
            this.textBox_PlayerTwoName.Size = new System.Drawing.Size(197, 20);
            this.textBox_PlayerTwoName.TabIndex = 1;
            this.textBox_PlayerTwoName.Text = "Blue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name :";
            // 
            // button_Play
            // 
            this.button_Play.Location = new System.Drawing.Point(25, 224);
            this.button_Play.Name = "button_Play";
            this.button_Play.Size = new System.Drawing.Size(247, 42);
            this.button_Play.TabIndex = 2;
            this.button_Play.Text = "Play";
            this.button_Play.UseVisualStyleBackColor = true;
            this.button_Play.Click += new System.EventHandler(this.button_Play_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.f16_3;
            this.pictureBox2.Location = new System.Drawing.Point(14, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.f16_2;
            this.pictureBox1.Location = new System.Drawing.Point(14, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form_TwoPlayerOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 278);
            this.Controls.Add(this.button_Play);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_TwoPlayerOptions";
            this.Text = "Connect4 : Two Player Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_PlayerOneChoose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_PlayerTwoChoose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox_PlayerTwoName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Play;
    }
}