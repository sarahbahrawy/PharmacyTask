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
    public partial class AddInStockForm : Form
    {
        SqlConnection Conn = new SqlConnection();
        List<int> CategoriesID = new List<int>();
        int ID;
        int Bid;
        int UQuantity;
        public AddInStockForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BranchForm f = new BranchForm();
            f.Show();
        }

        private void AddInStockForm_Load(object sender, EventArgs e)
        {
             Bid = ShowBranchesForm.SavedBranchID;
            Conn.ConnectionString = @"data source=(LocalDB)\MSSQLLocalDB;
                                      attachdbfilename=C:\Users\Sara\Documents\PharmacyDB.mdf;
                                      integrated security=True;
                                      connect timeout=30;
                                      MultipleActiveResultSets=True;";

            Conn.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = Conn;
            com.CommandText = @"select *
                                from Category 
                                where ID NOT IN (SELECT CategoryID FROM Stock where BranchID=@Bid)";
            com.CommandType = CommandType.Text;
            com.Parameters.Add("Bid", Bid);
            SqlDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                UnAvailbleCategoriesComboBox.Items.Add(r[1]);
                CategoriesID.Add(int.Parse(r[0].ToString()));

            }
        }

        private void UnAvailbleCategoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID = CategoriesID[UnAvailbleCategoriesComboBox.SelectedIndex];
        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            UQuantity =int.Parse( QuantityTextBox.Text);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(UnAvailbleCategoriesComboBox.SelectedItem!=null)
            {
                SqlCommand com = new SqlCommand();
                com.Connection = Conn;
                com.CommandText = "AddCategoryActions";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("Bid", Bid);
                com.Parameters.Add("Cid", ID);
                com.Parameters.Add("CQuantity", UQuantity);
                com.Parameters.Add("type", "New Category");
                com.ExecuteNonQuery();
                MessageBox.Show("Add Quantity");
            }
            else
            {
                MessageBox.Show("SomeThing Is Missing !");
            }
            
        }

        private void QuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr))
            {
                e.Handled = true;
                MessageBox.Show("Number Only");

            }
        }
    }
}
