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
        public List<Employer> GetEmployers()
        {
            using (FindJobDBEntities db = new FindJobDBEntities())
            {
                return db.Employer.ToList();
            }
        }
    }
}
