using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobMatch.Database
{
    class JobController : IController<Job>
    {
        public void Delete(int id)
        {
            Job job = null;
            using (JobMatchEntities context = new JobMatchEntities())
            {
                job = context.Job.FirstOrDefault(x => x.Id == id);
                if(job != null)
                {
                    context.Job.Remove(job);
                    context.SaveChanges();
                }
            }
        }

        public void Insert(Job obj)
        {
            using(JobMatchEntities context = new JobMatchEntities())
            {
                if(context.Employer.Any(x=>x.Id == obj.Employer_Id))
                {
                    context.Job.Add(obj);
                    context.SaveChanges();
                }
            }
        }

        public Job Select(int id)
        {
            using (JobMatchEntities context = new JobMatchEntities())
            {
                return context.Job.Include("Employer").Include("JobSeeker").SingleOrDefault(x => x.Id == id);
            }
        }

        public void Update(Job obj)
        {
            Job job = null;
            using (JobMatchEntities context = new JobMatchEntities())
            {
                job = context.Job.SingleOrDefault(x => x.Id == obj.Id);
                if(job != null)
                {
                    job.AditionalRequirements = obj.AditionalRequirements;
                    job.EducationRequirements = obj.EducationRequirements;
                    job.Employer_Id = obj.Employer_Id;
                    job.JobDescription = obj.JobDescription;
                    job.Position = obj.Position;
                    context.SaveChanges();
                }
            }
        }
    }
}
