using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.Services.Protocols;
using WA.Standard.IF.Biz.v2.HMCIS;
using WA.Standard.IF.Data.v2.HMCIS.Price;

namespace WA.Standard.IF.WebService.v2.HMCIS
{
    /// <summary>
    /// Price의 요약 설명입니다.
    /// </summary>
    [WebService(Namespace = "http://wa.dms.webservice/", Description = "")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // ASP.NET AJAX를 사용하여 스크립트에서 이 웹 서비스를 호출하려면 다음 줄의 주석 처리를 제거합니다. 
    [System.Web.Script.Services.ScriptService]
    public class Price : WA.Standard.IF.WebService.v2.Base.BaseWebService
    {
        [WebMethod(Description = "IF-DMS-PRICE-CHECK01/Price Check")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Xml)]
        //[SoapHeader("TransactionHeader", Direction = SoapHeaderDirection.InOut)] // TransactionHeader move from Header to Body 2015.05.30
        [SoapDocumentMethod(ParameterStyle = SoapParameterStyle.Bare)]
        public PriceCheckResponse PriceCheck(PriceCheckRequest request)
        {
            PriceCheckResponse response = new PriceCheckResponse();

            try
            {
                WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "WA PriceCheckRequest XML", request);

                //Request body-header object validation
                response.Errors = GetErrorDataListFromRequestTransactionHeader(request.TransactionHeader);
                if (response.Errors != null)
                {
                    response.TransactionHeader = new Data.v2.Common.Common.TransactionHeader();
                }
                response.Errors = GetErrorDataListFromRequest(request.PriceCheck);
                if (response.Errors != null)
                {
                    response.TransactionHeader = request.TransactionHeader;
                }

                if (response.Errors == null)
                {
                    using (Price_Biz biz = new Price_Biz())
                    {
                        response = biz.PriceCheck(request);
                    }

                    WA.Standard.IF.Logger.Log.Log.SaveXMLLog(0, request.TransactionHeader.DealerID, "WA PriceCheckResponse XML", response);
                }
            }
            catch (Exception ex)
            {
                response.Errors = GetErrorDataListFromException(ex);
                WA.Standard.IF.Logger.Log.Log.SaveErrorLog(null, "PriceCheck", request, ex.Message, ex);
            }

            return response;
        }
    }
}