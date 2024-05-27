namespace T8_68977__Nurzhibek
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
            this.components = new System.ComponentModel.Container();
            this.time_lbl = new System.Windows.Forms.Label();
            this.score_lbl = new System.Windows.Forms.Label();
            this.text_lbl = new System.Windows.Forms.Label();
            this.input_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer_game = new System.Windows.Forms.Timer(this.components);
            this.game_mode_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.BackColor = System.Drawing.Color.LimeGreen;
            this.time_lbl.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_lbl.ForeColor = System.Drawing.Color.White;
            this.time_lbl.Location = new System.Drawing.Point(297, 124);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(24, 32);
            this.time_lbl.TabIndex = 0;
            this.time_lbl.Text = "-";
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.BackColor = System.Drawing.Color.LimeGreen;
            this.score_lbl.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score_lbl.ForeColor = System.Drawing.Color.White;
            this.score_lbl.Location = new System.Drawing.Point(776, 124);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(31, 32);
            this.score_lbl.TabIndex = 1;
            this.score_lbl.Text = "0";
            // 
            // text_lbl
            // 
            this.text_lbl.AutoSize = true;
            this.text_lbl.BackColor = System.Drawing.Color.Honeydew;
            this.text_lbl.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_lbl.Location = new System.Drawing.Point(342, 303);
            this.text_lbl.Name = "text_lbl";
            this.text_lbl.Size = new System.Drawing.Size(250, 32);
            this.text_lbl.TabIndex = 2;
            this.text_lbl.Text = "Words appear here";
            // 
            // input_txt
            // 
            this.input_txt.Font = new System.Drawing.Font("Georgia", 12F);
            this.input_txt.Location = new System.Drawing.Point(22, 464);
            this.input_txt.Name = "input_txt";
            this.input_txt.Size = new System.Drawing.Size(872, 30);
            this.input_txt.TabIndex = 3;
            this.input_txt.TextChanged += new System.EventHandler(this.CheckTheWord);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(661, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Score:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(37, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Remaining Time:";
            // 
            // timer_game
            // 
            this.timer_game.Tick += new System.EventHandler(this.timer_game_Tick);
            // 
            // game_mode_lbl
            // 
            this.game_mode_lbl.AutoSize = true;
            this.game_mode_lbl.BackColor = System.Drawing.Color.Honeydew;
            this.game_mode_lbl.Font = new System.Drawing.Font("Georgia", 16.2F);
            this.game_mode_lbl.Location = new System.Drawing.Point(357, 46);
            this.game_mode_lbl.Name = "game_mode_lbl";
            this.game_mode_lbl.Size = new System.Drawing.Size(101, 32);
            this.game_mode_lbl.TabIndex = 6;
            this.game_mode_lbl.Text = "Mode: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(919, 559);
            this.Controls.Add(this.game_mode_lbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.input_txt);
            this.Controls.Add(this.text_lbl);
            this.Controls.Add(this.score_lbl);
            this.Controls.Add(this.time_lbl);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.Label text_lbl;
        private System.Windows.Forms.TextBox input_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer_game;
        private System.Windows.Forms.Label game_mode_lbl;
    }
}