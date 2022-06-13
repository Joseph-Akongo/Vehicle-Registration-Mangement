using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Vehicle_Registration_Mangement
{
    public partial class Form1 : Form
    {
        //Initilize and set text box to upper case
        public Form1()
        {
            InitializeComponent();

            inputBox.CharacterCasing = CharacterCasing.Upper;
            inputBox.MaxLength = 8;
        }
        // Question Two
        //The prototype must use a List<> data structure of data type “string”.
        List<String> myList = new List<String>();
        string currentFileName = "";

        //Question Three
        //OPEN: When the OPEN button is clicked the user can select different text files from pre-saved text files.
        //The text files must be named for difference scenarios where the file names are “demo_01.txt”, “demo_02.txt”, etc.
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

        //Question Nine
        //: All the rego plates displayed in the ListBox which is sorted alphabetically using the built-in List.Sort method.
        //The List<> must be sorted after every List<> process (add, edit, exit, etc).
        private void displayPlate()
        {
            listBox1.Items.Clear();
            myList.Sort();
            foreach (var plate in myList)
            {
                listBox1.Items.Add(plate);
            }
        }

        //Question Four
        //To add a rego plate to the List<> the user will type the data value (rego plate info) into the TextBox and click the ENTER button.
        //The data will be added to the List<> and the TextBox will be cleared, and the cursor will refocus back into the TextBox.
        //If the TextBox is empty the program should raise an error message.
        //All data added to the List<> must be “real”, your demonstration and submission must use data like: 1GTF-234, 1JNQ-123, 1QLP-989, etc. 
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

        //Question Ten
        //find a specific rego plate the user will type the information into the TextBox and click the BINARY SEARCH button.
        //If the rego plate is found, then a confirmation message should be displayed.
        //If the rego plate is not found, then a message should be displayed, and the TextBox cleared, and the cursor refocused.
        //The search code must use the built-in Binary Search.
        private void BinarySearch_Click(object sender, EventArgs e)
        {
            myList.Sort();
            int index = myList.BinarySearch(inputBox.Text);
            if (index == -1)
            {
                MessageBox.Show("NOT Found");
                inputBox.Clear();
                inputBox.Focus();
            }
            else
            {
                MessageBox.Show("Found" + index.ToString());
            }
        }

        //Question Eleven
        //a second search button that implements a linear search algorithm.
        //To find a rego plate the user will type the information into the TextBox and click the LINEAR SEARCH button.
        //If the rego plate is found, then a confirmation message should be displayed.
        //If the rego plate is not found, then a message should be displayed, and the TextBox cleared, and the cursor refocused.
        private void LinearSearch_Click(object sender, EventArgs e)
        {
            myList.Sort();
            int idex = myList.IndexOf(inputBox.Text);
            if (idex == -1)
            {
                MessageBox.Show("NOT Found");
                inputBox.Clear();
                inputBox.Focus();
            }
            else
            {
                MessageBox.Show("Found" + idex.ToString());
            }
        }

        //Question Six
        //To edit a rego plate click (select) an item from the ListBox so that is appears in the TextBox.
        //Alter the information and click the EDIT button.
        //The updated information is written back to the List<> and the TextBox is cleared, and the cursor refocus in the TextBox.
        //To edit a rego plate click (select) an item from the ListBox so that is appears in the TextBox.
        //Alter the information and click the EDIT button.
        //The updated information is written back to the List<> and the TextBox is cleared, and the cursor refocus in the TextBox.
        private void Edit_Click(object sender, EventArgs e)
        {
            myList.Sort();
            if (listBox1.SelectedIndex > -1)
                listBox1.Items[listBox1.SelectedIndex] = inputBox.Text;
            else
                MessageBox.Show("Select an item in the list box");
            listBox1.Sorted = true;
        }

        //Question Five 
        //The user will select a rego plate from the ListBox and click the Delete button.
        //The rego plate will be removed from the List<> and the TextBox will be cleared, and the cursor will refocus in the TextBox. 
        private void Delete_Click(object sender, EventArgs e)
        {
            myList.Sort();
            if (listBox1.SelectedIndex > -1)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            else
                MessageBox.Show("Select an item in listbox");
            listBox1.Sorted = true;
        }

        //Allow Backspace to clear input box 
        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                inputBox.Clear();
                inputBox.Focus();
            }
        }

        //Question Twelve
        //
        private void SaveText()
        {
            string fileName = "demo_01.txt";
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
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName, false))
                {
                    foreach (var Plates in myList)
                    {
                        writer.WriteLine(Plates);
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("File NOT saved");
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            SaveText();
        }

        //Question Seven
        //Add a RESET button to clear all the rego plates from the List<>.
        //The ListBox and TextBox should also be cleared.
        private void Reset_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayPlate();
        }

        //Question Thirteen
        //Tag method and associated TAG button to mark a rego plate.
        //When a rego plate is selected from the ListBox and “tagged” an additional character value “z” will be prefixed to the rego plate.
        private void TAG_Click(object sender, EventArgs e)
        {
            string prefix = "z";
            if (listBox1.SelectedIndex > -1)
                listBox1.Items[listBox1.SelectedIndex] = prefix + listBox1.SelectedItem;
        }

        //Question Eight
        //When a rego plate is selected from the ListBox, the information is displayed in the TextBox.
        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            listBox1.SetSelected(listBox1.SelectedIndex, true);
            inputBox.Text = myList.ElementAt(listBox1.SelectedIndex);
        }

        //If a "tagged” plate is selected then the “z” is removed. The List<> will be re-sorted and displayed after each action.
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.Items.Contains("z"))
            {
                int pos = listBox1.Items.IndexOf("z");
                listBox1.Items.RemoveAt(pos);
            }
            displayPlate();
        }


        //FORM closing method
        //using the save method so all data from the List<> will be written back to a single text file called “demo_##.txt” file which is auto incremented 
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string fileName = "";
            for(int i = 1; i <=8; i++)
            {
                fileName += "demo_0" + i.ToString("00") + ".txt"; 
            }
            string file = fileName;
            using (StreamWriter writer = new StreamWriter(file, false))
            {
                foreach (var Plates in myList)
                {
                    writer.WriteLine(Plates);
                }
                MessageBox.Show("Saved!");
            }
        }
    }
}

