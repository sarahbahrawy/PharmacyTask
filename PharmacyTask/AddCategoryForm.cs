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
    public partial class AddCategoryForm : Form
    {
        SqlConnection Conn = new SqlConnection();
        List<int> CategoriesIds = new List<int>();
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PharmacyForm f = new PharmacyForm();
            f.Show();
                
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            
            if(CategoryIDTextBox.Text!=""&& CategoryNameTextBox.Text!="")
            {
                int ID = int.Parse(CategoryIDTextBox.Text);
                string name = CategoryNameTextBox.Text;
                if (CategoriesIds.Contains(ID))
                {
                    MessageBox.Show("This ID is Already Exits");
                }
                else
                {
                    SqlCommand com = new SqlCommand();
                    com.Connection = Conn;
                    com.CommandText = "AddCategory";
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("Cid", ID);
                    com.Parameters.Add("Name", name);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Added");
                }
            }
            
        }

        private void AddCategoryForm_Load(object sender, EventArgs e)
        {
            Conn.ConnectionString = @"data source=(LocalDB)\MSSQLLocalDB;
                                      attachdbfilename=C:\Users\Sara\Documents\PharmacyDB.mdf;
                                      integrated security=True;
                                      connect timeout=30;
                                      MultipleActiveResultSets=True;";

            Conn.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = Conn;
            com.CommandText = "Select ID from Category ";
            com.CommandType = CommandType.Text;
            SqlDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                CategoriesIds.Add(int.Parse(r[0].ToString()));

            }
        }
    }
}
