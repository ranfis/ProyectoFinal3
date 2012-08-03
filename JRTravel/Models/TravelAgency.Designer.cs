﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("TravelAgencyModel", "FK_Factura_Reservacion", "reservacion", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(JRTravel.Models.reservacion), "factura", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(JRTravel.Models.factura), true)]
[assembly: EdmRelationshipAttribute("TravelAgencyModel", "FK_Reservacion_Cliente", "usuario", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(JRTravel.Models.usuario), "reservacion", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(JRTravel.Models.reservacion), true)]
[assembly: EdmRelationshipAttribute("TravelAgencyModel", "FK_Usuario_Rol", "rol", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(JRTravel.Models.rol), "usuario", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(JRTravel.Models.usuario), true)]

#endregion

namespace JRTravel.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class TravelAgencyEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new TravelAgencyEntities object using the connection string found in the 'TravelAgencyEntities' section of the application configuration file.
        /// </summary>
        public TravelAgencyEntities() : base("name=TravelAgencyEntities", "TravelAgencyEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new TravelAgencyEntities object.
        /// </summary>
        public TravelAgencyEntities(string connectionString) : base(connectionString, "TravelAgencyEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new TravelAgencyEntities object.
        /// </summary>
        public TravelAgencyEntities(EntityConnection connection) : base(connection, "TravelAgencyEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<agencia> agencias
        {
            get
            {
                if ((_agencias == null))
                {
                    _agencias = base.CreateObjectSet<agencia>("agencias");
                }
                return _agencias;
            }
        }
        private ObjectSet<agencia> _agencias;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<factura> facturas
        {
            get
            {
                if ((_facturas == null))
                {
                    _facturas = base.CreateObjectSet<factura>("facturas");
                }
                return _facturas;
            }
        }
        private ObjectSet<factura> _facturas;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<reservacion> reservacions
        {
            get
            {
                if ((_reservacions == null))
                {
                    _reservacions = base.CreateObjectSet<reservacion>("reservacions");
                }
                return _reservacions;
            }
        }
        private ObjectSet<reservacion> _reservacions;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<rol> rols
        {
            get
            {
                if ((_rols == null))
                {
                    _rols = base.CreateObjectSet<rol>("rols");
                }
                return _rols;
            }
        }
        private ObjectSet<rol> _rols;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<usuario> usuarios
        {
            get
            {
                if ((_usuarios == null))
                {
                    _usuarios = base.CreateObjectSet<usuario>("usuarios");
                }
                return _usuarios;
            }
        }
        private ObjectSet<usuario> _usuarios;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the agencias EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToagencias(agencia agencia)
        {
            base.AddObject("agencias", agencia);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the facturas EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTofacturas(factura factura)
        {
            base.AddObject("facturas", factura);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the reservacions EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToreservacions(reservacion reservacion)
        {
            base.AddObject("reservacions", reservacion);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the rols EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTorols(rol rol)
        {
            base.AddObject("rols", rol);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the usuarios EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTousuarios(usuario usuario)
        {
            base.AddObject("usuarios", usuario);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TravelAgencyModel", Name="agencia")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class agencia : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new agencia object.
        /// </summary>
        /// <param name="codigo">Initial value of the codigo property.</param>
        /// <param name="descripcion">Initial value of the descripcion property.</param>
        /// <param name="telefono">Initial value of the telefono property.</param>
        /// <param name="direccion">Initial value of the direccion property.</param>
        public static agencia Createagencia(global::System.Int32 codigo, global::System.String descripcion, global::System.String telefono, global::System.String direccion)
        {
            agencia agencia = new agencia();
            agencia.codigo = codigo;
            agencia.descripcion = descripcion;
            agencia.telefono = telefono;
            agencia.direccion = direccion;
            return agencia;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                if (_codigo != value)
                {
                    OncodigoChanging(value);
                    ReportPropertyChanging("codigo");
                    _codigo = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("codigo");
                    OncodigoChanged();
                }
            }
        }
        private global::System.Int32 _codigo;
        partial void OncodigoChanging(global::System.Int32 value);
        partial void OncodigoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                OndescripcionChanging(value);
                ReportPropertyChanging("descripcion");
                _descripcion = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("descripcion");
                OndescripcionChanged();
            }
        }
        private global::System.String _descripcion;
        partial void OndescripcionChanging(global::System.String value);
        partial void OndescripcionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String telefono
        {
            get
            {
                return _telefono;
            }
            set
            {
                OntelefonoChanging(value);
                ReportPropertyChanging("telefono");
                _telefono = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("telefono");
                OntelefonoChanged();
            }
        }
        private global::System.String _telefono;
        partial void OntelefonoChanging(global::System.String value);
        partial void OntelefonoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String direccion
        {
            get
            {
                return _direccion;
            }
            set
            {
                OndireccionChanging(value);
                ReportPropertyChanging("direccion");
                _direccion = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("direccion");
                OndireccionChanged();
            }
        }
        private global::System.String _direccion;
        partial void OndireccionChanging(global::System.String value);
        partial void OndireccionChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TravelAgencyModel", Name="factura")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class factura : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new factura object.
        /// </summary>
        /// <param name="codigo">Initial value of the codigo property.</param>
        /// <param name="reservacion">Initial value of the reservacion property.</param>
        /// <param name="precio">Initial value of the precio property.</param>
        public static factura Createfactura(global::System.Int32 codigo, global::System.String reservacion, global::System.Double precio)
        {
            factura factura = new factura();
            factura.codigo = codigo;
            factura.reservacion = reservacion;
            factura.precio = precio;
            return factura;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                if (_codigo != value)
                {
                    OncodigoChanging(value);
                    ReportPropertyChanging("codigo");
                    _codigo = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("codigo");
                    OncodigoChanged();
                }
            }
        }
        private global::System.Int32 _codigo;
        partial void OncodigoChanging(global::System.Int32 value);
        partial void OncodigoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String reservacion
        {
            get
            {
                return _reservacion;
            }
            set
            {
                OnreservacionChanging(value);
                ReportPropertyChanging("reservacion");
                _reservacion = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("reservacion");
                OnreservacionChanged();
            }
        }
        private global::System.String _reservacion;
        partial void OnreservacionChanging(global::System.String value);
        partial void OnreservacionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double precio
        {
            get
            {
                return _precio;
            }
            set
            {
                OnprecioChanging(value);
                ReportPropertyChanging("precio");
                _precio = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("precio");
                OnprecioChanged();
            }
        }
        private global::System.Double _precio;
        partial void OnprecioChanging(global::System.Double value);
        partial void OnprecioChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("TravelAgencyModel", "FK_Factura_Reservacion", "reservacion")]
        public reservacion reservacion1
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<reservacion>("TravelAgencyModel.FK_Factura_Reservacion", "reservacion").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<reservacion>("TravelAgencyModel.FK_Factura_Reservacion", "reservacion").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<reservacion> reservacion1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<reservacion>("TravelAgencyModel.FK_Factura_Reservacion", "reservacion");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<reservacion>("TravelAgencyModel.FK_Factura_Reservacion", "reservacion", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TravelAgencyModel", Name="reservacion")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class reservacion : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new reservacion object.
        /// </summary>
        /// <param name="codigo">Initial value of the codigo property.</param>
        /// <param name="vuelo">Initial value of the vuelo property.</param>
        /// <param name="agencia">Initial value of the agencia property.</param>
        /// <param name="clase">Initial value of the clase property.</param>
        /// <param name="cliente">Initial value of the cliente property.</param>
        public static reservacion Createreservacion(global::System.String codigo, global::System.Int32 vuelo, global::System.Int32 agencia, global::System.String clase, global::System.String cliente)
        {
            reservacion reservacion = new reservacion();
            reservacion.codigo = codigo;
            reservacion.vuelo = vuelo;
            reservacion.agencia = agencia;
            reservacion.clase = clase;
            reservacion.cliente = cliente;
            return reservacion;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                if (_codigo != value)
                {
                    OncodigoChanging(value);
                    ReportPropertyChanging("codigo");
                    _codigo = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("codigo");
                    OncodigoChanged();
                }
            }
        }
        private global::System.String _codigo;
        partial void OncodigoChanging(global::System.String value);
        partial void OncodigoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 vuelo
        {
            get
            {
                return _vuelo;
            }
            set
            {
                OnvueloChanging(value);
                ReportPropertyChanging("vuelo");
                _vuelo = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("vuelo");
                OnvueloChanged();
            }
        }
        private global::System.Int32 _vuelo;
        partial void OnvueloChanging(global::System.Int32 value);
        partial void OnvueloChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                OnagenciaChanging(value);
                ReportPropertyChanging("agencia");
                _agencia = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("agencia");
                OnagenciaChanged();
            }
        }
        private global::System.Int32 _agencia;
        partial void OnagenciaChanging(global::System.Int32 value);
        partial void OnagenciaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String clase
        {
            get
            {
                return _clase;
            }
            set
            {
                OnclaseChanging(value);
                ReportPropertyChanging("clase");
                _clase = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("clase");
                OnclaseChanged();
            }
        }
        private global::System.String _clase;
        partial void OnclaseChanging(global::System.String value);
        partial void OnclaseChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.SByte> estado
        {
            get
            {
                return _estado;
            }
            set
            {
                OnestadoChanging(value);
                ReportPropertyChanging("estado");
                _estado = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("estado");
                OnestadoChanged();
            }
        }
        private Nullable<global::System.SByte> _estado;
        partial void OnestadoChanging(Nullable<global::System.SByte> value);
        partial void OnestadoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String cliente
        {
            get
            {
                return _cliente;
            }
            set
            {
                OnclienteChanging(value);
                ReportPropertyChanging("cliente");
                _cliente = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("cliente");
                OnclienteChanged();
            }
        }
        private global::System.String _cliente;
        partial void OnclienteChanging(global::System.String value);
        partial void OnclienteChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String asiento
        {
            get
            {
                return _asiento;
            }
            set
            {
                OnasientoChanging(value);
                ReportPropertyChanging("asiento");
                _asiento = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("asiento");
                OnasientoChanged();
            }
        }
        private global::System.String _asiento;
        partial void OnasientoChanging(global::System.String value);
        partial void OnasientoChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("TravelAgencyModel", "FK_Factura_Reservacion", "factura")]
        public EntityCollection<factura> facturas
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<factura>("TravelAgencyModel.FK_Factura_Reservacion", "factura");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<factura>("TravelAgencyModel.FK_Factura_Reservacion", "factura", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("TravelAgencyModel", "FK_Reservacion_Cliente", "usuario")]
        public usuario usuario
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<usuario>("TravelAgencyModel.FK_Reservacion_Cliente", "usuario").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<usuario>("TravelAgencyModel.FK_Reservacion_Cliente", "usuario").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<usuario> usuarioReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<usuario>("TravelAgencyModel.FK_Reservacion_Cliente", "usuario");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<usuario>("TravelAgencyModel.FK_Reservacion_Cliente", "usuario", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TravelAgencyModel", Name="rol")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class rol : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new rol object.
        /// </summary>
        /// <param name="codigo">Initial value of the codigo property.</param>
        public static rol Createrol(global::System.String codigo)
        {
            rol rol = new rol();
            rol.codigo = codigo;
            return rol;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                if (_codigo != value)
                {
                    OncodigoChanging(value);
                    ReportPropertyChanging("codigo");
                    _codigo = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("codigo");
                    OncodigoChanged();
                }
            }
        }
        private global::System.String _codigo;
        partial void OncodigoChanging(global::System.String value);
        partial void OncodigoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                OndescripcionChanging(value);
                ReportPropertyChanging("descripcion");
                _descripcion = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("descripcion");
                OndescripcionChanged();
            }
        }
        private global::System.String _descripcion;
        partial void OndescripcionChanging(global::System.String value);
        partial void OndescripcionChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("TravelAgencyModel", "FK_Usuario_Rol", "usuario")]
        public EntityCollection<usuario> usuarios
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<usuario>("TravelAgencyModel.FK_Usuario_Rol", "usuario");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<usuario>("TravelAgencyModel.FK_Usuario_Rol", "usuario", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TravelAgencyModel", Name="usuario")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class usuario : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new usuario object.
        /// </summary>
        /// <param name="nusuario">Initial value of the nusuario property.</param>
        /// <param name="clave">Initial value of the clave property.</param>
        /// <param name="rol">Initial value of the rol property.</param>
        /// <param name="nombre">Initial value of the nombre property.</param>
        /// <param name="apellido">Initial value of the apellido property.</param>
        /// <param name="correo">Initial value of the correo property.</param>
        public static usuario Createusuario(global::System.String nusuario, global::System.String clave, global::System.String rol, global::System.String nombre, global::System.String apellido, global::System.String correo)
        {
            usuario usuario = new usuario();
            usuario.nusuario = nusuario;
            usuario.clave = clave;
            usuario.rol = rol;
            usuario.nombre = nombre;
            usuario.apellido = apellido;
            usuario.correo = correo;
            return usuario;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String nusuario
        {
            get
            {
                return _nusuario;
            }
            set
            {
                if (_nusuario != value)
                {
                    OnnusuarioChanging(value);
                    ReportPropertyChanging("nusuario");
                    _nusuario = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("nusuario");
                    OnnusuarioChanged();
                }
            }
        }
        private global::System.String _nusuario;
        partial void OnnusuarioChanging(global::System.String value);
        partial void OnnusuarioChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String clave
        {
            get
            {
                return _clave;
            }
            set
            {
                OnclaveChanging(value);
                ReportPropertyChanging("clave");
                _clave = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("clave");
                OnclaveChanged();
            }
        }
        private global::System.String _clave;
        partial void OnclaveChanging(global::System.String value);
        partial void OnclaveChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String rol
        {
            get
            {
                return _rol;
            }
            set
            {
                OnrolChanging(value);
                ReportPropertyChanging("rol");
                _rol = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("rol");
                OnrolChanged();
            }
        }
        private global::System.String _rol;
        partial void OnrolChanging(global::System.String value);
        partial void OnrolChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                OnnombreChanging(value);
                ReportPropertyChanging("nombre");
                _nombre = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("nombre");
                OnnombreChanged();
            }
        }
        private global::System.String _nombre;
        partial void OnnombreChanging(global::System.String value);
        partial void OnnombreChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                OnapellidoChanging(value);
                ReportPropertyChanging("apellido");
                _apellido = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("apellido");
                OnapellidoChanged();
            }
        }
        private global::System.String _apellido;
        partial void OnapellidoChanging(global::System.String value);
        partial void OnapellidoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String correo
        {
            get
            {
                return _correo;
            }
            set
            {
                OncorreoChanging(value);
                ReportPropertyChanging("correo");
                _correo = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("correo");
                OncorreoChanged();
            }
        }
        private global::System.String _correo;
        partial void OncorreoChanging(global::System.String value);
        partial void OncorreoChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("TravelAgencyModel", "FK_Reservacion_Cliente", "reservacion")]
        public EntityCollection<reservacion> reservacions
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<reservacion>("TravelAgencyModel.FK_Reservacion_Cliente", "reservacion");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<reservacion>("TravelAgencyModel.FK_Reservacion_Cliente", "reservacion", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("TravelAgencyModel", "FK_Usuario_Rol", "rol")]
        public rol rol1
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<rol>("TravelAgencyModel.FK_Usuario_Rol", "rol").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<rol>("TravelAgencyModel.FK_Usuario_Rol", "rol").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<rol> rol1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<rol>("TravelAgencyModel.FK_Usuario_Rol", "rol");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<rol>("TravelAgencyModel.FK_Usuario_Rol", "rol", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}