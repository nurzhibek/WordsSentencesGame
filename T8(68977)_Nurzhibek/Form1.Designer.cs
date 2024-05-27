namespace T8_68977__Nurzhibek
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.word_radio = new System.Windows.Forms.RadioButton();
            this.senten_radio = new System.Windows.Forms.RadioButton();
            this.both_radio = new System.Windows.Forms.RadioButton();
            this.exit_btn = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(291, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Type";
            // 
            // word_radio
            // 
            this.word_radio.AutoSize = true;
            this.word_radio.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.word_radio.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word_radio.ForeColor = System.Drawing.Color.SaddleBrown;
            this.word_radio.Location = new System.Drawing.Point(53, 128);
            this.word_radio.Name = "word_radio";
            this.word_radio.Size = new System.Drawing.Size(138, 28);
            this.word_radio.TabIndex = 1;
            this.word_radio.TabStop = true;
            this.word_radio.Text = "Words Only";
            this.word_radio.UseVisualStyleBackColor = false;
            // 
            // senten_radio
            // 
            this.senten_radio.AutoSize = true;
            this.senten_radio.BackColor = System.Drawing.Color.PaleGreen;
            this.senten_radio.Font = new System.Drawing.Font("Georgia", 12F);
            this.senten_radio.ForeColor = System.Drawing.Color.DarkGreen;
            this.senten_radio.Location = new System.Drawing.Point(287, 128);
            this.senten_radio.Name = "senten_radio";
            this.senten_radio.Size = new System.Drawing.Size(169, 28);
            this.senten_radio.TabIndex = 2;
            this.senten_radio.TabStop = true;
            this.senten_radio.Text = "Sentences Only";
            this.senten_radio.UseVisualStyleBackColor = false;
            // 
            // both_radio
            // 
            this.both_radio.AutoSize = true;
            this.both_radio.BackColor = System.Drawing.Color.Pink;
            this.both_radio.Font = new System.Drawing.Font("Georgia", 12F);
            this.both_radio.ForeColor = System.Drawing.Color.DarkRed;
            this.both_radio.Location = new System.Drawing.Point(572, 128);
            this.both_radio.Name = "both_radio";
            this.both_radio.Size = new System.Drawing.Size(74, 28);
            this.both_radio.TabIndex = 3;
            this.both_radio.TabStop = true;
            this.both_radio.Text = "Both";
            this.both_radio.UseVisualStyleBackColor = false;
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.SlateBlue;
            this.exit_btn.Font = new System.Drawing.Font("Georgia", 12F);
            this.exit_btn.ForeColor = System.Drawing.Color.White;
            this.exit_btn.Location = new System.Drawing.Point(99, 234);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(156, 48);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.SlateBlue;
            this.start_btn.Font = new System.Drawing.Font("Georgia", 12F);
            this.start_btn.ForeColor = System.Drawing.Color.White;
            this.start_btn.Location = new System.Drawing.Point(454, 234);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(144, 48);
            this.start_btn.TabIndex = 5;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 343);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.both_radio);
            this.Controls.Add(this.senten_radio);
            this.Controls.Add(this.word_radio);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton word_radio;
        private System.Windows.Forms.RadioButton senten_radio;
        private System.Windows.Forms.RadioButton both_radio;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button start_btn;
    }
}

