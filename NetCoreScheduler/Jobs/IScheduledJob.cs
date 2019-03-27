using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreScheduler.Jobs
{
    public interface IScheduledJob
    {
        void Run();
    }
}
