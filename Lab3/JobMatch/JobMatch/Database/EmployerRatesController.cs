﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobMatch.Database
{
    class EmployerRatesController
    {
        public void Insert(EmployerRates obj)
        {
            using (JobMatchEntities context = new JobMatchEntities())
            {
                context.EmployerRates.Add(obj);
                context.SaveChanges();
            }
        }

        public void Delete(int employer_Id, int jobSeeker_Id, int job_Id)
        {
            EmployerRates rate = null;
            using (JobMatchEntities context = new JobMatchEntities())
            {
                rate = context.EmployerRates.SingleOrDefault(x => x.JobSeeker_Id == jobSeeker_Id && x.Job_Id == job_Id && x.Employer_Id == employer_Id);
                if (rate != null)
                {
                    context.EmployerRates.Remove(rate);
                    context.SaveChanges();
                }
            }
        }
    }
}
