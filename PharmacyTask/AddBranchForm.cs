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

namespace PharmacyTask
{
    public partial class AddBranchForm : Form
    {
        SqlConnection Conn = new SqlConnection();
        List<int> BranchesIds = new List<int>();
        public AddBranchForm()
        {
            

            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBranchForm_Load(object sender, EventArgs e)
        {
            Conn.ConnectionString = @"data source=(LocalDB)\MSSQLLocalDB;
                                      attachdbfilename=C:\Users\Sara\Documents\PharmacyDB.mdf;
                                      integrated security=True;
                                      connect timeout=30;
                                      MultipleActiveResultSets=True;";

            Conn.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = Conn;
            com.CommandText = "Select ID from Branch ";
            com.CommandType = CommandType.Text;
            SqlDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                BranchesIds.Add(int.Parse(r[0].ToString()));

            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (BranchIDTextBox.Text != "" && BranchLocationTextBox.Text!=""&& BranchAddressTextBox.Text!=""&& BranchCityTextBox.Text!="")
            {
                int ID = int.Parse(BranchIDTextBox.Text);
                string location = BranchLocationTextBox.Text;
                string Address = BranchAddressTextBox.Text;
                string City = BranchCityTextBox.Text;

                if (BranchesIds.Contains(ID))
                {
                    MessageBox.Show("This ID is Already Exits");
                }
                else
                {
                    SqlCommand com = new SqlCommand();
                    com.Connection = Conn;
                    com.CommandText = "AddBranch";
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("Bid", ID);
                    com.Parameters.Add("Location", location);
                    com.Parameters.Add("Address", Address);
                    com.Parameters.Add("City", City);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Added");
                }
            }
            else
            {
                MessageBox.Show("Empty Data");
            }
            

            



        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PharmacyForm f = new PharmacyForm();
            f.Show();
        }

        private void BranchIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
