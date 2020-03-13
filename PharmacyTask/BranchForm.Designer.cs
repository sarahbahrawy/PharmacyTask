namespace PharmacyTask
{
    partial class BranchForm
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
            this.PreviousActionsButton = new System.Windows.Forms.Button();
            this.AvailableCategoriesButton = new System.Windows.Forms.Button();
            this.ActionsButton = new System.Windows.Forms.Button();
            this.CategoryInStockButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PreviousActionsButton
            // 
            this.PreviousActionsButton.Location = new System.Drawing.Point(40, 12);
            this.PreviousActionsButton.Name = "PreviousActionsButton";
            this.PreviousActionsButton.Size = new System.Drawing.Size(188, 23);
            this.PreviousActionsButton.TabIndex = 0;
            this.PreviousActionsButton.Text = "Show Previous Actions";
            this.PreviousActionsButton.UseVisualStyleBackColor = true;
            this.PreviousActionsButton.Click += new System.EventHandler(this.PreviousActionsButton_Click);
            // 
            // AvailableCategoriesButton
            // 
            this.AvailableCategoriesButton.Location = new System.Drawing.Point(40, 53);
            this.AvailableCategoriesButton.Name = "AvailableCategoriesButton";
            this.AvailableCategoriesButton.Size = new System.Drawing.Size(188, 23);
            this.AvailableCategoriesButton.TabIndex = 1;
            this.AvailableCategoriesButton.Text = "Show Available Categories";
            this.AvailableCategoriesButton.UseVisualStyleBackColor = true;
            this.AvailableCategoriesButton.Click += new System.EventHandler(this.AvailableCategoriesButton_Click);
            // 
            // ActionsButton
            // 
            this.ActionsButton.Location = new System.Drawing.Point(40, 103);
            this.ActionsButton.Name = "ActionsButton";
            this.ActionsButton.Size = new System.Drawing.Size(188, 23);
            this.ActionsButton.TabIndex = 2;
            this.ActionsButton.Text = "Make An Action";
            this.ActionsButton.UseVisualStyleBackColor = true;
            this.ActionsButton.Click += new System.EventHandler(this.ActionsButton_Click);
            // 
            // CategoryInStockButton
            // 
            this.CategoryInStockButton.Location = new System.Drawing.Point(40, 146);
            this.CategoryInStockButton.Name = "CategoryInStockButton";
            this.CategoryInStockButton.Size = new System.Drawing.Size(188, 23);
            this.CategoryInStockButton.TabIndex = 3;
            this.CategoryInStockButton.Text = "Add New Category in Stock";
            this.CategoryInStockButton.UseVisualStyleBackColor = true;
            this.CategoryInStockButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(87, 201);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Back";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // BranchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 250);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CategoryInStockButton);
            this.Controls.Add(this.ActionsButton);
            this.Controls.Add(this.AvailableCategoriesButton);
            this.Controls.Add(this.PreviousActionsButton);
            this.Name = "BranchForm";
            this.Text = "Branch";
            this.Load += new System.EventHandler(this.BranchForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PreviousActionsButton;
        private System.Windows.Forms.Button AvailableCategoriesButton;
        private System.Windows.Forms.Button ActionsButton;
        private System.Windows.Forms.Button CategoryInStockButton;
        private System.Windows.Forms.Button CancelButton;
    }
}