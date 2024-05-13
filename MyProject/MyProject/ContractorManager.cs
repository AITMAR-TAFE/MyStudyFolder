using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using Newtonsoft.Json;

namespace MyProject
{
    /// <summary>
    /// This is contractor managing class.
    /// It can add, remove and load all contractors on list.
    /// This also creates available contractor list and saves data to json file
    /// </summary>
    
    public class ContractorManager
    {
        List<Contractor> contractorlist = new List<Contractor>();
        public List<Contractor> availableContractorlist = new List<Contractor>();
        private string filePath;

        public ContractorManager()
        {
            ///contractorlist.Add(new Contractor(0,"John","Green",new DateTime(2023, 12, 05),40,Contractor.AvailablityStatus.Available));
            ///contractorlist.Add(new Contractor(1, "Emma", "Donald", new DateTime(2024, 01, 11), 35,Contractor.AvailablityStatus.Available));
            ///contractorlist.Add(new Contractor(2, "Dane", "Yes", new DateTime(2024, 02, 18), 45, Contractor.AvailablityStatus.NotAvailable));

            this.filePath = "contractors.json";
        }

        public List<Contractor> GetContractorList()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);

                contractorlist = JsonConvert.DeserializeObject<List<Contractor>>(json);
            }
            else
            {
                MessageBox.Show("File does not exist.");
            }

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

            SaveToJson();
        }

        public void RemoveContractor(Contractor oldcontractor)
        {
            contractorlist.Remove(oldcontractor);

            string myString = oldcontractor.ToString();

            MessageBox.Show("You have removed " + myString + " from the list.");

            SaveToJson();
        }

        public void ContractorAvailable(string contractorName) 
        {
            ///Takes the string from job list (the ones that have contractor assigned), and generates first and last name. 
            ///Then finds a contractor with same name.
            /// Finally it changes that contractor to be available again. 
            string[] nameParts = contractorName.Split(' ');

            string firstName = nameParts[0];
            string lastName = nameParts[1];
            MessageBox.Show(firstName+" "+lastName+" is going to be changed available again. ");

            foreach (Contractor contractor in contractorlist)
            {
                if (contractor.FirstName == firstName && contractor.LastName == lastName)
                {
                    contractor.Status = Contractor.AvailablityStatus.Available;
                    break; 
                }

            }

            SaveToJson();
        }

        public void SaveToJson()
        {
            string json = JsonConvert.SerializeObject(contractorlist, Formatting.Indented);

            File.WriteAllText(filePath, json);
        }

    }
}
