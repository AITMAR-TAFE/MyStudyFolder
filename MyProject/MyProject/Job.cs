using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Job
    {
        public int ID_job { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public JobStatus Status { get; set; }

        public Job()
        {

        }

        public Job(int id_job, string name, int cost, JobStatus status)
        {
            ID_job = id_job;
            Name = name;
            Cost = cost;
            Status = status;
        }

        public void AssingJob()
        {
            Status = JobStatus.ContractorAssigned;
        }

        public override string ToString()
        {
            string statusString = "Status not available???";

            // statement to handle each status value and display and actual word not variable
            switch (Status)
            {
                case JobStatus.NotCompleted:
                    statusString = "Not Completed";
                    break;
                case JobStatus.ContractorAssigned:
                    statusString = "Contractor Assigned";
                    break;
                case JobStatus.Completed:
                    statusString = "Completed";
                    break;
            }

            return $"{Name} (${Cost}) {statusString}";
        }

    public enum JobStatus
        {
            NotCompleted = 0,
            ContractorAssigned = 1,
            Completed = 2
        }

    }
}
