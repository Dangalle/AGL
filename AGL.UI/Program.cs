using AGL.Domain;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGL.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create Unity Container
                IUnityContainer container = new UnityContainer();

                // Regsiter types
                container.RegisterType<IRepository<Person>, Repository>();
                container.RegisterType<IAGLService<Person>, PersonService>();
                container.RegisterType<Person>();

                // Resolve person object
                Person person = container.Resolve<Person>();

                List<Pet> catsOfMaleOwners = person.GetCatsOwnedByMaleOwners();

                Console.WriteLine("Male");
                Console.WriteLine("======");
                                
                foreach (Pet pet in catsOfMaleOwners)
                {
                    Console.WriteLine(pet.Name);
                }

                
                List<Pet> catsOfFemaleOwners = person.GetCatsOwnedByFemaleOwners();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Female");
                Console.WriteLine("======");
                
                foreach (Pet pet in catsOfFemaleOwners)
                {
                    Console.WriteLine(pet.Name);
                }

                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("AN ERROR HAS OCCURED");
                Console.ReadLine();

            }
        }
    }
}
