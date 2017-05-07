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
    public partial class View : Form
    {
        DateTime date, month;
        string dateFileName, monthFileName;
        public View()
        {
            InitializeComponent();
        }

        private void View_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Description                                                                                                       Ammount");
            date = dateTimePicker1.Value;

            string temp = modifiedDate(date.ToShortDateString());

            dateFileName = File_Read_And_Write.path + Path.DirectorySeparatorChar + temp;


            if (!File.Exists(dateFileName))
            {
                MessageBox.Show("No data To display!", "NULL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            BinaryReader reader = new BinaryReader(new FileStream(dateFileName, FileMode.Open));

            while (true)
            {

                string descrition, ammount;
                try
                {
                    descrition = reader.ReadString();
                    ammount = reader.ReadString();

                    string spaces = spc(descrition, 125);
                   // MessageBox.Show("a" + spaces + "A");
                    listBox1.Items.Add(descrition + spaces + ammount);
                }
                catch (EndOfStreamException)
                {
                    reader.Close();
                    break;
                }
            }
        }

        private string modifiedDate(string a)
        {
            string temp = "";

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != '/')
                    temp += a[i];
            }

            return temp;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Description                                                                                                       Ammount");
            month = dateTimePicker2.Value;

            monthFileName = File_Read_And_Write.path + Path.DirectorySeparatorChar + month.Month + month.Year;

            if (!File.Exists(monthFileName))
            {
                MessageBox.Show("No data To display!", "NULL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            BinaryReader reader = new BinaryReader(new FileStream(monthFileName, FileMode.Open));

            while (true)
            {

                string descrition, ammount;
                try
                {
                    descrition = reader.ReadString();
                    ammount = reader.ReadString();

                    descrition = day(descrition);

                    string spaces = spc(descrition, 120);
                   // MessageBox.Show("a" + spaces + "A");

                    listBox1.Items.Add(descrition + spaces + ammount);


                }
                catch (EndOfStreamException)
                {
                    reader.Close();
                    break;
                }
            }
        }

        private string day(string descrition)
        {
            string temp = "";
            int i = 0;
            if(descrition[i] != '1')
            {
                temp += descrition[i++] ;
                temp += "-";
            }
            else
            {
                temp += descrition[i++] ;
                temp += descrition[i++];
                temp += "-";
            }

            int k = descrition.Length - 4;

            string temp1 = "-";

            for (int l = 0; l < 4; l++ )
            {
                temp1 += descrition[k++];
            }
           

            if (temp.Length + temp1.Length == descrition.Length)
            {
                temp += descrition[i++] ;
                temp += descrition[i++];
            }
            else
                temp += descrition[i++];

            temp += temp1;

                return temp;
        }

        private string spc(string descrition, int a)
        {
            string temp = "";

            for (int i = 0; i < a - descrition.Length; i++)
                temp += " ";

            return temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
