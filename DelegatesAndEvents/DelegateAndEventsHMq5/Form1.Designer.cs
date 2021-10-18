
namespace DelegateAndEventsHMq5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernametextBox1 = new System.Windows.Forms.TextBox();
            this.PasswordtextBox2 = new System.Windows.Forms.TextBox();
            this.DepositTextBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BankMoneytextBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 124);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // UsernametextBox1
            // 
            this.UsernametextBox1.Location = new System.Drawing.Point(133, 24);
            this.UsernametextBox1.Name = "UsernametextBox1";
            this.UsernametextBox1.Size = new System.Drawing.Size(150, 31);
            this.UsernametextBox1.TabIndex = 3;
            // 
            // PasswordtextBox2
            // 
            this.PasswordtextBox2.Location = new System.Drawing.Point(133, 82);
            this.PasswordtextBox2.Name = "PasswordtextBox2";
            this.PasswordtextBox2.Size = new System.Drawing.Size(150, 31);
            this.PasswordtextBox2.TabIndex = 4;
            // 
            // DepositTextBox1
            // 
            this.DepositTextBox1.Location = new System.Drawing.Point(775, 24);
            this.DepositTextBox1.Name = "DepositTextBox1";
            this.DepositTextBox1.Size = new System.Drawing.Size(192, 31);
            this.DepositTextBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "How much money to deposit";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1020, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 47);
            this.button2.TabIndex = 7;
            this.button2.Text = "Deposit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(509, 82);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(487, 179);
            this.listBox1.TabIndex = 8;
            // 
            // BankMoneytextBox1
            // 
            this.BankMoneytextBox1.Location = new System.Drawing.Point(754, 406);
            this.BankMoneytextBox1.Name = "BankMoneytextBox1";
            this.BankMoneytextBox1.Size = new System.Drawing.Size(150, 31);
            this.BankMoneytextBox1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(619, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bank Money:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 521);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BankMoneytextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DepositTextBox1);
            this.Controls.Add(this.PasswordtextBox2);
            this.Controls.Add(this.UsernametextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernametextBox1;
        private System.Windows.Forms.TextBox PasswordtextBox2;
        private System.Windows.Forms.TextBox DepositTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox BankMoneytextBox1;
        private System.Windows.Forms.Label label4;
    }
}

