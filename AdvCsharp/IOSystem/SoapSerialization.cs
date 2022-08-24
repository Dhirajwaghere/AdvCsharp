using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace AdvCsharp.IOSystem
{
    [Serializable]
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public double Percentage { get; set; }
    }


    class SoapSerialization
    {
       
            [Serializable]
            public class Student
            {
                public int RollNo { get; set; }
                public string Name { get; set; }
                public double Percentage { get; set; }
            }


            static void SoapSerializationWrite(Student stud)
            {
                try
                {
                    FileStream fs = new FileStream(@"D:\CSharp_Microsoft\Testfolder\SoapFile.soap", FileMode.Create, FileAccess.Write);
                   SoapFormatter sf = new SoapFormatter();
                   sf.Serialize(fs, stud);
                    Console.WriteLine("Soap data added");
                    fs.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            static void SoapSerializationRead()
            {
                try
                {
                    FileStream fs = new FileStream(@"D:\CSharp_Microsoft\Testfolder\SoapFile.soap", FileMode.Open, FileAccess.Read);
                     SoapFormatter sf = new SoapFormatter();
                     Student stud = (Student)sf.Deserialize(fs);
                     Console.WriteLine(stud.RollNo);
                     Console.WriteLine(stud.Name);
                             Console.WriteLine(stud.Percentage);
                    fs.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            static void Main(string[] args)
            {
                 Student stud = new Student { RollNo = 11, Name = "Ganesh", Percentage = 91.75 };
                SoapSerializationWrite(stud);
                SoapSerializationRead();

            }

        
    }
}
