namespace PharmacyTask
{
    partial class AddCategoryForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.CategoryIDTextBox = new System.Windows.Forms.TextBox();
            this.CategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.AddCategoryButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Name";
            // 
            // CategoryIDTextBox
            // 
            this.CategoryIDTextBox.Location = new System.Drawing.Point(173, 31);
            this.CategoryIDTextBox.Name = "CategoryIDTextBox";
            this.CategoryIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.CategoryIDTextBox.TabIndex = 2;
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.Location = new System.Drawing.Point(173, 73);
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.CategoryNameTextBox.TabIndex = 3;
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.Location = new System.Drawing.Point(53, 130);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(100, 23);
            this.AddCategoryButton.TabIndex = 4;
            this.AddCategoryButton.Text = "Add Category";
            this.AddCategoryButton.UseVisualStyleBackColor = true;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(173, 130);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(98, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 204);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddCategoryButton);
            this.Controls.Add(this.CategoryNameTextBox);
            this.Controls.Add(this.CategoryIDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCategoryForm";
            this.Text = "Add Category";
            this.Load += new System.EventHandler(this.AddCategoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CategoryIDTextBox;
        private System.Windows.Forms.TextBox CategoryNameTextBox;
        private System.Windows.Forms.Button AddCategoryButton;
        private System.Windows.Forms.Button CancelButton;
    }
}