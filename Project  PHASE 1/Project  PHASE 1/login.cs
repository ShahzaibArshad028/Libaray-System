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
using System.Configuration;

namespace Project__PHASE_1
{
    public partial class login : Form
    {
        string connectionString = @"Data Source=DESKTOP-K9UJB8G;Initial Catalog=PorjectDataBase;Integrated Security=True";

        SqlConnection connection;

        public login()
        {
            InitializeComponent();
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
            {
                connection = new SqlConnection(connectionString);
              //  connection.Open();
                string query = "Select * From Login Where userName='" + userText.Text.Trim() + "' and psd ='" + psdText.Text.Trim() +"'";
                SqlCommand loginCommand = new SqlCommand(query, connection);
                SqlDataAdapter data = new SqlDataAdapter(loginCommand);
                DataTable table = new DataTable();
                data.Fill(table);
                loginCommand.Connection.Open();
                loginCommand.ExecuteNonQuery();
                loginCommand.Connection.Close();

                if (table.Rows.Count>=1)
                {
                    welcome WelForm = new welcome(userText.Text,this.BackColor,
                    this.ForeColor, loginPanel.BackColor, loginPanel.ForeColor);
                    this.Hide();
                    WelForm.Show();

                }
                else
                {
                    MessageBox.Show("Username or Password is Incorrect !!");
                }
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        { 

            Application.Exit();
        }
    }
}
