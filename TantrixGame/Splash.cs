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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
       
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.05;
           
            if (this.Opacity >= 1)
            {
                System.Threading.Thread.Sleep(1500);
                timer1.Enabled = false;

                MainMenu menu = new MainMenu();
                menu.ShowDialog();

                Close();
            }
            
        }
        
    }
}
