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
    public partial class PharmacyForm : Form
    {
        public PharmacyForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowBranchesForm f = new ShowBranchesForm();
            f.Show();
        }

        private void NewBranch_Click(object sender, EventArgs e)
        { 
        
            this.Hide();
            AddBranchForm f = new AddBranchForm();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NewCategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCategoryForm f = new AddCategoryForm();
            f.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
