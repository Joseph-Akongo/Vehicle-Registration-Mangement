using System;
using System.Security;
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

            inputBox.CharacterCasing = CharacterCasing.Upper;
            inputBox.MaxLength = 8;
        }
        List<String> myList = new List<String>();
        List<String> myList2 = new List<String>();  
        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(openFileDialog1.FileName);
            }
            displayPlate();
        }

        private void displayPlate()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < myList.Count; i++)
            {
                listBox1.Items.Add(myList);
            }

        }


        private void Enter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputBox.Text))
                return;
            listBox1.Items.Add(inputBox.Text);
            inputBox.Clear();
            inputBox.Focus();
            statusLable.Text = "Plate added";
            listBox1.Sorted = true;
        }

        private void BinarySearch_Click(object sender, EventArgs e)
        {
            int index = myList.BinarySearch(inputBox.Text);
            if (index == -1)
            {
                statusLable.Text = "NOT Found";
            }
            else
            {
                statusLable.Text = "Found" + index.ToString();
            }
        }
        private void LinearSearch_Click(object sender, EventArgs e)
        {
            int idex = myList.IndexOf(inputBox.Text);
            if(idex == -1)
            {
                statusLable.Text = "NOT Found";
            }
            else
            {
                statusLable.Text = "Found" + idex.ToString();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
                listBox1.Items[listBox1.SelectedIndex] = inputBox.Text;
            else
                statusLable.Text = "Select an item in the list box";
            listBox1.Sorted = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string currentItem = listBox1.SelectedItems.ToString();
                int itemIndex = listBox1.FindString(currentItem);
                inputBox.Text = myList[itemIndex].ToString();
            }
            else
            {
                statusLable.Text = "Select from list";
            }
            foreach (string item in myList)
            {
                item.Replace("z", "");
            }
        }
      


        private void Delete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            else
                statusLable.Text = "Select an item in listbox";
            listBox1.Sorted = true;
        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                inputBox.Clear();
                inputBox.Focus();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    myStream.Close();
                }
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayPlate();
        }

        private void TAG_Click(object sender, EventArgs e)
        {
            string prefix = "z";
            if (listBox1.SelectedIndex > -1)
                listBox1.Items[listBox1.SelectedIndex] = prefix + listBox1.SelectedItem;           
        }
    }
}

