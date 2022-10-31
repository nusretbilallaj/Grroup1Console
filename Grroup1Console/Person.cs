using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grroup1Console
{
    internal class Person
    {

        public Person(string emri,string mbiemri, string adresa)
        {
            Emri = emri;
            Mbiemri = mbiemri;
            Adresa = adresa;
        }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string Adresa { get; set; }
    }
}
