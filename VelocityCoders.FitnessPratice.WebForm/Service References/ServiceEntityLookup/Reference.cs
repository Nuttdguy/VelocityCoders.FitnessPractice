﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VelocityCoders.FitnessPratice.WebForm.ServiceEntityLookup {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityTypeDTO", Namespace="http://schemas.datacontract.org/2004/07/VelocityCoders.FitnessPractice.Services.D" +
        "ataContracts")]
    [System.SerializableAttribute()]
    public partial class EntityTypeDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DisplayNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EntityIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EntityTypeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EntityTypeNameField;
        
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
        public string DisplayName {
            get {
                return this.DisplayNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DisplayNameField, value) != true)) {
                    this.DisplayNameField = value;
                    this.RaisePropertyChanged("DisplayName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EntityId {
            get {
                return this.EntityIdField;
            }
            set {
                if ((this.EntityIdField.Equals(value) != true)) {
                    this.EntityIdField = value;
                    this.RaisePropertyChanged("EntityId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EntityTypeId {
            get {
                return this.EntityTypeIdField;
            }
            set {
                if ((this.EntityTypeIdField.Equals(value) != true)) {
                    this.EntityTypeIdField = value;
                    this.RaisePropertyChanged("EntityTypeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EntityTypeName {
            get {
                return this.EntityTypeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EntityTypeNameField, value) != true)) {
                    this.EntityTypeNameField = value;
                    this.RaisePropertyChanged("EntityTypeName");
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
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="EntityTypeDTOCollection", Namespace="http://schemas.datacontract.org/2004/07/VelocityCoders.FitnessPractice.Services.D" +
        "ataContracts", ItemName="EntityTypeDTO")]
    [System.SerializableAttribute()]
    public class EntityTypeDTOCollection : System.Collections.Generic.List<VelocityCoders.FitnessPratice.WebForm.ServiceEntityLookup.EntityTypeDTO> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityLookupServiceFault", Namespace="http://schemas.datacontract.org/2004/07/VelocityCoders.FitnessPractice.Services.F" +
        "aults")]
    [System.SerializableAttribute()]
    public partial class EntityLookupServiceFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
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
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceEntityLookup.IEntityLookupService")]
    public interface IEntityLookupService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntityLookupService/GetEntityType", ReplyAction="http://tempuri.org/IEntityLookupService/GetEntityTypeResponse")]
        VelocityCoders.FitnessPratice.WebForm.ServiceEntityLookup.EntityTypeDTO GetEntityType(int entityTypeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntityLookupService/GetEntityType", ReplyAction="http://tempuri.org/IEntityLookupService/GetEntityTypeResponse")]
        System.Threading.Tasks.Task<VelocityCoders.FitnessPratice.WebForm.ServiceEntityLookup.EntityTypeDTO> GetEntityTypeAsync(int entityTypeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntityLookupService/GetEntityTypeCollection", ReplyAction="http://tempuri.org/IEntityLookupService/GetEntityTypeCollectionResponse")]
        VelocityCoders.FitnessPratice.WebForm.ServiceEntityLookup.EntityTypeDTOCollection GetEntityTypeCollection(int entityId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntityLookupService/GetEntityTypeCollection", ReplyAction="http://tempuri.org/IEntityLookupService/GetEntityTypeCollectionResponse")]
        System.Threading.Tasks.Task<VelocityCoders.FitnessPratice.WebForm.ServiceEntityLookup.EntityTypeDTOCollection> GetEntityTypeCollectionAsync(int entityId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntityLookupService/DeleteEntityType", ReplyAction="http://tempuri.org/IEntityLookupService/DeleteEntityTypeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(VelocityCoders.FitnessPratice.WebForm.ServiceEntityLookup.EntityLookupServiceFault), Action="http://tempuri.org/IEntityLookupService/DeleteEntityTypeEntityLookupServiceFaultF" +
            "ault", Name="EntityLookupServiceFault", Namespace="http://schemas.datacontract.org/2004/07/VelocityCoders.FitnessPractice.Services.F" +
            "aults")]
        void DeleteEntityType(int entityTypeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntityLookupService/DeleteEntityType", ReplyAction="http://tempuri.org/IEntityLookupService/DeleteEntityTypeResponse")]
        System.Threading.Tasks.Task DeleteEntityTypeAsync(int entityTypeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntityLookupService/SaveEntityType", ReplyAction="http://tempuri.org/IEntityLookupService/SaveEntityTypeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(VelocityCoders.FitnessPratice.WebForm.ServiceEntityLookup.EntityLookupServiceFault), Action="http://tempuri.org/IEntityLookupService/SaveEntityTypeEntityLookupServiceFaultFau" +
            "lt", Name="EntityLookupServiceFault", Namespace="http://schemas.datacontract.org/2004/07/VelocityCoders.FitnessPractice.Services.F" +
            "aults")]
        void SaveEntityType(VelocityCoders.FitnessPratice.WebForm.ServiceEntityLookup.EntityTypeDTO entityTypeToSave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntityLookupService/SaveEntityType", ReplyAction="http://tempuri.org/IEntityLookupService/SaveEntityTypeResponse")]
        System.Threading.Tasks.Task SaveEntityTypeAsync(VelocityCoders.FitnessPratice.WebForm.ServiceEntityLookup.EntityTypeDTO entityTypeToSave);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEntityLookupServiceChannel : VelocityCoders.FitnessPratice.WebForm.ServiceEntityLookup.IEntityLookupService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EntityLookupServiceClient : System.ServiceModel.ClientBase<VelocityCoders.FitnessPratice.WebForm.ServiceEntityLookup.IEntityLookupService>, VelocityCoders.FitnessPratice.WebForm.ServiceEntityLookup.IEntityLookupService {
        
        public EntityLookupServiceClient() {
        }
        
        public EntityLookupServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EntityLookupServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EntityLookupServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EntityLookupServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public VelocityCoders.FitnessPratice.WebForm.ServiceEntityLookup.EntityTypeDTO GetEntityType(int entityTypeId) {
            return base.Channel.GetEntityType(entityTypeId);
        }
        
        public System.Threading.Tasks.Task<VelocityCoders.FitnessPratice.WebForm.ServiceEntityLookup.EntityTypeDTO> GetEntityTypeAsync(int entityTypeId) {
            return base.Channel.GetEntityTypeAsync(entityTypeId);
        }
        
        public VelocityCoders.FitnessPratice.WebForm.ServiceEntityLookup.EntityTypeDTOCollection GetEntityTypeCollection(int entityId) {
            return base.Channel.GetEntityTypeCollection(entityId);
        }
        
        public System.Threading.Tasks.Task<VelocityCoders.FitnessPratice.WebForm.ServiceEntityLookup.EntityTypeDTOCollection> GetEntityTypeCollectionAsync(int entityId) {
            return base.Channel.GetEntityTypeCollectionAsync(entityId);
        }
        
        public void DeleteEntityType(int entityTypeId) {
            base.Channel.DeleteEntityType(entityTypeId);
        }
        
        public System.Threading.Tasks.Task DeleteEntityTypeAsync(int entityTypeId) {
            return base.Channel.DeleteEntityTypeAsync(entityTypeId);
        }
        
        public void SaveEntityType(VelocityCoders.FitnessPratice.WebForm.ServiceEntityLookup.EntityTypeDTO entityTypeToSave) {
            base.Channel.SaveEntityType(entityTypeToSave);
        }
        
        public System.Threading.Tasks.Task SaveEntityTypeAsync(VelocityCoders.FitnessPratice.WebForm.ServiceEntityLookup.EntityTypeDTO entityTypeToSave) {
            return base.Channel.SaveEntityTypeAsync(entityTypeToSave);
        }
    }
}
