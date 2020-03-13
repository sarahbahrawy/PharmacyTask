namespace PharmacyTask
{
    partial class PharmacyForm
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
            this.NewBranch = new System.Windows.Forms.Button();
            this.NewCategory = new System.Windows.Forms.Button();
            this.Branches = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewBranch
            // 
            this.NewBranch.Location = new System.Drawing.Point(49, 28);
            this.NewBranch.Name = "NewBranch";
            this.NewBranch.Size = new System.Drawing.Size(128, 23);
            this.NewBranch.TabIndex = 0;
            this.NewBranch.Text = "Add New Branch ";
            this.NewBranch.UseVisualStyleBackColor = false;
            this.NewBranch.Click += new System.EventHandler(this.NewBranch_Click);
            // 
            // NewCategory
            // 
            this.NewCategory.Location = new System.Drawing.Point(49, 86);
            this.NewCategory.Name = "NewCategory";
            this.NewCategory.Size = new System.Drawing.Size(128, 23);
            this.NewCategory.TabIndex = 1;
            this.NewCategory.Text = "Add New Category";
            this.NewCategory.UseVisualStyleBackColor = true;
            this.NewCategory.Click += new System.EventHandler(this.NewCategory_Click);
            // 
            // Branches
            // 
            this.Branches.Location = new System.Drawing.Point(49, 147);
            this.Branches.Name = "Branches";
            this.Branches.Size = new System.Drawing.Size(128, 23);
            this.Branches.TabIndex = 2;
            this.Branches.Text = "Show Branches";
            this.Branches.UseVisualStyleBackColor = true;
            this.Branches.Click += new System.EventHandler(this.button3_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(49, 208);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(128, 23);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PharmacyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 254);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.Branches);
            this.Controls.Add(this.NewCategory);
            this.Controls.Add(this.NewBranch);
            this.Name = "PharmacyForm";
            this.Text = "Pharmacy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewBranch;
        private System.Windows.Forms.Button NewCategory;
        private System.Windows.Forms.Button Branches;
        private System.Windows.Forms.Button CloseButton;
    }
}

