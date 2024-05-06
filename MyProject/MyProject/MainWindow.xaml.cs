using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        ContractorManager contractorManager = new ContractorManager();

        JobManager jobManager = new JobManager();

        public static int contractorCounter = 3;
        public static int jobCounter = 3;

        public MainWindow()
        {
            InitializeComponent();

        }



        private void Button_AddContractor_Click(object sender, RoutedEventArgs e)
        {
            DateTime dateTime = DateTime.Parse(Datepicker_StartDate.Text);
            int wage = 0;
            int.TryParse(Combo_Wage.Text, out wage);


            if (contractorCounter != 10)
            {
                Contractor newContractor = new Contractor(contractorCounter, TextBox_FirstName.Text, TextBox_LastName.Text, dateTime, wage,Contractor.AvailablityStatus.Available);
                contractorManager.AddContractor(newContractor);
                contractorCounter++;

            }

            else MessageBox.Show("Maximum amount of contractors added.");

            ListBox_Contractors.Items.Clear();
            Button_LoadContractors_Click(sender, e);

        }

        private void Button_RemoveContractor_Click(object sender, RoutedEventArgs e)
        {
            if (ListBox_Contractors.SelectedItem == null)
            {
                MessageBox.Show("Please select a contractor to remove.");
                return;
            }

            Contractor selectedContractor = (Contractor)ListBox_Contractors.SelectedItem;
            contractorManager.RemoveContractor(selectedContractor);
            contractorCounter--;

            ListBox_Contractors.Items.Clear();
            Button_LoadContractors_Click(sender, e);
        }

        private void Button_LoadContractors_Click(object sender, RoutedEventArgs e)
        {
            ListBox_Contractors.Items.Clear();
            foreach (Contractor contractor in contractorManager.GetContractorList())
            {
                ListBox_Contractors.Items.Add(contractor);
            }
        }

        private void Button_LoadAvailable_Contractors_Click(object sender, RoutedEventArgs e)
        {
            ListBox_Contractors.Items.Clear();
            foreach (Contractor contractor in contractorManager.GetAvailableContractors())
            {
                ListBox_Contractors.Items.Add(contractor);
            }
        }

        private void Button_AddJob_Click(object sender, RoutedEventArgs e)
        {
            DateTime dateTime = DateTime.Parse(Datepicker_JobDate.Text);
            string costString = TextBox_JobCost.Text;
            int cost = 0;
            int.TryParse(costString, out cost);

            if (!int.TryParse(costString, out cost))
            {
                MessageBox.Show("Cost must be a valid number.");
                return;
            }

            if (jobCounter != 10)
            {
                Job newjob = new Job(jobCounter, TextBox_JobName.Text, cost, Job.JobStatus.NotCompleted," ");
                jobManager.AddJob(newjob);
                jobCounter++;

            }

            else MessageBox.Show("Maximum amount of jobs added.");

            ListBox_Jobs.Items.Clear();
            Button_LoadJobs_Click(sender, e);
        }

        private void Button_RemoveJob_Click(object sender, RoutedEventArgs e)
        {
            if (ListBox_Jobs.SelectedItem == null)
            {
                MessageBox.Show("Please select a job to remove.");
                return;
            }

            Job selectedJob = (Job)ListBox_Jobs.SelectedItem;
            jobManager.RemoveJob(selectedJob);
            jobCounter--;

            ListBox_Jobs.Items.Clear();
            Button_LoadJobs_Click(sender, e);
        }

        private void Button_LoadJobs_Click(object sender, RoutedEventArgs e)
        {
            ListBox_Jobs.Items.Clear();
            foreach (Job job in jobManager.GetJobList())
            {
                ListBox_Jobs.Items.Add(job);
            }
        }

        private void Button_CompleteJob_Click(object sender, RoutedEventArgs e)
        {
            if (ListBox_Jobs.SelectedItem == null)
            {
                MessageBox.Show("Please select a job to complete. ");
                return;
            }

            Job selectedJob = (Job)ListBox_Jobs.SelectedItem;

            if (selectedJob.Status != Job.JobStatus.ContractorAssigned)
            {
                MessageBox.Show("Please select a job that has Contractor Assigned. ");
                return;
            }

            jobManager.CompleteJob(selectedJob);
            ListBox_Jobs.Items.Clear();
            Button_LoadJobs_Click(sender, e);
            ///Check if the selected item
        }


        private void Button_AssignJob_Click(object sender, RoutedEventArgs e)
        {
            // Check if a contractor is selected
            if (ListBox_Contractors.SelectedItem == null)
            {
                MessageBox.Show("Please select a contractor to assign to the job.");
                return;
            }

            // Get the selected contractor and job
            Contractor selectedContractor = (Contractor)ListBox_Contractors.SelectedItem;
            Job selectedJob = (Job)Combo_AvailableJobs.SelectedItem;

            // Check if the selected contractor is not available
            if (selectedContractor.Status == Contractor.AvailablityStatus.NotAvailable)
            {
                MessageBox.Show("The selected contractor is not available.");
                return;
            }

            // Assign the job to the contractor
            jobManager.AssignJob(selectedJob, selectedContractor);
            Button_LoadJobs_Click(sender,e);
            Button_LoadContractors_Click(sender, e);

        }


        private void Combo_AvailableJobs_DropDownOpened(object sender, EventArgs e)
        {
            
            Combo_AvailableJobs.Items.Clear();

            foreach (Job job in jobManager.GetAvailableJobs())
            {
                Combo_AvailableJobs.Items.Add(job);
            }
        }

        private void Button_NotCompleted_Click(object sender, RoutedEventArgs e)
        {
            ListBox_Jobs.Items.Clear();

            foreach (Job job in jobManager.GetAvailableJobs())
            {
                ListBox_Jobs.Items.Add(job);
            }
        }

        private void Button_InRangeJobs_Click(object sender, RoutedEventArgs e)
        {
            ListBox_Jobs.Items.Clear();

            if (!int.TryParse(TextBox_JobCost_Min.Text, out int minCost) || !int.TryParse(TextBox_JobCost_Max.Text, out int maxCost))
            {
                MessageBox.Show("Invalid input! Please enter valid numbers for job costs.");
                return;
            }

            if (int.Parse(TextBox_JobCost_Min.Text) < 0 || int.Parse(TextBox_JobCost_Max.Text) < 0)
            {
                MessageBox.Show("Job costs cannot be negative.");
                return;
            }

            foreach (Job job in jobManager.GetJobList())
            {
                if (job.Cost >= minCost && job.Cost <= maxCost)
                {
                    ListBox_Jobs.Items.Add(job);
                }
            }

            ///Button_LoadJobs_Click(sender, e);
        }
    }
}