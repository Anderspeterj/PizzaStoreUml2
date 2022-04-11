using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore4
{
    public class Customer
    {
        public string _navn { get; set; }
        public string _addresse { get; set; }
        public int _alder { get; set; }
        


        public Customer(string navn, string addresse, int alder)
        {
            _navn = navn;
            _addresse = addresse;
            _alder = alder;  
        }


    }
}
