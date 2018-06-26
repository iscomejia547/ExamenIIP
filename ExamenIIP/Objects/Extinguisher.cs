using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIIP.Objects
{
    public class Extinguisher
    {
        public int id { get; set; }
        public char cat { get; set; }
        public string brand { get; set; }
        public TYPE type { get; set; }
        public int cap { get; set; }
        public string und { get; set; }
        public string place { get; set; }
        public DateTime date { get; set; }
        public Client owner { get; set; }
        public enum TYPE{Agua,Químico,CO2}
        public Extinguisher(int id, char cat, string brand, int type, int cap, string und, string place, DateTime date, Client owner)
        {
            this.id = id;
            this.cat = cat;
            this.brand = brand;
            this.type = (TYPE)type;
            this.cat = cat;
            this.und = und;
            this.place = place;
            this.date = date;
            this.owner = owner;
        }
    }
}
