﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProtoBuf.Wcf.Tests.TestService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/ProtoBuf.Wcf.Sample")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BigContract", Namespace="http://schemas.datacontract.org/2004/07/ProtoBuf.Wcf.Sample")]
    [System.SerializableAttribute()]
    public partial class BigContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ProtoBuf.Wcf.Tests.TestService.CompositeType[] CompositeTypesField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ProtoBuf.Wcf.Tests.TestService.CompositeType[] CompositeTypes {
            get {
                return this.CompositeTypesField;
            }
            set {
                if ((object.ReferenceEquals(this.CompositeTypesField, value) != true)) {
                    this.CompositeTypesField = value;
                    this.RaisePropertyChanged("CompositeTypes");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TestService.ITestService")]
    public interface ITestService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/GetData", ReplyAction="http://tempuri.org/ITestService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/GetData", ReplyAction="http://tempuri.org/ITestService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ITestService/GetDataUsingDataContractResponse")]
        ProtoBuf.Wcf.Tests.TestService.CompositeType GetDataUsingDataContract(ProtoBuf.Wcf.Tests.TestService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ITestService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<ProtoBuf.Wcf.Tests.TestService.CompositeType> GetDataUsingDataContractAsync(ProtoBuf.Wcf.Tests.TestService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/GetDataUsingBigDataContract", ReplyAction="http://tempuri.org/ITestService/GetDataUsingBigDataContractResponse")]
        ProtoBuf.Wcf.Tests.TestService.BigContract GetDataUsingBigDataContract(ProtoBuf.Wcf.Tests.TestService.BigContract bigContract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/GetDataUsingBigDataContract", ReplyAction="http://tempuri.org/ITestService/GetDataUsingBigDataContractResponse")]
        System.Threading.Tasks.Task<ProtoBuf.Wcf.Tests.TestService.BigContract> GetDataUsingBigDataContractAsync(ProtoBuf.Wcf.Tests.TestService.BigContract bigContract);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITestServiceChannel : ProtoBuf.Wcf.Tests.TestService.ITestService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TestServiceClient : System.ServiceModel.ClientBase<ProtoBuf.Wcf.Tests.TestService.ITestService>, ProtoBuf.Wcf.Tests.TestService.ITestService {
        
        public TestServiceClient() {
        }
        
        public TestServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TestServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TestServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TestServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public ProtoBuf.Wcf.Tests.TestService.CompositeType GetDataUsingDataContract(ProtoBuf.Wcf.Tests.TestService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<ProtoBuf.Wcf.Tests.TestService.CompositeType> GetDataUsingDataContractAsync(ProtoBuf.Wcf.Tests.TestService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public ProtoBuf.Wcf.Tests.TestService.BigContract GetDataUsingBigDataContract(ProtoBuf.Wcf.Tests.TestService.BigContract bigContract) {
            return base.Channel.GetDataUsingBigDataContract(bigContract);
        }
        
        public System.Threading.Tasks.Task<ProtoBuf.Wcf.Tests.TestService.BigContract> GetDataUsingBigDataContractAsync(ProtoBuf.Wcf.Tests.TestService.BigContract bigContract) {
            return base.Channel.GetDataUsingBigDataContractAsync(bigContract);
        }
    }
}
