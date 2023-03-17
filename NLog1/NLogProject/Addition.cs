using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogProject
{
    public class Addition
    {
        Nlog nlog=new Nlog();
        public void sum(int a,int b)
        {
            if (a==0 || b==0)
            {
                nlog.LogInfo("Info:sum()");
                nlog.LogWarn("Warn:a or b is 0");
                nlog.LogError("Error:either a or b is 0");
            }
            int c = a + b;
            nlog.LogInfo("Info:sum()");
            nlog.LogDebug("Debug:sum()" + c);
        }
    }
}
