using System;
using System.Windows.Forms;

namespace TantrixGame
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1;
            if (this.Opacity >= 1)
                timer1.Enabled = false;
        }

        private void btn_clk_newgame(object sender, EventArgs e)
        {
            Levels mLevels = new Levels();
            mLevels.ShowDialog();
        }

        private void btn_clk_howtoplay(object sender, EventArgs e)
        {
            HowtoPlay mHowtoPlay = new HowtoPlay();
            mHowtoPlay.ShowDialog();
        }

        private void btn_clk_exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
