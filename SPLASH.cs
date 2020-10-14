using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_1
{
    public partial class SPLASH : Form
    {
        public SPLASH()
        {
            InitializeComponent();
        }

        private void SPLASH_Load(object sender, EventArgs e)
        {
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            
            while(circularProgressBar1.Value <= 99) {

                    circularProgressBar1.Value += 1;
            }
                   timer1.Stop();
                    LOGIN fm2 = new LOGIN();
                    fm2.Show();
                    this.Hide();
                
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}

