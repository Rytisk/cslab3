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

        public void Insert(Employer obj)
        {
            using(JobMatchEntities context = new JobMatchEntities())
            {
                context.Employer.Add(obj);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            Employer employer = null;
            using (JobMatchEntities context = new JobMatchEntities())
            {
                employer = context.Employer.SingleOrDefault(x => x.Id == id);
                if (employer != null)
                {
                    context.Employer.Remove(employer);
                    context.SaveChanges();
                } 
            }
        }

        public Employer Select(int id)
        {
            Employer emp = null;
            using (JobMatchEntities context = new JobMatchEntities())
            {
                emp = context.Employer.FirstOrDefault(x => x.Id == id);
            }
            return emp;
        }

        public void Update(Employer obj)
        {
            Employer emp = null;
            using (JobMatchEntities context = new JobMatchEntities())
            {
                emp = context.Employer.FirstOrDefault(x => x.Id == obj.Id);
                if(emp != null)
                {
                    emp.Email = obj.Email;
                    emp.Name = obj.Name;
                    emp.Password = obj.Password;
                    emp.Username = obj.Username;
                    context.SaveChanges();
                }
            }
        }
    }
}
