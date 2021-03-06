﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobMatch.Database
{
    class JobSeekerRatesController
    {
        public void Insert(JobSeekerRates obj)
        {
            using(JobMatchEntities context = new JobMatchEntities())
            {
                context.JobSeekerRates.Add(obj);
                context.SaveChanges();
            }
        }

        public void Delete(int jobSeeker_Id, int job_Id)
        {
            JobSeekerRates rate = null;
            using (JobMatchEntities context = new JobMatchEntities())
            {
                rate = context.JobSeekerRates.SingleOrDefault(x => x.JobSeeker_Id == jobSeeker_Id && x.Job_Id == job_Id);
                if(rate != null)
                {
                    context.JobSeekerRates.Remove(rate);
                    context.SaveChanges();
                }
            }
        }

        public bool ExistsRate(int jobSeeker_id, int job_id)
        {
            using(JobMatchEntities context = new JobMatchEntities())
            {
                return context.JobSeekerRates.Any(x => x.JobSeeker_Id == jobSeeker_id && x.Job_Id == job_id);
            }
        }
        public bool ExistsRateByJob(int job_id, int jobSeeker_Id)
        {
            using (JobMatchEntities context = new JobMatchEntities())
            {
                return context.JobSeekerRates.Any(x => x.Job_Id == job_id && x.JobSeeker_Id == jobSeeker_Id);
            }
        }

        public List<JobSeekerRates> GetRates()
        {
            using (JobMatchEntities context = new JobMatchEntities())
            {
                return context.JobSeekerRates.ToList();
            }
        }

        public void DeleteAllRates(int jobSeeker_id)
        {
            using(JobMatchEntities context = new JobMatchEntities())
            {
                if(context.JobSeekerRates.Any(x=>x.JobSeeker_Id == jobSeeker_id))
                {
                    var rates = context.JobSeekerRates.Where(x=>x.JobSeeker_Id == jobSeeker_id);
                    foreach(JobSeekerRates rate in rates)
                    {
                        context.JobSeekerRates.Remove(rate);
                    }
                    context.SaveChanges();
                }
            }
        }
    }
}
