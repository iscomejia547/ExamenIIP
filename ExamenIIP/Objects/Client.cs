using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIIP.Objects
{
    public class Client
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string cedula { get; set; }
        public string cel { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }

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

        public string[] ToArray()
        {
            string[] arr = {this.id.ToString(),this.cedula, this.name, this.surname, this.cel, this.email, this.address,
            this.city, this.state};
            return arr;
        }
    }
}
