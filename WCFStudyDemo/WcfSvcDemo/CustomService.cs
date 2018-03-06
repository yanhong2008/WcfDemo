using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfSvcDemo
{
    public class CustomService :ICustomService
    {
        public DateTime GetCurrentTime()
        {
            return DateTime.Now;
        }
    }
}