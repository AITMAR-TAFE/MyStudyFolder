using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    /// <summary>
    /// This Person Manager class manages my people.
    /// It can add, remove and return all of the people.
    /// </summary>
    class PersonManager
    {
        Person[] people = new Person[20];

        public PersonManager(int numOfPeople)
        {
            people = new Person[numOfPeople];
            people[0] = new Person(0, "Egg", "Gus", new DateTime(2005, 04, 05), 170);
            people[1] = new Person(1, "Betty", "White", new DateTime(1920, 01, 25), 158);
        }

        public List<Person> GetPeople()
        {
            return people.ToList();
        }

        public void Add(Person newPerson)
        {

        }

        public void Remove(Person oldPerson)
        {

        }

        public Person Search(int id)
        {
            return null;
        }

        public Person Search(string name)
        {
            return null;
        }

        public List<Person> Search(DateTime start, DateTime end)
        {
            List<Person> results = new List<Person>();
            //TODO: do stuff
            return results;
        }


    }
}
