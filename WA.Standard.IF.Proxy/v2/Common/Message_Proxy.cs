﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using WA.Standard.IF.Data.v2.Common.Message;
using WA.Standard.IF.Data.v2.Common.Common;

namespace WA.Standard.IF.Proxy.v2.Common
{
    public class Message_Proxy : Base.BaseProxy
    {
        public MessageSendResponse MessageSend(MessageSendRequest request)
        {
            MessageSendResponse response = new MessageSendResponse();

            //DMS information set by dealer information
            string proxypath = string.Format("{0}.{1}.{2}",
                request.TransactionHeader.DocumentVersion,
                request.TransactionHeader.DMSCode,
                request.TransactionHeader.DMSVersion);

            switch (proxypath)
            {
                case "v2.WA.v2":
                    {
                        WA.v2.ProxyService proxyservice = new WA.v2.ProxyService();
                        //response = proxyservice.MessageSend(request);
                    }
                    break;
                case "v2.1C.v8241":
                    {
                        _1C.v8241.ProxyService proxyservice = new _1C.v8241.ProxyService();
                        //response = proxyservice.MessageSend(request);     
                    }
                    break;
                default: response.TransactionHeader = request.TransactionHeader; response.Errors = new List<Error>() { new Error() { Code = ResponseCode.WA_NoMatchedProxy, Message = ResponseMessage.NoMatchedProxy } };
                    break;
            }

            return response;
        }
    }
}
