using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PizzaStore4
{
    public class MenuCatalog
    {

        public List<Pizza> pizzaer = new List<Pizza>(); 

        public void Pizzaer()
        {
            Pizza pizza1 = new Pizza(1, "Margherita", "ost", 75);
            Pizza pizza2 = new Pizza(2, "Hawaii", "Annanas", 60);
            Pizza pizza3 = new Pizza(3, "Speciale", "oksekød", 55);
            Pizza pizza4 = new Pizza(4, "Calzone", "Champignon", 65);
            

            pizzaer.Add(pizza1);
            pizzaer.Add(pizza2);
            pizzaer.Add(pizza3);
            pizzaer.Add(pizza4);
            
            

            


        }

        private void VisPizzaDetaljer(Pizza pizza)
        {
            Console.WriteLine($"No. {pizza._nummer} - {pizza._navn} - Tilbehør - { pizza._tilbehør} - Pris - { pizza._pris} DKK");
        }

        public void FjernPizza(int nummer)
        {
            try
            {
                pizzaer.RemoveAt(nummer - 1);
                Console.WriteLine();
                Console.WriteLine($"Du har hermed slettet {nummer} fra menuen");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Vælg venligst et tal fra menuen");
            }
        }
        
                
                 

        

        public void PrintMenu()
        {
            
            foreach (Pizza pizza in pizzaer)
            {
                
                Console.WriteLine($"No. {pizza._nummer} - Navn : {pizza._navn} - Tilbehør - { pizza._tilbehør} - Pris - { pizza._pris} DKK"); 
                Console.WriteLine("_______________________________________________________________________________________________________");
            }
                                   
        }

        public void TilføjPizza()
        {
            try
            {
                int nummer;

                Console.Clear();
                Console.WriteLine("Indtast dit pizza navn");
                string navn = Console.ReadLine();
                Console.WriteLine("Indtast tilbehør til pizzaen");
                var tilbehør = Console.ReadLine();
                Console.WriteLine("Indtast pris til pizzaen");
                var pris = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Tillykke! Du har lavet din egen pizza, din pizza har fået tildelt nummeret {pizzaer.Count + 1}");
                nummer = pizzaer.Count + 1;
                Pizza NyPizza = new Pizza(nummer, navn, tilbehør, pris);
                pizzaer.Add(NyPizza);
            }
            catch (FormatException)
            {
                Console.WriteLine("Brug venligst kun tal til prisen");
                Console.ReadKey(); 
            }
            

        }
        

        

        public void OpdaterPizza(int nummer)
        {
            var pizza = pizzaer.FirstOrDefault(p => p._nummer == nummer);
            if (pizza == null)
            {
                Console.WriteLine("Pizza ikke fundet");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Du har valgt Pizza No. {pizza._nummer}");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Vælg nyt navn");
                pizza._navn = Console.ReadLine();
                Console.WriteLine("Vælg nyt tilbehør");
                pizza._tilbehør = Console.ReadLine();
                Console.WriteLine("Vælg ny pris til pizzaen");
                pizza._pris = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Tillykke! Den valgte pizza er blevet opdateret");

                   
                
                
            }
        }

        public void BrugerMenu()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Tryk 1 for at se menuen");
            Console.WriteLine("Tryk 2 for at tilføje en pizza til menuen");
            Console.WriteLine("Tryk 3 for at slette en pizza fra menuen");
            Console.WriteLine("Tryk 4 for at søge efter en pizza via navn");
            Console.WriteLine("Tryk 5 for at opdatere en pizza fra menuen");
            Console.WriteLine("Tryk x for at gå ud af programmet");
            Console.WriteLine("------------------------------------------");
        }

        public void VisMatchendePizzaer(string searchPhrase)
        {
            var matchendePizzaer = pizzaer.Where(p => p._navn.Contains(searchPhrase)).ToList(); 
            foreach(Pizza pizza in matchendePizzaer)
            {
                VisPizzaDetaljer(pizza);
            }
               
        }
    }
}
