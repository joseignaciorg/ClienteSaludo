﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteSaludos.ServiciosSaludos {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Saludo", Namespace="http://schemas.datacontract.org/2004/07/ServicioSaludo")]
    [System.SerializableAttribute()]
    public partial class Saludo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdiomaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
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
        public string Idioma {
            get {
                return this.IdiomaField;
            }
            set {
                if ((object.ReferenceEquals(this.IdiomaField, value) != true)) {
                    this.IdiomaField = value;
                    this.RaisePropertyChanged("Idioma");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiciosSaludos.ISaludosService")]
    public interface ISaludosService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISaludosService/Saludar", ReplyAction="http://tempuri.org/ISaludosService/SaludarResponse")]
        string Saludar(ClienteSaludos.ServiciosSaludos.Saludo saludo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISaludosService/Saludar", ReplyAction="http://tempuri.org/ISaludosService/SaludarResponse")]
        System.Threading.Tasks.Task<string> SaludarAsync(ClienteSaludos.ServiciosSaludos.Saludo saludo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISaludosServiceChannel : ClienteSaludos.ServiciosSaludos.ISaludosService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SaludosServiceClient : System.ServiceModel.ClientBase<ClienteSaludos.ServiciosSaludos.ISaludosService>, ClienteSaludos.ServiciosSaludos.ISaludosService {
        
        public SaludosServiceClient() {
        }
        
        public SaludosServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SaludosServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SaludosServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SaludosServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Saludar(ClienteSaludos.ServiciosSaludos.Saludo saludo) {
            return base.Channel.Saludar(saludo);
        }
        
        public System.Threading.Tasks.Task<string> SaludarAsync(ClienteSaludos.ServiciosSaludos.Saludo saludo) {
            return base.Channel.SaludarAsync(saludo);
        }
    }
}
