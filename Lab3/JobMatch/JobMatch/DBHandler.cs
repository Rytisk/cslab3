using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobMatch
{
    class DBHandler
    { 
        public List<DataForSelector> GetEmployer()
        {
            using (FindJobDBEntities db = new FindJobDBEntities())
            {
                var list = (from emp in db.Employer
                            join jb in db.Job on emp.Id equals jb.Employer_Id
                            select new DataForSelector
                            {
                                CompanyName = emp.Name,
                                Position = jb.Position,
                                ShortJobDescription = jb.JobDescription,
                                Education = jb.EducationRequirements,
                                AdditionalRequirements = jb.AditionalRequirements,
                                //Oh god this is bullshit
                                //Get Required skills but this time its a list? i guess
                                

                            }).ToList();
                return list;
            }
        }
        public IEnumerable GetRequiredSkills(int? skillId)
        {
            using (FindJobDBEntities db = new FindJobDBEntities())
            {
                Console.WriteLine(db.RequiredSkill.Where(id => id.Id == skillId).First().Skill);
                var list = db.RequiredSkill.Where(id => id.Id == skillId);
                return list;
            }
        }
    }
}
