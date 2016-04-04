﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUDClient.ReviewsService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SurnameField;
        
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Surname {
            get {
                return this.SurnameField;
            }
            set {
                if ((object.ReferenceEquals(this.SurnameField, value) != true)) {
                    this.SurnameField = value;
                    this.RaisePropertyChanged("Surname");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Review", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    public partial class Review : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private CRUDClient.ReviewsService.Person AuthorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MovieIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ScoreField;
        
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
        public CRUDClient.ReviewsService.Person Author {
            get {
                return this.AuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorField, value) != true)) {
                    this.AuthorField = value;
                    this.RaisePropertyChanged("Author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Content {
            get {
                return this.ContentField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentField, value) != true)) {
                    this.ContentField = value;
                    this.RaisePropertyChanged("Content");
                }
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
        public int MovieId {
            get {
                return this.MovieIdField;
            }
            set {
                if ((this.MovieIdField.Equals(value) != true)) {
                    this.MovieIdField = value;
                    this.RaisePropertyChanged("MovieId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Score {
            get {
                return this.ScoreField;
            }
            set {
                if ((this.ScoreField.Equals(value) != true)) {
                    this.ScoreField = value;
                    this.RaisePropertyChanged("Score");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ReviewsService.IReviewsService")]
    public interface IReviewsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewsService/GetAllAuthors", ReplyAction="http://tempuri.org/IReviewsService/GetAllAuthorsResponse")]
        System.Collections.Generic.List<CRUDClient.ReviewsService.Person> GetAllAuthors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewsService/GetAllAuthors", ReplyAction="http://tempuri.org/IReviewsService/GetAllAuthorsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<CRUDClient.ReviewsService.Person>> GetAllAuthorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewsService/AddAuthor", ReplyAction="http://tempuri.org/IReviewsService/AddAuthorResponse")]
        int AddAuthor(CRUDClient.ReviewsService.Person author);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewsService/AddAuthor", ReplyAction="http://tempuri.org/IReviewsService/AddAuthorResponse")]
        System.Threading.Tasks.Task<int> AddAuthorAsync(CRUDClient.ReviewsService.Person author);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewsService/GetAuthor", ReplyAction="http://tempuri.org/IReviewsService/GetAuthorResponse")]
        CRUDClient.ReviewsService.Person GetAuthor(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewsService/GetAuthor", ReplyAction="http://tempuri.org/IReviewsService/GetAuthorResponse")]
        System.Threading.Tasks.Task<CRUDClient.ReviewsService.Person> GetAuthorAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewsService/UpdateAuthor", ReplyAction="http://tempuri.org/IReviewsService/UpdateAuthorResponse")]
        CRUDClient.ReviewsService.Person UpdateAuthor(CRUDClient.ReviewsService.Person author);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewsService/UpdateAuthor", ReplyAction="http://tempuri.org/IReviewsService/UpdateAuthorResponse")]
        System.Threading.Tasks.Task<CRUDClient.ReviewsService.Person> UpdateAuthorAsync(CRUDClient.ReviewsService.Person author);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewsService/DeleteAuthor", ReplyAction="http://tempuri.org/IReviewsService/DeleteAuthorResponse")]
        bool DeleteAuthor(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewsService/DeleteAuthor", ReplyAction="http://tempuri.org/IReviewsService/DeleteAuthorResponse")]
        System.Threading.Tasks.Task<bool> DeleteAuthorAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewsService/GetAllReviews", ReplyAction="http://tempuri.org/IReviewsService/GetAllReviewsResponse")]
        System.Collections.Generic.List<CRUDClient.ReviewsService.Review> GetAllReviews();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewsService/GetAllReviews", ReplyAction="http://tempuri.org/IReviewsService/GetAllReviewsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<CRUDClient.ReviewsService.Review>> GetAllReviewsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewsService/AddReview", ReplyAction="http://tempuri.org/IReviewsService/AddReviewResponse")]
        int AddReview(CRUDClient.ReviewsService.Review review);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewsService/AddReview", ReplyAction="http://tempuri.org/IReviewsService/AddReviewResponse")]
        System.Threading.Tasks.Task<int> AddReviewAsync(CRUDClient.ReviewsService.Review review);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewsService/GetReview", ReplyAction="http://tempuri.org/IReviewsService/GetReviewResponse")]
        CRUDClient.ReviewsService.Review GetReview(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewsService/GetReview", ReplyAction="http://tempuri.org/IReviewsService/GetReviewResponse")]
        System.Threading.Tasks.Task<CRUDClient.ReviewsService.Review> GetReviewAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewsService/UpdateReview", ReplyAction="http://tempuri.org/IReviewsService/UpdateReviewResponse")]
        CRUDClient.ReviewsService.Review UpdateReview(CRUDClient.ReviewsService.Review review);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewsService/UpdateReview", ReplyAction="http://tempuri.org/IReviewsService/UpdateReviewResponse")]
        System.Threading.Tasks.Task<CRUDClient.ReviewsService.Review> UpdateReviewAsync(CRUDClient.ReviewsService.Review review);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewsService/DeleteReview", ReplyAction="http://tempuri.org/IReviewsService/DeleteReviewResponse")]
        bool DeleteReview(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewsService/DeleteReview", ReplyAction="http://tempuri.org/IReviewsService/DeleteReviewResponse")]
        System.Threading.Tasks.Task<bool> DeleteReviewAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IReviewsServiceChannel : CRUDClient.ReviewsService.IReviewsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReviewsServiceClient : System.ServiceModel.ClientBase<CRUDClient.ReviewsService.IReviewsService>, CRUDClient.ReviewsService.IReviewsService {
        
        public ReviewsServiceClient() {
        }
        
        public ReviewsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ReviewsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReviewsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReviewsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<CRUDClient.ReviewsService.Person> GetAllAuthors() {
            return base.Channel.GetAllAuthors();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<CRUDClient.ReviewsService.Person>> GetAllAuthorsAsync() {
            return base.Channel.GetAllAuthorsAsync();
        }
        
        public int AddAuthor(CRUDClient.ReviewsService.Person author) {
            return base.Channel.AddAuthor(author);
        }
        
        public System.Threading.Tasks.Task<int> AddAuthorAsync(CRUDClient.ReviewsService.Person author) {
            return base.Channel.AddAuthorAsync(author);
        }
        
        public CRUDClient.ReviewsService.Person GetAuthor(int id) {
            return base.Channel.GetAuthor(id);
        }
        
        public System.Threading.Tasks.Task<CRUDClient.ReviewsService.Person> GetAuthorAsync(int id) {
            return base.Channel.GetAuthorAsync(id);
        }
        
        public CRUDClient.ReviewsService.Person UpdateAuthor(CRUDClient.ReviewsService.Person author) {
            return base.Channel.UpdateAuthor(author);
        }
        
        public System.Threading.Tasks.Task<CRUDClient.ReviewsService.Person> UpdateAuthorAsync(CRUDClient.ReviewsService.Person author) {
            return base.Channel.UpdateAuthorAsync(author);
        }
        
        public bool DeleteAuthor(int id) {
            return base.Channel.DeleteAuthor(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAuthorAsync(int id) {
            return base.Channel.DeleteAuthorAsync(id);
        }
        
        public System.Collections.Generic.List<CRUDClient.ReviewsService.Review> GetAllReviews() {
            return base.Channel.GetAllReviews();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<CRUDClient.ReviewsService.Review>> GetAllReviewsAsync() {
            return base.Channel.GetAllReviewsAsync();
        }
        
        public int AddReview(CRUDClient.ReviewsService.Review review) {
            return base.Channel.AddReview(review);
        }
        
        public System.Threading.Tasks.Task<int> AddReviewAsync(CRUDClient.ReviewsService.Review review) {
            return base.Channel.AddReviewAsync(review);
        }
        
        public CRUDClient.ReviewsService.Review GetReview(int id) {
            return base.Channel.GetReview(id);
        }
        
        public System.Threading.Tasks.Task<CRUDClient.ReviewsService.Review> GetReviewAsync(int id) {
            return base.Channel.GetReviewAsync(id);
        }
        
        public CRUDClient.ReviewsService.Review UpdateReview(CRUDClient.ReviewsService.Review review) {
            return base.Channel.UpdateReview(review);
        }
        
        public System.Threading.Tasks.Task<CRUDClient.ReviewsService.Review> UpdateReviewAsync(CRUDClient.ReviewsService.Review review) {
            return base.Channel.UpdateReviewAsync(review);
        }
        
        public bool DeleteReview(int id) {
            return base.Channel.DeleteReview(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteReviewAsync(int id) {
            return base.Channel.DeleteReviewAsync(id);
        }
    }
}