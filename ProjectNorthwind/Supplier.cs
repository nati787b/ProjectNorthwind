// Written by Nathnael Tegegne
// 9/5/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNorthwind
{
    public class Supplier
    {
        // class variables
        private int supplierId = -1;
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
        private string homePage = "n/a";

        // gets and sets
        public int SupplierId
        {
            get { return this.supplierId; }
            set
            {
                if (value > -1)
                { this.supplierId = value; }
            }
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
        public int ContactTitle
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
            set{ this.city = value; }
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
        public string HomePage
        {
            get { return this.homePage; }
            set { this.homePage = value; }
        }


        // methods
        public override string ToString()
        {
            string msg = "";
            msg = msg + "SupplierId:" + this.SupplierId + "\n";
            msg = msg + "CompanyName:" + this.CompanyName + "\n";
            msg = msg + "ContactTitle:" + this.ContactTitle + "\n";
            msg = msg + "Address:" + this.Address + "\n";
            msg = msg + "City:" + this.City + "\n";
            msg = msg + "Region:" + this.Region + "\n";
            msg = msg + "PostalCode:" + this.PostalCode + "\n";
            msg = msg + "Country:" + this.Country + "\n";
            msg = msg + "Phone:" + this.Phone + "\n";
            msg = msg + "Fax:" + this.Fax + "\n";
            msg = msg + "HomePage:" + this.HomePage + "\n";
            return msg;
        }
    }
}
