namespace BiblotecaUI
{
    partial class searchAuthorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchAuthorsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.booksButton = new System.Windows.Forms.Button();
            this.authorsListBox = new System.Windows.Forms.ListBox();
            this.findButton = new System.Windows.Forms.Button();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(99, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "PAU CASESNOVES LIBRARY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // booksButton
            // 
            this.booksButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.booksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksButton.Location = new System.Drawing.Point(70, 371);
            this.booksButton.Name = "booksButton";
            this.booksButton.Size = new System.Drawing.Size(232, 51);
            this.booksButton.TabIndex = 11;
            this.booksButton.Text = "<< Search Books ";
            this.booksButton.UseVisualStyleBackColor = false;
            this.booksButton.Click += new System.EventHandler(this.booksButton_Click);
            // 
            // authorsListBox
            // 
            this.authorsListBox.FormattingEnabled = true;
            this.authorsListBox.ItemHeight = 16;
            this.authorsListBox.Location = new System.Drawing.Point(45, 185);
            this.authorsListBox.Name = "authorsListBox";
            this.authorsListBox.Size = new System.Drawing.Size(712, 180);
            this.authorsListBox.TabIndex = 10;
            this.authorsListBox.DoubleClick += new System.EventHandler(this.authorsListBox_DoubleClick);
            // 
            // findButton
            // 
            this.findButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findButton.Location = new System.Drawing.Point(679, 124);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(106, 44);
            this.findButton.TabIndex = 9;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = false;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(45, 137);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(499, 22);
            this.authorTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Authors founds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Search author";
            // 
            // searchAuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.booksButton);
            this.Controls.Add(this.authorsListBox);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "searchAuthorsForm";
            this.Text = "Biblioteca Arcaica";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.searchAuthorsForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button booksButton;
        private System.Windows.Forms.ListBox authorsListBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}