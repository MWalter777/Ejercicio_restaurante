using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO3
{
    class Program
    {
        public const int OPTIONS = 3;
        private static BookControl bookControl = null;
        private static RestaurantControl restaurantControl = new RestaurantControl("TAQUERIA MEXICANA", "TAQUERIA LACA LACA MULTIPLAZA");

        static void Main(string[] args)
        {
            int exit = 0;
            ArrayList items = new ArrayList();
            items.Add("COLEECCION DE LIBROS");
            items.Add("SELECCION DE FUTBOL");
            items.Add("TICKET DE RESTAURANTE");
            items.Add("SALIR DEL PROGRAMA");
            Menu menu = new Menu(items, 15, 7);
            do
            {
                menu.printItems();
                exit = menu.getOption();

                switch (exit)
                {
                    case OPTIONS - 3:
                        showBooks();
                        break;
                    case OPTIONS - 2:
                        soccerTeam();
                        break;
                    case OPTIONS - 1:
                        showTicketRestaurant();
                        break;
                }


            } while (exit<OPTIONS);

        }

        private static void showTicketRestaurant()
        {
            ArrayList items = new ArrayList();
            items.Add("NUEVO TICKET");
            items.Add("GENERAR JSON");
            if (restaurantControl == null)
            {
                restaurantControl = new RestaurantControl("TAQUERIA MEXICANA", "LACA LACA MULTIPLAZA");
            }
            Console.Clear();
            foreach (Ticket t in restaurantControl.getTickets())
            {
                items.Add("Cuenta: "+t.getAccount()+", mesa: "+t.getTable() +", total: "+t.getTotal());
            }
            Menu menu = new Menu(items, 15, 7);
            menu.printItems();
            int index = menu.getOption();
            if (index < 2)
            {
                switch (index)
                {
                    case 0:
                        restaurantControl.newTicket();
                        break;
                    case 1:
                        printJSON();
                        break;
                }
            }
            else
            {
                index-=2;
                if (index < restaurantControl.getTickets().Count)
                {
                    try
                    {
                        Ticket ticket = restaurantControl.getTickets().ToArray()[index];
                        restaurantControl.showResult(ticket);
                    }catch(Exception e)
                    {
                        Console.WriteLine("OCURRIO UNA EXCEPCION AL MOSTRAR EL TICKET, CONTACTE CON EL ADMINISTRADOR");
                    }
                }
            }
        }

        private static void printJSON()
        {
            if (restaurantControl.getTickets().Count > 0)
            {
                Console.Clear();
                string json = JsonConvert.SerializeObject(restaurantControl.getTickets().ToArray());
                Console.WriteLine(json);
                try
                {
                    string path = Directory.GetCurrentDirectory();
                    Console.WriteLine(path + "\\tickets.json");
                    string[] separatingStrings = { "}]}" };
                    using (StreamWriter output = new StreamWriter(path + "\\tickets.json"))
                    {
                        output.WriteLine(json);
                    }

                }catch(Exception e)
                {
                    Console.WriteLine("ERROR, NO SE PUEDE CREAR EL ARCHIVO tickets.json\nError: {0}", e.ToString());
                }
                Console.ReadLine();
            }
        }

        private static void soccerTeam()
        {
            Coach coach = new Coach(1,1,"Entrenador", "Apellido entrenador", 25);
            Player player = new Player(1, "Jugador", "Apellido jugador", 24, 5, "demarcacion");
            MassageTherapist massage = new MassageTherapist("titulo", 10, 1, "Masajista", "Apellido masajista", 28);
            Console.Clear();
            Console.WriteLine(coach.ToString());
            Console.WriteLine(player.ToString());
            Console.WriteLine(massage.ToString());
            Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR");
            Console.ReadKey();
        }

        private static void showBooks()
        {
            ArrayList items = new ArrayList();
            items.Add("NUEVO LIBRO");
            if (bookControl == null)
            {
                createBook();
            }
            Console.Clear();
            Book[] b = bookControl.getBooks();
            for (int i = 0; i < bookControl.getQuantity(); i++)
            {
                if (b[i] != null)
                {
                    items.Add(b[i].ToString());
                }
            }
            Menu menu = new Menu(items, 15, 7);
            menu.printItems();
            if (menu.getOption() == 0)
            {
                createBook();
                showBooks();
            }
        }

        private static void createBook()
        {
            if(bookControl == null)
            {
                int quantity = 10;
                string number = null;
                Console.Clear();
                do
                {
                    Console.WriteLine("CANTIDAD DE LIBROS: ");
                    number = Console.ReadLine();
                    try
                    {
                        quantity = int.Parse(number);
                    }catch(Exception e)
                    {
                        number = null;
                    }
                } while (String.IsNullOrWhiteSpace(number));
                bookControl = new BookControl(quantity);
            }

            bookControl.AddBook();

        }
    }
}
