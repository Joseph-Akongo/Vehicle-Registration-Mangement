namespace Vehicle_Registration_Mangement
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
            this.Enter = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.BinarySearch = new System.Windows.Forms.Button();
            this.LinearSearch = new System.Windows.Forms.Button();
            this.TAG = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(22, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 433);
            this.listBox1.TabIndex = 0;
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(270, 94);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(143, 46);
            this.Enter.TabIndex = 1;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(270, 146);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(143, 46);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(270, 198);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(143, 46);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(270, 399);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(143, 46);
            this.Save.TabIndex = 5;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(478, 94);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(143, 46);
            this.Open.TabIndex = 6;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // BinarySearch
            // 
            this.BinarySearch.Location = new System.Drawing.Point(478, 198);
            this.BinarySearch.Name = "BinarySearch";
            this.BinarySearch.Size = new System.Drawing.Size(143, 46);
            this.BinarySearch.TabIndex = 7;
            this.BinarySearch.Text = "Binary Search";
            this.BinarySearch.UseVisualStyleBackColor = true;
            // 
            // LinearSearch
            // 
            this.LinearSearch.Location = new System.Drawing.Point(478, 250);
            this.LinearSearch.Name = "LinearSearch";
            this.LinearSearch.Size = new System.Drawing.Size(143, 46);
            this.LinearSearch.TabIndex = 8;
            this.LinearSearch.Text = "Linear Search";
            this.LinearSearch.UseVisualStyleBackColor = true;
            // 
            // TAG
            // 
            this.TAG.Location = new System.Drawing.Point(270, 250);
            this.TAG.Name = "TAG";
            this.TAG.Size = new System.Drawing.Size(143, 46);
            this.TAG.TabIndex = 9;
            this.TAG.Text = "TAG";
            this.TAG.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 466);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TAG);
            this.Controls.Add(this.LinearSearch);
            this.Controls.Add(this.BinarySearch);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button BinarySearch;
        private System.Windows.Forms.Button LinearSearch;
        private System.Windows.Forms.Button TAG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

