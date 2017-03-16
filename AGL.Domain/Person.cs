using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGL.Domain
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public List<Pet> pets { get; set; }

        private IRepository<Person> repository;
        private static List<Person> persons;

        public Person(IRepository<Person> repository)
        {
            this.repository = repository;
        }
        
        public List<Pet> GetCatsOwnedByMaleOwners()
        {
            persons = repository.GetData();
            return DoWork(persons);
        }

        private List<Pet> DoWork(List<Person> people)
        {
            var pets = people.Where(p=>p.Gender=="Male").Where(p=>p.pets != null).SelectMany(p => p.pets);
            var cats = pets.Where(c => c.Type == "Cat").OrderBy(c=>c.Name).ToList();
            return cats;
        }

        public List<Pet> GetCatsOwnedByFemaleOwners()
        {
            return DoWork_1(persons);
        }

        private List<Pet> DoWork_1(List<Person> people)
        {
            var pets = people.Where(p => p.Gender == "Female").Where(p => p.pets != null).SelectMany(p => p.pets);
            var cats = pets.Where(c => c.Type == "Cat").OrderBy(c=>c.Name).ToList();
            return cats;
        }
    }

 }
