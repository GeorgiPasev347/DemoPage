using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace test25_5
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Documents\Names.mdf;Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name = textBox1.Text;
            string number = textBox2.Text;
            string adress = textBox3.Text;
            string product = textBox4.Text;
           
            SqlConnection conn = new SqlConnection(connectionString);
            {
                string query = "INSERT INTO TableName (Name,Number,Adress,Product) VALUES (@Name,@Number,@Adress,@Product)";
                SqlCommand cmd = new SqlCommand(query, conn);
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Number", number);
                    cmd.Parameters.AddWithValue("@Adress", adress);
                    cmd.Parameters.AddWithValue("@Product", product);


                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Данните са записани успешно!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Грешка " + ex.Message);

                    }

                }
            }
        }
    }
}
