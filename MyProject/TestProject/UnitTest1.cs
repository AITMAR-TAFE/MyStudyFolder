using MyProject;
using Newtonsoft.Json.Linq;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        private List<Job> jobs;

        [TestInitialize]
        public void Setup()
        {
            JobManager jobManager = new JobManager();
            jobs = jobManager.GetJobList();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsNotNull(jobs);
            Assert.IsTrue(jobs.Count > 0);
        }
    }
}