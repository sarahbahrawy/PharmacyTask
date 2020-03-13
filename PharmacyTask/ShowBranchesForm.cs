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
    public partial class ShowBranchesForm : Form
    {
        SqlConnection Conn = new SqlConnection();
        public static int SavedBranchID =0;
        int ID;
        public List<int> BranchesIDs = new List<int>();
        public ShowBranchesForm()
        {
            
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PharmacyForm f = new PharmacyForm();
            f.Show();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (BranchesComboBox.SelectedItem != null)
            {
                SavedBranchID = ID;
                this.Hide();
                BranchForm f = new BranchForm();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Choose a Branch");
            }
            
        }

        private void ShowBranchesForm_Load(object sender, EventArgs e)
        {
            Conn.ConnectionString = @"data source=(LocalDB)\MSSQLLocalDB;
                                      attachdbfilename=C:\Users\Sara\Documents\PharmacyDB.mdf;
                                      integrated security=True;
                                      connect timeout=30;
                                      MultipleActiveResultSets=True;";

            Conn.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = Conn;
            com.CommandText = "select * from Branch";
            com.CommandType = CommandType.Text;
            SqlDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                String x = r[1].ToString()+"/" + r[2].ToString();
                BranchesComboBox.Items.Add(x);
                BranchesIDs.Add(int.Parse(r[0].ToString()));

            }
        }

        private void BranchesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ID= BranchesIDs[BranchesComboBox.SelectedIndex];
        }
    }
}
