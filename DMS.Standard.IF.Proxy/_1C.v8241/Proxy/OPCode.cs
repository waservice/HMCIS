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
// 이 소스 코드는 wsdl, 버전=4.0.30319.1에서 자동 생성되었습니다.
// 
namespace _1C.v8241.OPCode {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="OPCodeSoapBinding", Namespace="http://wa.dms.webservice/")]
    public partial class OPCode : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback OPCodeGetOperationCompleted;
        
        /// <remarks/>
        public OPCode() {
            this.Url = "http://192.168.32.2/rtr-atest/ws/opcode.1cws";
        }
        
        /// <remarks/>
        public event OPCodeGetCompletedEventHandler OPCodeGetCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://wa.dms.webservice/#OPCode:OPCodeGet", RequestNamespace="http://wa.dms.webservice/", ResponseNamespace="http://wa.dms.webservice/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return")]
        public OPCodeGetResponse OPCodeGet(OPCodeGetRequest OPCodeGetRequest) {
            object[] results = this.Invoke("OPCodeGet", new object[] {
                        OPCodeGetRequest});
            return ((OPCodeGetResponse)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginOPCodeGet(OPCodeGetRequest OPCodeGetRequest, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("OPCodeGet", new object[] {
                        OPCodeGetRequest}, callback, asyncState);
        }
        
        /// <remarks/>
        public OPCodeGetResponse EndOPCodeGet(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((OPCodeGetResponse)(results[0]));
        }
        
        /// <remarks/>
        public void OPCodeGetAsync(OPCodeGetRequest OPCodeGetRequest) {
            this.OPCodeGetAsync(OPCodeGetRequest, null);
        }
        
        /// <remarks/>
        public void OPCodeGetAsync(OPCodeGetRequest OPCodeGetRequest, object userState) {
            if ((this.OPCodeGetOperationCompleted == null)) {
                this.OPCodeGetOperationCompleted = new System.Threading.SendOrPostCallback(this.OnOPCodeGetOperationCompleted);
            }
            this.InvokeAsync("OPCodeGet", new object[] {
                        OPCodeGetRequest}, this.OPCodeGetOperationCompleted, userState);
        }
        
        private void OnOPCodeGetOperationCompleted(object arg) {
            if ((this.OPCodeGetCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.OPCodeGetCompleted(this, new OPCodeGetCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://wa.dms.webservice/OPCodeGetRequest")]
    public partial class OPCodeGetRequest {
        
        private TransactionHeader transactionHeaderField;
        
        private OPCodeGet oPCodeGetField;
        
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
        public OPCodeGet OPCodeGet {
            get {
                return this.oPCodeGetField;
            }
            set {
                this.oPCodeGetField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://wa.dms.webservice/OPCodeGetRequest")]
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
        
        private System.Nullable<System.DateTime> transactionDateTimeUTCField;
        
        private bool transactionDateTimeUTCFieldSpecified;
        
        private System.Nullable<System.DateTime> transactionDateTimeLocalField;
        
        private bool transactionDateTimeLocalFieldSpecified;
        
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> TransactionDateTimeUTC {
            get {
                return this.transactionDateTimeUTCField;
            }
            set {
                this.transactionDateTimeUTCField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransactionDateTimeUTCSpecified {
            get {
                return this.transactionDateTimeUTCFieldSpecified;
            }
            set {
                this.transactionDateTimeUTCFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> TransactionDateTimeLocal {
            get {
                return this.transactionDateTimeLocalField;
            }
            set {
                this.transactionDateTimeLocalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransactionDateTimeLocalSpecified {
            get {
                return this.transactionDateTimeLocalFieldSpecified;
            }
            set {
                this.transactionDateTimeLocalFieldSpecified = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://wa.dms.webservice/OPCodeGetRequest")]
    public partial class Part {
        
        private string manufacturerField;
        
        private string partNumberField;
        
        private string partDescriptionField;
        
        private string makeField;
        
        private string partStatusField;
        
        private string partTypeField;
        
        private string quantityOnHandField;
        
        private string stockStatusField;
        
        private string displayPartNumberField;
        
        private string remarksField;
        
        private string unitOfMeasureField;
        
        private string stockQuantityField;
        
        private string quantityField;
        
        private string serviceTypeField;
        
        private string displayRemarksField;
        
        private string mandatoryYNField;
        
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
        public string PartDescription {
            get {
                return this.partDescriptionField;
            }
            set {
                this.partDescriptionField = value;
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
        public string PartStatus {
            get {
                return this.partStatusField;
            }
            set {
                this.partStatusField = value;
            }
        }
        
        /// <remarks/>
        public string PartType {
            get {
                return this.partTypeField;
            }
            set {
                this.partTypeField = value;
            }
        }
        
        /// <remarks/>
        public string QuantityOnHand {
            get {
                return this.quantityOnHandField;
            }
            set {
                this.quantityOnHandField = value;
            }
        }
        
        /// <remarks/>
        public string StockStatus {
            get {
                return this.stockStatusField;
            }
            set {
                this.stockStatusField = value;
            }
        }
        
        /// <remarks/>
        public string DisplayPartNumber {
            get {
                return this.displayPartNumberField;
            }
            set {
                this.displayPartNumberField = value;
            }
        }
        
        /// <remarks/>
        public string Remarks {
            get {
                return this.remarksField;
            }
            set {
                this.remarksField = value;
            }
        }
        
        /// <remarks/>
        public string UnitOfMeasure {
            get {
                return this.unitOfMeasureField;
            }
            set {
                this.unitOfMeasureField = value;
            }
        }
        
        /// <remarks/>
        public string StockQuantity {
            get {
                return this.stockQuantityField;
            }
            set {
                this.stockQuantityField = value;
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
        public string ServiceType {
            get {
                return this.serviceTypeField;
            }
            set {
                this.serviceTypeField = value;
            }
        }
        
        /// <remarks/>
        public string DisplayRemarks {
            get {
                return this.displayRemarksField;
            }
            set {
                this.displayRemarksField = value;
            }
        }
        
        /// <remarks/>
        public string MandatoryYN {
            get {
                return this.mandatoryYNField;
            }
            set {
                this.mandatoryYNField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://wa.dms.webservice/OPCodeGetRequest")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="OPCode", Namespace="http://wa.dms.webservice/OPCodeGetRequest")]
    public partial class OPCode1 {
        
        private string codeField;
        
        private string descriptionField;
        
        private string oPCodeTypeField;
        
        private string displayOPCodeField;
        
        private string displayOPDescriptionField;
        
        private string makeField;
        
        private string modelField;
        
        private string engineField;
        
        private string yearField;
        
        private string mileageField;
        
        private string periodField;
        
        private string defLinePaymentMethodField;
        
        private string correctionLOPField;
        
        private string skillLevelField;
        
        private string hazardMaterialChargeField;
        
        private string estimatedHoursField;
        
        private string predefinedCauseDescriptionField;
        
        private string cPSINDField;
        
        private string mandatoryYNField;
        
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
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public string OPCodeType {
            get {
                return this.oPCodeTypeField;
            }
            set {
                this.oPCodeTypeField = value;
            }
        }
        
        /// <remarks/>
        public string DisplayOPCode {
            get {
                return this.displayOPCodeField;
            }
            set {
                this.displayOPCodeField = value;
            }
        }
        
        /// <remarks/>
        public string DisplayOPDescription {
            get {
                return this.displayOPDescriptionField;
            }
            set {
                this.displayOPDescriptionField = value;
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
        public string DefLinePaymentMethod {
            get {
                return this.defLinePaymentMethodField;
            }
            set {
                this.defLinePaymentMethodField = value;
            }
        }
        
        /// <remarks/>
        public string CorrectionLOP {
            get {
                return this.correctionLOPField;
            }
            set {
                this.correctionLOPField = value;
            }
        }
        
        /// <remarks/>
        public string SkillLevel {
            get {
                return this.skillLevelField;
            }
            set {
                this.skillLevelField = value;
            }
        }
        
        /// <remarks/>
        public string HazardMaterialCharge {
            get {
                return this.hazardMaterialChargeField;
            }
            set {
                this.hazardMaterialChargeField = value;
            }
        }
        
        /// <remarks/>
        public string EstimatedHours {
            get {
                return this.estimatedHoursField;
            }
            set {
                this.estimatedHoursField = value;
            }
        }
        
        /// <remarks/>
        public string PredefinedCauseDescription {
            get {
                return this.predefinedCauseDescriptionField;
            }
            set {
                this.predefinedCauseDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string CPSIND {
            get {
                return this.cPSINDField;
            }
            set {
                this.cPSINDField = value;
            }
        }
        
        /// <remarks/>
        public string MandatoryYN {
            get {
                return this.mandatoryYNField;
            }
            set {
                this.mandatoryYNField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://wa.dms.webservice/OPCodeGetRequest")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://wa.dms.webservice/OPCodeGetRequest")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://wa.dms.webservice/OPCodeGetRequest")]
    public partial class OPCodeGetResponse {
        
        private TransactionHeader transactionHeaderField;
        
        private ResultMessage resultMessageField;
        
        private Error[] errorsField;
        
        private OPCode1[] oPCodesField;
        
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://wa.dms.webservice/OPCodeGetRequest")]
    public partial class OPCodeGet {
        
        private string codeField;
        
        private string descriptionField;
        
        private string makeField;
        
        private string modelField;
        
        private string yearField;
        
        private string engineField;
        
        private string mileageField;
        
        private string categoryField;
        
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
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
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
        public string Year {
            get {
                return this.yearField;
            }
            set {
                this.yearField = value;
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
        public string Mileage {
            get {
                return this.mileageField;
            }
            set {
                this.mileageField = value;
            }
        }
        
        /// <remarks/>
        public string Category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    public delegate void OPCodeGetCompletedEventHandler(object sender, OPCodeGetCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OPCodeGetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal OPCodeGetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public OPCodeGetResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((OPCodeGetResponse)(this.results[0]));
            }
        }
    }
}
