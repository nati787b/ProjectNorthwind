// Written by Nathnael Tegegne
// 9/5/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNorthwind
{
    public class Category
    {
        // class variables 
        private int categoryId = -1;
        private string categoryName = "n/a";
        private string description = "n/a";

        // gets and sets 
        public int CategoryId
        {
            get { return this.categoryId; }
            set
            {
                //must be greater than -1
                if (value > -1)
                {
                    this.categoryId = value;
                }
                else
                {
                    this.categoryId = 0;
                }
            }
        }
        public string CategoryName
        {
            get { return this.categoryName; }
            set { this.categoryName = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // constructors

        // methods
        public override string ToString()
        {
            string msg = "";
            msg = msg + "Category Id:" + this.CategoryId + "\n";
            msg = msg + "Category Name:" + this.CategoryName + "\n";
            msg = msg + "Description:" + this.Description + "\n";   
            return msg;
        }
    }
}