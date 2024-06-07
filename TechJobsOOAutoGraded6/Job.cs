using System;
using System.Data.Common;
namespace TechJobsOOAutoGraded6
{
	public class Job
	{
        

            public int? Id { get; }
            private static int? nextId = 1;

        
            public string Name { get; set; }
            public Employer EmployerName { get; set; }
            public Location EmployerLocation { get; set; }
            public PositionType JobType { get; set; }
            public CoreCompetency JobCoreCompetency { get; set; }
        
         
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

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        public override bool Equals(object? obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        


        public override string ToString()
        {
            string emptyS = "Data not available";
            string jName = string.IsNullOrEmpty(Name) ? emptyS : Name;
            
            string nl = Environment.NewLine;

            return $"{nl}ID: {Id}{nl}Name: {jName}{nl}Employer: {EmployerName}{nl}Location: {EmployerLocation}{nl}Position Type: {JobType}{nl}Core Competency: {JobCoreCompetency}{nl}"; 
        }

    }
}

