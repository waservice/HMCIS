using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.Services.Protocols;
using WA.Standard.IF.Biz.v2.Common;
using WA.Standard.IF.Data.v2.Common.Part;

namespace WA.Standard.IF.WebService.v2.Common
{
    /// <summary>
    /// Parts의 요약 설명입니다.
    /// </summary>
    [WebService(Namespace = "http://wa.dms.webservice/", Description = "")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // ASP.NET AJAX를 사용하여 스크립트에서 이 웹 서비스를 호출하려면 다음 줄의 주석 처리를 제거합니다. 
    [System.Web.Script.Services.ScriptService]
    public class Parts : WA.Standard.IF.WebService.v2.Base.BaseWebService
    {
        [WebMethod(Description = "IF-DMS-PART-R01/Parts Get")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Xml)]
        //[SoapHeader("TransactionHeader", Direction = SoapHeaderDirection.InOut)] // TransactionHeader move from Header to Body 2015.05.30
        [SoapDocumentMethod(ParameterStyle = SoapParameterStyle.Bare)]
        public PartsGetResponse PartsGet(PartsGetRequest request)
        {
            PartsGetResponse response = new PartsGetResponse();

            try
            {
                WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "WA PartsGetRequest XML", request);

                //Request body-header object validation
                response.Errors = GetErrorDataListFromRequestTransactionHeader(request.TransactionHeader);
                if (response.Errors != null)
                {
                    response.TransactionHeader = new Data.v2.Common.Common.TransactionHeader();
                }
                response.Errors = GetErrorDataListFromRequest(request.PartsGet);
                if (response.Errors != null)
                {
                    response.TransactionHeader = request.TransactionHeader;
                }

                if (response.Errors == null)
                {
                    using (Parts_Biz biz = new Parts_Biz())
                    {
                        response = biz.PartsGet(request);
                    }

                    WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "WA PartsGetResponse XML", response);
                }
            }
            catch (Exception ex)
            {
                response.Errors = GetErrorDataListFromException(ex);
                WA.Standard.IF.Logger.Log.Log.SaveErrorLog(null, "PartsGet", request, ex.Message, ex);
            }

            return response;
        }
    }
}
