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
    public partial class Search : Form
    {
        string connectionString = @"Data Source=DESKTOP-K9UJB8G;Initial Catalog=PorjectDataBase;Integrated Security=True";

        
        public Search(Color BackGround, Color ForeGround, Color PanelBack)
        {
            InitializeComponent();
            this.BackColor = BackGround;
            this.ForeColor = ForeGround;
            SearchPanel.BackColor = PanelBack;
            SearchPanel.ForeColor = ForeGround;
            SearchBtn.BackColor = BackGround;
            SearchBook.BackColor = SearchPanel.ForeColor;
            SearchBook.ForeColor = SearchPanel.BackColor;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(275, 117);

        }

        private void Confirmbtn_Click(object sender, EventArgs e)
        {
              SqlConnection  connection = new SqlConnection(connectionString);

         connection.Open();      
        
            if (connection.State == System.Data.ConnectionState.Open)
            {
                SqlCommand query = new SqlCommand(" Select * from BookInfo Where BookName Like '"+Booktxt.Text+"%'", connection);

                //query.Parameters.Add("@BookName", this.Booktxt.Text);
             //   query.Parameters.Add("@Category", this.CategoryTxt.Text);
                SqlDataAdapter data = new SqlDataAdapter(query);
                DataTable table = new DataTable();
                data.Fill(table);
                SearchBook.DataSource = table;
                connection.Close();
            }
            else
                MessageBox.Show("Conenction failed");
            }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
         
        }

        private void Search_Load(object sender, EventArgs e)

        { 

            if (this.ForeColor == Color.FromArgb(255,240, 240, 240))  //light mode
            {
                exit.Image = Image.FromFile("C:\\Users\\shahz\\OneDrive\\Documents\\GitHub\\Libaray-System\\Project Pictures\\icons\\exit_White.png");
                SearchBook.ForeColor = Color.FromArgb(255,240, 240, 240);
                this.BackColor = Color.FromArgb(255, 200, 200, 200);
            }
            else
            {
                exit.Image = Image.FromFile("C:\\Users\\shahz\\OneDrive\\Documents\\GitHub\\Libaray-System\\Project Pictures\\icons\\exit_Black.png");
                SearchBook.ForeColor = Color.FromArgb(255, 100, 100, 100);
                this.BackColor = Color.FromArgb(255, 95, 95, 95);

            }
        }
    }
}
