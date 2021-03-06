﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client_JobQ.JobQService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Machine", Namespace="http://schemas.datacontract.org/2004/07/JobQ")]
    [System.SerializableAttribute()]
    public partial class Machine : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ConfigValuesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IpAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;
        
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
        public string ConfigValues {
            get {
                return this.ConfigValuesField;
            }
            set {
                if ((object.ReferenceEquals(this.ConfigValuesField, value) != true)) {
                    this.ConfigValuesField = value;
                    this.RaisePropertyChanged("ConfigValues");
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
        public string IpAddress {
            get {
                return this.IpAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.IpAddressField, value) != true)) {
                    this.IpAddressField = value;
                    this.RaisePropertyChanged("IpAddress");
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
        public string Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Job", Namespace="http://schemas.datacontract.org/2004/07/JobQ")]
    [System.SerializableAttribute()]
    public partial class Job : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ArgumentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CmdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client_JobQ.JobQService.Machine CreatingMachineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CreatingMachineIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CreatingUserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateCreatedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateExecutedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client_JobQ.JobQService.Machine ExecutionMachineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> ExecutionMachineIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;
        
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
        public string Arguments {
            get {
                return this.ArgumentsField;
            }
            set {
                if ((object.ReferenceEquals(this.ArgumentsField, value) != true)) {
                    this.ArgumentsField = value;
                    this.RaisePropertyChanged("Arguments");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cmd {
            get {
                return this.CmdField;
            }
            set {
                if ((object.ReferenceEquals(this.CmdField, value) != true)) {
                    this.CmdField = value;
                    this.RaisePropertyChanged("Cmd");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client_JobQ.JobQService.Machine CreatingMachine {
            get {
                return this.CreatingMachineField;
            }
            set {
                if ((object.ReferenceEquals(this.CreatingMachineField, value) != true)) {
                    this.CreatingMachineField = value;
                    this.RaisePropertyChanged("CreatingMachine");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CreatingMachineId {
            get {
                return this.CreatingMachineIdField;
            }
            set {
                if ((this.CreatingMachineIdField.Equals(value) != true)) {
                    this.CreatingMachineIdField = value;
                    this.RaisePropertyChanged("CreatingMachineId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CreatingUser {
            get {
                return this.CreatingUserField;
            }
            set {
                if ((object.ReferenceEquals(this.CreatingUserField, value) != true)) {
                    this.CreatingUserField = value;
                    this.RaisePropertyChanged("CreatingUser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateCreated {
            get {
                return this.DateCreatedField;
            }
            set {
                if ((this.DateCreatedField.Equals(value) != true)) {
                    this.DateCreatedField = value;
                    this.RaisePropertyChanged("DateCreated");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateExecuted {
            get {
                return this.DateExecutedField;
            }
            set {
                if ((this.DateExecutedField.Equals(value) != true)) {
                    this.DateExecutedField = value;
                    this.RaisePropertyChanged("DateExecuted");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client_JobQ.JobQService.Machine ExecutionMachine {
            get {
                return this.ExecutionMachineField;
            }
            set {
                if ((object.ReferenceEquals(this.ExecutionMachineField, value) != true)) {
                    this.ExecutionMachineField = value;
                    this.RaisePropertyChanged("ExecutionMachine");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ExecutionMachineId {
            get {
                return this.ExecutionMachineIdField;
            }
            set {
                if ((this.ExecutionMachineIdField.Equals(value) != true)) {
                    this.ExecutionMachineIdField = value;
                    this.RaisePropertyChanged("ExecutionMachineId");
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
        public string Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="JobQService.ICourier")]
    public interface ICourier {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourier/DispatchJob", ReplyAction="http://tempuri.org/ICourier/DispatchJobResponse")]
        Client_JobQ.JobQService.Job DispatchJob(Client_JobQ.JobQService.Machine requestingClient);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourier/DispatchJob", ReplyAction="http://tempuri.org/ICourier/DispatchJobResponse")]
        System.Threading.Tasks.Task<Client_JobQ.JobQService.Job> DispatchJobAsync(Client_JobQ.JobQService.Machine requestingClient);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourier/ReturnJob", ReplyAction="http://tempuri.org/ICourier/ReturnJobResponse")]
        string ReturnJob(Client_JobQ.JobQService.Job job);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourier/ReturnJob", ReplyAction="http://tempuri.org/ICourier/ReturnJobResponse")]
        System.Threading.Tasks.Task<string> ReturnJobAsync(Client_JobQ.JobQService.Job job);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICourierChannel : Client_JobQ.JobQService.ICourier, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CourierClient : System.ServiceModel.ClientBase<Client_JobQ.JobQService.ICourier>, Client_JobQ.JobQService.ICourier {
        
        public CourierClient() {
        }
        
        public CourierClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CourierClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CourierClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CourierClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client_JobQ.JobQService.Job DispatchJob(Client_JobQ.JobQService.Machine requestingClient) {
            return base.Channel.DispatchJob(requestingClient);
        }
        
        public System.Threading.Tasks.Task<Client_JobQ.JobQService.Job> DispatchJobAsync(Client_JobQ.JobQService.Machine requestingClient) {
            return base.Channel.DispatchJobAsync(requestingClient);
        }
        
        public string ReturnJob(Client_JobQ.JobQService.Job job) {
            return base.Channel.ReturnJob(job);
        }
        
        public System.Threading.Tasks.Task<string> ReturnJobAsync(Client_JobQ.JobQService.Job job) {
            return base.Channel.ReturnJobAsync(job);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="JobQService.IJobManager")]
    public interface IJobManager {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobManager/CreateJob", ReplyAction="http://tempuri.org/IJobManager/CreateJobResponse")]
        Client_JobQ.JobQService.Job CreateJob(string cmd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobManager/CreateJob", ReplyAction="http://tempuri.org/IJobManager/CreateJobResponse")]
        System.Threading.Tasks.Task<Client_JobQ.JobQService.Job> CreateJobAsync(string cmd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobManager/CreateJobWithName", ReplyAction="http://tempuri.org/IJobManager/CreateJobWithNameResponse")]
        Client_JobQ.JobQService.Job CreateJobWithName(string cmd, string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobManager/CreateJobWithName", ReplyAction="http://tempuri.org/IJobManager/CreateJobWithNameResponse")]
        System.Threading.Tasks.Task<Client_JobQ.JobQService.Job> CreateJobWithNameAsync(string cmd, string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobManager/CreateJobRange", ReplyAction="http://tempuri.org/IJobManager/CreateJobRangeResponse")]
        Client_JobQ.JobQService.Job[] CreateJobRange(string[] cmds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobManager/CreateJobRange", ReplyAction="http://tempuri.org/IJobManager/CreateJobRangeResponse")]
        System.Threading.Tasks.Task<Client_JobQ.JobQService.Job[]> CreateJobRangeAsync(string[] cmds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobManager/GetJob", ReplyAction="http://tempuri.org/IJobManager/GetJobResponse")]
        Client_JobQ.JobQService.Job GetJob(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobManager/GetJob", ReplyAction="http://tempuri.org/IJobManager/GetJobResponse")]
        System.Threading.Tasks.Task<Client_JobQ.JobQService.Job> GetJobAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobManager/GetAllJobs", ReplyAction="http://tempuri.org/IJobManager/GetAllJobsResponse")]
        Client_JobQ.JobQService.Job[] GetAllJobs();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobManager/GetAllJobs", ReplyAction="http://tempuri.org/IJobManager/GetAllJobsResponse")]
        System.Threading.Tasks.Task<Client_JobQ.JobQService.Job[]> GetAllJobsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobManager/GetAllExecutedJobs", ReplyAction="http://tempuri.org/IJobManager/GetAllExecutedJobsResponse")]
        Client_JobQ.JobQService.Job[] GetAllExecutedJobs();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobManager/GetAllExecutedJobs", ReplyAction="http://tempuri.org/IJobManager/GetAllExecutedJobsResponse")]
        System.Threading.Tasks.Task<Client_JobQ.JobQService.Job[]> GetAllExecutedJobsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobManager/GetAllUnexecutedJobs", ReplyAction="http://tempuri.org/IJobManager/GetAllUnexecutedJobsResponse")]
        Client_JobQ.JobQService.Job[] GetAllUnexecutedJobs();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobManager/GetAllUnexecutedJobs", ReplyAction="http://tempuri.org/IJobManager/GetAllUnexecutedJobsResponse")]
        System.Threading.Tasks.Task<Client_JobQ.JobQService.Job[]> GetAllUnexecutedJobsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobManager/UpdateJob", ReplyAction="http://tempuri.org/IJobManager/UpdateJobResponse")]
        Client_JobQ.JobQService.Job UpdateJob(int id, string cmd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobManager/UpdateJob", ReplyAction="http://tempuri.org/IJobManager/UpdateJobResponse")]
        System.Threading.Tasks.Task<Client_JobQ.JobQService.Job> UpdateJobAsync(int id, string cmd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobManager/UpdateJobWithName", ReplyAction="http://tempuri.org/IJobManager/UpdateJobWithNameResponse")]
        Client_JobQ.JobQService.Job UpdateJobWithName(int id, string cmd, string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobManager/UpdateJobWithName", ReplyAction="http://tempuri.org/IJobManager/UpdateJobWithNameResponse")]
        System.Threading.Tasks.Task<Client_JobQ.JobQService.Job> UpdateJobWithNameAsync(int id, string cmd, string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobManager/DeleteJob", ReplyAction="http://tempuri.org/IJobManager/DeleteJobResponse")]
        void DeleteJob(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobManager/DeleteJob", ReplyAction="http://tempuri.org/IJobManager/DeleteJobResponse")]
        System.Threading.Tasks.Task DeleteJobAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IJobManagerChannel : Client_JobQ.JobQService.IJobManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class JobManagerClient : System.ServiceModel.ClientBase<Client_JobQ.JobQService.IJobManager>, Client_JobQ.JobQService.IJobManager {
        
        public JobManagerClient() {
        }
        
        public JobManagerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public JobManagerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JobManagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JobManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client_JobQ.JobQService.Job CreateJob(string cmd) {
            return base.Channel.CreateJob(cmd);
        }
        
        public System.Threading.Tasks.Task<Client_JobQ.JobQService.Job> CreateJobAsync(string cmd) {
            return base.Channel.CreateJobAsync(cmd);
        }
        
        public Client_JobQ.JobQService.Job CreateJobWithName(string cmd, string username) {
            return base.Channel.CreateJobWithName(cmd, username);
        }
        
        public System.Threading.Tasks.Task<Client_JobQ.JobQService.Job> CreateJobWithNameAsync(string cmd, string username) {
            return base.Channel.CreateJobWithNameAsync(cmd, username);
        }
        
        public Client_JobQ.JobQService.Job[] CreateJobRange(string[] cmds) {
            return base.Channel.CreateJobRange(cmds);
        }
        
        public System.Threading.Tasks.Task<Client_JobQ.JobQService.Job[]> CreateJobRangeAsync(string[] cmds) {
            return base.Channel.CreateJobRangeAsync(cmds);
        }
        
        public Client_JobQ.JobQService.Job GetJob(int id) {
            return base.Channel.GetJob(id);
        }
        
        public System.Threading.Tasks.Task<Client_JobQ.JobQService.Job> GetJobAsync(int id) {
            return base.Channel.GetJobAsync(id);
        }
        
        public Client_JobQ.JobQService.Job[] GetAllJobs() {
            return base.Channel.GetAllJobs();
        }
        
        public System.Threading.Tasks.Task<Client_JobQ.JobQService.Job[]> GetAllJobsAsync() {
            return base.Channel.GetAllJobsAsync();
        }
        
        public Client_JobQ.JobQService.Job[] GetAllExecutedJobs() {
            return base.Channel.GetAllExecutedJobs();
        }
        
        public System.Threading.Tasks.Task<Client_JobQ.JobQService.Job[]> GetAllExecutedJobsAsync() {
            return base.Channel.GetAllExecutedJobsAsync();
        }
        
        public Client_JobQ.JobQService.Job[] GetAllUnexecutedJobs() {
            return base.Channel.GetAllUnexecutedJobs();
        }
        
        public System.Threading.Tasks.Task<Client_JobQ.JobQService.Job[]> GetAllUnexecutedJobsAsync() {
            return base.Channel.GetAllUnexecutedJobsAsync();
        }
        
        public Client_JobQ.JobQService.Job UpdateJob(int id, string cmd) {
            return base.Channel.UpdateJob(id, cmd);
        }
        
        public System.Threading.Tasks.Task<Client_JobQ.JobQService.Job> UpdateJobAsync(int id, string cmd) {
            return base.Channel.UpdateJobAsync(id, cmd);
        }
        
        public Client_JobQ.JobQService.Job UpdateJobWithName(int id, string cmd, string username) {
            return base.Channel.UpdateJobWithName(id, cmd, username);
        }
        
        public System.Threading.Tasks.Task<Client_JobQ.JobQService.Job> UpdateJobWithNameAsync(int id, string cmd, string username) {
            return base.Channel.UpdateJobWithNameAsync(id, cmd, username);
        }
        
        public void DeleteJob(int id) {
            base.Channel.DeleteJob(id);
        }
        
        public System.Threading.Tasks.Task DeleteJobAsync(int id) {
            return base.Channel.DeleteJobAsync(id);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="JobQService.IClientManager")]
    public interface IClientManager {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientManager/GetClient", ReplyAction="http://tempuri.org/IClientManager/GetClientResponse")]
        Client_JobQ.JobQService.Machine GetClient(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientManager/GetClient", ReplyAction="http://tempuri.org/IClientManager/GetClientResponse")]
        System.Threading.Tasks.Task<Client_JobQ.JobQService.Machine> GetClientAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientManager/GetAllClients", ReplyAction="http://tempuri.org/IClientManager/GetAllClientsResponse")]
        Client_JobQ.JobQService.Machine[] GetAllClients();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientManager/GetAllClients", ReplyAction="http://tempuri.org/IClientManager/GetAllClientsResponse")]
        System.Threading.Tasks.Task<Client_JobQ.JobQService.Machine[]> GetAllClientsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientManager/DeleteClient", ReplyAction="http://tempuri.org/IClientManager/DeleteClientResponse")]
        void DeleteClient(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientManager/DeleteClient", ReplyAction="http://tempuri.org/IClientManager/DeleteClientResponse")]
        System.Threading.Tasks.Task DeleteClientAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientManager/CreateClient", ReplyAction="http://tempuri.org/IClientManager/CreateClientResponse")]
        Client_JobQ.JobQService.Machine CreateClient(Client_JobQ.JobQService.Machine client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientManager/CreateClient", ReplyAction="http://tempuri.org/IClientManager/CreateClientResponse")]
        System.Threading.Tasks.Task<Client_JobQ.JobQService.Machine> CreateClientAsync(Client_JobQ.JobQService.Machine client);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClientManagerChannel : Client_JobQ.JobQService.IClientManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClientManagerClient : System.ServiceModel.ClientBase<Client_JobQ.JobQService.IClientManager>, Client_JobQ.JobQService.IClientManager {
        
        public ClientManagerClient() {
        }
        
        public ClientManagerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClientManagerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientManagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client_JobQ.JobQService.Machine GetClient(int id) {
            return base.Channel.GetClient(id);
        }
        
        public System.Threading.Tasks.Task<Client_JobQ.JobQService.Machine> GetClientAsync(int id) {
            return base.Channel.GetClientAsync(id);
        }
        
        public Client_JobQ.JobQService.Machine[] GetAllClients() {
            return base.Channel.GetAllClients();
        }
        
        public System.Threading.Tasks.Task<Client_JobQ.JobQService.Machine[]> GetAllClientsAsync() {
            return base.Channel.GetAllClientsAsync();
        }
        
        public void DeleteClient(int id) {
            base.Channel.DeleteClient(id);
        }
        
        public System.Threading.Tasks.Task DeleteClientAsync(int id) {
            return base.Channel.DeleteClientAsync(id);
        }
        
        public Client_JobQ.JobQService.Machine CreateClient(Client_JobQ.JobQService.Machine client) {
            return base.Channel.CreateClient(client);
        }
        
        public System.Threading.Tasks.Task<Client_JobQ.JobQService.Machine> CreateClientAsync(Client_JobQ.JobQService.Machine client) {
            return base.Channel.CreateClientAsync(client);
        }
    }
}
