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
    public partial class Search : Form
    {
       
        public Search(Color BackGround, Color ForeGround, Color PanelBack)
        {
            InitializeComponent();
            this.BackColor = BackGround;
            this.ForeColor = ForeGround;
            SearchPanel.BackColor = PanelBack;
            SearchPanel.ForeColor = ForeGround;
            SearchBtn.BackColor = BackGround;
            //if (this.BackColor == Color.FromArgb(28, 28, 33))
            //{
            //    AddBtn.BackColor = Color.FromArgb(50, 50, 66);
            //    AddBtn.ForeColor = Color.FromArgb(255, 255, 255);
            //}

        }

        private void Confirmbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
