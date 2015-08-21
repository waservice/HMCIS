using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using WA.Standard.IF.Data.v2.Common.Common;
using WA.Standard.IF.Data.v2.Common.Customer;
using WA.Standard.IF.Data.v2.Common.CustomerVehicle;

namespace WA.Standard.IF.Proxy.v2.Common
{
    public class CustomerVehicle_Proxy : Base.BaseProxy
    {
        public CustomerVehicleGetResponse CustomerVehicleGet(CustomerVehicleGetRequest request)
        {
            CustomerVehicleGetResponse response = new CustomerVehicleGetResponse();

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
                        response = proxyservice.CustomerVehicleGet(request);
                    }
                    break;
                case "v2.1C.v8241":
                    {
                        _1C.v8241.ProxyService proxyservice = new _1C.v8241.ProxyService();
                        response = proxyservice.CustomerVehicleGet(request);
                    }
                    break;
                default: response.TransactionHeader = request.TransactionHeader; response.Errors = new List<Error>() { new Error() { Code = ResponseCode.WA_NoMatchedProxy, Message = ResponseMessage.NoMatchedProxy } };
                    break;
            }

            return response;
        }

        public CustomerVehicleChangeResponse CustomerVehiclChange(CustomerVehicleChangeRequest request)
        {
            CustomerVehicleChangeResponse response = new CustomerVehicleChangeResponse();

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
                        response = proxyservice.CustomerVehiclChange(request);
                    }
                    break;
                case "v2.1C.v8241":
                    {
                        _1C.v8241.ProxyService proxyservice = new _1C.v8241.ProxyService();
                        response = proxyservice.CustomerVehiclChange(request);
                    }
                    break;
                default: response.TransactionHeader = request.TransactionHeader; response.Errors = new List<Error>() { new Error() { Code = ResponseCode.WA_NoMatchedProxy, Message = ResponseMessage.NoMatchedProxy } };
                    break;
            }

            return response;
        }
    }
}
