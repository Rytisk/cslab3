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

        public void Insert(Employer obj)
        {
            using (JobMatchEntities context = new JobMatchEntities())
            {
                context.Employer.Add(obj);
                context.SaveChanges();
            }
        }

        public Employer Select(int id)
        {
            using (JobMatchEntities context = new JobMatchEntities())
            {
                return context.Employer.Include("Job").Include("EmployerRates").SingleOrDefault(x => x.Id == id);
            }
        }

        public void Update(Employer obj)
        {
            Employer emp = null;
            using (JobMatchEntities context = new JobMatchEntities())
            {
                emp = context.Employer.SingleOrDefault(x => x.Id == obj.Id);
                if(emp != null)
                {
                    emp.Email = obj.Email;
                    emp.Password = obj.Password;
                    emp.Username = obj.Username;
                    context.SaveChanges();
                }
            }
        }

        public int GetIdByUsername(string username)
        {
            using (JobMatchEntities context = new JobMatchEntities())
            {
                return context.Employer.SingleOrDefault(x => x.Username == username).Id;
            }
        }

        public List<Employer> GetEmployers()
        {
            using (JobMatchEntities context = new JobMatchEntities())
            {
                return context.Employer.Include("Job").Include("EmployerRates").ToList();
            }
        }
    }
}
