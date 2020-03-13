using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyTask
{
    public partial class BranchForm : Form
    {
        public int BranchID;

        public BranchForm()
        {
            InitializeComponent();
        }

        private void BranchForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddInStockForm f = new AddInStockForm();
            f.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowBranchesForm f = new ShowBranchesForm();
            f.Show();

        }

        private void PreviousActionsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PreviousActionsForm f = new PreviousActionsForm();
            f.Show();
        }

        private void AvailableCategoriesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AvaliableCategoriesForm f = new AvaliableCategoriesForm();
            f.Show();
        }

        private void ActionsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MakeActionForm f = new MakeActionForm();
            f.Show();
        }
    }
}
