using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_1
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }
        static int attempt = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if ((this.textBox1.Text == "Admin") && (this.textBox2.Text == "admin"))
            {
                attempt = 0;
                MessageBox.Show("ACCESO GARANTIZADO");
                Application.Exit();

            }

            else if (attempt++ == 2)
            {
                MessageBox.Show("Falló en 3 intentos de inicio de sesión. Acceso no autorizado");
                Application.Exit();
            }
        }
        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
