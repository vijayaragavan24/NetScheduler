using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreScheduler.Jobs
{
    public class TimeJob : IScheduledJob
    {
        private IHostingEnvironment _hostingEnvironment;

        public TimeJob(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public void Run()
        {
            var path = string.Format("{0}\\App_Data\\Time.json", _hostingEnvironment.ContentRootPath);

            using (TextWriter writer = new StreamWriter(path, append: true))
            {
                writer.WriteLine(DateTime.Now.ToString());
            }
        }
    }
}
