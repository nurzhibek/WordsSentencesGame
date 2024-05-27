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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            SetMode();
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void SetMode()
        {
            if (word_radio.Checked)
            {
                Settings.mode = Settings.GameMode.Words;
            }
            else if (senten_radio.Checked)
            {
                Settings.mode = Settings.GameMode.Sentences;
            }
            else if (both_radio.Checked)
            {
                Settings.mode = Settings.GameMode.Both;
            }
            else
            {
                MessageBox.Show("Select the game mode", "Error");
            }
        }

        
    }
}
