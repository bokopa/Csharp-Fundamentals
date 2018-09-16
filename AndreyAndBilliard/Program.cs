using System;
using System.Collections.Generic;
using System.Linq;

namespace AndreyAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var menu = new SortedDictionary<string, double>();
            while (n-- > 0)
            {
                var product = Console.ReadLine().Split('-').ToList();
                if (!menu.ContainsKey(product[0]))
                {
                    menu[product[0]] = double.Parse(product[1]);
                }
                else
                {
                    menu[product[0]] = double.Parse(product[1]);
                }
            }
            var customerList = new List<Customer>();
            var order = Console.ReadLine();

            while (!order.Equals("end of clients"))
            {
                var ClientAndOrder = order.Split(new char[] { '-', ',' }).ToList();
                var name = ClientAndOrder[0];
                var product = ClientAndOrder[1];
                var quantity = int.Parse(ClientAndOrder[2]);
                Customer customer = new Customer(name);


                if (menu.ContainsKey(product))
                {
                    if (!customerList.Any(na => na.Name == name))
                    {
                        customer.ShopList[product] = quantity;
                        customer.Bill = menu[product] * customer.ShopList[product];
                        customerList.Add(customer);
                    }
                    else
                    {
                        if (customerList.Single(na => na.Name == name).ShopList.ContainsKey(product))
                        {
                            customerList.Single(na => na.Name == name).ShopList[product] += quantity;
                            customerList.Single(na => na.Name == name).Bill += menu[product] * customerList.Single(na => na.Name == name).ShopList[product];
                        }
                        else
                        {
                            customerList.Single(na => na.Name == name).ShopList[product] = quantity;
                            customerList.Single(na => na.Name == name).Bill += menu[product] * customerList.Single(na => na.Name == name).ShopList[product];
                        }
                    }
                }

                order = Console.ReadLine();
            }
            double total = 0;

            foreach (Customer customer in customerList.OrderBy(c => c.Name))
            {
                Console.WriteLine(customer.Name);
                foreach (var product in customer.ShopList)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }
                Console.WriteLine($"Bill: {customer.Bill:f2}");
                total += customer.Bill;
            }

            Console.WriteLine($"Total bill: {total:f2}");
        }
    }
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ShopList { get; set; }
        public double Bill { get; set; }

        public Customer(string name)
        {
            Name = name;
            ShopList = new Dictionary<string, int>();
        }
    }
}
