using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static MyProject.Job;

namespace MyProject
{
    public class Contractor
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public int Wage { get; set; }

        public AvailablityStatus Status { get; set; }

        public Contractor()
        {

        }
        
        public Contractor (int id, string firstname, string lastname, DateTime startDate, int wage, AvailablityStatus status)
        {
            ID = id;
            FirstName = firstname;
            LastName = lastname;
            StartDate = startDate;
            Wage = wage;
            Status = status;
        }

        public override string ToString()
        {
            string statusString = "Status not available???";

            // statement to handle each status value and display actual word not variable
            switch (Status)
            {
                case AvailablityStatus.NotAvailable:
                    statusString = "Not Available";
                    break;
                case AvailablityStatus.Available:
                    statusString = "Available";
                    break;
            }

            
            return $"{FirstName} {LastName} ($ {Wage} per h) {statusString}";
        }

        public enum AvailablityStatus
        {
            Available = 0,
            NotAvailable = 1
        }
    }
}
