using Microsoft.Azure.Amqp.Framing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Project_PRG281
{
    public class ProductMenu
    {

        public string removeItem { get; set; }

        public static void ImportText()
        {

            string filePath = @"C:\Project PRG281\TextFiles\BCMenu.txt";

            string[] textFileProducts;
            textFileProducts = File.ReadAllLines(filePath);

            //pName = new string[textFileProducts.Length];
            // pPrice = new string[textFileProducts.Length];
            List<string> product = new List<string>(File.ReadAllLines(filePath));
            List<string> productName = new List<string>();
            //productName = File.ReadAllLines(filePath);
            //List<double> productPrice = new List<double>();

            
        }

        public void RemovingItem(List<string> product, string filePath)
        {
            product.Sort();
            int productPosition = product.BinarySearch(removeItem);
            product.RemoveAt(productPosition);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var Item in product)
                {
                    writer.WriteLine(Item);
                }
            }
           // product = new List<string>(File.AppendAllLinesAsync(filePath));
        }
        public void AddingItem() 
        { 
        
        }
       public void UpdatingItem()
        {

        }
        public void PlacingOrder()
        {

        }
        public void RecordingSale()
        {

        }
        public void DisplayingSale()
        {

        }
        
    }
}
