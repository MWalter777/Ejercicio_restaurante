using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO3
{
    class Ticket
    {
        public int account;
        public int table;
        public string waiter;
        public int people;
        public double pay = 0;
        public double subTotal = 0;
        public double tip = 0;
        public double total = 0;
        public List<Product> products = new List<Product>();

        public Ticket(int account, int table, string waiter, int people, double pay)
        {
            this.account = account;
            this.table = table;
            this.waiter = waiter;
            this.people = people;
            this.pay = pay;
        }


        public void addProduct(Product product)
        {
            products.Add(product);
        }

        public List<Product> getProducts()
        {
            return products;
        }

        public void calculateTotal()
        {
            subTotal = 0;
            foreach (Product p in products)
            {
                subTotal += p.getUnitPrice() * p.getQuantity();
            }
            tip = subTotal * 0.10;
            total = tip + subTotal;
        }

        public int getAccount() { return account; }
        public int getTable() { return table; }
        public string getWaiter() { return waiter; }
        public int getPeople() { return people; }
        public double getPay() { return pay; }

        public double getSubTotal() {
            return subTotal;
        }
        public double getTip() { return tip; }
        public double getTotal() { return total; }

        internal void setPay(double pay)
        {
            this.pay = pay;
        }
    }
}
