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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        public NewUser(Color BackGround, Color ForeGround, Color PanelBack)
        {
            InitializeComponent();
            this.BackColor = BackGround;
            this.ForeColor = ForeGround;
            NewUserPanel.BackColor = PanelBack;
            NewUserPanel.ForeColor = ForeGround;
            NewUserBtn.BackColor = BackGround;
        }
    }
}
