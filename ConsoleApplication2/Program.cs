using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using WinformForWcfHost;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string getUrl = "http://localhost:888/Service1/";
            if (string.IsNullOrEmpty(getUrl))
                throw new Exception("服务地址不能为Null或者空");

            EndpointAddress address = new EndpointAddress(getUrl);
            BasicHttpBinding bind = new BasicHttpBinding();
            bind.CloseTimeout = new TimeSpan(0, 2, 0);

            ChannelFactory<IService1> factory = new ChannelFactory<IService1>(bind, address);
       

            var client = factory.CreateChannel();
            var data = client.GetData(2);

            Console.WriteLine(data);

            Console.Read();
        }
    }


   
}
