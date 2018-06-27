using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIIP.Objects
{
    public class Extinguisher
    {
        public int id { get; set; }//4
        public char cat { get; set; }//2
        public string brand { get; set; }//45char=90+3
        public TYPE type { get; set; }//4
        public float cap { get; set; }//4
        public string und { get; set; }//6char=12
        public string place { get; set; }//45char=90
        public DateTime date { get; set; }//8
        public Client owner { get; set; }//4
        //Extinguisher size=221

        public enum TYPE { Agua, Químico, CO2 }
        public Extinguisher(int id, char cat, string brand, int type, float cap, string und, string place, DateTime date, Client owner)
        {
            this.id = id;
            this.cat = cat;
            this.brand = brand;
            this.type = (TYPE)type;
            this.cap = cap;
            this.und = und;
            this.place = place;
            this.date = date;
            this.owner = owner;
        }
        public Extinguisher() { }
        public String[] ToArray()
        {
            String[] arr = {this.id.ToString(), this.cat.ToString(), this.brand, this.type.ToString(), this.cap.ToString(),
            this.und, this.place, this.date.ToShortDateString(), this.owner.id+": "+this.owner.name};
            return arr;
        }
        public String VoidAdvice()
        {
            return "El extintor de ID: " + this.id + ", marca: " + this.brand;
        }
    }
}
