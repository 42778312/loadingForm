using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loadingForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 499) 
            {
                timer3.Stop();
                Form2 fm2 = new Form2();
                this.Hide();
                fm2.Show();
            }
        }
    }
}
