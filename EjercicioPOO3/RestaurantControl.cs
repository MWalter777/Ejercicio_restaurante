using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO3
{
    class RestaurantControl
    {
        private Random rnd = new Random();
        private string name;
        private string direction;
        private List<Ticket> tickets = new List<Ticket>();

        public RestaurantControl(string name, string direction)
        {
            this.name = name;
            this.direction = direction;
        }

        public List<Ticket> getTickets()
        {
            return tickets;
        }

        public void newTicket()
        {
            Console.Clear();
            int table = 0;
            int people = 0;
            double pay = 0;
            string number = null;
            int exit = 0;

            do
            {
                Console.Write("Mesa #: ");
                number = Console.ReadLine();
                Console.WriteLine("");
                try
                {
                    table = int.Parse(number);
                }
                catch (Exception e)
                {
                    number = null;
                }
            } while (String.IsNullOrWhiteSpace(number));


            do
            {
                Console.Write("Personas #: ");
                number = Console.ReadLine();
                Console.WriteLine("");
                try
                {
                    people = int.Parse(number);
                }
                catch (Exception e)
                {
                    number = null;
                }
            } while (String.IsNullOrWhiteSpace(number));


            Ticket ticket = new Ticket(tickets.Count>0?tickets.ToArray()[tickets.Count-1].getAccount()+1:1, table, ""+rnd.Next(100,300), people, 0);

            do
            {
                string nameProduct = null;
                int quantity = -1;
                double price = -1;

                do
                {
                    Console.Write("NOMBRE PRODUCTO: ");
                    nameProduct = Console.ReadLine();
                    Console.WriteLine("");
                } while (String.IsNullOrWhiteSpace(nameProduct));

                do
                {
                    Console.Write("Cantidad #: ");
                    number = Console.ReadLine();
                    Console.WriteLine("");
                    try
                    {
                        quantity = int.Parse(number);
                    }
                    catch (Exception e)
                    {
                        number = null;
                    }
                } while (String.IsNullOrWhiteSpace(number));

                do
                {
                    Console.Write("Precio #: ");
                    number = Console.ReadLine();
                    Console.WriteLine("");
                    try
                    {
                        price = double.Parse(number);
                    }
                    catch (Exception e)
                    {
                        number = null;
                    }
                } while (String.IsNullOrWhiteSpace(number));

                Product product = new Product(quantity, price, nameProduct);
                ticket.addProduct(product);

                do
                {
                    Console.Write("PRESIONE 0 PARA SALIR Y 1 PARA CONTINUAR: ");
                    number = Console.ReadLine();
                    Console.WriteLine("");
                    try
                    {
                        exit = int.Parse(number);
                    }
                    catch (Exception e)
                    {
                        number = null;
                    }
                } while (String.IsNullOrWhiteSpace(number) || exit<0 || exit>1);

            } while (exit == 1 || ticket.getProducts().Count<0);
            ticket.calculateTotal();

            do
            {
                Console.Write("Total a cancelar ${0} Digite su pago: ", ticket.getTotal());
                number = Console.ReadLine();
                Console.WriteLine("");
                try
                {
                    pay = double.Parse(number);
                }
                catch (Exception e)
                {
                    number = null;
                }
            } while (String.IsNullOrWhiteSpace(number) || pay < ticket.getTotal());
            ticket.setPay(pay);
            tickets.Add(ticket);
            showResult(ticket);
        }

        public void showResult(Ticket ticket)
        {
            Console.Clear();
            int x = 15, y = 0;
            Console.SetCursorPosition(x+2, y);
            Console.Write(direction);
            y++;
            Console.SetCursorPosition(x + 7, y);
            Console.Write(name);
            y++;
            Console.SetCursorPosition(x + 7, y);
            Console.Write("Estado de cuenta");
            y++;
            Console.SetCursorPosition(x + 7, y);
            Console.Write("Exija su factura");
            y += 2;

            Console.SetCursorPosition(x, y);
            Console.Write("Cuenta: ");
            Console.SetCursorPosition(x + 11, y);
            Console.Write(ticket.getAccount() > 9 ? "" + ticket.getAccount() : "0" + ticket.getAccount());
            Console.SetCursorPosition(x + 20, y);
            Console.Write("Mesa: ");
            Console.SetCursorPosition(x + 32, y);
            Console.Write(""+ticket.getTable());
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("Mesero: ");
            Console.SetCursorPosition(x + 10, y);
            Console.Write("" + ticket.getWaiter());
            Console.SetCursorPosition(x + 20, y);
            Console.Write("Personas: ");
            Console.SetCursorPosition(x + 32, y);
            Console.Write("" + ticket.getPeople());

            y += 2;

            foreach (Product p in ticket.getProducts())
            {
                Console.SetCursorPosition(x, y);
                Console.Write("{0} X {1}", p.getQuantity(), p.getUnitPrice());
                y++;
                Console.SetCursorPosition(x, y);
                Console.Write("{0}", p.getName());
                Console.SetCursorPosition(x + 30, y);
                Console.Write("${0}", p.getTotal());
                y++;
            }
            Console.SetCursorPosition(x + 20, y);
            Console.Write("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("SUBTOTAL: ");
            Console.SetCursorPosition(x + 30, y);
            Console.Write("${0}", ticket.getSubTotal());
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("Propina: ");
            Console.SetCursorPosition(x + 30, y);
            Console.Write(" ${0}", ticket.getTip());
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("TOTAL: ");
            Console.SetCursorPosition(x + 30, y);
            Console.Write("${0}", ticket.getTotal());
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("Cambio: ");
            Console.SetCursorPosition(x + 30, y);
            Console.Write("${0}", ticket.getPay()-ticket.getTotal());
            Console.ReadLine();

        }


    }
}
