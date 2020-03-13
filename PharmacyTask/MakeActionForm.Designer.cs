namespace PharmacyTask
{
    partial class MakeActionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CategoriesComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.SellButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Categories";
            // 
            // CategoriesComboBox
            // 
            this.CategoriesComboBox.FormattingEnabled = true;
            this.CategoriesComboBox.Location = new System.Drawing.Point(12, 41);
            this.CategoriesComboBox.Name = "CategoriesComboBox";
            this.CategoriesComboBox.Size = new System.Drawing.Size(121, 21);
            this.CategoriesComboBox.TabIndex = 1;
            this.CategoriesComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoriesComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(189, 42);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.QuantityTextBox.TabIndex = 3;
            this.QuantityTextBox.TextChanged += new System.EventHandler(this.QuantityTextBox_TextChanged);
            this.QuantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityTextBox_KeyPress);
            // 
            // SellButton
            // 
            this.SellButton.Location = new System.Drawing.Point(40, 177);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(75, 23);
            this.SellButton.TabIndex = 4;
            this.SellButton.Text = "Sell";
            this.SellButton.UseVisualStyleBackColor = true;
            this.SellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(205, 177);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(122, 230);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Cancel";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // MakeActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 282);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SellButton);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CategoriesComboBox);
            this.Controls.Add(this.label1);
            this.Name = "MakeActionForm";
            this.Text = "Action";
            this.Load += new System.EventHandler(this.MakeActionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CategoriesComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Button SellButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button BackButton;
    }
}