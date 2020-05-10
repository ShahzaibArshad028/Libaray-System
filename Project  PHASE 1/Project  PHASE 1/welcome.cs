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
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        public welcome(Color BackGround, Color ForeGround, Color PanelBack, Color PanelFore)
        {
            InitializeComponent();
            BackColor = BackGround;
            ForeColor = ForeGround;
            leftPanel.BackColor = PanelBack;
            leftPanel.ForeColor = PanelFore;
            if (leftPanel.BackColor == Color.FromArgb(220, 220, 220))
            {
                imgPanel.BackColor = Color.FromArgb(190, 190, 190);
            }
            else
            {
                imgPanel.BackColor = Color.FromArgb(70, 70, 105);
            }
        }
        private void welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
