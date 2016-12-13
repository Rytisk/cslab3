using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobMatch.Database
{
    class JobSeekerController : IController<JobSeeker>
    {
        public void Delete(int id)
        {
            JobSeeker jobSeeker = null;
            using (JobMatchEntities context = new JobMatchEntities())
            {
                jobSeeker = context.JobSeeker.SingleOrDefault(x => x.Id == id);
                if (jobSeeker != null)
                {
                    context.JobSeeker.Remove(jobSeeker);
                    context.SaveChanges();
                }
            }
        }

        public void Insert(JobSeeker obj)
        {
            using (JobMatchEntities context = new JobMatchEntities())
            {
                context.JobSeeker.Add(obj);
                context.SaveChanges();
            }
        }

        public JobSeeker Select(int id)
        {
            using (JobMatchEntities context = new JobMatchEntities())
            {
                return context.JobSeeker.Include("Profile").Include("JobSeekerRates").SingleOrDefault(x => x.Id == id);
            }
        }

        public void Update(JobSeeker obj)
        {
            JobSeeker jobSeeker = null;
            using (JobMatchEntities context = new JobMatchEntities())
            {
                jobSeeker = context.JobSeeker.SingleOrDefault(x => x.Id == obj.Id);
                if (jobSeeker != null)
                {
                    jobSeeker.Email = obj.Email;
                    jobSeeker.Password = obj.Password;
                    jobSeeker.Username = obj.Username;
                    context.SaveChanges();
                }
            }
        }

        public int GetIdByUsername(string username)
        {
            using (JobMatchEntities context = new JobMatchEntities())
            {
                return context.JobSeeker.SingleOrDefault(x => x.Username == username).Id;
            }
        }

        public List<JobSeeker> GetJobSeekers()
        {
            using (JobMatchEntities context = new JobMatchEntities())
            {
                return context.JobSeeker.Include("JobSeekerRates").Include("Profile").ToList();
            }
        }
    }
}
