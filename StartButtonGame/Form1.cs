using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace StartButtonGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SoundPlayer sp = new SoundPlayer(Properties.Resources.Censored_Beep_Mastercard_569981218);
            sp.Play();

            startButton.Visible = false;

            BackColor = Color.Green;

            threeTwoOneCountdownLabel.Text = "3";
            Refresh();
            Thread.Sleep(2000);

            threeTwoOneCountdownLabel.Text = "2";
            sp.Play();
            Refresh();
            Thread.Sleep(2000);

            threeTwoOneCountdownLabel.Text = "1";
            sp.Play();
            Refresh();
            Thread.Sleep(2000);

            threeTwoOneCountdownLabel.Text = "GO!!!!";
            sp = new SoundPlayer(Properties.Resources.Air_Horn_SoundBible_com_964603082);
            sp.Play();



        }
    }
}
