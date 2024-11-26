using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varosok
{
    internal class Nagyvaros
    {
        public string Varos { get; set; }
        public string Orszag { get; set; }
        public decimal Nepesseg { get; set; }

        public override string ToString()
        {
            return $"{Varos}, {Orszag}, {Nepesseg:F0}";
        }

        public Nagyvaros(string sor)
        {
            string[] a = sor.Split(';');
            Varos = a[0];
            Orszag = a[1];
            Nepesseg = decimal.Parse(a[2]) * 1000000;
        }
    }
}
