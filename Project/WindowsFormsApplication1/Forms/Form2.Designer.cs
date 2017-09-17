namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton_PlayerOne = new System.Windows.Forms.RadioButton();
            this.radioButton_TwoPlayers = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // radioButton_PlayerOne
            // 
            this.radioButton_PlayerOne.AutoSize = true;
            this.radioButton_PlayerOne.Location = new System.Drawing.Point(19, 21);
            this.radioButton_PlayerOne.Name = "radioButton_PlayerOne";
            this.radioButton_PlayerOne.Size = new System.Drawing.Size(77, 17);
            this.radioButton_PlayerOne.TabIndex = 2;
            this.radioButton_PlayerOne.TabStop = true;
            this.radioButton_PlayerOne.Text = "One Player";
            this.radioButton_PlayerOne.UseVisualStyleBackColor = true;
            this.radioButton_PlayerOne.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton_TwoPlayers
            // 
            this.radioButton_TwoPlayers.AutoSize = true;
            this.radioButton_TwoPlayers.Location = new System.Drawing.Point(127, 21);
            this.radioButton_TwoPlayers.Name = "radioButton_TwoPlayers";
            this.radioButton_TwoPlayers.Size = new System.Drawing.Size(83, 17);
            this.radioButton_TwoPlayers.TabIndex = 3;
            this.radioButton_TwoPlayers.TabStop = true;
            this.radioButton_TwoPlayers.Text = "Two Players";
            this.radioButton_TwoPlayers.UseVisualStyleBackColor = true;
            this.radioButton_TwoPlayers.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_PlayerOne);
            this.groupBox1.Controls.Add(this.radioButton_TwoPlayers);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 50);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 117);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Connect4 : Main";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton_PlayerOne;
        private System.Windows.Forms.RadioButton radioButton_TwoPlayers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}