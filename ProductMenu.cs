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

        public List<string> productName = new List<string>();
        public List<string> productPrice = new List<string>();
        public string addedfilePath = @"C:\Project PRG281\TextFiles\AddedProducts.txt";
        public string productDisplayFilePath = @"C:\Project PRG281\TextFiles\BCMenu.txt";
        public string updatedDisplayProductPath = @"C\Project PRG281\TextFiles\UpdatedMenu.txt";
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
          if((productNames != null)|| (productNames !=""))
            {
                int locating = productName.IndexOf(productNames);
                productName.RemoveAt(locating);
                productPrice.RemoveAt(locating);
            }
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
                    System.Windows.Forms.MessageBox.Show("Product not found!","ERROR!");
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
        
        //public void RecordingShopSale(string theItems)
        //{
        //    var temporary = File.ReadAllLines(salesFilePath);
        //    List<string> tuckshopSale = new List<string>(temporary);
        //    tuckshopSale.Add(theItems);
        //    File.WriteAllLines(salesFilePath, tuckshopSale);
        //}
        //public List<string> DisplayingShopSale()
        //{
        //    var temporary = File.ReadAllLines(salesFilePath);
        //    List<string> tuckshopSale = new List<string>(temporary);
        //    return tuckshopSale;
        //}


        
    }
}
