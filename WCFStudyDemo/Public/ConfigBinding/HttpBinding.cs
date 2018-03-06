using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Public.ConfigBinding
{
    public class HttpBinding
    {
        private static BasicHttpBinding _BasicHttpBinding;

        public static BasicHttpBinding BasicHttpBinding
        {
            get
            {
                if (_BasicHttpBinding == null)
                {
                    _BasicHttpBinding = new BasicHttpBinding();

                    // 接收的讯息大小上限，默认值为65,536字节，
                    // 目前设定1k * 512，如果资料量大于这个值，请提出讨论，ex：8000笔资料大概128k
                    _BasicHttpBinding.MaxReceivedMessageSize = 400 * 8192 * 512;

                    // 由于回传String长度过长在反串行化时会出错！
                    // 所以放大最大字符串长度
                    _BasicHttpBinding.ReaderQuotas.MaxStringContentLength = 8192 * 1022;
                    _BasicHttpBinding.ReaderQuotas.MaxArrayLength = 8192 * 1022;
                    _BasicHttpBinding.SendTimeout = new TimeSpan(0, 5, 0);

                }

                return _BasicHttpBinding;
            }
        }
    }
}
