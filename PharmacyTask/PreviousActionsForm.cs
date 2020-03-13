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
    public partial class PreviousActionsForm : Form
    {
        SqlConnection Conn = new SqlConnection();
       
        public PreviousActionsForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BranchForm f = new BranchForm();
            f.Show();
        }

        private void PreviousActionsForm_Load(object sender, EventArgs e)
        {
            int BranchID = ShowBranchesForm.SavedBranchID;
            Conn.ConnectionString = @"data source=(LocalDB)\MSSQLLocalDB;
                                      attachdbfilename=C:\Users\Sara\Documents\PharmacyDB.mdf;
                                      integrated security=True;
                                      connect timeout=30;
                                      MultipleActiveResultSets=True;";

            Conn.Open();
            String sqlStatement = @"select C.Name , A.PreviousQuantity , A.CurrentQuantity ,A.Type
                                    from Category C , Actions A 
                                     where A.CategoryID = C.ID and A.BranchID =@Bid ";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sqlStatement, Conn.ConnectionString);
            da.SelectCommand.Parameters.Add("Bid", BranchID);
            da.Fill(ds);
            PreviousActionDataGridView.DataSource = ds.Tables[0];
            if (PreviousActionDataGridView.Rows.Count == 1)
            {
                MessageBox.Show("No Actions Yet");
            }
        }

        private void PreviousActionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
