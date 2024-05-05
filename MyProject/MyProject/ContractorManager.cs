using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyProject
{
    /// <summary>
    /// This is contractor managing class.
    /// It can add, remove and load all contractors on list
    /// </summary>
    
    class ContractorManager
    {
        List<Contractor> contractorlist = new List<Contractor>();
        public List<Contractor> availableContractorlist = new List<Contractor>();

        public ContractorManager()
        {
            contractorlist.Add(new Contractor(0,"John","Green",new DateTime(2023, 12, 05),40,Contractor.AvailablityStatus.Available));
            contractorlist.Add(new Contractor(1, "Emma", "Donald", new DateTime(2024, 01, 11), 35,Contractor.AvailablityStatus.Available));
            contractorlist.Add(new Contractor(2, "Dane", "Yes", new DateTime(2024, 02, 18), 45, Contractor.AvailablityStatus.NotAvailable));
        }

        public List<Contractor> GetContractorList()
        {
            return contractorlist.ToList();
        }

        public List<Contractor> GetAvailableContractors()
        {
            availableContractorlist.Clear();
            foreach (Contractor contractor in GetContractorList())
            {
                if (contractor.Status == Contractor.AvailablityStatus.Available)
                {
                    availableContractorlist.Add(contractor);
                }
            }

            return availableContractorlist.ToList();
        }

        public void AddContractor(Contractor newcontractor)
        {
            contractorlist.Add(newcontractor);

            string myString = newcontractor.ToString();

            MessageBox.Show("You have added " + myString + " to the list.");


        }

        public void RemoveContractor(Contractor oldcontractor)
        {
            contractorlist.Remove(oldcontractor);

            string myString = oldcontractor.ToString();

            MessageBox.Show("You have removed " + myString + " from the list.");
        }



    }
}
