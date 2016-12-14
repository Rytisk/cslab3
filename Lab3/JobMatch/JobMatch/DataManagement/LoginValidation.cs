using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobMatch.Database;

namespace JobMatch
{
    static class LoginValidation
    {
        public static bool Validate(Type type, string username, string password)
        {
            using (JobMatchEntities context = new JobMatchEntities())
            {
                if(type == Type.Employer)
                {
                    return context.Employer.Any(x => x.Username == username && x.Password == password);
                }
                else if(type == Type.JobSeeker)
                {
                    return context.JobSeeker.Any(x => x.Username == username && x.Password == password);
                }
            }
            return false;
        }
    }
}
