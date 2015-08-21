using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using WA.Standard.IF.Dac.v2.HMCIS;
using WA.Standard.IF.Data.v2.Common.Common;
using WA.Standard.IF.Data.v2.HMCIS.Price;

namespace WA.Standard.IF.Biz.v2.HMCIS
{
    public class Price_Biz : WA.Standard.IF.Biz.v2.Base.BaseBiz
    {
        public PriceCheckResponse PriceCheck(PriceCheckRequest request)
        {
            PriceCheckResponse response = new PriceCheckResponse();

            if (WA.Standard.IF.Logger.Log.Log.RunningMode.Equals(WA.Standard.IF.Data.v2.Common.Common.RunningMode.Mapper))
            {
                #region For Mapper Process
                WA.Standard.IF.Proxy.v2.HMCIS.Price_Proxy proxy = new Proxy.v2.HMCIS.Price_Proxy();
                response = proxy.PriceCheck(request);
                #endregion
            }
            else if (WA.Standard.IF.Logger.Log.Log.RunningMode.Equals(WA.Standard.IF.Data.v2.Common.Common.RunningMode.XMLDMS))
            {
                response.TransactionHeader = request.TransactionHeader;
                
                #region For XML Process
                //List<Price> Prices = Util.DataHelper.GetListByElementName<Price>(System.Web.HttpContext.Current.Server.MapPath("/v2/Repository/Prices.xml"), "Price");

                Price price = new Price();
                if (request.PriceCheck.OPCodes != null && request.PriceCheck.OPCodes.Count > 0)
                {
                    price.OPCodes = new List<Data.v2.Common.OPCode.OPCode>();
                    foreach (WA.Standard.IF.Data.v2.HMCIS.Price.OPCode proxyopcode in request.PriceCheck.OPCodes)
                    {
                        WA.Standard.IF.Data.v2.Common.OPCode.OPCode opcode = new Data.v2.Common.OPCode.OPCode();
                        opcode.Code = proxyopcode.Code;
                        //opcode.CorrectionLOP = proxyopcode.CorrectionLOP;
                        //opcode.CPSIND = proxyopcode.CPSIND;
                        //opcode.DefLinePaymentMethod = proxyopcode.DefLinePaymentMethod;
                        //opcode.Description = proxyopcode.Description;
                        //opcode.DisplayOPCode = proxyopcode.DisplayOPCode;
                        //opcode.DisplayOPDescription = proxyopcode.DisplayOPDescription;
                        //opcode.DMSOPCodeNo = proxyopcode.DMSOPCodeNo;
                        opcode.Engine = proxyopcode.Engine;
                        //opcode.EstimatedHours = proxyopcode.EstimatedHours;
                        //opcode.HazardMaterialCharge = proxyopcode.HazardMaterialCharge;
                        opcode.Make = proxyopcode.Make;
                        opcode.Mileage = proxyopcode.Mileage;
                        opcode.Model = proxyopcode.Model;
                        //opcode.OPCodeType = proxyopcode.OPCodeType;
                        //opcode.Period = proxyopcode.Period;
                        //opcode.PredefinedCauseDescription = proxyopcode.PredefinedCauseDescription;
                        opcode.PriceType = new PriceType()
                        {
                            DiscountPrice = (
                               (proxyopcode.PriceType.UnitPrice != null ? Convert.ToDouble(proxyopcode.PriceType.UnitPrice) : 0)
                               * (proxyopcode.PriceType.UnitPrice != null ? Convert.ToDouble(proxyopcode.Quantity) : 0)
                               * ((proxyopcode.PriceType.UnitPrice != null ? Convert.ToDouble(proxyopcode.PriceType.DiscountRate) : 0) / 100)
                           ).ToString(),
                            DiscountRate = proxyopcode.PriceType.DiscountRate,
                            TotalPrice = (
                                (proxyopcode.PriceType.UnitPrice != null ? Convert.ToDouble(proxyopcode.PriceType.UnitPrice) : 0)
                                    * (proxyopcode.PriceType.UnitPrice != null ? Convert.ToDouble(proxyopcode.Quantity) : 0)
                                    * (1 - (proxyopcode.PriceType.UnitPrice != null ? Convert.ToDouble(proxyopcode.PriceType.DiscountRate) : 0) / 100)
                            ).ToString(),
                            TotalPriceIncludeTax = (
                                (proxyopcode.PriceType.UnitPrice != null ? Convert.ToDouble(proxyopcode.PriceType.UnitPrice) : 0)
                                * (proxyopcode.PriceType.UnitPrice != null ? Convert.ToDouble(proxyopcode.Quantity) : 0)
                                * (1 - (proxyopcode.PriceType.UnitPrice != null ? Convert.ToDouble(proxyopcode.PriceType.DiscountRate) : 0) / 100)
                                * 1.18 // Tax
                            ).ToString(),
                            UnitPrice = proxyopcode.PriceType.UnitPrice,
                        };
                        opcode.Quantity = proxyopcode.Quantity;
                        //opcode.SkillLevel = proxyopcode.SkillLevel;
                        opcode.Year = proxyopcode.Year;


                        if (proxyopcode.Parts != null && proxyopcode.Parts.Count > 0)
                        {
                            opcode.Parts = new List<Data.v2.Common.Part.Part>();

                            foreach (WA.Standard.IF.Data.v2.HMCIS.Price.Part proxypart in proxyopcode.Parts)
                            {
                                WA.Standard.IF.Data.v2.Common.Part.Part part = new Data.v2.Common.Part.Part();
                                //part.DisplayPartNumber = proxypart.DisplayPartNumber;
                                //part.DisplayRemarks = proxypart.DisplayRemarks;
                                //part.DMSPartNo = proxypart.DMSPartNo;
                                //part.Make = proxypart.Make;
                                part.Manufacturer = proxypart.Manufacturer;
                                //part.PartDescription = proxypart.PartDescription;
                                part.PartNumber = proxypart.PartNumber;
                                //part.PartStatus = proxypart.PartStatus;
                                //part.PartType = proxypart.PartType;
                                part.PriceType = new PriceType()
                                {
                                    DiscountPrice = (
                                        (proxypart.PriceType.UnitPrice != null ? Convert.ToDouble(proxypart.PriceType.UnitPrice) : 0)
                                        * (proxypart.PriceType.UnitPrice != null ? Convert.ToDouble(proxypart.Quantity) : 0)
                                        * ((proxypart.PriceType.UnitPrice != null ? Convert.ToDouble(proxypart.PriceType.DiscountRate) : 0) / 100)
                                    ).ToString(),
                                    DiscountRate = proxypart.PriceType.DiscountRate,
                                    TotalPrice = (
                                        (proxypart.PriceType.UnitPrice != null ? Convert.ToDouble(proxypart.PriceType.UnitPrice) : 0)
                                            * (proxypart.PriceType.UnitPrice != null ? Convert.ToDouble(proxypart.Quantity) : 0)
                                            * (1 - (proxypart.PriceType.UnitPrice != null ? Convert.ToDouble(proxypart.PriceType.DiscountRate) : 0) / 100)
                                    ).ToString(),
                                    TotalPriceIncludeTax = (
                                        (proxypart.PriceType.UnitPrice != null ? Convert.ToDouble(proxypart.PriceType.UnitPrice) : 0)
                                        * (proxypart.PriceType.UnitPrice != null ? Convert.ToDouble(proxypart.Quantity) : 0)
                                        * (1 - (proxypart.PriceType.UnitPrice != null ? Convert.ToDouble(proxypart.PriceType.DiscountRate) : 0) / 100)
                                        * 1.18 // Tax
                                    ).ToString(),
                                    UnitPrice = proxypart.PriceType.UnitPrice,
                                };
                                part.Quantity = proxypart.Quantity;
                                //part.QuantityOnHand = proxypart.QuantityOnHand;
                                //part.Remarks = proxypart.Remarks;
                                //part.StockQuantity = proxypart.StockQuantity;
                                //part.StockStatus = proxypart.StockStatus;
                                //part.UnitOfMeasure = proxypart.UnitOfMeasure;

                                opcode.Parts.Add(part);
                            }
                        }

                        price.OPCodes.Add(opcode);
                    }
                }

                if (price != null)
                {
                    price.AdditionalRepairOrderSummary = "3010.5";
                    price.LaborCampaignDiscountAmount = "1158.78";
                    price.PartsCampaignDiscountAmount = "2031.00";
                    price.TotalAmount = "7987.45";
                    price.TotalCampaignDiscountAmount = "1241.20";
                    price.VATAmount = "125.15";
                    
                    response.Price = price;
                    response.ResultMessage = GetResultMessageData(ResponseCode.Success, ResponseMessage.Success);
                }
                else
                {
                    response.ResultMessage = GetResultMessageData(ResponseCode.NoResult, ResponseMessage.NoResult);
                }
                #endregion
            }
            else if (WA.Standard.IF.Logger.Log.Log.RunningMode.Equals(WA.Standard.IF.Data.v2.Common.Common.RunningMode.DBDMS))
            {
                #region For DB Process - Not Yet

                #endregion
            }

            return response;
        }
    }
}
