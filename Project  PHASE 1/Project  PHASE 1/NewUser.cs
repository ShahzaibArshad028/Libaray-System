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
    public partial class NewUser : Form
    {
        string connectionString = @"Data Source=DESKTOP-K9UJB8G;Initial Catalog=PorjectDataBase;Integrated Security=True";

        public NewUser()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(275, 117);

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

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void NewUserBtn_Click(object sender, EventArgs e)
        {
            if (NewUserBtn.Text == String.Empty || PsdTxt.Text == String.Empty || CnfPsdtxt.Text == String.Empty)
            {
                empty.Visible = true;
            }
            SqlConnection  connection = new SqlConnection(connectionString);
         connection.Open();
   
            if (PsdTxt.Text != CnfPsdtxt.Text)
                MessageBox.Show("password not same");
            else
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand query = new SqlCommand("Insert into Login Values(@userName,@psd)", connection);
                    query.Parameters.Add("@userName", NewUserTxt.Text);
                    query.Parameters.Add("@psd", CnfPsdtxt.Text);
                    query.ExecuteNonQuery();

                }
            }
            connection.Close();       
        }

        private void NewUser_Load(object sender, EventArgs e)
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
    }
}
