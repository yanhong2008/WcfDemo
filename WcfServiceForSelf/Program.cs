using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceForSelf
{
    class Program
    {
        static void Main(string[] args)
        {
            //string baseUrl = "http://localhost:888";

            //ServiceHost _serviceHost = new ServiceHost(typeof(Service1), new Uri(baseUrl));
            //BasicHttpBinding bind = new BasicHttpBinding();
            //bind.CloseTimeout = new TimeSpan(0, 2, 0);
            //_serviceHost.AddServiceEndpoint(typeof(IService1), bind, typeof(Service1).Name);
            //_serviceHost.Open();


            using (ServiceHost serviceHost = new ServiceHost(typeof(Service1)))
            {
                // Open the ServiceHost to create listeners and start listening for messages.
                serviceHost.Open();

                // The service can now be accessed.
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press <ENTER> to terminate service.");
                Console.WriteLine();
                Console.ReadLine();

            }

            Console.Read();
        }
    }

    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);
    }

    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            Console.WriteLine("服务端获得({0})", value);
            return string.Format("You entered: {0}", value);
        }
    }
}
