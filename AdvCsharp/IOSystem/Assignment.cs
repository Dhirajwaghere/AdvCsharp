using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AdvCsharp.IOSystem
{
    class Assignment
    {
        [Serializable]
        public class Product
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public int Price { get; set; }
        }

        static void BinarySerializationWrite(Product prod)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\CSharp_Microsoft\Testfolder1\BinaryFile.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, prod);
                Console.WriteLine("Binary data added");
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void BinarySerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\CSharp_Microsoft\Testfolder1\BinaryFile.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                Product prod = (Product)bf.Deserialize(fs);
                Console.WriteLine(prod.ProductId);
                Console.WriteLine(prod.ProductName);
                Console.WriteLine(prod.Price);
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            Product prod = new Product { ProductId = 555, ProductName = "DELL", Price = 55000 };
            BinarySerializationWrite(prod);
            BinarySerializationRead();
        }
    }
}
