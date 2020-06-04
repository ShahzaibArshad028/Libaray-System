using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project__PHASE_1
{
    public partial class login : Form
    {
        SqlConnection connection;
        public login()
        {
            
            InitializeComponent();
      
            connection = new SqlConnection(@"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C: \\Users\\shahz\\OneDrive\\Documents\\GitHub\\Libaray - System\\Project  PHASE 1\\DB\libraryDB.mdf;Integrated Security=True;Connect Timeout=30");

        }

        public login(Color BackGround,Color ForeGround,Color PanelBack,Color PanelFore)
        {
            InitializeComponent();
            this.BackColor = BackGround;
            this.ForeColor = ForeGround;
            loginPanel.BackColor=PanelBack;
            loginPanel.ForeColor=PanelFore;
            if (this.BackColor == Color.FromArgb(28, 28, 33))
            {
                ExitBtn.BackColor = Color.FromArgb(50, 50, 66);
                ExitBtn.ForeColor = Color.FromArgb(255, 255, 255);
            }

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
            string query = "Select From login Where username='"+userText.Text.Trim()+"and psd ='"+psdText.Text.Trim()+"'";

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
