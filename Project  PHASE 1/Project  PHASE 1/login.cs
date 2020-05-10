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

        public login(Color BackGround,Color ForeGround)
        {
            InitializeComponent();
            BackColor = BackGround;
            ForeColor = ForeGround;
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
