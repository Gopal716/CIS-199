namespace Prog4
{
    partial class prog4Form
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
            this.addBookGrpBox = new System.Windows.Forms.GroupBox();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.callNumTxtBox = new System.Windows.Forms.TextBox();
            this.copyrightTxtBox = new System.Windows.Forms.TextBox();
            this.publisherTxtBox = new System.Windows.Forms.TextBox();
            this.authorTxtBox = new System.Windows.Forms.TextBox();
            this.titleTxtBox = new System.Windows.Forms.TextBox();
            this.callNumLbl = new System.Windows.Forms.Label();
            this.copyrtYearLbl = new System.Windows.Forms.Label();
            this.publisherLbl = new System.Windows.Forms.Label();
            this.AuthorLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.selectBookGrpBox = new System.Windows.Forms.GroupBox();
            this.bookListBox = new System.Windows.Forms.ListBox();
            this.detailsBtn = new System.Windows.Forms.Button();
            this.checkOutBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.addBookGrpBox.SuspendLayout();
            this.selectBookGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBookGrpBox
            // 
            this.addBookGrpBox.Controls.Add(this.addBookBtn);
            this.addBookGrpBox.Controls.Add(this.callNumTxtBox);
            this.addBookGrpBox.Controls.Add(this.copyrightTxtBox);
            this.addBookGrpBox.Controls.Add(this.publisherTxtBox);
            this.addBookGrpBox.Controls.Add(this.authorTxtBox);
            this.addBookGrpBox.Controls.Add(this.titleTxtBox);
            this.addBookGrpBox.Controls.Add(this.callNumLbl);
            this.addBookGrpBox.Controls.Add(this.copyrtYearLbl);
            this.addBookGrpBox.Controls.Add(this.publisherLbl);
            this.addBookGrpBox.Controls.Add(this.AuthorLbl);
            this.addBookGrpBox.Controls.Add(this.titleLbl);
            this.addBookGrpBox.Location = new System.Drawing.Point(54, 80);
            this.addBookGrpBox.Name = "addBookGrpBox";
            this.addBookGrpBox.Size = new System.Drawing.Size(535, 426);
            this.addBookGrpBox.TabIndex = 0;
            this.addBookGrpBox.TabStop = false;
            this.addBookGrpBox.Text = "Add Book";
            // 
            // addBookBtn
            // 
            this.addBookBtn.Location = new System.Drawing.Point(155, 347);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(244, 56);
            this.addBookBtn.TabIndex = 10;
            this.addBookBtn.Text = "Add Book";
            this.addBookBtn.UseVisualStyleBackColor = true;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // callNumTxtBox
            // 
            this.callNumTxtBox.Location = new System.Drawing.Point(237, 267);
            this.callNumTxtBox.Name = "callNumTxtBox";
            this.callNumTxtBox.Size = new System.Drawing.Size(208, 38);
            this.callNumTxtBox.TabIndex = 9;
            // 
            // copyrightTxtBox
            // 
            this.copyrightTxtBox.Location = new System.Drawing.Point(237, 214);
            this.copyrightTxtBox.Name = "copyrightTxtBox";
            this.copyrightTxtBox.Size = new System.Drawing.Size(208, 38);
            this.copyrightTxtBox.TabIndex = 8;
            // 
            // publisherTxtBox
            // 
            this.publisherTxtBox.Location = new System.Drawing.Point(237, 159);
            this.publisherTxtBox.Name = "publisherTxtBox";
            this.publisherTxtBox.Size = new System.Drawing.Size(208, 38);
            this.publisherTxtBox.TabIndex = 7;
            // 
            // authorTxtBox
            // 
            this.authorTxtBox.Location = new System.Drawing.Point(237, 108);
            this.authorTxtBox.Name = "authorTxtBox";
            this.authorTxtBox.Size = new System.Drawing.Size(208, 38);
            this.authorTxtBox.TabIndex = 6;
            // 
            // titleTxtBox
            // 
            this.titleTxtBox.Location = new System.Drawing.Point(237, 55);
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.Size = new System.Drawing.Size(208, 38);
            this.titleTxtBox.TabIndex = 5;
            // 
            // callNumLbl
            // 
            this.callNumLbl.AutoSize = true;
            this.callNumLbl.Location = new System.Drawing.Point(51, 270);
            this.callNumLbl.Name = "callNumLbl";
            this.callNumLbl.Size = new System.Drawing.Size(180, 32);
            this.callNumLbl.TabIndex = 4;
            this.callNumLbl.Text = "Call Number:";
            // 
            // copyrtYearLbl
            // 
            this.copyrtYearLbl.AutoSize = true;
            this.copyrtYearLbl.Location = new System.Drawing.Point(19, 214);
            this.copyrtYearLbl.Name = "copyrtYearLbl";
            this.copyrtYearLbl.Size = new System.Drawing.Size(212, 32);
            this.copyrtYearLbl.TabIndex = 3;
            this.copyrtYearLbl.Text = "Copyright Year:";
            // 
            // publisherLbl
            // 
            this.publisherLbl.AutoSize = true;
            this.publisherLbl.Location = new System.Drawing.Point(88, 159);
            this.publisherLbl.Name = "publisherLbl";
            this.publisherLbl.Size = new System.Drawing.Size(143, 32);
            this.publisherLbl.TabIndex = 2;
            this.publisherLbl.Text = "Publisher:";
            // 
            // AuthorLbl
            // 
            this.AuthorLbl.AutoSize = true;
            this.AuthorLbl.Location = new System.Drawing.Point(124, 111);
            this.AuthorLbl.Name = "AuthorLbl";
            this.AuthorLbl.Size = new System.Drawing.Size(107, 32);
            this.AuthorLbl.TabIndex = 1;
            this.AuthorLbl.Text = "Author:";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(153, 58);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(78, 32);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Title:";
            // 
            // selectBookGrpBox
            // 
            this.selectBookGrpBox.Controls.Add(this.returnBtn);
            this.selectBookGrpBox.Controls.Add(this.checkOutBtn);
            this.selectBookGrpBox.Controls.Add(this.detailsBtn);
            this.selectBookGrpBox.Controls.Add(this.bookListBox);
            this.selectBookGrpBox.Location = new System.Drawing.Point(647, 80);
            this.selectBookGrpBox.Name = "selectBookGrpBox";
            this.selectBookGrpBox.Size = new System.Drawing.Size(701, 426);
            this.selectBookGrpBox.TabIndex = 1;
            this.selectBookGrpBox.TabStop = false;
            this.selectBookGrpBox.Text = "Select Book";
            // 
            // bookListBox
            // 
            this.bookListBox.FormattingEnabled = true;
            this.bookListBox.ItemHeight = 31;
            this.bookListBox.Location = new System.Drawing.Point(54, 55);
            this.bookListBox.Name = "bookListBox";
            this.bookListBox.Size = new System.Drawing.Size(268, 345);
            this.bookListBox.TabIndex = 0;
            // 
            // detailsBtn
            // 
            this.detailsBtn.Location = new System.Drawing.Point(369, 76);
            this.detailsBtn.Name = "detailsBtn";
            this.detailsBtn.Size = new System.Drawing.Size(225, 70);
            this.detailsBtn.TabIndex = 1;
            this.detailsBtn.Text = "Details";
            this.detailsBtn.UseVisualStyleBackColor = true;
            this.detailsBtn.Click += new System.EventHandler(this.detailsBtn_Click);
            // 
            // checkOutBtn
            // 
            this.checkOutBtn.Location = new System.Drawing.Point(369, 174);
            this.checkOutBtn.Name = "checkOutBtn";
            this.checkOutBtn.Size = new System.Drawing.Size(225, 72);
            this.checkOutBtn.TabIndex = 2;
            this.checkOutBtn.Text = "Check Out";
            this.checkOutBtn.UseVisualStyleBackColor = true;
            this.checkOutBtn.Click += new System.EventHandler(this.checkOutBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(369, 267);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(225, 75);
            this.returnBtn.TabIndex = 3;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // prog4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 685);
            this.Controls.Add(this.selectBookGrpBox);
            this.Controls.Add(this.addBookGrpBox);
            this.Name = "prog4Form";
            this.Text = "Program 4";
            this.addBookGrpBox.ResumeLayout(false);
            this.addBookGrpBox.PerformLayout();
            this.selectBookGrpBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addBookGrpBox;
        private System.Windows.Forms.TextBox callNumTxtBox;
        private System.Windows.Forms.TextBox copyrightTxtBox;
        private System.Windows.Forms.TextBox publisherTxtBox;
        private System.Windows.Forms.TextBox authorTxtBox;
        private System.Windows.Forms.TextBox titleTxtBox;
        private System.Windows.Forms.Label callNumLbl;
        private System.Windows.Forms.Label copyrtYearLbl;
        private System.Windows.Forms.Label publisherLbl;
        private System.Windows.Forms.Label AuthorLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.GroupBox selectBookGrpBox;
        private System.Windows.Forms.ListBox bookListBox;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button checkOutBtn;
        private System.Windows.Forms.Button detailsBtn;
    }
}

