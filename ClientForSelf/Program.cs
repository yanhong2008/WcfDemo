using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientForSelf
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();
            string result=client.GetData(55);
            Console.WriteLine(result);

            Console.Read();
        }
    }
}
