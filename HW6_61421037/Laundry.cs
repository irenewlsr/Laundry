using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_61421037
{
    class Laundry
    {
        //Irene Wonlopsiri 6142103726

        protected string consname;
        protected string phonenum;
        protected string roomnum;

        public Laundry(string cname, string phone, string room)
        {
            consname = cname;
            phonenum = phone;
            roomnum = room;
        }

        public string Consname
        {
            get { return consname; }
        }
        public string Phonenum
        {
            get { return phonenum; }
        }
        public string Roomnum
        {
            get { return roomnum; }
        }

        public virtual void Useservice(int clothing, int blanket, int hanger)
        { 
            if (hanger <= clothing + blanket)
            {
                hanger = ((clothing + blanket) - hanger) * 10;
                Console.WriteLine("You have to pay " + hanger + " baht for the cloth hanger");
            }
        }
    }

    class Package : Laundry
    {
        private int points;

        public int Points
        {
            get { return points; }
        }

        public Package (string cname, string phone, string room): base (cname, phone, room)
        {
            
        }

        public void buypackage ()
        {
            int packc;
            Console.WriteLine("Package\n1.20 points\n2.50 points\n3.100 points");
            Console.WriteLine("Chose your package : ");
            packc = Convert.ToInt32(Console.ReadLine());
            if (packc == 1)
            {
                points = points + 20;

                Console.WriteLine("You have " + points + " points left");
            }
            else if (packc == 2)
            {
                points = points + 50;

                Console.WriteLine("You have " + points + " points left");
            }
            else if (packc == 3)
            {
                points = points + 100;

                Console.WriteLine("You have " + points + " points left");
            }
            else
            {
                Console.WriteLine("Enter 1/2/3 only!");
            }
        }

        public override void Useservice(int clothing, int blanket, int hanger)
        {
            base.Useservice(clothing, blanket, hanger);

            int pointused;
            int pointleft;

            pointused = clothing + (blanket * 3);
            pointleft = points - pointused;
            Console.WriteLine("You have " + pointleft + " points left");
        }
    }


    class Regular : Laundry
    {

        public Regular(string cname, string phone, string room) : base(cname, phone, room)
        {

        }

        public override void Useservice(int clothing, int blanket, int hanger)
        {
            base.Useservice(clothing, blanket, hanger);

            int pricec;
            int priceb;
            int totprice;

            pricec = clothing * 15;
            priceb = blanket * 45;
            totprice = pricec + priceb;

            Console.WriteLine("Laundry services price (Does not include hanger price) : " + totprice + " baht");
        }
    }
}
