// Written by Nathnael Tegegne
// 9/5/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNorthwind
{
    public class Order
    {
        // class variables
        private int orderId = -1;
        private string customerId = "n/a";
        private int employeeId = -1;
        private string orderDate = "0/0/0";
        private string requireDate = "0/0/0";
        private string shippedDate = "0/0/0";
        private int shipVia = -1;   
        private double freight = double.MaxValue;
        private string shipName = "n/a";
        private string shipAddress = "n/a";
        private string shipCity = "n/a";
        private string shipRegion = "n/a";
        private string shipPostalCode = "n/a";
        private string shipCountry = "n/a";

        // gets and sets
        public int OrderId
        {
            get { return this.orderId; }
            set
            {
                if (value > -1)
                { this.orderId = value; }
            }
        }
        public string CustomerId
        {
            get { return this.customerId; }
            set { this.customerId = value; }
        }
        public int EmployeeId
        {
            get { return this.employeeId; }
            set
            {
                if (value > -1)
                { this.employeeId = value; }
            }
        }
        public string OrderDate
        {
            get { return this.orderDate; }
            set { this.orderDate = value; }
        }
        public string RequireDate
        {
            get { return this.requireDate; }
            set { this.requireDate = value; }
        }
        public string ShippedDate
        {
            get { return this.shippedDate; }
            set { this.shippedDate = value; }
        }
        public int ShipVia
        {
            get { return this.shipVia; }
            set
            {
                if (value > -1)
                { this.shipVia = value; }
            }
        }
        public double Freight
        {
            get { return this.freight; }
            set
            {
                if (value > 0.0)
                { this.freight = value; }
            }
        }
        public string ShipName
        {
            get { return this.shipName; }
            set { this.shipName = value; }
        }
        public string ShipAddress
        {
            get { return this.shipAddress; }
            set { this.shipAddress = value; }
        }
        public string ShipCity
        {
            get { return this.shipCity; }
            set { this.shipCity = value; }
        }
        public string ShipRegion
        {
            get { return this.shipRegion; }
            set { this.shipRegion = value; }
        }
        public string ShipPostalCode
        {
            get { return this.shipPostalCode; }
            set { this.shipPostalCode = value; }
        }
        public string ShipCountry
        {
            get { return this.shipCountry; }
            set { this.shipCountry = value; }
        }

        // constructors

        // methods
        public override string ToString()
        {
            string msg = "";
            msg = msg + "OrderId:" + this.OrderId + "\n";
            msg = msg + "CustomerId:" + this.CustomerId + "\n";
            msg = msg + "EmployeeId:" + this.EmployeeId + "\n";
            msg = msg + "OrderDate:" + this.OrderDate + "\n";
            msg = msg + "RequireDate:" + this.RequireDate + "\n";
            msg = msg + "ShippedDate:" + this.ShippedDate + "\n";
            msg = msg + "ShipVia:" + this.ShipVia + "\n";
            msg = msg + "Freight:" + this.Freight + "\n";
            msg = msg + "ShipName:" + this.ShipName + "\n";
            msg = msg + "ShipAddress:" + this.ShipAddress + "\n";
            msg = msg + "ShipCity:" + this.ShipCity + "\n";
            msg = msg + "ShipRegion:" + this.ShipRegion + "\n";
            msg = msg + "ShipPostalCode:" + this.ShipPostalCode + "\n";
            msg = msg + "ShipCountry:" + this.ShipCountry + "\n";
            return msg;
        }
    }
}
