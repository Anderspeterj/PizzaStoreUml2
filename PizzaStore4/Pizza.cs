using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore4
{
   public class Pizza
    {
       
       public int _nummer { get; set; }
       public string _navn { get; set; }
       public string _tilbehør { get; set; }
       public double _pris { get; set; }



        public Pizza(int nummer, string navn, string tilbehør, double pris)
        {
            _nummer = nummer; 
            _navn = navn;
            _tilbehør = tilbehør;
            _pris = pris; 
        }


       



        

    }
}
