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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        public login(Color BackGround,Color ForeGround,Color PanelBack,Color PanelFore)
        {
            InitializeComponent();
            BackColor = BackGround;
            ForeColor = ForeGround;
            loginPanel.BackColor=PanelBack;
            loginPanel.ForeColor=PanelFore;

        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void titleLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
