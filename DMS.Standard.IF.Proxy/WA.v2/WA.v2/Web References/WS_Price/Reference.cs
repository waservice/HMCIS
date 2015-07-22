﻿//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.34209
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 이 소스 코드가 Microsoft.VSDesigner, 버전 4.0.30319.34209에서 자동으로 생성되었습니다.
// 
#pragma warning disable 1591

namespace WA.v2.WS_Price {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="PriceSoap", Namespace="http://wa.dms.webservice/")]
    public partial class Price : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback PriceCheckOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Price() {
            this.Url = global::WA.v2.Properties.Settings.Default.WA_v2_WS_Price_Price;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event PriceCheckCompletedEventHandler PriceCheckCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://wa.dms.webservice/PriceCheck", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("PriceCheckResponse", Namespace="http://wa.dms.webservice/PriceCheckResponse", IsNullable=true)]
        public PriceCheckResponse PriceCheck([System.Xml.Serialization.XmlElementAttribute(Namespace="http://wa.dms.webservice/PriceCheckRequest", IsNullable=true)] PriceCheckRequest PriceCheckRequest) {
            object[] results = this.Invoke("PriceCheck", new object[] {
                        PriceCheckRequest});
            return ((PriceCheckResponse)(results[0]));
        }
        
        /// <remarks/>
        public void PriceCheckAsync(PriceCheckRequest PriceCheckRequest) {
            this.PriceCheckAsync(PriceCheckRequest, null);
        }
        
        /// <remarks/>
        public void PriceCheckAsync(PriceCheckRequest PriceCheckRequest, object userState) {
            if ((this.PriceCheckOperationCompleted == null)) {
                this.PriceCheckOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPriceCheckOperationCompleted);
            }
            this.InvokeAsync("PriceCheck", new object[] {
                        PriceCheckRequest}, this.PriceCheckOperationCompleted, userState);
        }
        
        private void OnPriceCheckOperationCompleted(object arg) {
            if ((this.PriceCheckCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PriceCheckCompleted(this, new PriceCheckCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://wa.dms.webservice/PriceCheckRequest")]
    public partial class PriceCheckRequest {
        
        private TransactionHeader transactionHeaderField;
        
        private PriceCheck priceCheckField;
        
        /// <remarks/>
        public TransactionHeader TransactionHeader {
            get {
                return this.transactionHeaderField;
            }
            set {
                this.transactionHeaderField = value;
            }
        }
        
        /// <remarks/>
        public PriceCheck PriceCheck {
            get {
                return this.priceCheckField;
            }
            set {
                this.priceCheckField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://wa.dms.webservice/PriceCheckRequest")]
    public partial class TransactionHeader {
        
        private string countryIDField;
        
        private string distributorIDField;
        
        private string groupIDField;
        
        private string dealerIDField;
        
        private string dMSCodeField;
        
        private string dMSVersionField;
        
        private string dMSServerUrlField;
        
        private string documentVersionField;
        
        private string usernameField;
        
        private string passwordField;
        
        private string transactionIdField;
        
        private System.DateTime transactionDateTimeUTCField;
        
        private System.DateTime transactionDateTimeLocalField;
        
        private string transactionTypeField;
        
        private string requestTypeField;
        
        private string requestPollingTokenField;
        
        private string venderTrackingCodeField;
        
        private string ineterfaceIDField;
        
        private string pollingTokenField;
        
        /// <remarks/>
        public string CountryID {
            get {
                return this.countryIDField;
            }
            set {
                this.countryIDField = value;
            }
        }
        
        /// <remarks/>
        public string DistributorID {
            get {
                return this.distributorIDField;
            }
            set {
                this.distributorIDField = value;
            }
        }
        
        /// <remarks/>
        public string GroupID {
            get {
                return this.groupIDField;
            }
            set {
                this.groupIDField = value;
            }
        }
        
        /// <remarks/>
        public string DealerID {
            get {
                return this.dealerIDField;
            }
            set {
                this.dealerIDField = value;
            }
        }
        
        /// <remarks/>
        public string DMSCode {
            get {
                return this.dMSCodeField;
            }
            set {
                this.dMSCodeField = value;
            }
        }
        
        /// <remarks/>
        public string DMSVersion {
            get {
                return this.dMSVersionField;
            }
            set {
                this.dMSVersionField = value;
            }
        }
        
        /// <remarks/>
        public string DMSServerUrl {
            get {
                return this.dMSServerUrlField;
            }
            set {
                this.dMSServerUrlField = value;
            }
        }
        
        /// <remarks/>
        public string DocumentVersion {
            get {
                return this.documentVersionField;
            }
            set {
                this.documentVersionField = value;
            }
        }
        
        /// <remarks/>
        public string Username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
            }
        }
        
        /// <remarks/>
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        public string TransactionId {
            get {
                return this.transactionIdField;
            }
            set {
                this.transactionIdField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime TransactionDateTimeUTC {
            get {
                return this.transactionDateTimeUTCField;
            }
            set {
                this.transactionDateTimeUTCField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime TransactionDateTimeLocal {
            get {
                return this.transactionDateTimeLocalField;
            }
            set {
                this.transactionDateTimeLocalField = value;
            }
        }
        
        /// <remarks/>
        public string TransactionType {
            get {
                return this.transactionTypeField;
            }
            set {
                this.transactionTypeField = value;
            }
        }
        
        /// <remarks/>
        public string RequestType {
            get {
                return this.requestTypeField;
            }
            set {
                this.requestTypeField = value;
            }
        }
        
        /// <remarks/>
        public string RequestPollingToken {
            get {
                return this.requestPollingTokenField;
            }
            set {
                this.requestPollingTokenField = value;
            }
        }
        
        /// <remarks/>
        public string VenderTrackingCode {
            get {
                return this.venderTrackingCodeField;
            }
            set {
                this.venderTrackingCodeField = value;
            }
        }
        
        /// <remarks/>
        public string IneterfaceID {
            get {
                return this.ineterfaceIDField;
            }
            set {
                this.ineterfaceIDField = value;
            }
        }
        
        /// <remarks/>
        public string PollingToken {
            get {
                return this.pollingTokenField;
            }
            set {
                this.pollingTokenField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="Part", Namespace="http://wa.dms.webservice/PriceCheckResponse")]
    public partial class Part1 {
        
        private string manufacturerField;
        
        private string partNumberField;
        
        private string quantityField;
        
        private PriceType1 priceTypeField;
        
        /// <remarks/>
        public string Manufacturer {
            get {
                return this.manufacturerField;
            }
            set {
                this.manufacturerField = value;
            }
        }
        
        /// <remarks/>
        public string PartNumber {
            get {
                return this.partNumberField;
            }
            set {
                this.partNumberField = value;
            }
        }
        
        /// <remarks/>
        public string Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        public PriceType1 PriceType {
            get {
                return this.priceTypeField;
            }
            set {
                this.priceTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="PriceType", Namespace="http://wa.dms.webservice/PriceCheckResponse")]
    public partial class PriceType1 {
        
        private string unitPriceField;
        
        private string totalPriceField;
        
        private string totalPriceIncludeTaxField;
        
        private string discountRateField;
        
        private string discountPriceField;
        
        /// <remarks/>
        public string UnitPrice {
            get {
                return this.unitPriceField;
            }
            set {
                this.unitPriceField = value;
            }
        }
        
        /// <remarks/>
        public string TotalPrice {
            get {
                return this.totalPriceField;
            }
            set {
                this.totalPriceField = value;
            }
        }
        
        /// <remarks/>
        public string TotalPriceIncludeTax {
            get {
                return this.totalPriceIncludeTaxField;
            }
            set {
                this.totalPriceIncludeTaxField = value;
            }
        }
        
        /// <remarks/>
        public string DiscountRate {
            get {
                return this.discountRateField;
            }
            set {
                this.discountRateField = value;
            }
        }
        
        /// <remarks/>
        public string DiscountPrice {
            get {
                return this.discountPriceField;
            }
            set {
                this.discountPriceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="OPCode", Namespace="http://wa.dms.webservice/PriceCheckResponse")]
    public partial class OPCode1 {
        
        private string codeField;
        
        private string makeField;
        
        private string modelField;
        
        private string engineField;
        
        private string yearField;
        
        private string mileageField;
        
        private string periodField;
        
        private string quantityField;
        
        private PriceType1 priceTypeField;
        
        private Part1[] partsField;
        
        /// <remarks/>
        public string Code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        public string Make {
            get {
                return this.makeField;
            }
            set {
                this.makeField = value;
            }
        }
        
        /// <remarks/>
        public string Model {
            get {
                return this.modelField;
            }
            set {
                this.modelField = value;
            }
        }
        
        /// <remarks/>
        public string Engine {
            get {
                return this.engineField;
            }
            set {
                this.engineField = value;
            }
        }
        
        /// <remarks/>
        public string Year {
            get {
                return this.yearField;
            }
            set {
                this.yearField = value;
            }
        }
        
        /// <remarks/>
        public string Mileage {
            get {
                return this.mileageField;
            }
            set {
                this.mileageField = value;
            }
        }
        
        /// <remarks/>
        public string Period {
            get {
                return this.periodField;
            }
            set {
                this.periodField = value;
            }
        }
        
        /// <remarks/>
        public string Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        public PriceType1 PriceType {
            get {
                return this.priceTypeField;
            }
            set {
                this.priceTypeField = value;
            }
        }
        
        /// <remarks/>
        public Part1[] Parts {
            get {
                return this.partsField;
            }
            set {
                this.partsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="Price", Namespace="http://wa.dms.webservice/PriceCheckResponse")]
    public partial class Price1 {
        
        private string partsCampaignDiscountAmountField;
        
        private string laborCampaignDiscountAmountField;
        
        private string totalCampaignDiscountAmountField;
        
        private string totalAmountField;
        
        private string vATAmountField;
        
        private OPCode1[] oPCodesField;
        
        /// <remarks/>
        public string PartsCampaignDiscountAmount {
            get {
                return this.partsCampaignDiscountAmountField;
            }
            set {
                this.partsCampaignDiscountAmountField = value;
            }
        }
        
        /// <remarks/>
        public string LaborCampaignDiscountAmount {
            get {
                return this.laborCampaignDiscountAmountField;
            }
            set {
                this.laborCampaignDiscountAmountField = value;
            }
        }
        
        /// <remarks/>
        public string TotalCampaignDiscountAmount {
            get {
                return this.totalCampaignDiscountAmountField;
            }
            set {
                this.totalCampaignDiscountAmountField = value;
            }
        }
        
        /// <remarks/>
        public string TotalAmount {
            get {
                return this.totalAmountField;
            }
            set {
                this.totalAmountField = value;
            }
        }
        
        /// <remarks/>
        public string VATAmount {
            get {
                return this.vATAmountField;
            }
            set {
                this.vATAmountField = value;
            }
        }
        
        /// <remarks/>
        public OPCode1[] OPCodes {
            get {
                return this.oPCodesField;
            }
            set {
                this.oPCodesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://wa.dms.webservice/PriceCheckResponse")]
    public partial class Error {
        
        private string codeField;
        
        private string messageField;
        
        /// <remarks/>
        public string Code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://wa.dms.webservice/PriceCheckResponse")]
    public partial class ResultMessage {
        
        private string codeField;
        
        private string messageField;
        
        /// <remarks/>
        public string Code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="TransactionHeader", Namespace="http://wa.dms.webservice/PriceCheckResponse")]
    public partial class TransactionHeader1 {
        
        private string countryIDField;
        
        private string distributorIDField;
        
        private string groupIDField;
        
        private string dealerIDField;
        
        private string dMSCodeField;
        
        private string dMSVersionField;
        
        private string dMSServerUrlField;
        
        private string documentVersionField;
        
        private string usernameField;
        
        private string passwordField;
        
        private string transactionIdField;
        
        private System.DateTime transactionDateTimeUTCField;
        
        private System.DateTime transactionDateTimeLocalField;
        
        private string transactionTypeField;
        
        private string requestTypeField;
        
        private string requestPollingTokenField;
        
        private string venderTrackingCodeField;
        
        private string ineterfaceIDField;
        
        private string pollingTokenField;
        
        /// <remarks/>
        public string CountryID {
            get {
                return this.countryIDField;
            }
            set {
                this.countryIDField = value;
            }
        }
        
        /// <remarks/>
        public string DistributorID {
            get {
                return this.distributorIDField;
            }
            set {
                this.distributorIDField = value;
            }
        }
        
        /// <remarks/>
        public string GroupID {
            get {
                return this.groupIDField;
            }
            set {
                this.groupIDField = value;
            }
        }
        
        /// <remarks/>
        public string DealerID {
            get {
                return this.dealerIDField;
            }
            set {
                this.dealerIDField = value;
            }
        }
        
        /// <remarks/>
        public string DMSCode {
            get {
                return this.dMSCodeField;
            }
            set {
                this.dMSCodeField = value;
            }
        }
        
        /// <remarks/>
        public string DMSVersion {
            get {
                return this.dMSVersionField;
            }
            set {
                this.dMSVersionField = value;
            }
        }
        
        /// <remarks/>
        public string DMSServerUrl {
            get {
                return this.dMSServerUrlField;
            }
            set {
                this.dMSServerUrlField = value;
            }
        }
        
        /// <remarks/>
        public string DocumentVersion {
            get {
                return this.documentVersionField;
            }
            set {
                this.documentVersionField = value;
            }
        }
        
        /// <remarks/>
        public string Username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
            }
        }
        
        /// <remarks/>
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        public string TransactionId {
            get {
                return this.transactionIdField;
            }
            set {
                this.transactionIdField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime TransactionDateTimeUTC {
            get {
                return this.transactionDateTimeUTCField;
            }
            set {
                this.transactionDateTimeUTCField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime TransactionDateTimeLocal {
            get {
                return this.transactionDateTimeLocalField;
            }
            set {
                this.transactionDateTimeLocalField = value;
            }
        }
        
        /// <remarks/>
        public string TransactionType {
            get {
                return this.transactionTypeField;
            }
            set {
                this.transactionTypeField = value;
            }
        }
        
        /// <remarks/>
        public string RequestType {
            get {
                return this.requestTypeField;
            }
            set {
                this.requestTypeField = value;
            }
        }
        
        /// <remarks/>
        public string RequestPollingToken {
            get {
                return this.requestPollingTokenField;
            }
            set {
                this.requestPollingTokenField = value;
            }
        }
        
        /// <remarks/>
        public string VenderTrackingCode {
            get {
                return this.venderTrackingCodeField;
            }
            set {
                this.venderTrackingCodeField = value;
            }
        }
        
        /// <remarks/>
        public string IneterfaceID {
            get {
                return this.ineterfaceIDField;
            }
            set {
                this.ineterfaceIDField = value;
            }
        }
        
        /// <remarks/>
        public string PollingToken {
            get {
                return this.pollingTokenField;
            }
            set {
                this.pollingTokenField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://wa.dms.webservice/PriceCheckResponse")]
    public partial class PriceCheckResponse {
        
        private TransactionHeader1 transactionHeaderField;
        
        private ResultMessage resultMessageField;
        
        private Error[] errorsField;
        
        private Price1 priceField;
        
        /// <remarks/>
        public TransactionHeader1 TransactionHeader {
            get {
                return this.transactionHeaderField;
            }
            set {
                this.transactionHeaderField = value;
            }
        }
        
        /// <remarks/>
        public ResultMessage ResultMessage {
            get {
                return this.resultMessageField;
            }
            set {
                this.resultMessageField = value;
            }
        }
        
        /// <remarks/>
        public Error[] Errors {
            get {
                return this.errorsField;
            }
            set {
                this.errorsField = value;
            }
        }
        
        /// <remarks/>
        public Price1 Price {
            get {
                return this.priceField;
            }
            set {
                this.priceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://wa.dms.webservice/PriceCheckRequest")]
    public partial class Part {
        
        private string manufacturerField;
        
        private string partNumberField;
        
        private string quantityField;
        
        private PriceType priceTypeField;
        
        /// <remarks/>
        public string Manufacturer {
            get {
                return this.manufacturerField;
            }
            set {
                this.manufacturerField = value;
            }
        }
        
        /// <remarks/>
        public string PartNumber {
            get {
                return this.partNumberField;
            }
            set {
                this.partNumberField = value;
            }
        }
        
        /// <remarks/>
        public string Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        public PriceType PriceType {
            get {
                return this.priceTypeField;
            }
            set {
                this.priceTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://wa.dms.webservice/PriceCheckRequest")]
    public partial class PriceType {
        
        private string unitPriceField;
        
        private string totalPriceField;
        
        private string totalPriceIncludeTaxField;
        
        private string discountRateField;
        
        private string discountPriceField;
        
        /// <remarks/>
        public string UnitPrice {
            get {
                return this.unitPriceField;
            }
            set {
                this.unitPriceField = value;
            }
        }
        
        /// <remarks/>
        public string TotalPrice {
            get {
                return this.totalPriceField;
            }
            set {
                this.totalPriceField = value;
            }
        }
        
        /// <remarks/>
        public string TotalPriceIncludeTax {
            get {
                return this.totalPriceIncludeTaxField;
            }
            set {
                this.totalPriceIncludeTaxField = value;
            }
        }
        
        /// <remarks/>
        public string DiscountRate {
            get {
                return this.discountRateField;
            }
            set {
                this.discountRateField = value;
            }
        }
        
        /// <remarks/>
        public string DiscountPrice {
            get {
                return this.discountPriceField;
            }
            set {
                this.discountPriceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://wa.dms.webservice/PriceCheckRequest")]
    public partial class OPCode {
        
        private string codeField;
        
        private string makeField;
        
        private string modelField;
        
        private string engineField;
        
        private string yearField;
        
        private string mileageField;
        
        private string periodField;
        
        private string quantityField;
        
        private PriceType priceTypeField;
        
        private Part[] partsField;
        
        /// <remarks/>
        public string Code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        public string Make {
            get {
                return this.makeField;
            }
            set {
                this.makeField = value;
            }
        }
        
        /// <remarks/>
        public string Model {
            get {
                return this.modelField;
            }
            set {
                this.modelField = value;
            }
        }
        
        /// <remarks/>
        public string Engine {
            get {
                return this.engineField;
            }
            set {
                this.engineField = value;
            }
        }
        
        /// <remarks/>
        public string Year {
            get {
                return this.yearField;
            }
            set {
                this.yearField = value;
            }
        }
        
        /// <remarks/>
        public string Mileage {
            get {
                return this.mileageField;
            }
            set {
                this.mileageField = value;
            }
        }
        
        /// <remarks/>
        public string Period {
            get {
                return this.periodField;
            }
            set {
                this.periodField = value;
            }
        }
        
        /// <remarks/>
        public string Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        public PriceType PriceType {
            get {
                return this.priceTypeField;
            }
            set {
                this.priceTypeField = value;
            }
        }
        
        /// <remarks/>
        public Part[] Parts {
            get {
                return this.partsField;
            }
            set {
                this.partsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://wa.dms.webservice/PriceCheckRequest")]
    public partial class PriceCheck {
        
        private string dMSRONoField;
        
        private OPCode[] oPCodesField;
        
        /// <remarks/>
        public string DMSRONo {
            get {
                return this.dMSRONoField;
            }
            set {
                this.dMSRONoField = value;
            }
        }
        
        /// <remarks/>
        public OPCode[] OPCodes {
            get {
                return this.oPCodesField;
            }
            set {
                this.oPCodesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void PriceCheckCompletedEventHandler(object sender, PriceCheckCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PriceCheckCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal PriceCheckCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public PriceCheckResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((PriceCheckResponse)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591