// Written by Nathnael Tegegne
// 9/5/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNorthwind
{
    public class Shipper
    {
        // class variables
        private int shipperId = -1;
        private string companyName = "n/a";
        private string phone = "n/a";

        // gets and sets
        public int ShipperId
        {
            get { return this.shipperId; }
            set
            {
                if (value > -1)
                { this.shipperId = value; }
            }
        }
        public string CompanyName
        {
            get { return this.companyName; }
            set { this.companyName = value; }
        }
        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        // methods
        public override string ToString()
        {
            string msg = "";
            msg = msg + "ShipperId:" + this.ShipperId + "\n";
            msg = msg + "CompanyName:" + this.CompanyName + "\n";
            msg = msg + "Phone:" + this.Phone + "\n";
            return msg;
        }
    }
}
