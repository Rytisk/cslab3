using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobMatch.Database
{
    class SkillController
    {
        public void Delete(int profile_id, string skill)
        {
            Skill obj = null;
            using (JobMatchEntities context = new JobMatchEntities())
            {
                obj = context.Skill.SingleOrDefault(x => x.Profile_Id == profile_id && x.Skill1 == skill);
                if(obj != null)
                {
                    context.Skill.Remove(obj);
                    context.SaveChanges();
                }
            }
        }
        public void Insert(Skill obj)
        {
            using (JobMatchEntities context = new JobMatchEntities())
            {
                context.Skill.Add(obj);
                context.SaveChanges();
            }
        }

        public List<Skill> GetSkills(int profile_id)
        {
            using (JobMatchEntities context = new JobMatchEntities())
            {
                return context.Skill.Where(x=>x.Profile_Id == profile_id).ToList();
            }
        }
    }
}
