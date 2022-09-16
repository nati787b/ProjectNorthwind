﻿// Written by Nathnael Tegegne
// 9/5/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNorthwind
{
    public class Product
    {
        // class variables
        private int productId = -1;
        private string productName = "n/a";
        private int supplierId = -1;
        private int categoryId = -1;
        private string quantityPerUnit = "n/a";
        private double unitPrice = double.MaxValue;
        private int unitsInStock = -1;
        private int unitsOnOrder = -1;
        private int reOrderLevel = int.MaxValue;
        private bool discontinued = true;

        // gets and sets 
        public int ProductId
        {
            get { return this.productId; }
            set
            {
                if (value > -1)
                { this.productId = value; }
            }
        }
        public string ProductName
        { 
            get { return this.productName; } 
            set { this.productName = value; } 
        }
        public int SupplierId
        { 
            get { return this.supplierId; }
            set
            {
                if (value > -1)
                { this.supplierId = value; }
            }
        }
        public int CategoryId
        {
            get { return this.categoryId; }
            set
            {
                if (value > -1)
                { this.categoryId = value; }
            }
        }
        public string QuantityPerUnit
        { 
            get { return this.quantityPerUnit; } 
            set { this.quantityPerUnit = value; } 
        }
        public double UnitPrice 
        { 
            get { return this.unitPrice; }
            set
            {
                if (value > 0.0)
                { this.unitPrice = value; }
            }
        }
        public int UnitsInStock
        { 
            get { return this.unitsInStock; }
            set
            {
                if (value > -1)
                { this.unitsInStock = value; }
            }
        }
        public int UnitsOnOrder
        {
            get { return this.unitsOnOrder; }
            set
            {
                if (value > -1)
                { this.unitsOnOrder = value; }
            }
        }
        public int ReorderLevel
        { 
            get { return this.reOrderLevel; }
            set
            {
                if (value > 0)
                { this.reOrderLevel = value; }
            }
        }
        public bool Discontinued
        { 
            get { return this.discontinued; } 
            set { this.discontinued = value; } 
        }

        // methods
        public override string ToString()
        {
            string msg = "";
            msg = msg + "ProductId:" + this.ProductId + "\n";
            msg = msg + "ProductName:" + this.ProductName + "\n";
            msg = msg + "SupplierId:" + this.SupplierId + "\n";
            msg = msg + "CategoryId:" + this.CategoryId + "\n";
            msg = msg + "QuantityPerUnit:" + this.QuantityPerUnit + "\n";
            msg = msg + "UnitPrice:" + this.UnitPrice + "\n";
            msg = msg + "UnitsInStock:" + this.UnitsInStock + "\n";
            msg = msg + "UnitsOnOrder:" + this.UnitsOnOrder + "\n";
            msg = msg + "ReorderLevel:" + this.ReorderLevel + "\n";
            msg = msg + "Discontinued:" + this.Discontinued + "\n";
            return msg; 
        }
    }
}
