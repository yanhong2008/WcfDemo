using Public.ConfigBinding;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyProxyService
{
    public class MyServiceProxy
    {
        private static MyServiceClient _databaseService;

        private static MyServiceClient DatabaseService
        {
            get
            {
                if (_databaseService == null)
                {
                    string sApServer1 = ConfigurationManager.AppSettings["ApServer1"];

                    if (sApServer1 == null)
                    {
                        _databaseService = new MyServiceClient();
                    }
                    else
                    {
                        EndpointAddress endPointAddr = new EndpointAddress(string.Format("{0}/MyService.svc", sApServer1));
                        _databaseService = new MyServiceClient(HttpBinding.BasicHttpBinding, endPointAddr);
                    }
                }

                if (_databaseService.State == CommunicationState.Faulted)
                {
                    string sApServer2 = ConfigurationManager.AppSettings["ApServer2"];

                    if (sApServer2 == null)
                    {
                        _databaseService = new MyServiceClient();
                    }
                    else
                    {
                        EndpointAddress endPointAddr = new EndpointAddress(string.Format("{0}/MyService.svc", sApServer2));
                        _databaseService = new MyServiceClient(HttpBinding.BasicHttpBinding, endPointAddr);
                    }
                }

                return _databaseService;
            }
        }

        /// <summary>
        /// 返回当前时间
        /// </summary>
        /// <returns></returns>
        public static DateTime GetCurrentTime()
        {
            return DatabaseService.GetCurrentTime();
        }
    }
}
