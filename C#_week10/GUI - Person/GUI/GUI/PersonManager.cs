using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Dynamic;
using System.Windows.Controls;

namespace GUI
{
    /// <summary>
    /// This Person Manager class manages my people.
    /// It can add, remove and return all of the people.
    /// </summary>
    class PersonManager
    {
        Person[] people = new Person[20];
        private const string filename = "people_data.json";

        public PersonManager(int numOfPeople)
        {
            people = new Person[numOfPeople];
            //people[0] = new Person(0, "Egg", "Gus", new DateTime(2005, 04, 05), 170);
            //people[1] = new Person(1, "Betty", "White", new DateTime(1920, 01, 25), 158);
           
            
            if (System.IO.File.Exists(filename))
            {
                string data = System.IO.File.ReadAllText(filename);
                people = JsonConvert.DeserializeObject<Person[]>(data);
            }

            else
            {
               ///
            }
            
        }

        public List<Person> GetPeople()
        {
            string jsonText = System.IO.File.ReadAllText("people_data.json");
            List<Person> myList = JsonConvert.DeserializeObject<List<Person>>(jsonText);

            // reading from json file and converting into a list

            return myList;
        }

        public void Add(Person newPerson)
        {

            people[newPerson.ID] = newPerson;

            string myStr = people[newPerson.ID].ToString();

            MessageBox.Show("You have added " + myStr + " to the list.");

            StoreData();

        }

        public void Remove(Person oldPerson)
        {
            int index = 0;

            for (; index < people.Length; ++index)
            {
                if (people[index] == oldPerson)
                {
                    people[index] = null;
                    break;
                }
            }
            
            for (int i= index; i < people.Length - 1; ++i)
            {

                people[i] = people[i + 1];
                if (people[i] != null)
                {
                    int newID = i;
                    people[i] = new Person(newID, people[i].FirstName, people[i].LastName, people[i].DateOfBirth, people[i].Height);
                }

                
            }
            TextBox()

            MainWindow.counter--;
            StoreData();
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

        
        public void StoreData()
        {
            string datastr = JsonConvert.SerializeObject(people);
            ///string data = System.IO.File.ReadAllText("people_data.json");
            System.IO.File.WriteAllText(filename, datastr);
        }
        


    }
}
