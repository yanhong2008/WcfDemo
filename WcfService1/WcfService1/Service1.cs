﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class Service1 : IService1
    {
        IAfterCompleteCallback callback = null;

        public Service1()
        {
            callback = OperationContext.Current.GetCallbackChannel<IAfterCompleteCallback>();
        }
        public void GetData(string name)
        {
            callback.Over(name);
            ;
        }
    }
}
