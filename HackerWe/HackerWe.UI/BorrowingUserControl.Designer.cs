namespace HackerWe.UI
{
    partial class BorrowingUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpBorrowingDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClientsComboBox1 = new System.Windows.Forms.ComboBox();
            this.BooksComboBox = new System.Windows.Forms.ComboBox();
            this.lblDueReturningDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpBorrowingDate
            // 
            this.dtpBorrowingDate.Location = new System.Drawing.Point(163, 40);
            this.dtpBorrowingDate.Name = "dtpBorrowingDate";
            this.dtpBorrowingDate.Size = new System.Drawing.Size(291, 31);
            this.dtpBorrowingDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Borrowing Date: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Book: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Due Returning Date: ";
            // 
            // ClientsComboBox1
            // 
            this.ClientsComboBox1.FormattingEnabled = true;
            this.ClientsComboBox1.Location = new System.Drawing.Point(163, 94);
            this.ClientsComboBox1.Name = "ClientsComboBox1";
            this.ClientsComboBox1.Size = new System.Drawing.Size(291, 33);
            this.ClientsComboBox1.TabIndex = 2;
            // 
            // BooksComboBox
            // 
            this.BooksComboBox.FormattingEnabled = true;
            this.BooksComboBox.Location = new System.Drawing.Point(163, 152);
            this.BooksComboBox.Name = "BooksComboBox";
            this.BooksComboBox.Size = new System.Drawing.Size(291, 33);
            this.BooksComboBox.TabIndex = 3;
            // 
            // lblDueReturningDate
            // 
            this.lblDueReturningDate.AutoSize = true;
            this.lblDueReturningDate.Location = new System.Drawing.Point(185, 222);
            this.lblDueReturningDate.Name = "lblDueReturningDate";
            this.lblDueReturningDate.Size = new System.Drawing.Size(176, 25);
            this.lblDueReturningDate.TabIndex = 6;
            this.lblDueReturningDate.Text = "Due Returning Date: ";
            // 
            // BorrowingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDueReturningDate);
            this.Controls.Add(this.BooksComboBox);
            this.Controls.Add(this.ClientsComboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpBorrowingDate);
            this.Name = "BorrowingUserControl";
            this.Size = new System.Drawing.Size(746, 536);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtpBorrowingDate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox ClientsComboBox1;
        private ComboBox BooksComboBox;
        private Label lblDueReturningDate;
    }
}
