﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.Phone.ServiceReference, version 3.7.0.0
// 
namespace NatuurApp.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService1/TestDBConnection", ReplyAction="http://tempuri.org/IService1/TestDBConnectionResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.IAsyncResult BeginTestDBConnection(NatuurApp.ServiceReference1.TestDBConnectionRequest request, System.AsyncCallback callback, object asyncState);
        
        NatuurApp.ServiceReference1.TestDBConnectionResponse EndTestDBConnection(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService1/GetStringResult", ReplyAction="http://tempuri.org/IService1/GetStringResultResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.IAsyncResult BeginGetStringResult(NatuurApp.ServiceReference1.GetStringResultRequest request, System.AsyncCallback callback, object asyncState);
        
        NatuurApp.ServiceReference1.GetStringResultResponse EndGetStringResult(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService1/ExecuteCommand", ReplyAction="http://tempuri.org/IService1/ExecuteCommandResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.IAsyncResult BeginExecuteCommand(NatuurApp.ServiceReference1.ExecuteCommandRequest request, System.AsyncCallback callback, object asyncState);
        
        NatuurApp.ServiceReference1.ExecuteCommandResponse EndExecuteCommand(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService1/GetDataTableResult", ReplyAction="http://tempuri.org/IService1/GetDataTableResultResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.IAsyncResult BeginGetDataTableResult(NatuurApp.ServiceReference1.GetDataTableResultRequest request, System.AsyncCallback callback, object asyncState);
        
        NatuurApp.ServiceReference1.GetDataTableResultResponse EndGetDataTableResult(System.IAsyncResult result);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="TestDBConnection", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class TestDBConnectionRequest {
        
        public TestDBConnectionRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="TestDBConnectionResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class TestDBConnectionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool TestDBConnectionResult;
        
        public TestDBConnectionResponse() {
        }
        
        public TestDBConnectionResponse(bool TestDBConnectionResult) {
            this.TestDBConnectionResult = TestDBConnectionResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetStringResult", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetStringResultRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Query;
        
        public GetStringResultRequest() {
        }
        
        public GetStringResultRequest(string Query) {
            this.Query = Query;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetStringResultResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetStringResultResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string GetStringResultResult;
        
        public GetStringResultResponse() {
        }
        
        public GetStringResultResponse(string GetStringResultResult) {
            this.GetStringResultResult = GetStringResultResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ExecuteCommand", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ExecuteCommandRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Query;
        
        public ExecuteCommandRequest() {
        }
        
        public ExecuteCommandRequest(string Query) {
            this.Query = Query;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ExecuteCommandResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ExecuteCommandResponse {
        
        public ExecuteCommandResponse() {
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://tempuri.org/")]
    public partial class GetDataTableResultResponseGetDataTableResultResult : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Xml.Linq.XElement[] anyField;
        
        private System.Xml.Linq.XElement any1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.w3.org/2001/XMLSchema", Order=0)]
        public System.Xml.Linq.XElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
                this.RaisePropertyChanged("Any");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="urn:schemas-microsoft-com:xml-diffgram-v1", Order=1)]
        public System.Xml.Linq.XElement Any1 {
            get {
                return this.any1Field;
            }
            set {
                this.any1Field = value;
                this.RaisePropertyChanged("Any1");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDataTableResult", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetDataTableResultRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Query;
        
        public GetDataTableResultRequest() {
        }
        
        public GetDataTableResultRequest(string Query) {
            this.Query = Query;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDataTableResultResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetDataTableResultResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public NatuurApp.ServiceReference1.GetDataTableResultResponseGetDataTableResultResult GetDataTableResultResult;
        
        public GetDataTableResultResponse() {
        }
        
        public GetDataTableResultResponse(NatuurApp.ServiceReference1.GetDataTableResultResponseGetDataTableResultResult GetDataTableResultResult) {
            this.GetDataTableResultResult = GetDataTableResultResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : NatuurApp.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TestDBConnectionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public TestDBConnectionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public NatuurApp.ServiceReference1.TestDBConnectionResponse Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((NatuurApp.ServiceReference1.TestDBConnectionResponse)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetStringResultCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetStringResultCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public NatuurApp.ServiceReference1.GetStringResultResponse Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((NatuurApp.ServiceReference1.GetStringResultResponse)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ExecuteCommandCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public ExecuteCommandCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public NatuurApp.ServiceReference1.ExecuteCommandResponse Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((NatuurApp.ServiceReference1.ExecuteCommandResponse)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetDataTableResultCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetDataTableResultCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public NatuurApp.ServiceReference1.GetDataTableResultResponse Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((NatuurApp.ServiceReference1.GetDataTableResultResponse)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<NatuurApp.ServiceReference1.IService1>, NatuurApp.ServiceReference1.IService1 {
        
        private BeginOperationDelegate onBeginTestDBConnectionDelegate;
        
        private EndOperationDelegate onEndTestDBConnectionDelegate;
        
        private System.Threading.SendOrPostCallback onTestDBConnectionCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetStringResultDelegate;
        
        private EndOperationDelegate onEndGetStringResultDelegate;
        
        private System.Threading.SendOrPostCallback onGetStringResultCompletedDelegate;
        
        private BeginOperationDelegate onBeginExecuteCommandDelegate;
        
        private EndOperationDelegate onEndExecuteCommandDelegate;
        
        private System.Threading.SendOrPostCallback onExecuteCommandCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetDataTableResultDelegate;
        
        private EndOperationDelegate onEndGetDataTableResultDelegate;
        
        private System.Threading.SendOrPostCallback onGetDataTableResultCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<TestDBConnectionCompletedEventArgs> TestDBConnectionCompleted;
        
        public event System.EventHandler<GetStringResultCompletedEventArgs> GetStringResultCompleted;
        
        public event System.EventHandler<ExecuteCommandCompletedEventArgs> ExecuteCommandCompleted;
        
        public event System.EventHandler<GetDataTableResultCompletedEventArgs> GetDataTableResultCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult NatuurApp.ServiceReference1.IService1.BeginTestDBConnection(NatuurApp.ServiceReference1.TestDBConnectionRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginTestDBConnection(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NatuurApp.ServiceReference1.TestDBConnectionResponse NatuurApp.ServiceReference1.IService1.EndTestDBConnection(System.IAsyncResult result) {
            return base.Channel.EndTestDBConnection(result);
        }
        
        private System.IAsyncResult OnBeginTestDBConnection(object[] inValues, System.AsyncCallback callback, object asyncState) {
            NatuurApp.ServiceReference1.TestDBConnectionRequest request = ((NatuurApp.ServiceReference1.TestDBConnectionRequest)(inValues[0]));
            return ((NatuurApp.ServiceReference1.IService1)(this)).BeginTestDBConnection(request, callback, asyncState);
        }
        
        private object[] OnEndTestDBConnection(System.IAsyncResult result) {
            NatuurApp.ServiceReference1.TestDBConnectionResponse retVal = ((NatuurApp.ServiceReference1.IService1)(this)).EndTestDBConnection(result);
            return new object[] {
                    retVal};
        }
        
        private void OnTestDBConnectionCompleted(object state) {
            if ((this.TestDBConnectionCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.TestDBConnectionCompleted(this, new TestDBConnectionCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void TestDBConnectionAsync(NatuurApp.ServiceReference1.TestDBConnectionRequest request) {
            this.TestDBConnectionAsync(request, null);
        }
        
        public void TestDBConnectionAsync(NatuurApp.ServiceReference1.TestDBConnectionRequest request, object userState) {
            if ((this.onBeginTestDBConnectionDelegate == null)) {
                this.onBeginTestDBConnectionDelegate = new BeginOperationDelegate(this.OnBeginTestDBConnection);
            }
            if ((this.onEndTestDBConnectionDelegate == null)) {
                this.onEndTestDBConnectionDelegate = new EndOperationDelegate(this.OnEndTestDBConnection);
            }
            if ((this.onTestDBConnectionCompletedDelegate == null)) {
                this.onTestDBConnectionCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnTestDBConnectionCompleted);
            }
            base.InvokeAsync(this.onBeginTestDBConnectionDelegate, new object[] {
                        request}, this.onEndTestDBConnectionDelegate, this.onTestDBConnectionCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult NatuurApp.ServiceReference1.IService1.BeginGetStringResult(NatuurApp.ServiceReference1.GetStringResultRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetStringResult(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NatuurApp.ServiceReference1.GetStringResultResponse NatuurApp.ServiceReference1.IService1.EndGetStringResult(System.IAsyncResult result) {
            return base.Channel.EndGetStringResult(result);
        }
        
        private System.IAsyncResult OnBeginGetStringResult(object[] inValues, System.AsyncCallback callback, object asyncState) {
            NatuurApp.ServiceReference1.GetStringResultRequest request = ((NatuurApp.ServiceReference1.GetStringResultRequest)(inValues[0]));
            return ((NatuurApp.ServiceReference1.IService1)(this)).BeginGetStringResult(request, callback, asyncState);
        }
        
        private object[] OnEndGetStringResult(System.IAsyncResult result) {
            NatuurApp.ServiceReference1.GetStringResultResponse retVal = ((NatuurApp.ServiceReference1.IService1)(this)).EndGetStringResult(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetStringResultCompleted(object state) {
            if ((this.GetStringResultCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetStringResultCompleted(this, new GetStringResultCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetStringResultAsync(NatuurApp.ServiceReference1.GetStringResultRequest request) {
            this.GetStringResultAsync(request, null);
        }
        
        public void GetStringResultAsync(NatuurApp.ServiceReference1.GetStringResultRequest request, object userState) {
            if ((this.onBeginGetStringResultDelegate == null)) {
                this.onBeginGetStringResultDelegate = new BeginOperationDelegate(this.OnBeginGetStringResult);
            }
            if ((this.onEndGetStringResultDelegate == null)) {
                this.onEndGetStringResultDelegate = new EndOperationDelegate(this.OnEndGetStringResult);
            }
            if ((this.onGetStringResultCompletedDelegate == null)) {
                this.onGetStringResultCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetStringResultCompleted);
            }
            base.InvokeAsync(this.onBeginGetStringResultDelegate, new object[] {
                        request}, this.onEndGetStringResultDelegate, this.onGetStringResultCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult NatuurApp.ServiceReference1.IService1.BeginExecuteCommand(NatuurApp.ServiceReference1.ExecuteCommandRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginExecuteCommand(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NatuurApp.ServiceReference1.ExecuteCommandResponse NatuurApp.ServiceReference1.IService1.EndExecuteCommand(System.IAsyncResult result) {
            return base.Channel.EndExecuteCommand(result);
        }
        
        private System.IAsyncResult OnBeginExecuteCommand(object[] inValues, System.AsyncCallback callback, object asyncState) {
            NatuurApp.ServiceReference1.ExecuteCommandRequest request = ((NatuurApp.ServiceReference1.ExecuteCommandRequest)(inValues[0]));
            return ((NatuurApp.ServiceReference1.IService1)(this)).BeginExecuteCommand(request, callback, asyncState);
        }
        
        private object[] OnEndExecuteCommand(System.IAsyncResult result) {
            NatuurApp.ServiceReference1.ExecuteCommandResponse retVal = ((NatuurApp.ServiceReference1.IService1)(this)).EndExecuteCommand(result);
            return new object[] {
                    retVal};
        }
        
        private void OnExecuteCommandCompleted(object state) {
            if ((this.ExecuteCommandCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.ExecuteCommandCompleted(this, new ExecuteCommandCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void ExecuteCommandAsync(NatuurApp.ServiceReference1.ExecuteCommandRequest request) {
            this.ExecuteCommandAsync(request, null);
        }
        
        public void ExecuteCommandAsync(NatuurApp.ServiceReference1.ExecuteCommandRequest request, object userState) {
            if ((this.onBeginExecuteCommandDelegate == null)) {
                this.onBeginExecuteCommandDelegate = new BeginOperationDelegate(this.OnBeginExecuteCommand);
            }
            if ((this.onEndExecuteCommandDelegate == null)) {
                this.onEndExecuteCommandDelegate = new EndOperationDelegate(this.OnEndExecuteCommand);
            }
            if ((this.onExecuteCommandCompletedDelegate == null)) {
                this.onExecuteCommandCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnExecuteCommandCompleted);
            }
            base.InvokeAsync(this.onBeginExecuteCommandDelegate, new object[] {
                        request}, this.onEndExecuteCommandDelegate, this.onExecuteCommandCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult NatuurApp.ServiceReference1.IService1.BeginGetDataTableResult(NatuurApp.ServiceReference1.GetDataTableResultRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetDataTableResult(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NatuurApp.ServiceReference1.GetDataTableResultResponse NatuurApp.ServiceReference1.IService1.EndGetDataTableResult(System.IAsyncResult result) {
            return base.Channel.EndGetDataTableResult(result);
        }
        
        private System.IAsyncResult OnBeginGetDataTableResult(object[] inValues, System.AsyncCallback callback, object asyncState) {
            NatuurApp.ServiceReference1.GetDataTableResultRequest request = ((NatuurApp.ServiceReference1.GetDataTableResultRequest)(inValues[0]));
            return ((NatuurApp.ServiceReference1.IService1)(this)).BeginGetDataTableResult(request, callback, asyncState);
        }
        
        private object[] OnEndGetDataTableResult(System.IAsyncResult result) {
            NatuurApp.ServiceReference1.GetDataTableResultResponse retVal = ((NatuurApp.ServiceReference1.IService1)(this)).EndGetDataTableResult(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetDataTableResultCompleted(object state) {
            if ((this.GetDataTableResultCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetDataTableResultCompleted(this, new GetDataTableResultCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetDataTableResultAsync(NatuurApp.ServiceReference1.GetDataTableResultRequest request) {
            this.GetDataTableResultAsync(request, null);
        }
        
        public void GetDataTableResultAsync(NatuurApp.ServiceReference1.GetDataTableResultRequest request, object userState) {
            if ((this.onBeginGetDataTableResultDelegate == null)) {
                this.onBeginGetDataTableResultDelegate = new BeginOperationDelegate(this.OnBeginGetDataTableResult);
            }
            if ((this.onEndGetDataTableResultDelegate == null)) {
                this.onEndGetDataTableResultDelegate = new EndOperationDelegate(this.OnEndGetDataTableResult);
            }
            if ((this.onGetDataTableResultCompletedDelegate == null)) {
                this.onGetDataTableResultCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetDataTableResultCompleted);
            }
            base.InvokeAsync(this.onBeginGetDataTableResultDelegate, new object[] {
                        request}, this.onEndGetDataTableResultDelegate, this.onGetDataTableResultCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override NatuurApp.ServiceReference1.IService1 CreateChannel() {
            return new Service1ClientChannel(this);
        }
        
        private class Service1ClientChannel : ChannelBase<NatuurApp.ServiceReference1.IService1>, NatuurApp.ServiceReference1.IService1 {
            
            public Service1ClientChannel(System.ServiceModel.ClientBase<NatuurApp.ServiceReference1.IService1> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginTestDBConnection(NatuurApp.ServiceReference1.TestDBConnectionRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("TestDBConnection", _args, callback, asyncState);
                return _result;
            }
            
            public NatuurApp.ServiceReference1.TestDBConnectionResponse EndTestDBConnection(System.IAsyncResult result) {
                object[] _args = new object[0];
                NatuurApp.ServiceReference1.TestDBConnectionResponse _result = ((NatuurApp.ServiceReference1.TestDBConnectionResponse)(base.EndInvoke("TestDBConnection", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetStringResult(NatuurApp.ServiceReference1.GetStringResultRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("GetStringResult", _args, callback, asyncState);
                return _result;
            }
            
            public NatuurApp.ServiceReference1.GetStringResultResponse EndGetStringResult(System.IAsyncResult result) {
                object[] _args = new object[0];
                NatuurApp.ServiceReference1.GetStringResultResponse _result = ((NatuurApp.ServiceReference1.GetStringResultResponse)(base.EndInvoke("GetStringResult", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginExecuteCommand(NatuurApp.ServiceReference1.ExecuteCommandRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("ExecuteCommand", _args, callback, asyncState);
                return _result;
            }
            
            public NatuurApp.ServiceReference1.ExecuteCommandResponse EndExecuteCommand(System.IAsyncResult result) {
                object[] _args = new object[0];
                NatuurApp.ServiceReference1.ExecuteCommandResponse _result = ((NatuurApp.ServiceReference1.ExecuteCommandResponse)(base.EndInvoke("ExecuteCommand", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetDataTableResult(NatuurApp.ServiceReference1.GetDataTableResultRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("GetDataTableResult", _args, callback, asyncState);
                return _result;
            }
            
            public NatuurApp.ServiceReference1.GetDataTableResultResponse EndGetDataTableResult(System.IAsyncResult result) {
                object[] _args = new object[0];
                NatuurApp.ServiceReference1.GetDataTableResultResponse _result = ((NatuurApp.ServiceReference1.GetDataTableResultResponse)(base.EndInvoke("GetDataTableResult", _args, result)));
                return _result;
            }
        }
    }
}