using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project__PHASE_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ForeColor = Color.FromArgb(28, 28, 33);
            BackColor = Color.FromArgb(240, 240, 240);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ThemeDark_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(28, 28, 33);
            ForeColor = Color.FromArgb(240, 240, 240);
        }
        private void themeLight_CheckedChanged(object sender, EventArgs e)
        {
            ForeColor = Color.FromArgb(28, 28, 33);
            BackColor = Color.FromArgb(240, 240, 240);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            if (ThemeDark.Checked == true)
            {
                panel2.BackColor = Color.FromArgb(50, 50, 66);
            }
            else
            {
                panel2.BackColor = Color.FromArgb(220, 220, 220);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
