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
    public partial class Remove : Form
    {
    
        public Remove(Color BackGround, Color ForeGround, Color PanelBack)
        {
            InitializeComponent();
            this.BackColor = BackGround;
            this.ForeColor = ForeGround;
            RemovePanel.BackColor = PanelBack;
            RemovePanel.ForeColor = ForeGround;
            RemoveBtn.BackColor = BackGround;
        }

        private void AuthorNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
