using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serilog;

namespace SerilogWeb.Services
{
    public class SimpleLogger
    {
        public void SimpleLog(string msg)
        {
            Log.Debug(msg);
        }
    }
}
