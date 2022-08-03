using Microsoft.Azure.Amqp.Framing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Project_PRG281
{
    public class ProductMenu
    {

        public string removeItem { get; set; }

        public List<string> productName = new List<string>();
        public List<string> productPrice = new List<string>();
        public string addedfilePath = @"C:\Project PRG281\TextFiles\AddedProducts.txt";
        public string productDisplayFilePath = @"C:\Project PRG281\TextFiles\BCMenu.txt";
        public string updatedDisplayProductPath = @"C:\Project PRG281\TextFiles\UpdatedMenu.txt";
        public string[] textFileProducts;

        public void ImportText()
        {

            
            int textFileLength;
            int splitLength;
                              
            

            textFileProducts = File.ReadAllLines(addedfilePath);
            textFileLength = textFileProducts.Length;

            string[] splitProductFile = new string[textFileProducts.Length * 2];
            splitLength = splitProductFile.Length;

            if (textFileLength != 0)
            {
                for (int i = 0; i < textFileLength; i++)
                {
                    splitProductFile = textFileProducts[i].Split(',');

                    for (int k = 0; k < splitLength; k++)
                    {
                        if (k % 2 == 0)
                        {
                            productName.Add(splitProductFile[k]);
                        }
                        else
                        {
                            productPrice.Add(splitProductFile[k]);
                        }
                    }
                }
            }  
        }

        public void ExportText()
        {
            File.WriteAllText(addedfilePath, string.Empty);
            using (StreamWriter writer = File.AppendText(addedfilePath))
            {
                for(int i =0; i < productName.Count; i++)
                {
                    string theProducts = (productName[i]  + "," + productPrice[i]);
                    writer.WriteLine(theProducts);
                }
            }
        }

        public void CombineTextFiles()
        {
            string[] originalTextFile = File.ReadAllLines(productDisplayFilePath);
            string[] addedToTextFile = File.ReadAllLines(addedfilePath);


           
                using (StreamWriter writer = File.AppendText(@"C\Project PRG281\TextFiles\UpdatedMenu.txt"))
                {
                    int lineNum = 0;
                    while (lineNum < originalTextFile.Length || lineNum < addedToTextFile.Length)
                    {
                        if (lineNum < originalTextFile.Length)
                            writer.WriteLine(originalTextFile[lineNum]);
                        if (lineNum < addedToTextFile.Length)
                            writer.WriteLine(addedToTextFile[lineNum]);
                        lineNum++;
                    }
                }
            
                
            
             
            
        }


        public void RemovingProduct(string productNames)
        {
            //AddRemoveItem addRemoveItem = new AddRemoveItem();

            //List<string> productList = File.ReadAllLines(updatedDisplayProductPath).ToList();

            //if ((productNames != null) || (productNames != ""))
            //{
            //    int locating = productList.IndexOf(productNames);
            //    productName.RemoveAt(locating);
            //    productPrice.RemoveAt(locating);
            //    System.Windows.Forms.MessageBox.Show("Product has succesfully been removed", "COMPLETED");
            //}
            //else
            //{
            //    System.Windows.Forms.MessageBox.Show("Product has unsuccesfully been removed", "COMPLETED");
            //}

            //string[] menuArray = System.IO.File.ReadAllLines(updatedDisplayProductPath);
            //for (int i = 0; i < menuArray.Length; i++)
            //{
            //    if (menuArray[i] == (productNames + productPrice))
            //    {
            //        menuArray.splice(i);
            //    }
            //}

            //menuArray = menuArray.Where(e => e != productNames).ToArray();
            //Console.WriteLine(String.Join(",", menuArray));

            //List<string> removedList = menuArray.ToList<string>();

            //using (StreamWriter writer = File.AppendText(@"C:\Project PRG281\TextFiles\UpdatedMenu.txt"))
            //{
            //    for (int i = 0; i < removedList.Count; i++)
            //    {
            //        writer.WriteLine(removedList[i]);
            //    }
            //}

            //System.Windows.Forms.MessageBox.Show("Product has succesfully been removed", "COMPLETED");


            var oldLines = System.IO.File.ReadAllLines(updatedDisplayProductPath);
            var newLines = oldLines.Where(line => !line.Contains(productNames));
            System.IO.File.WriteAllLines(updatedDisplayProductPath, newLines);
            FileStream obj = new FileStream(updatedDisplayProductPath, FileMode.Append);
            obj.Close();


        }
        public void AddingProduct(string nameOfProduct, string priceOfProduct) 
        {
            if (((nameOfProduct != null) || (nameOfProduct != "")) && ((priceOfProduct != null) || (priceOfProduct != "")))
            {
                try
                {
                    productName.Add(nameOfProduct);
                    productPrice.Add(priceOfProduct);
                    System.Windows.Forms.MessageBox.Show("Product has succesfully been added","COMPLETED");

                }
                catch 
                {
                    System.Windows.Forms.MessageBox.Show("Product has failed being added. Try Again","ERROR OCCURED");

                }
            }
        }
       public void UpdatingProductName(string originalName, string updatedName)
        {
            if(((originalName !=null)|| (originalName != " ")) && ((updatedName !=null)|| (updatedName !=" ")))
            {
                try
                {
                    int indexing = productName.IndexOf(originalName);
                    productName[indexing] = updatedName;
                }
                catch(Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Item not found!","ERROR!");
                }
            }
        }
        public void UpdatingProductPrice(string originalName, string updatedPrice)
        {
            if (((originalName != null) || (originalName != "")) && ((updatedPrice != null) || (updatedPrice != "")))
            {
                int indexing = productName.IndexOf(originalName);
                productPrice[indexing] = updatedPrice;
            }
        }
        



        
    }
}
