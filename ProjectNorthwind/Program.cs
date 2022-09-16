// Written by Nathnael Tegegne
// 9/5/2022

using System;
namespace ProjectNorthwind
{
    static void Main()
    {
        // create some categories
        Category cat1 = new Category();
        // create some customers
        Customer cus1 = new Customer();
        // create some employees
        Employee emp1 = new Employee();
        // create some orderDetails
        OrderDetail ordd1 = new OrderDetail();
        // create some orders
        Order ord1 = new Order();
        // create some products
        Product pro1 = new Product();
        // create some shippers
        Shipper shi1 = new Shipper();
        // create some suppliers
        Supplier sup1 = new Supplier();


        // assign values for each
        cat1.CategoryId = 1234;
        cus1.CustomerId = "1234";


        // create list
        List<Customer> aListOfCustomers = new List<Customer>();

        // add the customers to the list
        aListOfCustomers.Add(cus1);

        // loop and print
        foreach (var s in aListOfCustomers)
        {
            Console.WriteLine(s.ToString());
            Console.WriteLine("\n");
        }

    }  
}