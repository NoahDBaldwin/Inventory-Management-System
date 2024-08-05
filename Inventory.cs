using C__Task;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Task
{
    internal class Inventory
    {

        // Initialize the lists for parts and products by making new objects of type BindingList of parts/products
        public static  BindingList<Parts> partsList = new BindingList<Parts>();
        public static BindingList<Products> productsList = new BindingList<Products>();


        // Add Product
        public static void AddProduct(Products product)
        {
            productsList.Add(product);
        }
 

        // removeProduct(int) : bool            --Method
        // lookupProduct(int) : Product         --Method
        // updateProduct(int, Product) : void   --Method





        // Add Part
        public static void AddPart(Parts part)
        {
            partsList.Add(part);
        }


        // deletePart(Part) : bool              --Method
        //public static bool DeletePart(Parts part)
        //{
        //    partsList.Remove(part);
        //}



        
        // lookupPart(int) : Part               --Method
        public static void LookupPart(int partSearchId)
        {
            /*
            foreach (Parts part in partsList)
            {
                if(part.PartId == partSearchId)
                {
                    return part;
                }
                else
                {
                    MessageBox.Show("No part matches that ID");
                }
            }
            */

            /*
            foreach (DataGridViewRow row in partsDataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == partSearchId)
                {
                    ;
                }
            }
            */
            
        }
        

        /*
        // updatePart(int, Part) : void         --Method
        public static void UpdatePart(int partId, Parts part)
        {
            partsList[partId] = (   
                partId,
                modifyPartNameTextBox.Text,
                Convert.ToInt32(modifyPartInventoryTextBox.Text),
                Convert.ToDecimal(modifyPartPriceTextBox.Text),
                Convert.ToInt32(modifyPartMinTextBox.Text),
                Convert.ToInt32(modifyPartMaxTextBox.Text),
                Convert.ToInt32(modifyPartMachineIDTextBox.Text)
            );
        }
        */







        // Populate some data into the products list
        public static void ListInit()
        {
            productsList.Add(new Products
            {
                ProductId = 0,
                ProductName = "Specialized Sirrus",
                ProductInventory = 8,
                ProductPrice = 345.95M,
                ProductMin = 5,
                ProductMax = 25,
            });

            productsList.Add(new Products
            {
                ProductId = 1,
                ProductName = "Specialized Reabux",
                ProductInventory = 12,
                ProductPrice = 890.99M,
                ProductMin = 5,
                ProductMax = 25,
            });

            productsList.Add(new Products
            {
                ProductId = 2,
                ProductName = "Specialized S-Works",
                ProductInventory = 5,
                ProductPrice = 9559.00M,
                ProductMin = 5,
                ProductMax = 25,
            });
        }
    }
}
