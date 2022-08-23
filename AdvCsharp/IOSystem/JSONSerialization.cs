using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace AdvCsharp.IOSystem
{
    class JSONSerialization
    {
        [Serializable]
        public class Student
        {
            public int RollNo { get; set; }
            public string Name { get; set; }
            public double Percentage { get; set; }
        }
        class Jsonserialization
        {


            static void JsonSerializationWrite(Student stud)
            {
                try
                {
                    FileStream fs = new FileStream(@"D:\CSharp_Microsoft\TestFolder\JsonFile.json", FileMode.Create, FileAccess.Write);
                    JsonSerializer.Serialize<Student>(fs, stud);
                    Console.WriteLine("Json data added");
                    fs.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            static void JsonSerializationRead()
            {
                try
                {
                    FileStream fs = new FileStream(@"D:\CSharp_Microsoft\TestFolder\JsonFile.json", FileMode.Open, FileAccess.Read);
                    Student stud = JsonSerializer.Deserialize<Student>(fs);
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
               // Student stud = new Student { RollNo = 11, Name = "Ganesh", Percentage = 91.75 };
              //  JsonSerializationWrite(stud);
                JsonSerializationRead();

            }
        }
    }
}
