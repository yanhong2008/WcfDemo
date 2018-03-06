using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformForWcfHost
{

  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string baseUrl = "http://localhost:888";

            ServiceHost _serviceHost = new ServiceHost(typeof(Service1), new Uri(baseUrl));
            BasicHttpBinding bind = new BasicHttpBinding();
            bind.CloseTimeout = new TimeSpan(0, 2, 0);
            _serviceHost.AddServiceEndpoint(typeof(IService1), bind, typeof(Service1).Name);
            _serviceHost.Open();

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
            return string.Format("You entered: {0}", value);
        }
    }
}
