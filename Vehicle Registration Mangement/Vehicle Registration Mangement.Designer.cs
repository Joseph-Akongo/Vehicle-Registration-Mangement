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
            this.Enter = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.BinarySearch = new System.Windows.Forms.Button();
            this.LinearSearch = new System.Windows.Forms.Button();
            this.TAG = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.StatusLable = new System.Windows.Forms.StatusStrip();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(243, 94);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(143, 46);
            this.Enter.TabIndex = 1;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(243, 146);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(143, 46);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(243, 198);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(143, 46);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(243, 392);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(143, 46);
            this.Save.TabIndex = 5;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(454, 94);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(143, 46);
            this.Open.TabIndex = 6;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // BinarySearch
            // 
            this.BinarySearch.Location = new System.Drawing.Point(454, 198);
            this.BinarySearch.Name = "BinarySearch";
            this.BinarySearch.Size = new System.Drawing.Size(143, 46);
            this.BinarySearch.TabIndex = 7;
            this.BinarySearch.Text = "Binary Search";
            this.BinarySearch.UseVisualStyleBackColor = true;
            this.BinarySearch.Click += new System.EventHandler(this.BinarySearch_Click);
            // 
            // LinearSearch
            // 
            this.LinearSearch.Location = new System.Drawing.Point(454, 250);
            this.LinearSearch.Name = "LinearSearch";
            this.LinearSearch.Size = new System.Drawing.Size(143, 46);
            this.LinearSearch.TabIndex = 8;
            this.LinearSearch.Text = "Linear Search";
            this.LinearSearch.UseVisualStyleBackColor = true;
            // 
            // TAG
            // 
            this.TAG.Location = new System.Drawing.Point(243, 250);
            this.TAG.Name = "TAG";
            this.TAG.Size = new System.Drawing.Size(143, 46);
            this.TAG.TabIndex = 9;
            this.TAG.Text = "TAG";
            this.TAG.UseVisualStyleBackColor = true;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(454, 392);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(143, 46);
            this.Reset.TabIndex = 10;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(243, 56);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(143, 20);
            this.InputBox.TabIndex = 11;
            // 
            // StatusLable
            // 
            this.StatusLable.Location = new System.Drawing.Point(0, 467);
            this.StatusLable.Name = "StatusLable";
            this.StatusLable.Size = new System.Drawing.Size(620, 22);
            this.StatusLable.TabIndex = 12;
            this.StatusLable.Text = "statusStrip1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(193, 407);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Selected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Vehicle Plate Details";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 489);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.StatusLable);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.TAG);
            this.Controls.Add(this.LinearSearch);
            this.Controls.Add(this.BinarySearch);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Enter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button BinarySearch;
        private System.Windows.Forms.Button LinearSearch;
        private System.Windows.Forms.Button TAG;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.StatusStrip StatusLable;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

