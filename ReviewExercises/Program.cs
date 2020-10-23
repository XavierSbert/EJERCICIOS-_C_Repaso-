using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ReviewExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>()
            {
            "John", "Mary", "Sue", "Greg", "Yolanda", "Jose", "Bill"
            };

            foreach (var list in list1)
                Console.WriteLine("Hello " + list);

            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();

            List<PersonModel> peopleModels = GetPeopleModels();

            foreach (PersonModel person in peopleModels)
            {
                Console.WriteLine($"Hello {person.FirstName} {person.LastName}" );
            }

            Console.ReadLine();
            
        }

        private static List<PersonModel> GetPeopleModels()
        {
            List<PersonModel> output = new List<PersonModel>();

            output.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" }); 
            output.Add(new PersonModel { FirstName = "Bill", LastName = "McCoy" }); 
            output.Add(new PersonModel { FirstName = "Mary", LastName = "Jones" }); 
            output.Add(new PersonModel { FirstName = "Sue", LastName = "Smith" }); 
       
       
       
       
       

            return output;
        }
    }
}
    