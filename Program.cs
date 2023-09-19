using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sikidom> sikidomok = new List<Sikidom>();
            sikidomok.Add(new Kor("Kör!"));
            sikidomok.Add(new Teglalap("Téglalap!"));
            sikidomok.Add(new Negyzet("Négyzet!"));
            foreach (var item in sikidomok)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
