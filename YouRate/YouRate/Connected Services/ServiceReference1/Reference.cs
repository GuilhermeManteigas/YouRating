﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YouRate.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Comments", Namespace="http://schemas.datacontract.org/2004/07/ServicoSoap")]
    [System.SerializableAttribute()]
    public partial class Comments : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Comments_CommentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Comments_DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Comments_IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Comments__Video_IdField;
        
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
        public string Comments_Comments {
            get {
                return this.Comments_CommentsField;
            }
            set {
                if ((object.ReferenceEquals(this.Comments_CommentsField, value) != true)) {
                    this.Comments_CommentsField = value;
                    this.RaisePropertyChanged("Comments_Comments");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Comments_Date {
            get {
                return this.Comments_DateField;
            }
            set {
                if ((this.Comments_DateField.Equals(value) != true)) {
                    this.Comments_DateField = value;
                    this.RaisePropertyChanged("Comments_Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Comments_Id {
            get {
                return this.Comments_IdField;
            }
            set {
                if ((this.Comments_IdField.Equals(value) != true)) {
                    this.Comments_IdField = value;
                    this.RaisePropertyChanged("Comments_Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Comments__Video_Id {
            get {
                return this.Comments__Video_IdField;
            }
            set {
                if ((this.Comments__Video_IdField.Equals(value) != true)) {
                    this.Comments__Video_IdField = value;
                    this.RaisePropertyChanged("Comments__Video_Id");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Ratings", Namespace="http://schemas.datacontract.org/2004/07/ServicoSoap")]
    [System.SerializableAttribute()]
    public partial class Ratings : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Ratings_IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Ratings_ScoreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Ratings_Video_IdField;
        
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
        public int Ratings_Id {
            get {
                return this.Ratings_IdField;
            }
            set {
                if ((this.Ratings_IdField.Equals(value) != true)) {
                    this.Ratings_IdField = value;
                    this.RaisePropertyChanged("Ratings_Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Ratings_Score {
            get {
                return this.Ratings_ScoreField;
            }
            set {
                if ((this.Ratings_ScoreField.Equals(value) != true)) {
                    this.Ratings_ScoreField = value;
                    this.RaisePropertyChanged("Ratings_Score");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Ratings_Video_Id {
            get {
                return this.Ratings_Video_IdField;
            }
            set {
                if ((this.Ratings_Video_IdField.Equals(value) != true)) {
                    this.Ratings_Video_IdField = value;
                    this.RaisePropertyChanged("Ratings_Video_Id");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Videos", Namespace="http://schemas.datacontract.org/2004/07/ServicoSoap")]
    [System.SerializableAttribute()]
    public partial class Videos : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Videos_DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Videos_DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Videos_IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Videos_NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Videos_URLField;
        
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
        public System.DateTime Videos_Date {
            get {
                return this.Videos_DateField;
            }
            set {
                if ((this.Videos_DateField.Equals(value) != true)) {
                    this.Videos_DateField = value;
                    this.RaisePropertyChanged("Videos_Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Videos_Description {
            get {
                return this.Videos_DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.Videos_DescriptionField, value) != true)) {
                    this.Videos_DescriptionField = value;
                    this.RaisePropertyChanged("Videos_Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Videos_Id {
            get {
                return this.Videos_IdField;
            }
            set {
                if ((this.Videos_IdField.Equals(value) != true)) {
                    this.Videos_IdField = value;
                    this.RaisePropertyChanged("Videos_Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Videos_Name {
            get {
                return this.Videos_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.Videos_NameField, value) != true)) {
                    this.Videos_NameField = value;
                    this.RaisePropertyChanged("Videos_Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Videos_URL {
            get {
                return this.Videos_URLField;
            }
            set {
                if ((object.ReferenceEquals(this.Videos_URLField, value) != true)) {
                    this.Videos_URLField = value;
                    this.RaisePropertyChanged("Videos_URL");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetComments", ReplyAction="http://tempuri.org/IService1/GetCommentsResponse")]
        YouRate.ServiceReference1.Comments[] GetComments();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetComments", ReplyAction="http://tempuri.org/IService1/GetCommentsResponse")]
        System.Threading.Tasks.Task<YouRate.ServiceReference1.Comments[]> GetCommentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetVideoComments", ReplyAction="http://tempuri.org/IService1/GetVideoCommentsResponse")]
        YouRate.ServiceReference1.Comments[] GetVideoComments(int videoId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetVideoComments", ReplyAction="http://tempuri.org/IService1/GetVideoCommentsResponse")]
        System.Threading.Tasks.Task<YouRate.ServiceReference1.Comments[]> GetVideoCommentsAsync(int videoId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetRatings", ReplyAction="http://tempuri.org/IService1/GetRatingsResponse")]
        YouRate.ServiceReference1.Ratings[] GetRatings();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetRatings", ReplyAction="http://tempuri.org/IService1/GetRatingsResponse")]
        System.Threading.Tasks.Task<YouRate.ServiceReference1.Ratings[]> GetRatingsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetVideoRatings", ReplyAction="http://tempuri.org/IService1/GetVideoRatingsResponse")]
        double GetVideoRatings(int videoId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetVideoRatings", ReplyAction="http://tempuri.org/IService1/GetVideoRatingsResponse")]
        System.Threading.Tasks.Task<double> GetVideoRatingsAsync(int videoId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetVideos", ReplyAction="http://tempuri.org/IService1/GetVideosResponse")]
        YouRate.ServiceReference1.Videos[] GetVideos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetVideos", ReplyAction="http://tempuri.org/IService1/GetVideosResponse")]
        System.Threading.Tasks.Task<YouRate.ServiceReference1.Videos[]> GetVideosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSingleVideo", ReplyAction="http://tempuri.org/IService1/GetSingleVideoResponse")]
        YouRate.ServiceReference1.Videos GetSingleVideo(string videoURL);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSingleVideo", ReplyAction="http://tempuri.org/IService1/GetSingleVideoResponse")]
        System.Threading.Tasks.Task<YouRate.ServiceReference1.Videos> GetSingleVideoAsync(string videoURL);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NewComment", ReplyAction="http://tempuri.org/IService1/NewCommentResponse")]
        void NewComment(string comment, int videoID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NewComment", ReplyAction="http://tempuri.org/IService1/NewCommentResponse")]
        System.Threading.Tasks.Task NewCommentAsync(string comment, int videoID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NewRating", ReplyAction="http://tempuri.org/IService1/NewRatingResponse")]
        void NewRating(int score, int videoID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NewRating", ReplyAction="http://tempuri.org/IService1/NewRatingResponse")]
        System.Threading.Tasks.Task NewRatingAsync(int score, int videoID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteComment", ReplyAction="http://tempuri.org/IService1/DeleteCommentResponse")]
        void DeleteComment(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteComment", ReplyAction="http://tempuri.org/IService1/DeleteCommentResponse")]
        System.Threading.Tasks.Task DeleteCommentAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NewVideo", ReplyAction="http://tempuri.org/IService1/NewVideoResponse")]
        void NewVideo(string name, string url, string description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NewVideo", ReplyAction="http://tempuri.org/IService1/NewVideoResponse")]
        System.Threading.Tasks.Task NewVideoAsync(string name, string url, string description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteVideo", ReplyAction="http://tempuri.org/IService1/DeleteVideoResponse")]
        void DeleteVideo(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteVideo", ReplyAction="http://tempuri.org/IService1/DeleteVideoResponse")]
        System.Threading.Tasks.Task DeleteVideoAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : YouRate.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<YouRate.ServiceReference1.IService1>, YouRate.ServiceReference1.IService1 {
        
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
        
        public YouRate.ServiceReference1.Comments[] GetComments() {
            return base.Channel.GetComments();
        }
        
        public System.Threading.Tasks.Task<YouRate.ServiceReference1.Comments[]> GetCommentsAsync() {
            return base.Channel.GetCommentsAsync();
        }
        
        public YouRate.ServiceReference1.Comments[] GetVideoComments(int videoId) {
            return base.Channel.GetVideoComments(videoId);
        }
        
        public System.Threading.Tasks.Task<YouRate.ServiceReference1.Comments[]> GetVideoCommentsAsync(int videoId) {
            return base.Channel.GetVideoCommentsAsync(videoId);
        }
        
        public YouRate.ServiceReference1.Ratings[] GetRatings() {
            return base.Channel.GetRatings();
        }
        
        public System.Threading.Tasks.Task<YouRate.ServiceReference1.Ratings[]> GetRatingsAsync() {
            return base.Channel.GetRatingsAsync();
        }
        
        public double GetVideoRatings(int videoId) {
            return base.Channel.GetVideoRatings(videoId);
        }
        
        public System.Threading.Tasks.Task<double> GetVideoRatingsAsync(int videoId) {
            return base.Channel.GetVideoRatingsAsync(videoId);
        }
        
        public YouRate.ServiceReference1.Videos[] GetVideos() {
            return base.Channel.GetVideos();
        }
        
        public System.Threading.Tasks.Task<YouRate.ServiceReference1.Videos[]> GetVideosAsync() {
            return base.Channel.GetVideosAsync();
        }
        
        public YouRate.ServiceReference1.Videos GetSingleVideo(string videoURL) {
            return base.Channel.GetSingleVideo(videoURL);
        }
        
        public System.Threading.Tasks.Task<YouRate.ServiceReference1.Videos> GetSingleVideoAsync(string videoURL) {
            return base.Channel.GetSingleVideoAsync(videoURL);
        }
        
        public void NewComment(string comment, int videoID) {
            base.Channel.NewComment(comment, videoID);
        }
        
        public System.Threading.Tasks.Task NewCommentAsync(string comment, int videoID) {
            return base.Channel.NewCommentAsync(comment, videoID);
        }
        
        public void NewRating(int score, int videoID) {
            base.Channel.NewRating(score, videoID);
        }
        
        public System.Threading.Tasks.Task NewRatingAsync(int score, int videoID) {
            return base.Channel.NewRatingAsync(score, videoID);
        }
        
        public void DeleteComment(int id) {
            base.Channel.DeleteComment(id);
        }
        
        public System.Threading.Tasks.Task DeleteCommentAsync(int id) {
            return base.Channel.DeleteCommentAsync(id);
        }
        
        public void NewVideo(string name, string url, string description) {
            base.Channel.NewVideo(name, url, description);
        }
        
        public System.Threading.Tasks.Task NewVideoAsync(string name, string url, string description) {
            return base.Channel.NewVideoAsync(name, url, description);
        }
        
        public void DeleteVideo(int id) {
            base.Channel.DeleteVideo(id);
        }
        
        public System.Threading.Tasks.Task DeleteVideoAsync(int id) {
            return base.Channel.DeleteVideoAsync(id);
        }
    }
}