namespace MegaDesk_4_scotttolman
{
    partial class AddQuote
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
            this.ShowMainMenu = new System.Windows.Forms.Button();
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.depthLabel = new System.Windows.Forms.Label();
            this.instructions = new System.Windows.Forms.Label();
            this.oak = new System.Windows.Forms.RadioButton();
            this.laminate = new System.Windows.Forms.RadioButton();
            this.pine = new System.Windows.Forms.RadioButton();
            this.rosewood = new System.Windows.Forms.RadioButton();
            this.veneer = new System.Windows.Forms.RadioButton();
            this.drawerBox = new System.Windows.Forms.ComboBox();
            this.rushBox = new System.Windows.Forms.ComboBox();
            this.drawerLabel = new System.Windows.Forms.Label();
            this.rushLabel = new System.Windows.Forms.Label();
            this.ShowQuote = new System.Windows.Forms.Button();
            this.widthError = new System.Windows.Forms.Label();
            this.depthError = new System.Windows.Forms.Label();
            this.depthBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ShowMainMenu
            // 
            this.ShowMainMenu.Location = new System.Drawing.Point(294, 326);
            this.ShowMainMenu.Name = "ShowMainMenu";
            this.ShowMainMenu.Size = new System.Drawing.Size(75, 23);
            this.ShowMainMenu.TabIndex = 0;
            this.ShowMainMenu.Text = "Cancel";
            this.ShowMainMenu.UseVisualStyleBackColor = true;
            this.ShowMainMenu.Click += new System.EventHandler(this.ShowMainMenu_Click);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(43, 71);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(35, 13);
            this.widthLabel.TabIndex = 1;
            this.widthLabel.Text = "Width";
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(84, 64);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(100, 20);
            this.widthBox.TabIndex = 2;
            this.widthBox.Validating += new System.ComponentModel.CancelEventHandler(this.widthBox_Validating);
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Location = new System.Drawing.Point(308, 67);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(36, 13);
            this.depthLabel.TabIndex = 3;
            this.depthLabel.Text = "Depth";
            // 
            // instructions
            // 
            this.instructions.AutoSize = true;
            this.instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions.Location = new System.Drawing.Point(79, 9);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(371, 26);
            this.instructions.TabIndex = 5;
            this.instructions.Text = "Please enter your desk specifications";
            // 
            // oak
            // 
            this.oak.AutoSize = true;
            this.oak.Location = new System.Drawing.Point(84, 115);
            this.oak.Name = "oak";
            this.oak.Size = new System.Drawing.Size(45, 17);
            this.oak.TabIndex = 6;
            this.oak.TabStop = true;
            this.oak.Text = "Oak";
            this.oak.UseVisualStyleBackColor = true;
            // 
            // laminate
            // 
            this.laminate.AutoSize = true;
            this.laminate.Location = new System.Drawing.Point(84, 138);
            this.laminate.Name = "laminate";
            this.laminate.Size = new System.Drawing.Size(68, 17);
            this.laminate.TabIndex = 7;
            this.laminate.TabStop = true;
            this.laminate.Text = "Laminate";
            this.laminate.UseVisualStyleBackColor = true;
            // 
            // pine
            // 
            this.pine.AutoSize = true;
            this.pine.Location = new System.Drawing.Point(84, 161);
            this.pine.Name = "pine";
            this.pine.Size = new System.Drawing.Size(46, 17);
            this.pine.TabIndex = 8;
            this.pine.TabStop = true;
            this.pine.Text = "Pine";
            this.pine.UseVisualStyleBackColor = true;
            // 
            // rosewood
            // 
            this.rosewood.AutoSize = true;
            this.rosewood.Location = new System.Drawing.Point(84, 184);
            this.rosewood.Name = "rosewood";
            this.rosewood.Size = new System.Drawing.Size(76, 17);
            this.rosewood.TabIndex = 9;
            this.rosewood.TabStop = true;
            this.rosewood.Text = "Rosewood";
            this.rosewood.UseVisualStyleBackColor = true;
            // 
            // veneer
            // 
            this.veneer.AutoSize = true;
            this.veneer.Location = new System.Drawing.Point(84, 207);
            this.veneer.Name = "veneer";
            this.veneer.Size = new System.Drawing.Size(59, 17);
            this.veneer.TabIndex = 10;
            this.veneer.TabStop = true;
            this.veneer.Text = "Veneer";
            this.veneer.UseVisualStyleBackColor = true;
            // 
            // drawerBox
            // 
            this.drawerBox.FormattingEnabled = true;
            this.drawerBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.drawerBox.Location = new System.Drawing.Point(329, 138);
            this.drawerBox.Name = "drawerBox";
            this.drawerBox.Size = new System.Drawing.Size(121, 21);
            this.drawerBox.TabIndex = 11;
            // 
            // rushBox
            // 
            this.rushBox.FormattingEnabled = true;
            this.rushBox.Items.AddRange(new object[] {
            "No Rush",
            "7 Days",
            "5 Days",
            "3 Days"});
            this.rushBox.Location = new System.Drawing.Point(329, 206);
            this.rushBox.Name = "rushBox";
            this.rushBox.Size = new System.Drawing.Size(121, 21);
            this.rushBox.TabIndex = 12;
            // 
            // drawerLabel
            // 
            this.drawerLabel.AutoSize = true;
            this.drawerLabel.Location = new System.Drawing.Point(352, 115);
            this.drawerLabel.Name = "drawerLabel";
            this.drawerLabel.Size = new System.Drawing.Size(98, 13);
            this.drawerLabel.TabIndex = 13;
            this.drawerLabel.Text = "Number of Drawers";
            // 
            // rushLabel
            // 
            this.rushLabel.AutoSize = true;
            this.rushLabel.Location = new System.Drawing.Point(384, 184);
            this.rushLabel.Name = "rushLabel";
            this.rushLabel.Size = new System.Drawing.Size(66, 13);
            this.rushLabel.TabIndex = 14;
            this.rushLabel.Text = "Rush Option";
            // 
            // ShowQuote
            // 
            this.ShowQuote.Location = new System.Drawing.Point(375, 326);
            this.ShowQuote.Name = "ShowQuote";
            this.ShowQuote.Size = new System.Drawing.Size(75, 23);
            this.ShowQuote.TabIndex = 15;
            this.ShowQuote.Text = "Ok";
            this.ShowQuote.UseVisualStyleBackColor = true;
            // 
            // widthError
            // 
            this.widthError.AutoSize = true;
            this.widthError.BackColor = System.Drawing.Color.Orange;
            this.widthError.Location = new System.Drawing.Point(93, 48);
            this.widthError.Name = "widthError";
            this.widthError.Size = new System.Drawing.Size(91, 13);
            this.widthError.TabIndex = 16;
            this.widthError.Text = "24\" min. 96\" max.";
            this.widthError.Visible = false;
            // 
            // depthError
            // 
            this.depthError.AutoSize = true;
            this.depthError.BackColor = System.Drawing.Color.Orange;
            this.depthError.Location = new System.Drawing.Point(270, 48);
            this.depthError.Name = "depthError";
            this.depthError.Size = new System.Drawing.Size(180, 13);
            this.depthError.TabIndex = 17;
            this.depthError.Text = "Please enter digits and decimals only";
            this.depthError.Visible = false;
            // 
            // depthBox
            // 
            this.depthBox.Location = new System.Drawing.Point(350, 64);
            this.depthBox.MaxLength = 2;
            this.depthBox.Name = "depthBox";
            this.depthBox.Size = new System.Drawing.Size(100, 20);
            this.depthBox.TabIndex = 4;
            this.depthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depthBox_KeyPress);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.depthError);
            this.Controls.Add(this.widthError);
            this.Controls.Add(this.ShowQuote);
            this.Controls.Add(this.rushLabel);
            this.Controls.Add(this.drawerLabel);
            this.Controls.Add(this.rushBox);
            this.Controls.Add(this.drawerBox);
            this.Controls.Add(this.veneer);
            this.Controls.Add(this.rosewood);
            this.Controls.Add(this.pine);
            this.Controls.Add(this.laminate);
            this.Controls.Add(this.oak);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.depthBox);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.ShowMainMenu);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowMainMenu;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label instructions;
        private System.Windows.Forms.RadioButton oak;
        private System.Windows.Forms.RadioButton laminate;
        private System.Windows.Forms.RadioButton pine;
        private System.Windows.Forms.RadioButton rosewood;
        private System.Windows.Forms.RadioButton veneer;
        private System.Windows.Forms.ComboBox drawerBox;
        private System.Windows.Forms.ComboBox rushBox;
        private System.Windows.Forms.Label drawerLabel;
        private System.Windows.Forms.Label rushLabel;
        private System.Windows.Forms.Button ShowQuote;
        private System.Windows.Forms.Label widthError;
        private System.Windows.Forms.Label depthError;
        private System.Windows.Forms.TextBox depthBox;
    }
}