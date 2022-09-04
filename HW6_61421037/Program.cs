using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HW6_61421037
{
    class Program
    {
        //Irene Wonlopsiri 6142103726
        static void Main(string[] args)
        {
            int choice;
            int i;
            string cname, phone, room;
            Console.WriteLine("Menu\n1.Add custumer\n2.Buy more package\n3.Use laundry services\n4.Exit");
            Console.WriteLine("Enter your choice : ");
            choice = Convert.ToInt32(Console.ReadLine());

            ArrayList cons = new ArrayList();

            while (choice != 4)
            {
                if (choice == 1)
                {
                    int yesno;

                    Console.WriteLine("Enter consumer name : ");
                    cname = Console.ReadLine();
                    Console.WriteLine("Enter consumer phone number : ");
                    phone = Console.ReadLine();
                    Console.WriteLine("Enter consumer room number : ");
                    room = Console.ReadLine();

                    Console.WriteLine("Do you want to buy package?(1=yes/2=no) : ");
                    yesno = Convert.ToInt32(Console.ReadLine());

                    if (yesno == 1)
                    {
                        Package p = new Package(cname, phone, room);
                        cons.Add(p);

                        for (i = 0; i < cons.Count; i++)
                            ((Package)cons[i]).buypackage();
                    }

                    else if (yesno == 2)
                    {
                        Regular r = new Regular(cname, phone, room);
                        cons.Add(r);

                        Console.WriteLine("Custumer added");
                    }
                    else
                    {
                        Console.WriteLine("Enter 1/2 only!");
                    }
                }

                else if (choice == 2)
                {
                    Console.WriteLine("Enter consumer name : ");
                    cname = Console.ReadLine();
                    for (i = 0; i < cons.Count; i++)
                        if (((Package)cons[i]).Consname == cname)
                        {
                            ((Package)cons[i]).buypackage(); break;
                        }
                }

                else
                {
                    int clothing, blanket, hanger;
                    Console.WriteLine("Enter consumer name : ");
                    cname = Console.ReadLine();
                    for (i = 0; i < cons.Count; i++)
                        if (((Laundry)cons[i]).Consname == cname)
                        {
                            Console.WriteLine("Enter number of shirts/pants/skirts : ");
                            clothing = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter number of blanket : ");
                            blanket = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter number of colth hangers : ");
                            hanger = Convert.ToInt32(Console.ReadLine());

                            ((Laundry)cons[i]).Useservice(clothing, blanket, hanger);
                        }
                }

                Console.WriteLine("Menu\n1.Add custumer\n2.Buy more package\n3.Use laundry services\n4.Exit");
                Console.WriteLine("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            

        }
    }
}
