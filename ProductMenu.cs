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
        //publicly declared variables, lists and arrays that will be used in the class
        //list that will store the product name after textfile has been split
        public List<string> productName = new List<string>();
        //list that will store the product price after textfile has been split
        public List<string> productPrice = new List<string>();
        //string variables that stores file paths to textfiles
        public string addedfilePath = @"C:\Project PRG281\TextFiles\AddedProducts.txt";
        public string productDisplayFilePath = @"C:\Project PRG281\TextFiles\BCMenu.txt";
        public string updatedDisplayProductPath = @"C:\Project PRG281\TextFiles\UpdatedMenu.txt";
        public string[] textFileProducts;

        //This method is used to import the text inc
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

        //Method that exports textfile 
        public void ExportText()
        {
            //uses streamwriter to write to textfile
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
            //Was supposed to allow us to merge 2 textfiles together

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

        //This method is used to remove a product from the menu
        public void RemovingProduct(string productNames)
        {
            //code we got from https://www.c-sharpcorner.com/blogs/read-write-and-delete-the-text-file-content-using-c-sharp
            var oldLines = System.IO.File.ReadAllLines(updatedDisplayProductPath);
            var newLines = oldLines.Where(line => !line.Contains(productNames));
            System.IO.File.WriteAllLines(updatedDisplayProductPath, newLines);
            FileStream obj = new FileStream(updatedDisplayProductPath, FileMode.Append);
            obj.Close();


        }

        //this method allows us to add a product to a textfile 
        public void AddingProduct(string nameOfProduct, string priceOfProduct) 
        {
            if (((nameOfProduct != null) || (nameOfProduct != "")) && ((priceOfProduct != null) || (priceOfProduct != "")))
            {
                //try catch to see if product has been added successfully
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

        //method that updates the productname
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

        //method that updates product price
        public void UpdatingProductPrice(string originalName, string updatedPrice)
        {
            //tests to see if the original name and price can be found in text file
            if (((originalName != null) || (originalName != "")) && ((updatedPrice != null) || (updatedPrice != "")))
            {
                //finds the index of item in list
                int indexing = productName.IndexOf(originalName);
                productPrice[indexing] = updatedPrice;
            }
        }
        



        
    }
}
