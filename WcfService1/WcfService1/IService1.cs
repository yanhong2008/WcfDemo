using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService1”。
    //[ServiceContract]
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples", SessionMode = SessionMode.Required,
            CallbackContract = typeof(IAfterCompleteCallback))]
    public interface IService1
    {
        [OperationContract(IsOneWay = true)]
        void GetData(string name);

        // TODO: 在此添加您的服务操作
    }
    public interface IAfterCompleteCallback
    {
        [OperationContract(IsOneWay = true)]
        void Over(string name);
       
    }
  
}
