// Written by Nathnael Tegegne
// 9/5/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNorthwind
{
    public class Customer
    {
        // class variables
        private string customerId = "*";
        private string companyName = "n/a";
        private string contactName = "n/a";
        private string contactTitle = "n/a";
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalCode = "n/a";
        private string country = "n/a";
        private string phone = "n/a";
        private string fax = "n/a";

        // gets and sets
        public string CustomerId
        {
            get { return this.customerId; } 
            set { this.customerId = value; } 
        }
        public string CompanyName
        {
            get { return this.companyName; } 
            set { this.companyName = value; } 
        }
        public string ContactName
        {
            get { return this.contactName; } 
            set { this.contactName = value; }
        }
        public string ContactTitle
        {
            get { return this.contactTitle; } 
            set { this.contactTitle = value; } 
        }
        public string Address
        { 
            get { return this.address; } 
            set { this.address = value; } 
        }
        public string City
        { 
            get { return this.city; } 
            set { this.city = value; } 
        }
        public string Region
        { 
            get { return this.region; } 
            set { this.region = value; }
        }
        public string PostalCode
        { 
            get { return this.postalCode; } 
            set { this.postalCode = value; } 
        }
        public string Country
        { 
            get { return this.country; } 
            set { this.country = value; } 
        }
        public string Phone
        { 
            get { return this.phone; } 
            set { this.phone = value; } 
        }
        public string Fax
        { 
            get { return this.fax; } 
            set { this.fax = value; } 
        }

        // constructors
        // methods
        public override string ToString()
        {
            string msg = "";
            msg = msg + "Customer Id:" + this.CustomerId + "\n";
            msg = msg + "Company Name:" + this.CompanyName + "\n";
            msg = msg + "Contact Name:" + this.ContactName + "\n";   
            msg = msg + "Contact Title:" + this.ContactTitle + "\n";
            msg = msg + "Address:" + this.Address + "\n";
            msg = msg + "City:" + this.City + "\n";
            msg = msg + "Region:" + this.Region + "\n";
            msg = msg + "Postal Code:" + this.PostalCode + "\n";
            msg = msg + "Country:" + this.Country + "\n";
            msg = msg + "Phone:" + this.Phone + "\n";
            msg = msg + "Fax:" + this.Fax + "\n";
            return msg;
        }
    }
}

