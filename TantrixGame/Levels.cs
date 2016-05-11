using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TantrixGame
{
    public partial class Levels : Form
    {
        public Levels()
        {
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 1;
            if (this.Opacity >= 1)
                timer1.Enabled = false;
        }

        // -> geri dugmesi
        // -> back button
        private void btn_clk_back(object sender, EventArgs e)
        {
            Close();
        }

        // -> Seviyeler dugmesi 1..8
        // -> Levels button 1..8
        private void clk_selectLevel(object sender, EventArgs e)
        {
            int lwl = Convert.ToInt32(((Panel)sender).Tag);
            GameScreen mGameScreen = new GameScreen(lwl);
            mGameScreen.ShowDialog();
        }
    }
}
