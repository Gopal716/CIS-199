namespace Prog2
{
    partial class Form1
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
            this.hoursCompletedLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.hoursCompletedTxtBox = new System.Windows.Forms.TextBox();
            this.lastNameTxtBox = new System.Windows.Forms.TextBox();
            this.enterBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hoursCompletedLbl
            // 
            this.hoursCompletedLbl.AutoSize = true;
            this.hoursCompletedLbl.Location = new System.Drawing.Point(148, 87);
            this.hoursCompletedLbl.Name = "hoursCompletedLbl";
            this.hoursCompletedLbl.Size = new System.Drawing.Size(333, 64);
            this.hoursCompletedLbl.TabIndex = 0;
            this.hoursCompletedLbl.Text = "Credit Hours Completed :\r\n(Prior To Fall 2016)";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(315, 180);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(166, 64);
            this.lastNameLbl.TabIndex = 1;
            this.lastNameLbl.Text = "Last Name :\r\n\r\n";
            // 
            // hoursCompletedTxtBox
            // 
            this.hoursCompletedTxtBox.Location = new System.Drawing.Point(487, 87);
            this.hoursCompletedTxtBox.Name = "hoursCompletedTxtBox";
            this.hoursCompletedTxtBox.Size = new System.Drawing.Size(177, 38);
            this.hoursCompletedTxtBox.TabIndex = 2;
            // 
            // lastNameTxtBox
            // 
            this.lastNameTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lastNameTxtBox.Location = new System.Drawing.Point(487, 180);
            this.lastNameTxtBox.Name = "lastNameTxtBox";
            this.lastNameTxtBox.Size = new System.Drawing.Size(177, 38);
            this.lastNameTxtBox.TabIndex = 3;
            // 
            // enterBtn
            // 
            this.enterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterBtn.Location = new System.Drawing.Point(315, 268);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(166, 57);
            this.enterBtn.TabIndex = 4;
            this.enterBtn.Text = "ENTER";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.enterBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 376);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.lastNameTxtBox);
            this.Controls.Add(this.hoursCompletedTxtBox);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.hoursCompletedLbl);
            this.Name = "Form1";
            this.Text = "Program 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hoursCompletedLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.TextBox hoursCompletedTxtBox;
        private System.Windows.Forms.TextBox lastNameTxtBox;
        private System.Windows.Forms.Button enterBtn;
    }
}

