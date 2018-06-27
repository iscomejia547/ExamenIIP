using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIIP.Objects
{
    public class Client
    {
        public int id { get; set; }//4
        public string name { get; set; }//45 char=90+3
        public string surname { get; set; }//45 char=90
        public string cedula { get; set; }//16char=32
        public string cel { get; set; }//8char=16
        public string email { get; set; }//20 char=40
        public string address { get; set; }//45 char=90
        public string city { get; set; }//15 char=30
        public string state { get; set; }//15 char=30
        //client SIZE= 413
        public Client(int id, string name, string surname, string cedula, string cel, string email, string address,string city, string state){
            this.id = id;
            this.cedula = cedula;
            this.name = name;
            this.surname = surname;
            this.cel = cel;
            this.email = email;
            this.address = address;
            this.city = city;
            this.state = state;
        }
        public Client() { }
        public string[] ToArray()
        {
            string[] arr = {this.id.ToString(),this.cedula, this.name, this.surname, this.cel, this.email, this.address,
            this.city, this.state};
            return arr;
        }
        public string pair()
        {
            return "|" + this.id + ": " + this.name + " " + this.surname+"|";
        }
    }
}
