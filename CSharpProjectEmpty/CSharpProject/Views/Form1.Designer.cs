namespace CSharpProject.Views
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.urlBox1 = new System.Windows.Forms.TextBox();
            this.infoLabel1 = new System.Windows.Forms.Label();
            this.backButton1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.urlLabel1 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameField1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 300);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(76, 147);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // urlBox1
            // 
            this.urlBox1.Location = new System.Drawing.Point(12, 59);
            this.urlBox1.Name = "urlBox1";
            this.urlBox1.Size = new System.Drawing.Size(165, 20);
            this.urlBox1.TabIndex = 1;
            // 
            // infoLabel1
            // 
            this.infoLabel1.AutoSize = true;
            this.infoLabel1.Location = new System.Drawing.Point(12, 258);
            this.infoLabel1.Name = "infoLabel1";
            this.infoLabel1.Size = new System.Drawing.Size(51, 13);
            this.infoLabel1.TabIndex = 2;
            this.infoLabel1.Text = "Podcasts";
            this.infoLabel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // backButton1
            // 
            this.backButton1.Location = new System.Drawing.Point(525, 424);
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(75, 23);
            this.backButton1.TabIndex = 3;
            this.backButton1.Text = "Back";
            this.backButton1.UseVisualStyleBackColor = true;
            this.backButton1.Click += new System.EventHandler(this.backButton1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 19);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "URL";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(188, 300);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(162, 147);
            this.listBox2.TabIndex = 6;
            // 
            // nameLabel1
            // 
            this.nameLabel1.AutoSize = true;
            this.nameLabel1.Location = new System.Drawing.Point(12, 284);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(35, 13);
            this.nameLabel1.TabIndex = 7;
            this.nameLabel1.Text = "Name";
            // 
            // urlLabel1
            // 
            this.urlLabel1.AutoSize = true;
            this.urlLabel1.Location = new System.Drawing.Point(185, 284);
            this.urlLabel1.Name = "urlLabel1";
            this.urlLabel1.Size = new System.Drawing.Size(29, 13);
            this.urlLabel1.TabIndex = 8;
            this.urlLabel1.Text = "URL";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(94, 300);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(82, 147);
            this.listBox3.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Category";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(298, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 19);
            this.button2.TabIndex = 12;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 96);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "Name";
            // 
            // nameField1
            // 
            this.nameField1.Location = new System.Drawing.Point(12, 113);
            this.nameField1.Name = "nameField1";
            this.nameField1.Size = new System.Drawing.Size(165, 20);
            this.nameField1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Add Podcasts";
            // 
            // categoryBox1
            // 
            this.categoryBox1.FormattingEnabled = true;
            this.categoryBox1.Location = new System.Drawing.Point(12, 168);
            this.categoryBox1.Name = "categoryBox1";
            this.categoryBox1.Size = new System.Drawing.Size(121, 21);
            this.categoryBox1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 459);
            this.Controls.Add(this.categoryBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameField1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.urlLabel1);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backButton1);
            this.Controls.Add(this.infoLabel1);
            this.Controls.Add(this.urlBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox urlBox1;
        private System.Windows.Forms.Label infoLabel1;
        private System.Windows.Forms.Button backButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label urlLabel1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameField1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox categoryBox1;
    }
}