﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.431
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EcodexIntegrationSample.SrvRepository {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ComprobanteEstatus", Namespace="http://Ecodex.WS.Model/2011/CFDI")]
    [System.SerializableAttribute()]
    public partial class ComprobanteEstatus : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string UUIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime UltimaActualizacionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string UUID {
            get {
                return this.UUIDField;
            }
            set {
                if ((object.ReferenceEquals(this.UUIDField, value) != true)) {
                    this.UUIDField = value;
                    this.RaisePropertyChanged("UUID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public string Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoField, value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public System.DateTime UltimaActualizacion {
            get {
                return this.UltimaActualizacionField;
            }
            set {
                if ((this.UltimaActualizacionField.Equals(value) != true)) {
                    this.UltimaActualizacionField = value;
                    this.RaisePropertyChanged("UltimaActualizacion");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FallaServicio", Namespace="http://Ecodex.WS.Model/2011/CFDI")]
    [System.SerializableAttribute()]
    public partial class FallaServicio : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string RFCField;
        
        private int NumeroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EventoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string RFC {
            get {
                return this.RFCField;
            }
            set {
                if ((object.ReferenceEquals(this.RFCField, value) != true)) {
                    this.RFCField = value;
                    this.RaisePropertyChanged("RFC");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public int Numero {
            get {
                return this.NumeroField;
            }
            set {
                if ((this.NumeroField.Equals(value) != true)) {
                    this.NumeroField = value;
                    this.RaisePropertyChanged("Numero");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public string Evento {
            get {
                return this.EventoField;
            }
            set {
                if ((object.ReferenceEquals(this.EventoField, value) != true)) {
                    this.EventoField = value;
                    this.RaisePropertyChanged("Evento");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FallaSesion", Namespace="http://Ecodex.WS.Model/2011/CFDI")]
    [System.SerializableAttribute()]
    public partial class FallaSesion : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string RFCField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EstatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string RFC {
            get {
                return this.RFCField;
            }
            set {
                if ((object.ReferenceEquals(this.RFCField, value) != true)) {
                    this.RFCField = value;
                    this.RaisePropertyChanged("RFC");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int Estatus {
            get {
                return this.EstatusField;
            }
            set {
                if ((this.EstatusField.Equals(value) != true)) {
                    this.EstatusField = value;
                    this.RaisePropertyChanged("Estatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ComprobanteXML", Namespace="http://Ecodex.WS.Model/2011/CFDI")]
    [System.SerializableAttribute()]
    public partial class ComprobanteXML : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DatosXMLField;
        
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
        public string DatosXML {
            get {
                return this.DatosXMLField;
            }
            set {
                if ((object.ReferenceEquals(this.DatosXMLField, value) != true)) {
                    this.DatosXMLField = value;
                    this.RaisePropertyChanged("DatosXML");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="InformacionQR", Namespace="http://Ecodex.WS.Model/2011/CFDI")]
    [System.SerializableAttribute()]
    public partial class InformacionQR : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ImagenField;
        
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
        public byte[] Imagen {
            get {
                return this.ImagenField;
            }
            set {
                if ((object.ReferenceEquals(this.ImagenField, value) != true)) {
                    this.ImagenField = value;
                    this.RaisePropertyChanged("Imagen");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Ecodex.WS.Model/2011/CFDI", ConfigurationName="SrvRepository.Repositorio")]
    public interface Repositorio {
        
        // CODEGEN: Generating message contract since the wrapper name (SolicitudEstatusComprobante) of message SolicitudEstatusComprobante does not match the default value (EstatusComprobante)
        [System.ServiceModel.OperationContractAttribute(Action="http://Ecodex.WS.Model/2011/CFDI/ServicioRepositorio/EstatusComprobante", ReplyAction="http://Ecodex.WS.Model/2011/CFDI/Repositorio/EstatusComprobanteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EcodexIntegrationSample.SrvRepository.FallaServicio), Action="http://Ecodex.WS.Model/2011/CFDI/Repositorio/EstatusComprobanteFallaServicioFault" +
            "", Name="FallaServicio")]
        [System.ServiceModel.FaultContractAttribute(typeof(EcodexIntegrationSample.SrvRepository.FallaSesion), Action="http://Ecodex.WS.Model/2011/CFDI/Repositorio/EstatusComprobanteFallaSesionFault", Name="FallaSesion")]
        EcodexIntegrationSample.SrvRepository.RespuestaEstatusComprobante EstatusComprobante(EcodexIntegrationSample.SrvRepository.SolicitudEstatusComprobante request);
        
        // CODEGEN: Generating message contract since the wrapper name (SolicitudObtenerComprobante) of message SolicitudObtenerComprobante does not match the default value (ObtenerComprobante)
        [System.ServiceModel.OperationContractAttribute(Action="http://Ecodex.WS.Model/2011/CFDI/Repositorio/ObtenerComprobante", ReplyAction="http://Ecodex.WS.Model/2011/CFDI/Repositorio/ObtenerComprobanteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EcodexIntegrationSample.SrvRepository.FallaServicio), Action="http://Ecodex.WS.Model/2011/CFDI/Repositorio/ObtenerComprobanteFallaServicioFault" +
            "", Name="FallaServicio")]
        [System.ServiceModel.FaultContractAttribute(typeof(EcodexIntegrationSample.SrvRepository.FallaSesion), Action="http://Ecodex.WS.Model/2011/CFDI/Repositorio/ObtenerComprobanteFallaSesionFault", Name="FallaSesion")]
        EcodexIntegrationSample.SrvRepository.RespuestaObtenerComprobante ObtenerComprobante(EcodexIntegrationSample.SrvRepository.SolicitudObtenerComprobante request);
        
        // CODEGEN: Generating message contract since the wrapper name (SolicitudCancelaComprobante) of message SolicitudCancelaComprobante does not match the default value (CancelaComprobante)
        [System.ServiceModel.OperationContractAttribute(Action="http://Ecodex.WS.Model/2011/CFDI/ServicioRepositorio/CancelaComprobante", ReplyAction="http://Ecodex.WS.Model/2011/CFDI/Repositorio/CancelaComprobanteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EcodexIntegrationSample.SrvRepository.FallaSesion), Action="http://Ecodex.WS.Model/2011/CFDI/Repositorio/CancelaComprobanteFallaSesionFault", Name="FallaSesion")]
        [System.ServiceModel.FaultContractAttribute(typeof(EcodexIntegrationSample.SrvRepository.FallaServicio), Action="http://Ecodex.WS.Model/2011/CFDI/Repositorio/CancelaComprobanteFallaServicioFault" +
            "", Name="FallaServicio")]
        EcodexIntegrationSample.SrvRepository.RespuestaCancelaComprobante CancelaComprobante(EcodexIntegrationSample.SrvRepository.SolicitudCancelaComprobante request);
        
        // CODEGEN: Generating message contract since the wrapper name (SolicitudObtenerQR) of message SolicitudObtenerQR does not match the default value (ObtenerQR)
        [System.ServiceModel.OperationContractAttribute(Action="http://Ecodex.WS.Model/2011/CFDI/Repositorio/ObtenerQR", ReplyAction="http://Ecodex.WS.Model/2011/CFDI/Repositorio/ObtenerQRResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EcodexIntegrationSample.SrvRepository.FallaServicio), Action="http://Ecodex.WS.Model/2011/CFDI/Repositorio/ObtenerQRFallaServicioFault", Name="FallaServicio")]
        [System.ServiceModel.FaultContractAttribute(typeof(EcodexIntegrationSample.SrvRepository.FallaSesion), Action="http://Ecodex.WS.Model/2011/CFDI/Repositorio/ObtenerQRFallaSesionFault", Name="FallaSesion")]
        EcodexIntegrationSample.SrvRepository.RespuestaObtenerQR ObtenerQR(EcodexIntegrationSample.SrvRepository.SolicitudObtenerQR request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SolicitudEstatusComprobante", WrapperNamespace="http://Ecodex.WS.Model/2011/CFDI", IsWrapped=true)]
    public partial class SolicitudEstatusComprobante {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ecodex.WS.Model/2011/CFDI", Order=0)]
        public string RFC;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ecodex.WS.Model/2011/CFDI", Order=1)]
        public string Token;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ecodex.WS.Model/2011/CFDI", Order=2)]
        public long TransaccionID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ecodex.WS.Model/2011/CFDI", Order=3)]
        public long TransaccionOriginal;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ecodex.WS.Model/2011/CFDI", Order=4)]
        public string UUID;
        
        public SolicitudEstatusComprobante() {
        }
        
        public SolicitudEstatusComprobante(string RFC, string Token, long TransaccionID, long TransaccionOriginal, string UUID) {
            this.RFC = RFC;
            this.Token = Token;
            this.TransaccionID = TransaccionID;
            this.TransaccionOriginal = TransaccionOriginal;
            this.UUID = UUID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RespuestaEstatusComprobante", WrapperNamespace="http://Ecodex.WS.Model/2011/CFDI", IsWrapped=true)]
    public partial class RespuestaEstatusComprobante {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ecodex.WS.Model/2011/CFDI", Order=0)]
        public EcodexIntegrationSample.SrvRepository.ComprobanteEstatus Estatus;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ecodex.WS.Model/2011/CFDI", Order=1)]
        public long TransaccionID;
        
        public RespuestaEstatusComprobante() {
        }
        
        public RespuestaEstatusComprobante(EcodexIntegrationSample.SrvRepository.ComprobanteEstatus Estatus, long TransaccionID) {
            this.Estatus = Estatus;
            this.TransaccionID = TransaccionID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SolicitudObtenerComprobante", WrapperNamespace="http://Ecodex.WS.Model/2011/CFDI", IsWrapped=true)]
    public partial class SolicitudObtenerComprobante {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ecodex.WS.Model/2011/CFDI", Order=0)]
        public string RFC;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ecodex.WS.Model/2011/CFDI", Order=1)]
        public string Token;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ecodex.WS.Model/2011/CFDI", Order=2)]
        public long TransaccionID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ecodex.WS.Model/2011/CFDI", Order=3)]
        public long TransaccionOriginal;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ecodex.WS.Model/2011/CFDI", Order=4)]
        public string UUID;
        
        public SolicitudObtenerComprobante() {
        }
        
        public SolicitudObtenerComprobante(string RFC, string Token, long TransaccionID, long TransaccionOriginal, string UUID) {
            this.RFC = RFC;
            this.Token = Token;
            this.TransaccionID = TransaccionID;
            this.TransaccionOriginal = TransaccionOriginal;
            this.UUID = UUID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RespuestaObtenerComprobante", WrapperNamespace="http://Ecodex.WS.Model/2011/CFDI", IsWrapped=true)]
    public partial class RespuestaObtenerComprobante {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ecodex.WS.Model/2011/CFDI", Order=0)]
        public EcodexIntegrationSample.SrvRepository.ComprobanteXML ComprobanteXML;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ecodex.WS.Model/2011/CFDI", Order=1)]
        public long TransaccionID;
        
        public RespuestaObtenerComprobante() {
        }
        
        public RespuestaObtenerComprobante(EcodexIntegrationSample.SrvRepository.ComprobanteXML ComprobanteXML, long TransaccionID) {
            this.ComprobanteXML = ComprobanteXML;
            this.TransaccionID = TransaccionID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SolicitudCancelaComprobante", WrapperNamespace="http://Ecodex.WS.Model/2011/CFDI", IsWrapped=true)]
    public partial class SolicitudCancelaComprobante {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ecodex.WS.Model/2011/CFDI", Order=0)]
        public string RFC;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ecodex.WS.Model/2011/CFDI", Order=1)]
        public string Token;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ecodex.WS.Model/2011/CFDI", Order=2)]
        public long TransaccionID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ecodex.WS.Model/2011/CFDI", Order=3)]
        public string UUID;
        
        public SolicitudCancelaComprobante() {
        }
        
        public SolicitudCancelaComprobante(string RFC, string Token, long TransaccionID, string UUID) {
            this.RFC = RFC;
            this.Token = Token;
            this.TransaccionID = TransaccionID;
            this.UUID = UUID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RespuestaCancelaComprobante", WrapperNamespace="http://Ecodex.WS.Model/2011/CFDI", IsWrapped=true)]
    public partial class RespuestaCancelaComprobante {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ecodex.WS.Model/2011/CFDI", Order=0)]
        public bool Cancelada;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ecodex.WS.Model/2011/CFDI", Order=1)]
        public long TransaccionID;
        
        public RespuestaCancelaComprobante() {
        }
        
        public RespuestaCancelaComprobante(bool Cancelada, long TransaccionID) {
            this.Cancelada = Cancelada;
            this.TransaccionID = TransaccionID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SolicitudObtenerQR", WrapperNamespace="http://Ecodex.WS.Model/2011/CFDI", IsWrapped=true)]
    public partial class SolicitudObtenerQR {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ecodex.WS.Model/2011/CFDI", Order=0)]
        public string RFC;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ecodex.WS.Model/2011/CFDI", Order=1)]
        public string Token;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ecodex.WS.Model/2011/CFDI", Order=2)]
        public long TransaccionID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ecodex.WS.Model/2011/CFDI", Order=3)]
        public string UUID;
        
        public SolicitudObtenerQR() {
        }
        
        public SolicitudObtenerQR(string RFC, string Token, long TransaccionID, string UUID) {
            this.RFC = RFC;
            this.Token = Token;
            this.TransaccionID = TransaccionID;
            this.UUID = UUID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RespuestaObtenerQR", WrapperNamespace="http://Ecodex.WS.Model/2011/CFDI", IsWrapped=true)]
    public partial class RespuestaObtenerQR {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ecodex.WS.Model/2011/CFDI", Order=0)]
        public EcodexIntegrationSample.SrvRepository.InformacionQR QR;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ecodex.WS.Model/2011/CFDI", Order=1)]
        public long TransaccionID;
        
        public RespuestaObtenerQR() {
        }
        
        public RespuestaObtenerQR(EcodexIntegrationSample.SrvRepository.InformacionQR QR, long TransaccionID) {
            this.QR = QR;
            this.TransaccionID = TransaccionID;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface RepositorioChannel : EcodexIntegrationSample.SrvRepository.Repositorio, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RepositorioClient : System.ServiceModel.ClientBase<EcodexIntegrationSample.SrvRepository.Repositorio>, EcodexIntegrationSample.SrvRepository.Repositorio {
        
        public RepositorioClient() {
        }
        
        public RepositorioClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RepositorioClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RepositorioClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RepositorioClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EcodexIntegrationSample.SrvRepository.RespuestaEstatusComprobante EcodexIntegrationSample.SrvRepository.Repositorio.EstatusComprobante(EcodexIntegrationSample.SrvRepository.SolicitudEstatusComprobante request) {
            return base.Channel.EstatusComprobante(request);
        }
        
        public EcodexIntegrationSample.SrvRepository.ComprobanteEstatus EstatusComprobante(string RFC, string Token, ref long TransaccionID, long TransaccionOriginal, string UUID) {
            EcodexIntegrationSample.SrvRepository.SolicitudEstatusComprobante inValue = new EcodexIntegrationSample.SrvRepository.SolicitudEstatusComprobante();
            inValue.RFC = RFC;
            inValue.Token = Token;
            inValue.TransaccionID = TransaccionID;
            inValue.TransaccionOriginal = TransaccionOriginal;
            inValue.UUID = UUID;
            EcodexIntegrationSample.SrvRepository.RespuestaEstatusComprobante retVal = ((EcodexIntegrationSample.SrvRepository.Repositorio)(this)).EstatusComprobante(inValue);
            TransaccionID = retVal.TransaccionID;
            return retVal.Estatus;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EcodexIntegrationSample.SrvRepository.RespuestaObtenerComprobante EcodexIntegrationSample.SrvRepository.Repositorio.ObtenerComprobante(EcodexIntegrationSample.SrvRepository.SolicitudObtenerComprobante request) {
            return base.Channel.ObtenerComprobante(request);
        }
        
        public EcodexIntegrationSample.SrvRepository.ComprobanteXML ObtenerComprobante(string RFC, string Token, ref long TransaccionID, long TransaccionOriginal, string UUID) {
            EcodexIntegrationSample.SrvRepository.SolicitudObtenerComprobante inValue = new EcodexIntegrationSample.SrvRepository.SolicitudObtenerComprobante();
            inValue.RFC = RFC;
            inValue.Token = Token;
            inValue.TransaccionID = TransaccionID;
            inValue.TransaccionOriginal = TransaccionOriginal;
            inValue.UUID = UUID;
            EcodexIntegrationSample.SrvRepository.RespuestaObtenerComprobante retVal = ((EcodexIntegrationSample.SrvRepository.Repositorio)(this)).ObtenerComprobante(inValue);
            TransaccionID = retVal.TransaccionID;
            return retVal.ComprobanteXML;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EcodexIntegrationSample.SrvRepository.RespuestaCancelaComprobante EcodexIntegrationSample.SrvRepository.Repositorio.CancelaComprobante(EcodexIntegrationSample.SrvRepository.SolicitudCancelaComprobante request) {
            return base.Channel.CancelaComprobante(request);
        }
        
        public bool CancelaComprobante(string RFC, string Token, ref long TransaccionID, string UUID) {
            EcodexIntegrationSample.SrvRepository.SolicitudCancelaComprobante inValue = new EcodexIntegrationSample.SrvRepository.SolicitudCancelaComprobante();
            inValue.RFC = RFC;
            inValue.Token = Token;
            inValue.TransaccionID = TransaccionID;
            inValue.UUID = UUID;
            EcodexIntegrationSample.SrvRepository.RespuestaCancelaComprobante retVal = ((EcodexIntegrationSample.SrvRepository.Repositorio)(this)).CancelaComprobante(inValue);
            TransaccionID = retVal.TransaccionID;
            return retVal.Cancelada;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EcodexIntegrationSample.SrvRepository.RespuestaObtenerQR EcodexIntegrationSample.SrvRepository.Repositorio.ObtenerQR(EcodexIntegrationSample.SrvRepository.SolicitudObtenerQR request) {
            return base.Channel.ObtenerQR(request);
        }
        
        public EcodexIntegrationSample.SrvRepository.InformacionQR ObtenerQR(string RFC, string Token, ref long TransaccionID, string UUID) {
            EcodexIntegrationSample.SrvRepository.SolicitudObtenerQR inValue = new EcodexIntegrationSample.SrvRepository.SolicitudObtenerQR();
            inValue.RFC = RFC;
            inValue.Token = Token;
            inValue.TransaccionID = TransaccionID;
            inValue.UUID = UUID;
            EcodexIntegrationSample.SrvRepository.RespuestaObtenerQR retVal = ((EcodexIntegrationSample.SrvRepository.Repositorio)(this)).ObtenerQR(inValue);
            TransaccionID = retVal.TransaccionID;
            return retVal.QR;
        }
    }
}
