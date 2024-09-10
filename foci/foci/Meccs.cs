using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foci
{
    internal class Meccs
    {
        public Meccs(int fordulo, int hazaiGol, int vendegGol, int felHazai, int felVendeg, string hazaiNev, string vendegNev)
        {
            this.fordulo = fordulo;
            this.hazaiGol = hazaiGol;
            this.vendegGol = vendegGol;
            this.felHazai = felHazai;
            this.felVendeg = felVendeg;
            this.hazaiNev = hazaiNev;
            this.vendegNev = vendegNev;
        }

        public int fordulo {  get; set; }
        public int hazaiGol { get; set; }
        public int vendegGol { get; set; }
        public int felHazai {  get; set; }
        public int felVendeg { get; set; }
        public string hazaiNev { get; set; }
        public string vendegNev { get; set; }
    }
}
