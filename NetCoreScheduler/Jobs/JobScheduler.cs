using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreScheduler.Jobs
{
    public class JobScheduler
    {
        public static void ScheduleRecurringJobs()
        {
            //RecurringJob.RemoveIfExists(nameof(CustomerJob));
            RecurringJob.AddOrUpdate<CustomerJob>(nameof(CustomerJob), job => job.Run(), Cron.Daily(13, 35), TimeZoneInfo.Local);
            RecurringJob.AddOrUpdate<TimeJob>(nameof(TimeJob), job => job.Run(), Cron.Minutely, TimeZoneInfo.Local);
        }
    }
}
