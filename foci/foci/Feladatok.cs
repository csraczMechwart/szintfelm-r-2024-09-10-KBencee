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
            Console.WriteLine("2. feladat:");
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

        public void Feladat2()
        {
            Console.WriteLine("3. feladat:");
            Console.WriteLine("Az alábbi csapatok fordítottak a mérkőzésen:");
            foreach(var meccs in adatok)
            {
                if (meccs.felHazai < meccs.felVendeg && meccs.hazaiGol > meccs.vendegGol)
                {
                    Console.WriteLine($"\n{meccs.fordulo}. forduló, győztes:{meccs.hazaiNev}");
                }
                else if (meccs.felVendeg < meccs.felHazai && meccs.vendegGol > meccs.hazaiGol)
                {
                    Console.WriteLine($"\n{meccs.fordulo}. forduló, győztes:{meccs.vendegNev}");
                }
            }    
        }

        public void Feladat3()
        {
            Console.WriteLine("4-5. feladat:");
            Console.Write("Adj meg egy csapatnevet:");
            string nev = Console.ReadLine();
            int osszgol = 0;
            int kapottgol = 0;
            foreach(var meccs in adatok)
            {
                if (meccs.hazaiNev == nev)
                {
                    osszgol += meccs.hazaiGol;
                    kapottgol += meccs.vendegGol;
                }
                else if (meccs.vendegNev == nev)
                {
                    osszgol += meccs.vendegGol;
                    kapottgol += meccs.hazaiGol;
                }
            }

            Console.WriteLine();

            Console.WriteLine("6. feladat:");
            Console.WriteLine($"Lőtt: {osszgol} kapott: {kapottgol}");
            foreach(var meccs in adatok)
            {
                if(meccs.hazaiNev == nev && meccs.hazaiGol<meccs.vendegGol)
                {
                    Console.WriteLine($"A csapat otthon a {meccs.fordulo}. fordulóban kapott ki először a {meccs.vendegNev} csapattól");
                }
                else if(meccs.hazaiNev == nev && meccs.hazaiGol !< meccs.vendegGol) 
                    Console.WriteLine("A csapat otthon veretlen maradt");
            }
        }
    }
}
