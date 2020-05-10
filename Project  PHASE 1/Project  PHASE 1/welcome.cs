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
            BtnPanel.ForeColor = ForeColor;
           
            // BtnPanel.BackColor = BackGround;

            if (leftPanel.BackColor == Color.FromArgb(220, 220, 220))
            {
                Color LIGHT = Color.FromArgb(190, 190, 190);
                imgPanel.BackColor = LIGHT;
                AddBtn.BackColor = leftPanel.BackColor;
                RemoveBtn.BackColor = leftPanel.BackColor;
                RetBtn.BackColor = leftPanel.BackColor;
                CngPsdBtn.BackColor = leftPanel.BackColor;
                addNewUserBtn.BackColor = leftPanel.BackColor;
                LogoutBtn.BackColor = leftPanel.BackColor;
                ExitBtn.BackColor = leftPanel.BackColor;

            }
            else
            {
                Color DARK = Color.FromArgb(70, 70, 105);
                AddBtn.BackColor = DARK;
                RemoveBtn.BackColor = DARK;
                RetBtn.BackColor = DARK;
                CngPsdBtn.BackColor = DARK;
                addNewUserBtn.BackColor = DARK;
                LogoutBtn.BackColor = DARK;
                ExitBtn.BackColor = DARK;
                imgPanel.BackColor = DARK;
            }
        }
        private void welcome_Load(object sender, EventArgs e)
        {

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            login lgnForm = new login(this.BackColor,
                this.ForeColor, leftPanel.BackColor, leftPanel.ForeColor);
            this.Hide();
            lgnForm.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RetBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
