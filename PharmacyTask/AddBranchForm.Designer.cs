namespace PharmacyTask
{
    partial class AddBranchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BranchID = new System.Windows.Forms.Label();
            this.BranchLoscation = new System.Windows.Forms.Label();
            this.BranchAddress = new System.Windows.Forms.Label();
            this.BranchCity = new System.Windows.Forms.Label();
            this.BranchIDTextBox = new System.Windows.Forms.TextBox();
            this.BranchLocationTextBox = new System.Windows.Forms.TextBox();
            this.BranchAddressTextBox = new System.Windows.Forms.TextBox();
            this.BranchCityTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BranchID
            // 
            this.BranchID.AutoSize = true;
            this.BranchID.Location = new System.Drawing.Point(35, 44);
            this.BranchID.Name = "BranchID";
            this.BranchID.Size = new System.Drawing.Size(55, 13);
            this.BranchID.TabIndex = 0;
            this.BranchID.Text = "Branch ID";
            // 
            // BranchLoscation
            // 
            this.BranchLoscation.AutoSize = true;
            this.BranchLoscation.Location = new System.Drawing.Point(35, 94);
            this.BranchLoscation.Name = "BranchLoscation";
            this.BranchLoscation.Size = new System.Drawing.Size(85, 13);
            this.BranchLoscation.TabIndex = 1;
            this.BranchLoscation.Text = "Branch Location";
            // 
            // BranchAddress
            // 
            this.BranchAddress.AutoSize = true;
            this.BranchAddress.Location = new System.Drawing.Point(35, 153);
            this.BranchAddress.Name = "BranchAddress";
            this.BranchAddress.Size = new System.Drawing.Size(82, 13);
            this.BranchAddress.TabIndex = 2;
            this.BranchAddress.Text = "Branch Address";
            // 
            // BranchCity
            // 
            this.BranchCity.AutoSize = true;
            this.BranchCity.Location = new System.Drawing.Point(35, 211);
            this.BranchCity.Name = "BranchCity";
            this.BranchCity.Size = new System.Drawing.Size(61, 13);
            this.BranchCity.TabIndex = 3;
            this.BranchCity.Text = "Branch City";
            // 
            // BranchIDTextBox
            // 
            this.BranchIDTextBox.Location = new System.Drawing.Point(163, 44);
            this.BranchIDTextBox.Name = "BranchIDTextBox";
            this.BranchIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.BranchIDTextBox.TabIndex = 4;
            this.BranchIDTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.BranchIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BranchIDTextBox_KeyPress);
            // 
            // BranchLocationTextBox
            // 
            this.BranchLocationTextBox.Location = new System.Drawing.Point(163, 87);
            this.BranchLocationTextBox.Name = "BranchLocationTextBox";
            this.BranchLocationTextBox.Size = new System.Drawing.Size(100, 20);
            this.BranchLocationTextBox.TabIndex = 5;
            // 
            // BranchAddressTextBox
            // 
            this.BranchAddressTextBox.Location = new System.Drawing.Point(163, 150);
            this.BranchAddressTextBox.Name = "BranchAddressTextBox";
            this.BranchAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.BranchAddressTextBox.TabIndex = 6;
            // 
            // BranchCityTextBox
            // 
            this.BranchCityTextBox.Location = new System.Drawing.Point(163, 204);
            this.BranchCityTextBox.Name = "BranchCityTextBox";
            this.BranchCityTextBox.Size = new System.Drawing.Size(100, 20);
            this.BranchCityTextBox.TabIndex = 7;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(38, 279);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(105, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add Branch ";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(163, 279);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(105, 23);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddBranchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 371);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BranchCityTextBox);
            this.Controls.Add(this.BranchAddressTextBox);
            this.Controls.Add(this.BranchLocationTextBox);
            this.Controls.Add(this.BranchIDTextBox);
            this.Controls.Add(this.BranchCity);
            this.Controls.Add(this.BranchAddress);
            this.Controls.Add(this.BranchLoscation);
            this.Controls.Add(this.BranchID);
            this.Name = "AddBranchForm";
            this.Text = "Add Branch";
            this.Load += new System.EventHandler(this.AddBranchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BranchID;
        private System.Windows.Forms.Label BranchLoscation;
        private System.Windows.Forms.Label BranchAddress;
        private System.Windows.Forms.Label BranchCity;
        private System.Windows.Forms.TextBox BranchIDTextBox;
        private System.Windows.Forms.TextBox BranchLocationTextBox;
        private System.Windows.Forms.TextBox BranchAddressTextBox;
        private System.Windows.Forms.TextBox BranchCityTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelButton;
    }
}