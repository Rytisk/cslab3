using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobMatch;

namespace JobMatch.Database
{
    class EmployerController : IController<Employer>
    {
        public EmployerController()
        {
        }

        public int Create(Employer obj)
        {
            using(JobMatchEntities context = new JobMatchEntities())
            {
                context.Employer.Add(obj);
                context.SaveChanges();
            }
            return obj.Id;
        }

        public void Delete(string key)
        {
            throw new NotImplementedException();
        }

        public Employer Retrieve(string key)
        {
            throw new NotImplementedException();
        }

        public void Update(Employer obj)
        {
            throw new NotImplementedException();
        }
    }
}
