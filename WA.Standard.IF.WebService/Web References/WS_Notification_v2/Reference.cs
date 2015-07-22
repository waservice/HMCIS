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

namespace WA.Standard.IF.WebService.WS_Notification_v2 {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="NotificationSoap", Namespace="http://tempuri.org/")]
    public partial class Notification : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ReceiverOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Notification() {
            this.Url = global::WA.Standard.IF.WebService.Properties.Settings.Default.WA_Standard_IF_WebService_WS_Notification_v2_Notification;
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
        public event ReceiverCompletedEventHandler ReceiverCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Receiver", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Receiver(MessageReceiveRequest request) {
            this.Invoke("Receiver", new object[] {
                        request});
        }
        
        /// <remarks/>
        public void ReceiverAsync(MessageReceiveRequest request) {
            this.ReceiverAsync(request, null);
        }
        
        /// <remarks/>
        public void ReceiverAsync(MessageReceiveRequest request, object userState) {
            if ((this.ReceiverOperationCompleted == null)) {
                this.ReceiverOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReceiverOperationCompleted);
            }
            this.InvokeAsync("Receiver", new object[] {
                        request}, this.ReceiverOperationCompleted, userState);
        }
        
        private void OnReceiverOperationCompleted(object arg) {
            if ((this.ReceiverCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReceiverCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://wa.dms.webservice/MessageReceiveRequest")]
    public partial class MessageReceiveRequest {
        
        private TransactionHeader transactionHeaderField;
        
        private MessageReceive messageReceiveField;
        
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
        public MessageReceive MessageReceive {
            get {
                return this.messageReceiveField;
            }
            set {
                this.messageReceiveField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://wa.dms.webservice/MessageReceiveRequest")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://wa.dms.webservice/MessageReceiveRequest")]
    public partial class MessageReceive {
        
        private string messageIDField;
        
        private string messageTypeField;
        
        private string actionTypeField;
        
        /// <remarks/>
        public string MessageID {
            get {
                return this.messageIDField;
            }
            set {
                this.messageIDField = value;
            }
        }
        
        /// <remarks/>
        public string MessageType {
            get {
                return this.messageTypeField;
            }
            set {
                this.messageTypeField = value;
            }
        }
        
        /// <remarks/>
        public string ActionType {
            get {
                return this.actionTypeField;
            }
            set {
                this.actionTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void ReceiverCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591