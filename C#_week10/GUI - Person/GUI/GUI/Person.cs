using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Height { get; set; }

        public Person()
        {

        }

        public Person(int id, string firstName, string lastName, DateTime dateOfBirth, double height)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Height = height;
        }


        public int Age()
        {
            var today = DateTime.Now;
            var age = today - DateOfBirth;
            int newage = (int)(age.TotalDays / 365.25);
            return newage;
        }

        public override string ToString()
        {
            return $"[{ID}] {FirstName} {LastName} {Age()}";
        }

    }
}
