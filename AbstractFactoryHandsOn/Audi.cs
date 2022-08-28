using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryHandsOn
{
    internal class AudiHeadlight: Headlight
    {

        public override void  MakeHeadlight()
        {
            Console.WriteLine("audi headlight");
        }

    }
    internal class MercedesHeadlight : Headlight
    {

        public override void MakeHeadlight()
        {
            Console.WriteLine("Mercedes headlight");
        }

    }
    internal class AudiTire : Tire
    {

        public override void MakeTire()
        {
            Console.WriteLine("audi Tire");
        }

    }
    internal class MercedesTire : Tire
    {

        public override void MakeTire()
        {
            Console.WriteLine("Mercedes Tire");
        }

    }
}
