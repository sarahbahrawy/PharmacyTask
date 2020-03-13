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
    public partial class MakeActionForm : Form
    {
        SqlConnection Conn = new SqlConnection();
        List<int> CategoryQuantity = new List<int>();
        List<int> CategoryID = new List<int>();
        int PQuantity;
        int UserQuantity=0;
        int Cid;
        int Bid;
        string ActionType;
        public MakeActionForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BranchForm f = new BranchForm();
            f.Show();
        }

        private void MakeActionForm_Load(object sender, EventArgs e)
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
            com.CommandText = @"select C.Name , S.Quantity ,S.CategoryID
                                from Stock S , Category C
                                where C.ID = S.CategoryID and S.BranchID = @Bid ";
            com.CommandType = CommandType.Text;
            com.Parameters.Add("Bid", Bid);
            SqlDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                CategoriesComboBox.Items.Add(r[0].ToString());
                CategoryQuantity.Add(int.Parse(r[1].ToString()));
                CategoryID.Add(int.Parse(r[2].ToString()));

            }
        }

        private void CategoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PQuantity = CategoryQuantity[CategoriesComboBox.SelectedIndex];
            Cid = CategoryID[CategoriesComboBox.SelectedIndex];
        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {

            UserQuantity = int .Parse(QuantityTextBox.Text);

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int newQ = PQuantity + UserQuantity;
            ActionType = "Add Quantity";
            if (CategoriesComboBox.SelectedItem != null)
            {

                Action(newQ);
                MessageBox.Show("Add Quantity");
            }
            else
            {
                MessageBox.Show("Empty Data");
            }
                
            
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            int newQ = PQuantity - UserQuantity;
            ActionType = "Sell Quantity";
            if (CategoriesComboBox.SelectedItem != null)
            {
                if (UserQuantity <= PQuantity)
                {
                    Action(newQ);
                    MessageBox.Show ("Sell Quantity");

                    if(newQ==0)
                    {
                        SqlCommand com2 = new SqlCommand();
                        com2.Connection = Conn;
                        com2.CommandText = "DeleteCategory";
                        com2.CommandType = CommandType.StoredProcedure;
                        com2.Parameters.Add("Bid", Bid);
                        com2.Parameters.Add("Cid", Cid);
                        com2.ExecuteNonQuery();
                    }


                }
                else
                {
                    MessageBox.Show("UnAvaliable Qunatity You Have " + PQuantity + " Quantity In Stock");
                }
            }
            else
            {
                MessageBox.Show("Empty Data");
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
        private void Action(int NQ)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = Conn;
            com.CommandText = "UpdateQuantityActions";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("Bid", Bid);
            com.Parameters.Add("Cid", Cid);
            com.Parameters.Add("PQuantity", PQuantity);
            com.Parameters.Add("CQuantity", NQ);
            com.Parameters.Add("type", ActionType);
            com.ExecuteNonQuery();
        }
    }
}
