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

        //This dictionary is for assigned contractors to jobs
        Dictionary<Contractor, List<Job>> assignedJobs = new Dictionary<Contractor, List<Job>>();

        public JobManager()
        {
            joblist.Add(new Job(0,"Window installing",2000,Job.JobStatus.Completed));
            joblist.Add(new Job(1, "Main floor painting", 3100, Job.JobStatus.NotCompleted));
            joblist.Add(new Job(2, "Concreting ", 11450, Job.JobStatus.ContractorAssigned));
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



        public void CompleteJob()
        {

        }

        // Method to assign a job to a contractor
        public void AssignJob(Contractor contractor, Job job)
        {
            if (!assignedJobs.ContainsKey(contractor))
            {
                assignedJobs[contractor] = new List<Job>();
                MessageBox.Show("You have assigned the contractor to the job.");
            }

            // Add the job to the list of jobs assigned to the contractor
            assignedJobs[contractor].Add(job);
        }

    }
}
