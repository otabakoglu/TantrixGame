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
    public partial class HowtoPlay : Form
    {
        public HowtoPlay()
        {
            InitializeComponent();
        }

        // -> geri dugmesi
        // -> back button 
        private void btn_clk_back(object sender, EventArgs e)
        {
            Close();
        }
    }
}
