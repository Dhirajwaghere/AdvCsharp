using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace AdvCsharp.IOSystem
{
    class Assignment11
    {
        [Serializable]
        public class Product
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public int Price { get; set; }
        }

        static void JsonSerializationWrite(Product prod)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\CSharp_Microsoft\Testfolder1\JsonFile.json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize<Product>(fs, prod);
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
                FileStream fs = new FileStream(@"D:\CSharp_Microsoft\Testfolder1\JsonFile.json", FileMode.Open, FileAccess.Read);
                Product prod = JsonSerializer.Deserialize<Product>(fs);
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
            JsonSerializationWrite(prod);
            JsonSerializationRead();
        }
    }
}
