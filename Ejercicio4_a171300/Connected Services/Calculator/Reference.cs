﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ejercicio4_a171300.Calculator {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Calculator.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento HelloWorldResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        Ejercicio4_a171300.Calculator.HelloWorldResponse HelloWorld(Ejercicio4_a171300.Calculator.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<Ejercicio4_a171300.Calculator.HelloWorldResponse> HelloWorldAsync(Ejercicio4_a171300.Calculator.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/cuadrado", ReplyAction="*")]
        double cuadrado(double Base, double altura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/cuadrado", ReplyAction="*")]
        System.Threading.Tasks.Task<double> cuadradoAsync(double Base, double altura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/triangulo", ReplyAction="*")]
        double triangulo(double Base, double altura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/triangulo", ReplyAction="*")]
        System.Threading.Tasks.Task<double> trianguloAsync(double Base, double altura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/circulo", ReplyAction="*")]
        double circulo(double radio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/circulo", ReplyAction="*")]
        System.Threading.Tasks.Task<double> circuloAsync(double radio);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public Ejercicio4_a171300.Calculator.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(Ejercicio4_a171300.Calculator.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public Ejercicio4_a171300.Calculator.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(Ejercicio4_a171300.Calculator.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : Ejercicio4_a171300.Calculator.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<Ejercicio4_a171300.Calculator.WebService1Soap>, Ejercicio4_a171300.Calculator.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Ejercicio4_a171300.Calculator.HelloWorldResponse Ejercicio4_a171300.Calculator.WebService1Soap.HelloWorld(Ejercicio4_a171300.Calculator.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            Ejercicio4_a171300.Calculator.HelloWorldRequest inValue = new Ejercicio4_a171300.Calculator.HelloWorldRequest();
            inValue.Body = new Ejercicio4_a171300.Calculator.HelloWorldRequestBody();
            Ejercicio4_a171300.Calculator.HelloWorldResponse retVal = ((Ejercicio4_a171300.Calculator.WebService1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Ejercicio4_a171300.Calculator.HelloWorldResponse> Ejercicio4_a171300.Calculator.WebService1Soap.HelloWorldAsync(Ejercicio4_a171300.Calculator.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<Ejercicio4_a171300.Calculator.HelloWorldResponse> HelloWorldAsync() {
            Ejercicio4_a171300.Calculator.HelloWorldRequest inValue = new Ejercicio4_a171300.Calculator.HelloWorldRequest();
            inValue.Body = new Ejercicio4_a171300.Calculator.HelloWorldRequestBody();
            return ((Ejercicio4_a171300.Calculator.WebService1Soap)(this)).HelloWorldAsync(inValue);
        }
        
        public double cuadrado(double Base, double altura) {
            return base.Channel.cuadrado(Base, altura);
        }
        
        public System.Threading.Tasks.Task<double> cuadradoAsync(double Base, double altura) {
            return base.Channel.cuadradoAsync(Base, altura);
        }
        
        public double triangulo(double Base, double altura) {
            return base.Channel.triangulo(Base, altura);
        }
        
        public System.Threading.Tasks.Task<double> trianguloAsync(double Base, double altura) {
            return base.Channel.trianguloAsync(Base, altura);
        }
        
        public double circulo(double radio) {
            return base.Channel.circulo(radio);
        }
        
        public System.Threading.Tasks.Task<double> circuloAsync(double radio) {
            return base.Channel.circuloAsync(radio);
        }
    }
}