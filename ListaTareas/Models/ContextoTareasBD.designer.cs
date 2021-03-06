﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ListaTareas.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TareasBD")]
	public partial class ContextoTareasBDDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertTareas(Tareas instance);
    partial void UpdateTareas(Tareas instance);
    partial void DeleteTareas(Tareas instance);
    partial void InsertUsuarios(Usuarios instance);
    partial void UpdateUsuarios(Usuarios instance);
    partial void DeleteUsuarios(Usuarios instance);
    #endregion
		
		public ContextoTareasBDDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["TareasBDConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ContextoTareasBDDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ContextoTareasBDDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ContextoTareasBDDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ContextoTareasBDDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Tareas> Tareas
		{
			get
			{
				return this.GetTable<Tareas>();
			}
		}
		
		public System.Data.Linq.Table<Usuarios> Usuarios
		{
			get
			{
				return this.GetTable<Usuarios>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tareas")]
	public partial class Tareas : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Id_Tarea;
		
		private string _NombreTarea;
		
		private string _DescripcionTarea;
		
		private int _PrioridadTarea;
		
		private System.Guid _Fk_Usuario;
		
		private EntityRef<Usuarios> _Usuarios;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_TareaChanging(System.Guid value);
    partial void OnId_TareaChanged();
    partial void OnNombreTareaChanging(string value);
    partial void OnNombreTareaChanged();
    partial void OnDescripcionTareaChanging(string value);
    partial void OnDescripcionTareaChanged();
    partial void OnPrioridadTareaChanging(int value);
    partial void OnPrioridadTareaChanged();
    partial void OnFk_UsuarioChanging(System.Guid value);
    partial void OnFk_UsuarioChanged();
    #endregion
		
		public Tareas()
		{
			this._Usuarios = default(EntityRef<Usuarios>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Tarea", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id_Tarea
		{
			get
			{
				return this._Id_Tarea;
			}
			set
			{
				if ((this._Id_Tarea != value))
				{
					this.OnId_TareaChanging(value);
					this.SendPropertyChanging();
					this._Id_Tarea = value;
					this.SendPropertyChanged("Id_Tarea");
					this.OnId_TareaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreTarea", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string NombreTarea
		{
			get
			{
				return this._NombreTarea;
			}
			set
			{
				if ((this._NombreTarea != value))
				{
					this.OnNombreTareaChanging(value);
					this.SendPropertyChanging();
					this._NombreTarea = value;
					this.SendPropertyChanged("NombreTarea");
					this.OnNombreTareaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DescripcionTarea", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string DescripcionTarea
		{
			get
			{
				return this._DescripcionTarea;
			}
			set
			{
				if ((this._DescripcionTarea != value))
				{
					this.OnDescripcionTareaChanging(value);
					this.SendPropertyChanging();
					this._DescripcionTarea = value;
					this.SendPropertyChanged("DescripcionTarea");
					this.OnDescripcionTareaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrioridadTarea", DbType="Int NOT NULL")]
		public int PrioridadTarea
		{
			get
			{
				return this._PrioridadTarea;
			}
			set
			{
				if ((this._PrioridadTarea != value))
				{
					this.OnPrioridadTareaChanging(value);
					this.SendPropertyChanging();
					this._PrioridadTarea = value;
					this.SendPropertyChanged("PrioridadTarea");
					this.OnPrioridadTareaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fk_Usuario", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Fk_Usuario
		{
			get
			{
				return this._Fk_Usuario;
			}
			set
			{
				if ((this._Fk_Usuario != value))
				{
					if (this._Usuarios.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnFk_UsuarioChanging(value);
					this.SendPropertyChanging();
					this._Fk_Usuario = value;
					this.SendPropertyChanged("Fk_Usuario");
					this.OnFk_UsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuarios_Tareas", Storage="_Usuarios", ThisKey="Fk_Usuario", OtherKey="ID_Credencial", IsForeignKey=true)]
		public Usuarios Usuarios
		{
			get
			{
				return this._Usuarios.Entity;
			}
			set
			{
				Usuarios previousValue = this._Usuarios.Entity;
				if (((previousValue != value) 
							|| (this._Usuarios.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Usuarios.Entity = null;
						previousValue.Tareas.Remove(this);
					}
					this._Usuarios.Entity = value;
					if ((value != null))
					{
						value.Tareas.Add(this);
						this._Fk_Usuario = value.ID_Credencial;
					}
					else
					{
						this._Fk_Usuario = default(System.Guid);
					}
					this.SendPropertyChanged("Usuarios");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Usuarios")]
	public partial class Usuarios : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ID_Credencial;
		
		private string _NombreUsuario;
		
		private string _ClaveAcceso;
		
		private string _EmailUsuario;
		
		private System.Nullable<System.DateTime> _FechaAlta;
		
		private EntitySet<Tareas> _Tareas;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_CredencialChanging(System.Guid value);
    partial void OnID_CredencialChanged();
    partial void OnNombreUsuarioChanging(string value);
    partial void OnNombreUsuarioChanged();
    partial void OnClaveAccesoChanging(string value);
    partial void OnClaveAccesoChanged();
    partial void OnEmailUsuarioChanging(string value);
    partial void OnEmailUsuarioChanged();
    partial void OnFechaAltaChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaAltaChanged();
    #endregion
		
		public Usuarios()
		{
			this._Tareas = new EntitySet<Tareas>(new Action<Tareas>(this.attach_Tareas), new Action<Tareas>(this.detach_Tareas));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Credencial", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid ID_Credencial
		{
			get
			{
				return this._ID_Credencial;
			}
			set
			{
				if ((this._ID_Credencial != value))
				{
					this.OnID_CredencialChanging(value);
					this.SendPropertyChanging();
					this._ID_Credencial = value;
					this.SendPropertyChanged("ID_Credencial");
					this.OnID_CredencialChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreUsuario", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string NombreUsuario
		{
			get
			{
				return this._NombreUsuario;
			}
			set
			{
				if ((this._NombreUsuario != value))
				{
					this.OnNombreUsuarioChanging(value);
					this.SendPropertyChanging();
					this._NombreUsuario = value;
					this.SendPropertyChanged("NombreUsuario");
					this.OnNombreUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClaveAcceso", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ClaveAcceso
		{
			get
			{
				return this._ClaveAcceso;
			}
			set
			{
				if ((this._ClaveAcceso != value))
				{
					this.OnClaveAccesoChanging(value);
					this.SendPropertyChanging();
					this._ClaveAcceso = value;
					this.SendPropertyChanged("ClaveAcceso");
					this.OnClaveAccesoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailUsuario", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string EmailUsuario
		{
			get
			{
				return this._EmailUsuario;
			}
			set
			{
				if ((this._EmailUsuario != value))
				{
					this.OnEmailUsuarioChanging(value);
					this.SendPropertyChanging();
					this._EmailUsuario = value;
					this.SendPropertyChanged("EmailUsuario");
					this.OnEmailUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaAlta", DbType="DateTime")]
		public System.Nullable<System.DateTime> FechaAlta
		{
			get
			{
				return this._FechaAlta;
			}
			set
			{
				if ((this._FechaAlta != value))
				{
					this.OnFechaAltaChanging(value);
					this.SendPropertyChanging();
					this._FechaAlta = value;
					this.SendPropertyChanged("FechaAlta");
					this.OnFechaAltaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuarios_Tareas", Storage="_Tareas", ThisKey="ID_Credencial", OtherKey="Fk_Usuario")]
		public EntitySet<Tareas> Tareas
		{
			get
			{
				return this._Tareas;
			}
			set
			{
				this._Tareas.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Tareas(Tareas entity)
		{
			this.SendPropertyChanging();
			entity.Usuarios = this;
		}
		
		private void detach_Tareas(Tareas entity)
		{
			this.SendPropertyChanging();
			entity.Usuarios = null;
		}
	}
}
#pragma warning restore 1591
