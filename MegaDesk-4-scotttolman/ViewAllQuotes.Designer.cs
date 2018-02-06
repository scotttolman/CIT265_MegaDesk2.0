namespace MegaDesk_4_scotttolman
{
    partial class ViewAllQuotes
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
            this.viewCancel = new System.Windows.Forms.Button();
            this.quoteList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // viewCancel
            // 
            this.viewCancel.Location = new System.Drawing.Point(505, 298);
            this.viewCancel.Name = "viewCancel";
            this.viewCancel.Size = new System.Drawing.Size(75, 23);
            this.viewCancel.TabIndex = 0;
            this.viewCancel.Text = "Cancel";
            this.viewCancel.UseVisualStyleBackColor = true;
            this.viewCancel.Click += new System.EventHandler(this.viewCancel_Click);
            // 
            // quoteList
            // 
            this.quoteList.Location = new System.Drawing.Point(58, 43);
            this.quoteList.Name = "quoteList";
            this.quoteList.Size = new System.Drawing.Size(522, 236);
            this.quoteList.TabIndex = 1;
            this.quoteList.UseCompatibleStateImageBehavior = false;
            this.quoteList.View = System.Windows.Forms.View.List;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.quoteList);
            this.Controls.Add(this.viewCancel);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewCancel;
        private System.Windows.Forms.ListView quoteList;
    }
}