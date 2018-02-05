namespace MegaDesk_4_scotttolman
{
    partial class SearchQuotes
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
            this.searchCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchCancel
            // 
            this.searchCancel.Location = new System.Drawing.Point(545, 299);
            this.searchCancel.Name = "searchCancel";
            this.searchCancel.Size = new System.Drawing.Size(75, 23);
            this.searchCancel.TabIndex = 0;
            this.searchCancel.Text = "Cancel";
            this.searchCancel.UseVisualStyleBackColor = true;
            this.searchCancel.Click += new System.EventHandler(this.searchCancel_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.searchCancel);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchCancel;
    }
}