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
                            join skill in db.RequiredSkill on jb.RequiredSkill_Id equals skill.Id
                            select new DataForSelector
                            {
                                CompanyName = emp.Name,
                                Position = jb.Position,
                                ShortJobDescription = jb.JobDescription,
                                Education = jb.EducationRequirements,
                                AdditionalRequirements = jb.AditionalRequirements


                            }).ToList();
                return list;
            }
        }
    }
}
