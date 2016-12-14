using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobMatch.Database
{
    class RequiredSkillController
    {
        public void Delete(int job_id, string skill)
        {
            RequiredSkill obj = null;
            using (JobMatchEntities context = new JobMatchEntities())
            {
                obj = context.RequiredSkill.SingleOrDefault(x => x.Job_Id == job_id && x.Skill == skill);
                if (obj != null)
                {
                    context.RequiredSkill.Remove(obj);
                    context.SaveChanges();
                }
            }
        }
        public void Insert(RequiredSkill obj)
        {
            using (JobMatchEntities context = new JobMatchEntities())
            {
                context.RequiredSkill.Add(obj);
                context.SaveChanges();
            }
        }
    }
}
