using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        string currentFileName = "";
        private void Open_Click(object sender, EventArgs e)
        {
            string fileName = "demo_01.txt";
            OpenFileDialog OpenText = new OpenFileDialog();
            DialogResult sr = OpenText.ShowDialog();
            if (sr == DialogResult.OK)
            {
                fileName = OpenText.FileName;
            }
            currentFileName = fileName;
            try
            {
                myList.Clear();
                using (StreamReader reader = new StreamReader(File.OpenRead(fileName)))
                {
                    while (!reader.EndOfStream)
                    {
                        myList.Add(reader.ReadLine());
                    }
                }
                displayPlate();
            }
            catch (IOException)
            {
                MessageBox.Show("file not openned");
            }
        }

        private void displayPlate()
        {
            listBox1.Items.Clear();
            myList.Sort();
            foreach (var plate in myList)
            {
                listBox1.Items.Add(plate);
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
            myList.Sort();
            int index = myList.BinarySearch(inputBox.Text);
            if (index == -1)
            {
                MessageBox.Show("NOT Found");
            }
            else
            {
                MessageBox.Show("Found" + index.ToString());
            }
        }
        private void LinearSearch_Click(object sender, EventArgs e)
        {
            myList.Sort();
            int idex = myList.IndexOf(inputBox.Text);
            if (idex == -1)
            {
                MessageBox.Show("NOT Found");
            }
            else
            {
                MessageBox.Show("Found" + idex.ToString());
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            myList.Sort();
            if (listBox1.SelectedIndex > -1)
                listBox1.Items[listBox1.SelectedIndex] = inputBox.Text;
            else
                statusLable.Text = "Select an item in the list box";
            listBox1.Sorted = true;
        }


        private void Delete_Click(object sender, EventArgs e)
        {
            myList.Sort();
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

            int num = 0;
            num = num + 1;
            string fileName = "demo_0" + num + ".txt";
            SaveFileDialog SaveText = new SaveFileDialog();
            DialogResult sr = SaveText.ShowDialog();
            if (sr == DialogResult.OK)
            {
                fileName = SaveText.FileName;
            }
            if (sr == DialogResult.Cancel)
            {
                SaveText.FileName = fileName;
            }
            // Validate file name and increment
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName, false))
                {
                    foreach (var plate in myList)
                    {
                        writer.WriteLine(plate);
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("File NOT saved");
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

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            listBox1.SetSelected(listBox1.SelectedIndex, true);
            inputBox.Text = myList.ElementAt(listBox1.SelectedIndex);
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.Items.Contains("z"))
            {
                int pos = listBox1.Items.IndexOf("z");
                listBox1.Items.RemoveAt(pos);
            }
            displayPlate();
        }
    }
}

