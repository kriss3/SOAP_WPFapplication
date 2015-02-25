﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceClient.MyServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyServiceReference.CalculatorWebServiceSoap")]
    public interface CalculatorWebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        int Add(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Subtract", ReplyAction="*")]
        int Subtract(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiply", ReplyAction="*")]
        int Multiply(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Divide", ReplyAction="*")]
        double Divide(double x, double y);
        
        // CODEGEN: Generating message contract since element name messageValue from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMyString", ReplyAction="*")]
        WebServiceClient.MyServiceReference.GetMyStringResponse GetMyString(WebServiceClient.MyServiceReference.GetMyStringRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMyStringRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMyString", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceClient.MyServiceReference.GetMyStringRequestBody Body;
        
        public GetMyStringRequest() {
        }
        
        public GetMyStringRequest(WebServiceClient.MyServiceReference.GetMyStringRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetMyStringRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string messageValue;
        
        public GetMyStringRequestBody() {
        }
        
        public GetMyStringRequestBody(string messageValue) {
            this.messageValue = messageValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMyStringResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMyStringResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceClient.MyServiceReference.GetMyStringResponseBody Body;
        
        public GetMyStringResponse() {
        }
        
        public GetMyStringResponse(WebServiceClient.MyServiceReference.GetMyStringResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetMyStringResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetMyStringResult;
        
        public GetMyStringResponseBody() {
        }
        
        public GetMyStringResponseBody(string GetMyStringResult) {
            this.GetMyStringResult = GetMyStringResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalculatorWebServiceSoapChannel : WebServiceClient.MyServiceReference.CalculatorWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorWebServiceSoapClient : System.ServiceModel.ClientBase<WebServiceClient.MyServiceReference.CalculatorWebServiceSoap>, WebServiceClient.MyServiceReference.CalculatorWebServiceSoap {
        
        public CalculatorWebServiceSoapClient() {
        }
        
        public CalculatorWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int x, int y) {
            return base.Channel.Add(x, y);
        }
        
        public int Subtract(int x, int y) {
            return base.Channel.Subtract(x, y);
        }
        
        public int Multiply(int x, int y) {
            return base.Channel.Multiply(x, y);
        }
        
        public double Divide(double x, double y) {
            return base.Channel.Divide(x, y);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceClient.MyServiceReference.GetMyStringResponse WebServiceClient.MyServiceReference.CalculatorWebServiceSoap.GetMyString(WebServiceClient.MyServiceReference.GetMyStringRequest request) {
            return base.Channel.GetMyString(request);
        }
        
        public string GetMyString(string messageValue) {
            WebServiceClient.MyServiceReference.GetMyStringRequest inValue = new WebServiceClient.MyServiceReference.GetMyStringRequest();
            inValue.Body = new WebServiceClient.MyServiceReference.GetMyStringRequestBody();
            inValue.Body.messageValue = messageValue;
            WebServiceClient.MyServiceReference.GetMyStringResponse retVal = ((WebServiceClient.MyServiceReference.CalculatorWebServiceSoap)(this)).GetMyString(inValue);
            return retVal.Body.GetMyStringResult;
        }
    }
}
