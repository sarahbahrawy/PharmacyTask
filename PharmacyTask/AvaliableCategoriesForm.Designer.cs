namespace PharmacyTask
{
    partial class AvaliableCategoriesForm
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
            this.AvaialbleCategoriesDataGridView = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AvaialbleCategoriesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AvaialbleCategoriesDataGridView
            // 
            this.AvaialbleCategoriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvaialbleCategoriesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.AvaialbleCategoriesDataGridView.Name = "AvaialbleCategoriesDataGridView";
            this.AvaialbleCategoriesDataGridView.Size = new System.Drawing.Size(253, 212);
            this.AvaialbleCategoriesDataGridView.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(90, 245);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AvaliableCategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 294);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AvaialbleCategoriesDataGridView);
            this.Name = "AvaliableCategoriesForm";
            this.Text = "Avaliable Categories";
            this.Load += new System.EventHandler(this.AvaliableCategoriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AvaialbleCategoriesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AvaialbleCategoriesDataGridView;
        private System.Windows.Forms.Button BackButton;
    }
}