﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MonitoringAdmin.DataCollectorServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DataCollectorServiceReference.IDataCollectorService")]
    public interface IDataCollectorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataCollectorService/StartDataCollectorServer", ReplyAction="http://tempuri.org/IDataCollectorService/StartDataCollectorServerResponse")]
        bool StartDataCollectorServer();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataCollectorService/StartDataCollectorServer", ReplyAction="http://tempuri.org/IDataCollectorService/StartDataCollectorServerResponse")]
        System.Threading.Tasks.Task<bool> StartDataCollectorServerAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataCollectorService/StopDataCollectorServer", ReplyAction="http://tempuri.org/IDataCollectorService/StopDataCollectorServerResponse")]
        bool StopDataCollectorServer();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataCollectorService/StopDataCollectorServer", ReplyAction="http://tempuri.org/IDataCollectorService/StopDataCollectorServerResponse")]
        System.Threading.Tasks.Task<bool> StopDataCollectorServerAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataCollectorService/GetServerStatus", ReplyAction="http://tempuri.org/IDataCollectorService/GetServerStatusResponse")]
        SharedLibrary.ServerStatus GetServerStatus();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataCollectorService/GetServerStatus", ReplyAction="http://tempuri.org/IDataCollectorService/GetServerStatusResponse")]
        System.Threading.Tasks.Task<SharedLibrary.ServerStatus> GetServerStatusAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataCollectorServiceChannel : MonitoringAdmin.DataCollectorServiceReference.IDataCollectorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataCollectorServiceClient : System.ServiceModel.ClientBase<MonitoringAdmin.DataCollectorServiceReference.IDataCollectorService>, MonitoringAdmin.DataCollectorServiceReference.IDataCollectorService {
        
        public DataCollectorServiceClient() {
        }
        
        public DataCollectorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataCollectorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataCollectorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataCollectorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool StartDataCollectorServer() {
            return base.Channel.StartDataCollectorServer();
        }
        
        public System.Threading.Tasks.Task<bool> StartDataCollectorServerAsync() {
            return base.Channel.StartDataCollectorServerAsync();
        }
        
        public bool StopDataCollectorServer() {
            return base.Channel.StopDataCollectorServer();
        }
        
        public System.Threading.Tasks.Task<bool> StopDataCollectorServerAsync() {
            return base.Channel.StopDataCollectorServerAsync();
        }
        
        public SharedLibrary.ServerStatus GetServerStatus() {
            return base.Channel.GetServerStatus();
        }
        
        public System.Threading.Tasks.Task<SharedLibrary.ServerStatus> GetServerStatusAsync() {
            return base.Channel.GetServerStatusAsync();
        }
    }
}
