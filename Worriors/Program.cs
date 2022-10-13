using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worriors.Enum;

namespace Worriors
{
    class Program
    {

        static Random rng = new Random();
        static void Main(string[] args)
        {
            Worrior GoodGuy = new Worrior("Bob", Faction.GoodGuy);
            Worrior BadGuy = new Worrior("Joe", Faction.BadGuy);

            while (GoodGuy.IsAlive && BadGuy.IsAlive)
            {
                if (rng.Next(0,10)<5)
                {
                    GoodGuy.Attack(BadGuy);

                }else
                {
                    BadGuy.Attack(GoodGuy);
                }
            }
        }
    }
}
