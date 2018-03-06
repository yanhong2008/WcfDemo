using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientForIIs
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();
            string result = client.GetData(3);
            Console.WriteLine(result);

            Console.Read();
        }
    }
}
