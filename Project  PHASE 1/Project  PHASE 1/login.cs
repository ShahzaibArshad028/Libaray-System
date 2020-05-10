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
            if (this.ForeColor == Color.FromArgb(240, 240, 240))  //light mode
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\shahz\\OneDrive\\Documents\\GitHub\\Libaray-System\\Project Pictures\\icons\\white-arrow.png");
                userText.BackColor = BackColor;
                userText.ForeColor = ForeColor;
                psdText.BackColor = BackColor;
                psdText.ForeColor = ForeColor;
            }
            else {
                pictureBox1.Image = Image.FromFile("C:\\Users\\shahz\\OneDrive\\Documents\\GitHub\\Libaray-System\\Project Pictures\\icons\\black-arrow.png");
                userText.BackColor = BackColor;
                userText.ForeColor = ForeColor;
                psdText.BackColor = BackColor;
                psdText.ForeColor = ForeColor;
            }
        
        }

        private void titleLogin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ThemeForm TForm = new ThemeForm(this.BackColor,
                this.ForeColor);
            this.Hide();
            TForm.Show();
        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            welcome WelForm= new welcome(this.BackColor,
                this.ForeColor, loginPanel.BackColor, loginPanel.ForeColor);
            this.Hide();
            WelForm.Show();

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
