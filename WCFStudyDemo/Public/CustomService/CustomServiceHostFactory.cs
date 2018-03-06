using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Activation;

namespace Public.CustomService
{
    public class CustomServiceHostFactory : ServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            CustomServiceHost customServiceHost = new CustomServiceHost(serviceType, baseAddresses);
            return customServiceHost;
        }          
    }
}
