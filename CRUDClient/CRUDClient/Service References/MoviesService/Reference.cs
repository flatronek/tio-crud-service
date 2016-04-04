﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUDClient.MoviesService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Movie", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    public partial class Movie : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ReleaseYearField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ReleaseYear {
            get {
                return this.ReleaseYearField;
            }
            set {
                if ((this.ReleaseYearField.Equals(value) != true)) {
                    this.ReleaseYearField = value;
                    this.RaisePropertyChanged("ReleaseYear");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MoviesService.IMoviesService")]
    public interface IMoviesService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/GetAll", ReplyAction="http://tempuri.org/IMoviesService/GetAllResponse")]
        System.Collections.Generic.List<CRUDClient.MoviesService.Movie> GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/GetAll", ReplyAction="http://tempuri.org/IMoviesService/GetAllResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<CRUDClient.MoviesService.Movie>> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/Add", ReplyAction="http://tempuri.org/IMoviesService/AddResponse")]
        int Add(CRUDClient.MoviesService.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/Add", ReplyAction="http://tempuri.org/IMoviesService/AddResponse")]
        System.Threading.Tasks.Task<int> AddAsync(CRUDClient.MoviesService.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/Get", ReplyAction="http://tempuri.org/IMoviesService/GetResponse")]
        CRUDClient.MoviesService.Movie Get(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/Get", ReplyAction="http://tempuri.org/IMoviesService/GetResponse")]
        System.Threading.Tasks.Task<CRUDClient.MoviesService.Movie> GetAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/Update", ReplyAction="http://tempuri.org/IMoviesService/UpdateResponse")]
        CRUDClient.MoviesService.Movie Update(CRUDClient.MoviesService.Movie Movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/Update", ReplyAction="http://tempuri.org/IMoviesService/UpdateResponse")]
        System.Threading.Tasks.Task<CRUDClient.MoviesService.Movie> UpdateAsync(CRUDClient.MoviesService.Movie Movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/Delete", ReplyAction="http://tempuri.org/IMoviesService/DeleteResponse")]
        bool Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/Delete", ReplyAction="http://tempuri.org/IMoviesService/DeleteResponse")]
        System.Threading.Tasks.Task<bool> DeleteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMoviesServiceChannel : CRUDClient.MoviesService.IMoviesService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MoviesServiceClient : System.ServiceModel.ClientBase<CRUDClient.MoviesService.IMoviesService>, CRUDClient.MoviesService.IMoviesService {
        
        public MoviesServiceClient() {
        }
        
        public MoviesServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MoviesServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MoviesServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MoviesServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<CRUDClient.MoviesService.Movie> GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<CRUDClient.MoviesService.Movie>> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public int Add(CRUDClient.MoviesService.Movie movie) {
            return base.Channel.Add(movie);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(CRUDClient.MoviesService.Movie movie) {
            return base.Channel.AddAsync(movie);
        }
        
        public CRUDClient.MoviesService.Movie Get(int id) {
            return base.Channel.Get(id);
        }
        
        public System.Threading.Tasks.Task<CRUDClient.MoviesService.Movie> GetAsync(int id) {
            return base.Channel.GetAsync(id);
        }
        
        public CRUDClient.MoviesService.Movie Update(CRUDClient.MoviesService.Movie Movie) {
            return base.Channel.Update(Movie);
        }
        
        public System.Threading.Tasks.Task<CRUDClient.MoviesService.Movie> UpdateAsync(CRUDClient.MoviesService.Movie Movie) {
            return base.Channel.UpdateAsync(Movie);
        }
        
        public bool Delete(int id) {
            return base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
    }
}
