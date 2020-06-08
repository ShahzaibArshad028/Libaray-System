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
    public partial class Add : Form
    {
        string connectionString = @"Data Source=DESKTOP-K9UJB8G;Initial Catalog=PorjectDataBase;Integrated Security=True";

        public Add(Color BackGround, Color ForeGround, Color PanelBack)
        {
            InitializeComponent();
           // AddConfirm.BackColor = Color.FromArgb(50, Color.Black);
            AddConfirm.Visible = false;
            this.BackColor = BackGround;
            this.ForeColor = ForeGround;
            AddPanel.BackColor = PanelBack;
            AddPanel.ForeColor = ForeGround;
            AddBtn.BackColor = BackGround;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(275, 117);

        }

        private void Add_Load(object sender, EventArgs e)
        {
            if (this.ForeColor == Color.FromArgb(255, 240, 240, 240))  //light mode
            {
                exit.Image = Image.FromFile("C:\\Users\\shahz\\OneDrive\\Documents\\GitHub\\Libaray-System\\Project Pictures\\icons\\exit_White.png");
        
            }
            else
            {
                exit.Image = Image.FromFile("C:\\Users\\shahz\\OneDrive\\Documents\\GitHub\\Libaray-System\\Project Pictures\\icons\\exit_Black.png");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
         

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (bookTitleTxt.Text == String.Empty || AuthorNametxt.Text == String.Empty || CategoryTxt.Text == String.Empty || QuantityTxt.Text == String.Empty)
            {
                empty.Visible = true;
            }
            else
            {

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand sql = new SqlCommand("Insert into BookInfo Values (@BookName,@AuthorName ,@Category,@Quantity)", connection);
                    sql.Parameters.Add("@BookName", this.bookTitleTxt.Text);
                    sql.Parameters.Add("@AuthorName", this.AuthorNametxt.Text);
                    sql.Parameters.Add("@Category", this.CategoryTxt.Text);
                    //slider number add kar la bhai !!
                    sql.Parameters.Add("@Quantity", this.QuantityTxt.Text);
                    sql.ExecuteNonQuery();

                    AddConfirm.Visible = true;
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


        private void button1_Click(object sender, EventArgs e)
        {
            AddConfirm.Visible = false;
            bookTitleTxt.Text = String.Empty;
            AuthorNametxt.Text = String.Empty;
            CategoryTxt.Text = String.Empty;
            QuantityTxt.Text = String.Empty;
        }
    }
}
