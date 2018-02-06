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
            this.materialBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quoteList = new System.Windows.Forms.ListView();
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
            // materialBox
            // 
            this.materialBox.FormattingEnabled = true;
            this.materialBox.Location = new System.Drawing.Point(225, 28);
            this.materialBox.Name = "materialBox";
            this.materialBox.Size = new System.Drawing.Size(121, 21);
            this.materialBox.TabIndex = 1;
            this.materialBox.SelectedIndexChanged += new System.EventHandler(this.materialBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // quoteList
            // 
            this.quoteList.Location = new System.Drawing.Point(125, 68);
            this.quoteList.Name = "quoteList";
            this.quoteList.Size = new System.Drawing.Size(384, 211);
            this.quoteList.TabIndex = 3;
            this.quoteList.UseCompatibleStateImageBehavior = false;
            this.quoteList.View = System.Windows.Forms.View.List;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.quoteList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialBox);
            this.Controls.Add(this.searchCancel);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchCancel;
        private System.Windows.Forms.ComboBox materialBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView quoteList;
    }
}