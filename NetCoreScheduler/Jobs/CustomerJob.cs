using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreScheduler.Jobs
{
    public class CustomerJob : IScheduledJob
    {
        private IHostingEnvironment _hostingEnvironment;

        public CustomerJob(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public void Run()
        {
            var path = string.Format("{0}\\App_Data\\Customer.json", _hostingEnvironment.ContentRootPath);
            var list = Customer.GetCustomers();
            var json = JsonConvert.SerializeObject(list);
            using (TextWriter writer = new StreamWriter(path, append: true))
            {
                writer.WriteLine(json);
            }
        }
    }
}
