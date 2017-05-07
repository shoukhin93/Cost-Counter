using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkDIrectory();
        }

        private void checkDIrectory()
        {
            if (!Directory.Exists(File_Read_And_Write.path))
                Directory.CreateDirectory(File_Read_And_Write.path);
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            Add obj = new Add();
            this.Hide();
            obj.ShowDialog();
            this.Show();
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            View obj = new View();
            this.Hide();
            obj.ShowDialog();
            this.Show();
        }

        private void dltbtnbtn_Click(object sender, EventArgs e)
        {
            Delete obj = new Delete();
            this.Hide();
            obj.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
