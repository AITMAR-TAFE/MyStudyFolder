using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyProject
{
    class JobManager
    {
        List<Job> joblist = new List<Job>();
        List<Job> availableJoblist = new List<Job>();


        public JobManager()
        {
            joblist.Add(new Job(0,"Window installing",2000,Job.JobStatus.Completed," "));
            joblist.Add(new Job(1, "Main floor painting", 3100, Job.JobStatus.NotCompleted, " "));
            joblist.Add(new Job(2, "Concreting ", 11450, Job.JobStatus.ContractorAssigned, "John Green"));
        }

        public List<Job> GetJobList()
        {
            return joblist.ToList();
        }

        public List<Job> GetAvailableJobs()
        {
            availableJoblist.Clear();
            foreach (Job job in GetJobList())
            {
                if (job.Status == Job.JobStatus.NotCompleted)
                {
                    availableJoblist.Add(job);
                }
            }

            return availableJoblist.ToList();
        }

        public void AddJob(Job newjob)
        {
           joblist.Add(newjob);

            string myString = newjob.ToString();

            MessageBox.Show("You have added " + myString + " to the list.");
        }

        public void RemoveJob(Job oldjob)
        {
            joblist.Remove(oldjob);

            string myString = oldjob.ToString();

            MessageBox.Show("You have removed " + myString + " from the list.");
        }



        public void CompleteJob(Job job)
        {
            job.Status = Job.JobStatus.Completed;
            job.ContractorName = " ";
        }


        public void AssignJob(Job job, Contractor contractor)
        {
            ///Assignes selected contractor to the job and changes both job and the contractor list.  
            contractor.Status = Contractor.AvailablityStatus.NotAvailable;
            job.Status = Job.JobStatus.ContractorAssigned;
            job.ContractorName = contractor.FirstName + " " + contractor.LastName;

            MessageBox.Show("You have assigned " + job.Name + " job to " + contractor.FirstName + " " + contractor.LastName +".");

        }
    }
    
}
