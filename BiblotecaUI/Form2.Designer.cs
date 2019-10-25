namespace BiblotecaUI
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.title = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.description = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.autoresList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(238, 41);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(46, 17);
            this.title.TabIndex = 0;
            this.title.Text = "label1";
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Location = new System.Drawing.Point(238, 163);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(0, 17);
            this.author.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(238, 102);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(46, 17);
            this.description.TabIndex = 3;
            this.description.Text = "label1";
            // 
            // department
            // 
            this.department.AutoSize = true;
            this.department.Location = new System.Drawing.Point(238, 224);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(46, 17);
            this.department.TabIndex = 4;
            this.department.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(532, 72);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // autoresList
            // 
            this.autoresList.FormattingEnabled = true;
            this.autoresList.ItemHeight = 16;
            this.autoresList.Location = new System.Drawing.Point(241, 153);
            this.autoresList.Name = "autoresList";
            this.autoresList.Size = new System.Drawing.Size(290, 52);
            this.autoresList.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.autoresList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.department);
            this.Controls.Add(this.description);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.author);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Info Libro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label department;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox autoresList;
    }
}