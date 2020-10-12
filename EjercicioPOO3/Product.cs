using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO3
{
    class Product
    {
        public int quantity;
        public double unitPrice;
        public string name;
        public double total;


        public Product(int quantity, double unitPrice, string name)
        {
            this.quantity = quantity;
            this.unitPrice = unitPrice;
            this.name = name;
            total = this.quantity * unitPrice;
        }

        public int getQuantity() { return quantity; }
        public void setQuantity(int quantity) { this.quantity = quantity; }

        public double getUnitPrice() { return unitPrice; }
        public void seUnitPrice(double unitPrice) { this.unitPrice = unitPrice; }

        public string getName() { return name; }

        public double getTotal() { return unitPrice * quantity; }


    }
}
