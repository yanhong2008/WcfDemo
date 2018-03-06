using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Activation;

namespace Public.CustomService
{
    public class CustomServiceHost :ServiceHost
    {
        public CustomServiceHost(Type serviceType, params Uri[] baseAddresses)
            : base(serviceType, baseAddresses)
        { 
            //加载Web.config的配置
            log4net.Config.XmlConfigurator.Configure();
        }
        protected override void ApplyConfiguration()
        {
            base.ApplyConfiguration();
        }
    }
}
