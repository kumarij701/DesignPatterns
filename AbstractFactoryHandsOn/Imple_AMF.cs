using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryHandsOn
{
    internal class MercedesFactory: Factory

    {
        public override Headlight MakeHeadlight()
        {
            return new MercedesHeadlight();
        }
        public override Tire MakeTire()
        {
           return new MercedesTire();
        }
    }

    class AudiFactory: Factory
    {
        public override Headlight MakeHeadlight()
        {
            return new AudiHeadlight();
        }
        public override Tire MakeTire()
        {
            return new AudiTire();
        }
    }

}
