using System;
using System.Data.Common;
namespace TechJobsOOAutoGraded6
{
	public class Job
	{
        

            public int Id { get; }
            private static int nextId = 1;


        public string Name { get; set; }
            public Employer EmployerName { get; set; }
            public Location EmployerLocation { get; set; }
            public PositionType JobType { get; set; }
            public CoreCompetency JobCoreCompetency { get; set; }

            // TODO: Task 3: Add the two necessary constructors.

            
            

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Task 3: Generate Equals() and GetHashCode() methods.
        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override bool Equals(object? obj)
        {
            
            return obj is Job job &&
                   Id == job.Id;
        }


        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.


        public override string ToString()
        {
            string emptyS = "Data not available";
            
            string jName = string.IsNullOrEmpty(Name) ? emptyS : Name;
            
            // string eName = EmployerName.Value;
            // string eName = EmployerName.Equals(null) ? emptyS : EmployerName.ToString();
            
            // string eLocation = EmployerLocation.Value;
            // string eLocation = string.IsNullOrEmpty(EmployerLocation.ToString()) ? emptyS : eL;
            
            // string jType = JobType.Value;
            // string jType = string.IsNullOrEmpty(jT) ? emptyS : jT;
            
            // string jCore = JobCoreCompetency.Value;
            // string jCore = string.IsNullOrEmpty(jC) ? emptyS : jC;

            string nl = Environment.NewLine;

            return $"{nl}ID: {Id}{nl}Name: {jName}{nl}Employer: {EmployerName}{nl}Location: {EmployerLocation}{nl}Position Type: {JobType}{nl}Core Competency: {JobCoreCompetency}{nl}"; 
        }

    }
}

