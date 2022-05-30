using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog plateFile = new OpenFileDialog();
            plateFile.Title = "Open Text File";
            plateFile.Filter = "TXT files|*.txt";
            plateFile.InitialDirectory = @"C:\Users\30053863\Source\Repos\Vehicle Registration Mangement";
            if (plateFile.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(plateFile.FileName.ToString());
            }
        }


        private void Enter_Click(object sender, EventArgs e)
        {

        }
    }
}
