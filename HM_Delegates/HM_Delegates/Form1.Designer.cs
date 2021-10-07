
namespace HM_Delegates
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
            this.button2 = new System.Windows.Forms.Button();
            this.Resulte = new System.Windows.Forms.TextBox();
            this.Num2 = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(443, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sub";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Resulte
            // 
            this.Resulte.Location = new System.Drawing.Point(508, 82);
            this.Resulte.Name = "Resulte";
            this.Resulte.Size = new System.Drawing.Size(150, 31);
            this.Resulte.TabIndex = 2;
            // 
            // Num2
            // 
            this.Num2.Location = new System.Drawing.Point(328, 82);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(150, 31);
            this.Num2.TabIndex = 3;
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(155, 82);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(150, 31);
            this.num1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageStudentsToolStripMenuItem});
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // manageStudentsToolStripMenuItem
            // 
            this.manageStudentsToolStripMenuItem.Name = "manageStudentsToolStripMenuItem";
            this.manageStudentsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.manageStudentsToolStripMenuItem.Text = "Manage Students";
            this.manageStudentsToolStripMenuItem.Click += new System.EventHandler(this.manageStudentsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Resulte);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Resulte;
        private System.Windows.Forms.TextBox Num2;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStudentsToolStripMenuItem;
    }
}

