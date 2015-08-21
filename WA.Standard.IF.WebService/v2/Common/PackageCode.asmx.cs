using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.Services.Protocols;
using WA.Standard.IF.Data.v2.Common.PackageCode;
using WA.Standard.IF.Biz.v2.Common;

namespace WA.Standard.IF.WebService.v2.Common
{
    /// <summary>
    /// PackageCode의 요약 설명입니다.
    /// </summary>
    [WebService(Namespace = "http://wa.dms.webservice/", Description = "")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // ASP.NET AJAX를 사용하여 스크립트에서 이 웹 서비스를 호출하려면 다음 줄의 주석 처리를 제거합니다. 
    [System.Web.Script.Services.ScriptService]
    public class PackageCode : WA.Standard.IF.WebService.v2.Base.BaseWebService
    {
        [WebMethod(Description = "IF-DMS-MC-R01/PackageCode Get")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Xml)]
        //[SoapHeader("TransactionHeader", Direction = SoapHeaderDirection.InOut)] // TransactionHeader move from Header to Body 2015.05.30
        [SoapDocumentMethod(ParameterStyle = SoapParameterStyle.Bare)]
        public PackageCodeGetResponse PackageCodeGet(PackageCodeGetRequest request)
        {
            PackageCodeGetResponse response = new PackageCodeGetResponse();

            try
            {
                WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "WA PackageCodeGetRequest XML", request);

                //Request body-header object validation
                response.Errors = GetErrorDataListFromRequestTransactionHeader(request.TransactionHeader);
                if (response.Errors != null)
                {
                    response.TransactionHeader = new Data.v2.Common.Common.TransactionHeader();
                }
                response.Errors = GetErrorDataListFromRequest(request.PackageCodeGet);
                if (response.Errors != null)
                {
                    response.TransactionHeader = request.TransactionHeader;
                }

                if (response.Errors == null)
                {
                    using (PackageCode_Biz biz = new PackageCode_Biz())
                    {
                        response = biz.PackageCodeGet(request);
                    }

                    WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "WA PackageCodeGetResponse XML", response);
                }
            }
            catch (Exception ex)
            {
                response.Errors = GetErrorDataListFromException(ex);
                WA.Standard.IF.Logger.Log.Log.SaveErrorLog(null, "PackageCodeGet", request, ex.Message, ex);
            }

            return response;
        }
    }
}