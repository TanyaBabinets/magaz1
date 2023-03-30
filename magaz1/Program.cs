using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magaz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Magazin mag = new Magazin("Cosmo", "1997", "for strong and beautiful women", "05033344455", "cosmo@gmail.com");
            Magazin mag1 = new Magazin("Vogue", "1965", "fashion and style", "06033344400", "vogue@gmail.com");
            Magazin mag2 = new Magazin("050");
            mag.Print();
            Console.WriteLine(mag.GetYear());
            Console.WriteLine(mag1.GetContecst());
            Console.WriteLine(mag1.GetName());
            Console.WriteLine(mag2.GetTel());
        }

    }

    class Magazin
    {
        public string name;
        public string yearI;
        public string about;
        public string tel;
        public string email;

        public Magazin(string n, string y, string ab, string t, string em)//main constructor
        {
            Console.WriteLine("Main constructor");
            name = n;
            yearI = y;
            about = ab;
            tel = t;
            email = em;

        }
        public Magazin() { Console.WriteLine("default const"); }
        public Magazin(string tel) : this("Cosmo", "1997", "for strong and beautiful women", "05033344455", "cosmo@gmail.com")
        {
            Console.WriteLine("this constructor");
        }

        public void SetName(string n) 
        { 
            name = n;
            Console.WriteLine(name);
        }
        
        public string GetName() { return name; }
        public void SetYear(string Y) { yearI = Y; }
        public string GetYear() { return yearI; }
        public void SetContecst(string ab) { about = ab; }
        public string GetContecst() { return about; Console.WriteLine(about); }
        public void SetTel(string t) { tel = t; }
        public string GetTel() { return tel; }
        public void SetEmail(string em) { email = em; }


        public void Print()
        {
            Console.WriteLine($"Magazin { name} was issued in { yearI} and publishes { about }");
            Console.WriteLine($"Contacts are: {tel} e-mail {email}");
        }
    }

}

