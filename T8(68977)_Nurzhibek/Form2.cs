using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T8_68977__Nurzhibek
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Settings.AddToTheLists();
            timer_game.Start();
            ShowText();
        }

        private void timer_game_Tick(object sender, EventArgs e)
        {
            if (Settings.seconds <= 0.1)
            {
                timer_game.Stop();
            }
            else {
                time_lbl.Text = Math.Round(Settings.seconds -= 0.1, 1).ToString();
            }
        }

        private void ShowText()
        {
            Random rnd = new Random();

            if (Settings.mode == Settings.GameMode.Words)
            {
                game_mode_lbl.Text = $"Mode: {Settings.mode.ToString()}";
                int num = rnd.Next(0, Settings.Words.Count);
                text_lbl.Text = Settings.Words[num];
            }

            else if(Settings.mode == Settings.GameMode.Sentences)
            {
                game_mode_lbl.Text = $"Mode: {Settings.mode.ToString()}";
                int num = rnd.Next(0, Settings.Sentences.Count);
                text_lbl.Text = Settings.Sentences[num];
            }

            else if(Settings.mode == Settings.GameMode.Both)
            {
                game_mode_lbl.Text = $"Mode: {Settings.mode.ToString()}";
                int num = rnd.Next(0, Settings.Both.Count);
                text_lbl.Text = Settings.Both[num];
            }
            Form2 form2 = new Form2();
            text_lbl.Location = new Point((form2.Width - text_lbl.Width) / 2, text_lbl.Location.Y);
        }

        private void CheckTheWord(object sender, EventArgs e)
        {
            if (input_txt.Text.Trim() == text_lbl.Text.Trim())
            {
                Settings.score += 1;
                score_lbl.Text = Settings.score.ToString();

                timer_game.Stop();
                input_txt.Text = "";

                ShowText();
                Settings.ResetSeconds();
                timer_game.Start();
            }
        }
    }
}
