using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore4
{
    class Store
    {
        public void Start()
        {
            Test(); 
        }

        public void Test()
        {
            


           
            MenuCatalog menucatalog = new MenuCatalog();
            menucatalog.Pizzaer();
            menucatalog.BrugerMenu();
            var userinput = Console.ReadLine();



            while (true)
            {
                switch (userinput)
                {
                    case "1":

                        Console.Clear();
                        
                        menucatalog.PrintMenu();
                        break;
                    case "2":
                       
                        menucatalog.TilføjPizza();
                        
                        break;
                    case "3":
                        try
                        {
                            Console.WriteLine();
                            menucatalog.PrintMenu();
                            Console.WriteLine();
                            Console.WriteLine("Indtast venligst et nummer på den pizza du gerne vil slette");
                            Console.WriteLine();
                            int searchNummer = Convert.ToInt32(Console.ReadLine());

                            menucatalog.FjernPizza(searchNummer);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Vælg venligst et tal fra menuen");
                        }                   
                                          

                        break;

                    case "4":

                        Console.Clear();
                        Console.WriteLine("Søg efter en pizza via. navn");
                        Console.WriteLine();
                        var searchPhrase = Console.ReadLine();
                         
                        menucatalog.VisMatchendePizzaer(searchPhrase);

                        break;

                    case "x":
                        return;
                            

                    case "5":
                        Console.Clear();
                        Console.WriteLine("Vælg et nummer fra menuen for at opdatere din pizza");
                        Console.WriteLine();
                        menucatalog.PrintMenu();
                        int nummer = Convert.ToInt32(Console.ReadLine());
                        menucatalog.OpdaterPizza(nummer);
                        break;


                    default:
                        Console.Clear(); 
                        Console.WriteLine("Vælg venligst en af mulighederne fra brugermenuen");
                        break;

                }

                Console.WriteLine("Tryk t for at komme tilbage til menuen");
                if (userinput == "t")
                {
                    Console.Clear();
                    menucatalog.BrugerMenu();
                }
                

                userinput = Console.ReadLine();
                
                
            } 
            
        }
    }
}
