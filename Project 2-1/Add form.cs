using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2_1
{
    public partial class Add_form : Form
    {
        DateTime dateMonthYear;
        string filename;
        public Add_form()
        {
            InitializeComponent();
        }
        public Add_form(DateTime datetime)
        {
            InitializeComponent();
            dateMonthYear = datetime;
            label2.Text = dateMonthYear.ToShortDateString();
        }

        private void Add_form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            bool b = int.TryParse(textBox2.Text, out x);

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Input both Description And Ammount", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(b == false)
            {
                MessageBox.Show("Input AMmount as Int value!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //removing '\' char and generating the name of file
            filename = ModifiedDateMonth(dateMonthYear.ToShortDateString());

            File_Read_And_Write obj = new File_Read_And_Write();
            obj.write(filename, textBox1.Text, textBox2.Text);

            string monthAndYear = dateMonthYear.Month.ToString() + dateMonthYear.Year.ToString();
            obj.writemonth(monthAndYear, filename);

            MessageBox.Show("Saved Succcessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

         public static string ModifiedDateMonth(string p)
        {
            string temp = "";

            for (int i = 0; i < p.Length; i++ )
            {
                if (p[i] != '/')
                    temp += p[i];
            }

                return temp;
        }

         private void button2_Click(object sender, EventArgs e)
         {
             this.Close();
         }
    }
}
