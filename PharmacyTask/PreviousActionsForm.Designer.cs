namespace PharmacyTask
{
    partial class PreviousActionsForm
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
            this.PreviousActionDataGridView = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousActionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PreviousActionDataGridView
            // 
            this.PreviousActionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PreviousActionDataGridView.Location = new System.Drawing.Point(12, 12);
            this.PreviousActionDataGridView.Name = "PreviousActionDataGridView";
            this.PreviousActionDataGridView.Size = new System.Drawing.Size(443, 205);
            this.PreviousActionDataGridView.TabIndex = 0;
            this.PreviousActionDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PreviousActionDataGridView_CellContentClick);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(182, 248);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PreviousActionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 283);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.PreviousActionDataGridView);
            this.Name = "PreviousActionsForm";
            this.Text = "Previous Actions";
            this.Load += new System.EventHandler(this.PreviousActionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PreviousActionDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PreviousActionDataGridView;
        private System.Windows.Forms.Button BackButton;
    }
}