using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.IO;

namespace AdvCsharp.IOSystem
{
    public class Institute
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int Fee { get; set; }
        public string Duration { get; set; }
    }


    class WrittenTest1
    {
        static void JsonSerializationWrite(Institute ins)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\CSharp_Microsoft\TestFolder2\JsonFile.json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize<Institute>(fs, ins);
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
                FileStream fs = new FileStream(@"D:\CSharp_Microsoft\TestFolder2\JsonFile.json", FileMode.Open, FileAccess.Read);
                Institute ins = JsonSerializer.Deserialize<Institute>(fs);
                Console.WriteLine(ins.CourseID);
                Console.WriteLine(ins.CourseName);
                Console.WriteLine(ins.Fee);
                Console.WriteLine(ins.Duration);
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void Main(string[] args)
        {
            Institute ins = new Institute { CourseID = 1001, CourseName = "CSharp-Dotnet", Fee = 154000, Duration = "One Year" };
            JsonSerializationWrite(ins);
            JsonSerializationRead();

        }

    }
}
