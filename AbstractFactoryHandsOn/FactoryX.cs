using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryHandsOn
{
    internal class FactoryX
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of the factory either Mercedes or Audi");
            string type = Console.ReadLine();
            Client client = new Client();
            client.GetFact(type);

        }
        
    }
    internal class Client
    {
        public void GetFact(string type)
        {
            if (string.Equals(type, "mercedes", StringComparison.OrdinalIgnoreCase))
            {
                MercedesFactory merce =new MercedesFactory();
                Headlight h1 = merce.MakeHeadlight();
                h1.MakeHeadlight();
                Tire t1 = merce.MakeTire();
                t1.MakeTire();

            }
            else if (string.Equals(type, "audi", StringComparison.OrdinalIgnoreCase))
            {
                AudiFactory audi =new AudiFactory();
                Headlight h1 = audi.MakeHeadlight();
                h1.MakeHeadlight();
                Tire t1 = audi.MakeTire();
                t1.MakeTire();

            }

        

        }
    }
}
