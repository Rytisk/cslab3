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
        public async static Task<bool> Validate(Type type, string username, string password)
        {
            using (JobMatchEntities context = new JobMatchEntities())
            {
                if (type == Type.Employer)
                {
                    var res = await Task.Run(() => context.Employer.Any(x => x.Username == username && x.Password == password));
                    return res;
                }
                else if(type == Type.JobSeeker)
                {
                    var res = await Task.Run(() => context.JobSeeker.Any(x => x.Username == username && x.Password == password));
                    return res;
                }
            }
            return await Task.FromResult(false);
        }
    }
}
