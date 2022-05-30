using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Registration_Mangement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<String[]> myArray = new List<string[]>();
        string[] myArray2 = new string[20];

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog plateFile = new OpenFileDialog();
            plateFile.Title = "Open Text File";
            plateFile.Filter = "TXT files|*.txt";
            plateFile.InitialDirectory = @"C:\Users\30053863\Source\Repos\Vehicle Registration Mangement";
            OpenFileDialog f = new OpenFileDialog();
            if (plateFile.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                List<String> list = new List<String>();
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        listBox1.Items.Add(line);
                    }
                }
                MessageBox.Show(plateFile.FileName.ToString());
            }
        }

        private void DisplayPlate()
        {
            myArray.Clear();
        }


        private void Enter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(InputBox.Text))
                return;
                listBox1.Items.Add(InputBox.Text);
                InputBox.Clear();
                InputBox.Focus();
            
        }

        private void BinarySearch_Click(object sender, EventArgs e)
        {
           
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = listBox1.Text;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count > 0)
               listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                InputBox.Clear();
                InputBox.Focus();
            }
        }


    }
}

