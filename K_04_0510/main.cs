using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K_04_0510
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void main_gen_Click(object sender, EventArgs e)
        {
            var mygen = new generate(this);
            this.Enabled = false;
            mygen.Show();
        }

        private void main_exp_Click(object sender, EventArgs e)
        {
            var myexp = new experiment(this);
            //this.Enabled = false;
            myexp.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }
    }
}
