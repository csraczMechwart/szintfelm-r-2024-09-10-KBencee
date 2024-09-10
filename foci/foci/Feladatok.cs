using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foci
{
    internal class Feladatok
    {
        public List<Meccs> adatok;
        public Feladatok(string filename) 
        {
            adatok = new();
            foreach (var item in File.ReadAllLines(filename, Encoding.UTF8).Skip(1))
            {
                string[] parts = item.Split(' ');
                int fordulo = Convert.ToInt32(parts[0]);
                int hazaigol = Convert.ToInt32(parts[1]);
                int vendeggol = Convert.ToInt32(parts[2]);
                int felhazai = Convert.ToInt32(parts[3]);
                int felvendeg = Convert.ToInt32(parts[4]);
                string hazainev = parts[5];
                string vendegnev = parts[6];
                Meccs uj = new(fordulo, hazaigol, vendeggol, felhazai, felvendeg, hazainev, vendegnev);
                adatok.Add(uj);
            }
        }

        public void Feladat1()
        {
            Console.Write("Adj meg egy fordulószámot: ");
            int fszam = Convert.ToInt32(Console.ReadLine());
            foreach(var meccs in adatok)
            {
                if (fszam == meccs.fordulo)
                {
                    Console.WriteLine($"\t{meccs.hazaiNev}-{meccs.vendegNev}: {meccs.hazaiGol}-{meccs.vendegGol} ({meccs.felHazai}-{meccs.felVendeg})");
                }

            }
        }
    }
}
