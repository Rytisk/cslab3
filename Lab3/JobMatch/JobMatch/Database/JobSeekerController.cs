using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobMatch.Database
{
    class JobSeekerController : IController<JobSeeker>
    {
        public void Insert(JobSeeker obj)
        {
            using (JobMatchEntities context = new JobMatchEntities())
            {
                context.JobSeeker.Add(obj);
                context.SaveChanges();
            }
        }

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

        public JobSeeker Select(int id)
        {
            JobSeeker jobSeeker = null;

            using (JobMatchEntities context = new JobMatchEntities())
            {
                jobSeeker = context.JobSeeker.FirstOrDefault(x => x.Id == id);
            }

            return jobSeeker;
        }

        public void Update(JobSeeker obj)
        {
            JobSeeker jobSeeker = null;
            using (JobMatchEntities context = new JobMatchEntities())
            {
                jobSeeker = context.JobSeeker.FirstOrDefault(x => x.Id == obj.Id);
                if (jobSeeker != null)
                {
                    jobSeeker.Email = obj.Email;
                    jobSeeker.FirstName = obj.FirstName;
                    jobSeeker.Password = obj.Password;
                    jobSeeker.Username = obj.Username;
                    context.SaveChanges();
                }
            }
        }
    }
}
