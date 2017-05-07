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
    public partial class Delete : Form
    {
        DateTime datetime;
        public Delete()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            datetime = dateTimePicker1.Value;
            string temp = Add_form.ModifiedDateMonth(datetime.ToShortDateString());
            string filename = File_Read_And_Write.path + Path.DirectorySeparatorChar + temp ;

            if(File.Exists(filename))
            {

                File.Delete(filename);
                MessageBox.Show("Successfully Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No data Found to be deleted Deleted", "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string monthyear = File_Read_And_Write.path + Path.DirectorySeparatorChar + datetime.Month + datetime.Year;

            if(!File.Exists(monthyear))
                return;

            BinaryReader reader = new BinaryReader(new FileStream(monthyear, FileMode.Open));

            string[] ara = new string[10000];
            int i = 0;
            string date, ammount;
            while(true)
            {

                try
                {
                    date = reader.ReadString();
                    ammount = reader.ReadString();

                    if (date == temp)
                        continue;

                    ara[i++] = date;
                    ara[i++] = ammount;
                }
                catch(EndOfStreamException)
                {
                    reader.Close();

                    break;
                }
            }

            File.Delete(monthyear);

            BinaryWriter writer = new BinaryWriter(new FileStream(monthyear, FileMode.Append));

            for(int j = 0; j < i;)
            {
                writer.Write(ara[j++]);
                writer.Write(ara[j++]);
            }
            writer.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
