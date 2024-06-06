
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Serialization;

namespace TechJobs.Tests
{
	 [TestClass]
	 public class JobTests
	 {
        Job job1;
        Job job2;
        Job job3;
        Job job4;

         //Testing objects
        [TestInitialize]
        public void SetUpData()
        {
            job1 = new();

            job2 = new();

            job3 = new("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            job4 = new("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.AreEqual(job1.Id + 1, job2.Id);
        }
        
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", job3.Name, "Constructor should set Name.");
            Assert.AreEqual("ACME", job3.EmployerName.Value, "Constructor should set Employer name.");
            Assert.AreEqual("Desert", job3.EmployerLocation.Value, "Constructor should set Employer Location.");
            Assert.AreEqual("Quality control", job3.JobType.Value, "Constructor should set Job Type.");
            Assert.AreEqual("Persistence", job3.JobCoreCompetency.Value, "Constructor should set Core Competency.");
        
        }
       
       
        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job3.Equals(job4));
        }
        
        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            string jString = job4.ToString();    

            Assert.IsTrue(jString.StartsWith(Environment.NewLine), "ToString method should return one NewLine before job is printed.");
            Assert.IsTrue(jString.EndsWith(Environment.NewLine), "ToString method should return one NewLinde after job is printed.");
        }
    
        
        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            string jString = job3.ToString();
               
            Assert.IsTrue(jString.Contains("ID: 3"), "ID Label or Data set Incorrectly");
            Assert.IsTrue(jString.Contains("Name: Product tester"), "Name Label or Data set Incorrectly");
            Assert.IsTrue(jString.Contains("Employer: ACME"), "Employer name Label or Data set Incorrectly");
            Assert.IsTrue(jString.Contains("Location: Desert"), "Location Label or Data set Incorrectly");
            Assert.IsTrue(jString.Contains("Position Type: Quality control"), "Postion Type Label or Data set Incorrectly");
            Assert.IsTrue(jString.Contains("Core Competency: Persistence"), "Core Competency Label or Data set Incorrectly");
            
        }
        
       
        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            string jString = job1.ToString();
            
            Assert.IsTrue(jString.Contains("Name: Data not available"));   
            
        }
    }
}

