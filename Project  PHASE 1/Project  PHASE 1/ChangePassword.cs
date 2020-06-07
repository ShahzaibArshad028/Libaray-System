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
    public partial class ChangePassword : Form
    {
        string connectionString = @"Data Source=DESKTOP-K9UJB8G;Initial Catalog=PorjectDataBase;Integrated Security=True";

        string currentLogin;
        public ChangePassword(string currentLOGIN,Color BackGround, Color ForeGround, Color PanelBack)
        {
            InitializeComponent();
            this.BackColor = BackGround;
            this.ForeColor = ForeGround;
            ChangePasswordPanel.BackColor = PanelBack;
            ChangePasswordPanel.ForeColor = ForeGround;
            ChangePasswordBtn.BackColor = BackGround;
            currentLogin = currentLOGIN;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(275, 117);

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            if (this.ForeColor == Color.FromArgb(240, 240, 240))  //light mode
            {
                exit.Image = Image.FromFile("C:\\Users\\shahz\\OneDrive\\Documents\\GitHub\\Libaray-System\\Project Pictures\\icons\\exit_White.png");
            }
            else
            {
                exit.Image = Image.FromFile("C:\\Users\\shahz\\OneDrive\\Documents\\GitHub\\Libaray-System\\Project Pictures\\icons\\exit_Black.png");
            }
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            if (OldPsdTxt.Text == String.Empty || NewPsdTxt.Text == String.Empty || CnfPsdtxt.Text == String.Empty)
            {
                empty.Visible = true;
            }
            else
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();


                if (connection.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand sql = new SqlCommand("Update Login Set psd=@psd Where userName='" + currentLogin + "'and psd=@psdOld", connection);
                    sql.Parameters.Add("@psd", this.NewPsdTxt.Text);
                    sql.Parameters.Add("@psdOld", this.OldPsdTxt.Text);

                    if (NewPsdTxt.Text != CnfPsdtxt.Text)
                    {
                        MessageBox.Show("New Password and Confirm Password are Not Same");
                    }
                    else
                        sql.ExecuteNonQuery();

                }
                else
                {
                    MessageBox.Show("connection failed");

                }
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            empty.Visible = false;
        }
    }
}
