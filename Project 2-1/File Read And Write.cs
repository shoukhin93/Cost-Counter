using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Project_2_1
{
    class File_Read_And_Write
    {
        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + Path.DirectorySeparatorChar
                            + "COST COUNTER";

        public void write(string fileName, String value1, string value2)
        {
            string Name = path + Path.DirectorySeparatorChar + fileName;

            BinaryWriter writer = new BinaryWriter(new FileStream(Name, FileMode.Append));
            writer.Write(value1);
            writer.Write(value2);

            writer.Close();

        }

        public void writemonth(string monthYear, string date)
        {
            string name = path + Path.DirectorySeparatorChar + date;

            BinaryReader reader = new BinaryReader(new FileStream(name, FileMode.Open));

            int sum = 0;
            while(true)
            {
                string temp;
                
                try
                {
                    temp = reader.ReadString();
                    sum += int.Parse( reader.ReadString());
                }
                catch(EndOfStreamException)
                {
                    reader.Close();
                    break;
                }
                    
            }

            name = path + Path.DirectorySeparatorChar + monthYear;

            if (!File.Exists(name))
                File.Create(name).Close();

            reader = new BinaryReader(new FileStream(name, FileMode.Open));

            string[] ara = new string[100000];

            int i = 0;

            while(true)
            {
                string tmp1;
                string tmp2;
                try
                {
                    tmp1 = reader.ReadString();
                    tmp2 = reader.ReadString();                    

                    if(tmp1 == date)
                    {
                        continue;
                    }
                    ara[i++] = tmp1;
                    ara[i++] = tmp2;
                }
                catch(EndOfStreamException)
                {
                    reader.Close();
                    break;
                }
            }

            File.Delete(name);

            BinaryWriter writer = new BinaryWriter(new FileStream(name, FileMode.Append));
           
            for(int j = 0; j < i;)
            {
                writer.Write(ara[j++]);
                writer.Write(ara[j++]);    
                
            }

            writer.Write(date);
            writer.Write(sum.ToString());

            writer.Close();


        }
    }
}
