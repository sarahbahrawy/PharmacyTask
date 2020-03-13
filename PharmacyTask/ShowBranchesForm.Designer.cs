namespace PharmacyTask
{
    partial class ShowBranchesForm
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
            this.BranchesComboBox = new System.Windows.Forms.ComboBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BranchesComboBox
            // 
            this.BranchesComboBox.FormattingEnabled = true;
            this.BranchesComboBox.Location = new System.Drawing.Point(12, 35);
            this.BranchesComboBox.Name = "BranchesComboBox";
            this.BranchesComboBox.Size = new System.Drawing.Size(121, 21);
            this.BranchesComboBox.TabIndex = 0;
            this.BranchesComboBox.SelectedIndexChanged += new System.EventHandler(this.BranchesComboBox_SelectedIndexChanged);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(207, 95);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select A Branch ";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(207, 124);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Back";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ShowBranchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 208);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.BranchesComboBox);
            this.Name = "ShowBranchesForm";
            this.Text = "Branches";
            this.Load += new System.EventHandler(this.ShowBranchesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BranchesComboBox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelButton;
    }
}