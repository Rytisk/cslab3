using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobMatch.Database
{
    class ProfileController : IController<Profile>
    {
        public void Delete(int id)
        {
            Profile profile = null;
            using (JobMatchEntities context = new JobMatchEntities())
            {
                profile = context.Profile.SingleOrDefault(x => x.JobSeeker_Id == id);
                if(profile != null)
                {
                    context.Profile.Remove(profile);
                    context.SaveChanges();
                }
            }
        }

        public void Insert(Profile obj)
        {
            using (JobMatchEntities context = new JobMatchEntities())
            {
                context.Profile.Add(obj);
                context.SaveChanges();
            }
        }

        public Profile Select(int id)
        {
            using (JobMatchEntities context = new JobMatchEntities())
            {
                return context.Profile.Include("EmployerRates")
                                      .Include("JobSeeker")
                                      .Include("Skill").SingleOrDefault(x => x.JobSeeker_Id == id);
            }
        }

        public void Update(Profile obj)
        {
            Profile profile = null;
            using (JobMatchEntities context = new JobMatchEntities())
            {
                profile = context.Profile.SingleOrDefault(x => x.JobSeeker_Id == obj.JobSeeker_Id);
                if(profile != null)
                {
                    profile.LastName = obj.LastName;
                    profile.ShortDescription = obj.ShortDescription;
                    profile.WorkExperience = obj.WorkExperience;
                    profile.Education = obj.Education;
                    profile.ContactData = obj.ContactData;
                    context.SaveChanges();
                }
            }
        }
    }
}
