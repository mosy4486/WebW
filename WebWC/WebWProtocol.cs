using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace WebWC
{
    public class WebWProtocol
    {
        public async Task SendDataAsync(NetworkStream stream, WebWProtocolStruct s)
        {
            WebDataStruct ds = s.data;
            
        }
        //fulln/n/start/end/mes
        public async Task<WebWProtocolStruct> ReadDataAsync(NetworkStream stream)
        {
            return new WebWProtocolStruct();
        }

    }
}
