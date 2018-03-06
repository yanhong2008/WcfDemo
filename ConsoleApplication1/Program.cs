using ConsoleApplication1.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfService1;

namespace ConsoleApplication1
{
    // public class CallbackHandler : IAfterCompleteCallback
    public class CallbackHandler : ServiceReference1.IService1Callback
    {
        public void Over(string name)
        {
            Console.WriteLine("({0})服务端调用客户端", name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            InstanceContext instanceContext = new InstanceContext(new CallbackHandler());
            Service1Client client = new Service1Client(instanceContext);
            client.GetData("Tom");

            Console.Read();
        }
    }
}
