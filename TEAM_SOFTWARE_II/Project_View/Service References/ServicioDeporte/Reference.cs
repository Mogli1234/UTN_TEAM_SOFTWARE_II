﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18010
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_View.ServicioDeporte {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioDeporte.IDeportesWebService")]
    public interface IDeportesWebService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDeportesWebService/createSport", ReplyAction="http://tempuri.org/IDeportesWebService/createSportResponse")]
        bool createSport(AccesoDatos.Modelo.deporte sport);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDeportesWebService/createSport", ReplyAction="http://tempuri.org/IDeportesWebService/createSportResponse")]
        System.Threading.Tasks.Task<bool> createSportAsync(AccesoDatos.Modelo.deporte sport);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDeportesWebService/ChargeSportsList", ReplyAction="http://tempuri.org/IDeportesWebService/ChargeSportsListResponse")]
        AccesoDatos.Sport[] ChargeSportsList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDeportesWebService/ChargeSportsList", ReplyAction="http://tempuri.org/IDeportesWebService/ChargeSportsListResponse")]
        System.Threading.Tasks.Task<AccesoDatos.Sport[]> ChargeSportsListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDeportesWebService/DeleteSport", ReplyAction="http://tempuri.org/IDeportesWebService/DeleteSportResponse")]
        bool DeleteSport(AccesoDatos.Modelo.deporte oSport);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDeportesWebService/DeleteSport", ReplyAction="http://tempuri.org/IDeportesWebService/DeleteSportResponse")]
        System.Threading.Tasks.Task<bool> DeleteSportAsync(AccesoDatos.Modelo.deporte oSport);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDeportesWebServiceChannel : Project_View.ServicioDeporte.IDeportesWebService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DeportesWebServiceClient : System.ServiceModel.ClientBase<Project_View.ServicioDeporte.IDeportesWebService>, Project_View.ServicioDeporte.IDeportesWebService {
        
        public DeportesWebServiceClient() {
        }
        
        public DeportesWebServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DeportesWebServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DeportesWebServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DeportesWebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool createSport(AccesoDatos.Modelo.deporte sport) {
            return base.Channel.createSport(sport);
        }
        
        public System.Threading.Tasks.Task<bool> createSportAsync(AccesoDatos.Modelo.deporte sport) {
            return base.Channel.createSportAsync(sport);
        }
        
        public AccesoDatos.Sport[] ChargeSportsList() {
            return base.Channel.ChargeSportsList();
        }
        
        public System.Threading.Tasks.Task<AccesoDatos.Sport[]> ChargeSportsListAsync() {
            return base.Channel.ChargeSportsListAsync();
        }
        
        public bool DeleteSport(AccesoDatos.Modelo.deporte oSport) {
            return base.Channel.DeleteSport(oSport);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteSportAsync(AccesoDatos.Modelo.deporte oSport) {
            return base.Channel.DeleteSportAsync(oSport);
        }
    }
}
