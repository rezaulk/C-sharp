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

namespace Blood_Donation
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Blood")]
	public partial class BloodDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertGuestInfo(GuestInfo instance);
    partial void UpdateGuestInfo(GuestInfo instance);
    partial void DeleteGuestInfo(GuestInfo instance);
    partial void InsertDonorInfo(DonorInfo instance);
    partial void UpdateDonorInfo(DonorInfo instance);
    partial void DeleteDonorInfo(DonorInfo instance);
    partial void InsertRequestInfo(RequestInfo instance);
    partial void UpdateRequestInfo(RequestInfo instance);
    partial void DeleteRequestInfo(RequestInfo instance);
    partial void InsertAdminInfo(AdminInfo instance);
    partial void UpdateAdminInfo(AdminInfo instance);
    partial void DeleteAdminInfo(AdminInfo instance);
    #endregion
		
		public BloodDataContext() : 
				base(global::Blood_Donation.Properties.Settings.Default.BloodConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BloodDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BloodDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BloodDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BloodDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<GuestInfo> GuestInfos
		{
			get
			{
				return this.GetTable<GuestInfo>();
			}
		}
		
		public System.Data.Linq.Table<DonorInfo> DonorInfos
		{
			get
			{
				return this.GetTable<DonorInfo>();
			}
		}
		
		public System.Data.Linq.Table<RequestInfo> RequestInfos
		{
			get
			{
				return this.GetTable<RequestInfo>();
			}
		}
		
		public System.Data.Linq.Table<AdminInfo> AdminInfos
		{
			get
			{
				return this.GetTable<AdminInfo>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.GuestInfo")]
	public partial class GuestInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Gid;
		
		private string _GPhone;
		
		private string _GName;
		
		private string _GAddress;
		
		private EntitySet<RequestInfo> _RequestInfos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnGidChanging(int value);
    partial void OnGidChanged();
    partial void OnGPhoneChanging(string value);
    partial void OnGPhoneChanged();
    partial void OnGNameChanging(string value);
    partial void OnGNameChanged();
    partial void OnGAddressChanging(string value);
    partial void OnGAddressChanged();
    #endregion
		
		public GuestInfo()
		{
			this._RequestInfos = new EntitySet<RequestInfo>(new Action<RequestInfo>(this.attach_RequestInfos), new Action<RequestInfo>(this.detach_RequestInfos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Gid
		{
			get
			{
				return this._Gid;
			}
			set
			{
				if ((this._Gid != value))
				{
					this.OnGidChanging(value);
					this.SendPropertyChanging();
					this._Gid = value;
					this.SendPropertyChanged("Gid");
					this.OnGidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GPhone", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string GPhone
		{
			get
			{
				return this._GPhone;
			}
			set
			{
				if ((this._GPhone != value))
				{
					this.OnGPhoneChanging(value);
					this.SendPropertyChanging();
					this._GPhone = value;
					this.SendPropertyChanged("GPhone");
					this.OnGPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string GName
		{
			get
			{
				return this._GName;
			}
			set
			{
				if ((this._GName != value))
				{
					this.OnGNameChanging(value);
					this.SendPropertyChanging();
					this._GName = value;
					this.SendPropertyChanged("GName");
					this.OnGNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GAddress", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string GAddress
		{
			get
			{
				return this._GAddress;
			}
			set
			{
				if ((this._GAddress != value))
				{
					this.OnGAddressChanging(value);
					this.SendPropertyChanging();
					this._GAddress = value;
					this.SendPropertyChanged("GAddress");
					this.OnGAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GuestInfo_RequestInfo", Storage="_RequestInfos", ThisKey="Gid", OtherKey="Gid")]
		public EntitySet<RequestInfo> RequestInfos
		{
			get
			{
				return this._RequestInfos;
			}
			set
			{
				this._RequestInfos.Assign(value);
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
		
		private void attach_RequestInfos(RequestInfo entity)
		{
			this.SendPropertyChanging();
			entity.GuestInfo = this;
		}
		
		private void detach_RequestInfos(RequestInfo entity)
		{
			this.SendPropertyChanging();
			entity.GuestInfo = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DonorInfo")]
	public partial class DonorInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DonorId;
		
		private string _Name;
		
		private string _Password;
		
		private string _BloodGroup;
		
		private string _Phone;
		
		private string _Address;
		
		private string _UserID;
		
		private string _Status;
		
		private EntitySet<RequestInfo> _RequestInfos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDonorIdChanging(int value);
    partial void OnDonorIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnBloodGroupChanging(string value);
    partial void OnBloodGroupChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnUserIDChanging(string value);
    partial void OnUserIDChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    #endregion
		
		public DonorInfo()
		{
			this._RequestInfos = new EntitySet<RequestInfo>(new Action<RequestInfo>(this.attach_RequestInfos), new Action<RequestInfo>(this.detach_RequestInfos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonorId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int DonorId
		{
			get
			{
				return this._DonorId;
			}
			set
			{
				if ((this._DonorId != value))
				{
					this.OnDonorIdChanging(value);
					this.SendPropertyChanging();
					this._DonorId = value;
					this.SendPropertyChanged("DonorId");
					this.OnDonorIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BloodGroup", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string BloodGroup
		{
			get
			{
				return this._BloodGroup;
			}
			set
			{
				if ((this._BloodGroup != value))
				{
					this.OnBloodGroupChanging(value);
					this.SendPropertyChanging();
					this._BloodGroup = value;
					this.SendPropertyChanged("BloodGroup");
					this.OnBloodGroupChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="VarChar(50)")]
		public string UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="VarChar(50)")]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonorInfo_RequestInfo", Storage="_RequestInfos", ThisKey="DonorId", OtherKey="DonorId")]
		public EntitySet<RequestInfo> RequestInfos
		{
			get
			{
				return this._RequestInfos;
			}
			set
			{
				this._RequestInfos.Assign(value);
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
		
		private void attach_RequestInfos(RequestInfo entity)
		{
			this.SendPropertyChanging();
			entity.DonorInfo = this;
		}
		
		private void detach_RequestInfos(RequestInfo entity)
		{
			this.SendPropertyChanging();
			entity.DonorInfo = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RequestInfo")]
	public partial class RequestInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RequestId;
		
		private int _DonorId;
		
		private int _Gid;
		
		private string _Status;
		
		private string _Gphone;
		
		private EntityRef<GuestInfo> _GuestInfo;
		
		private EntityRef<DonorInfo> _DonorInfo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRequestIdChanging(int value);
    partial void OnRequestIdChanged();
    partial void OnDonorIdChanging(int value);
    partial void OnDonorIdChanged();
    partial void OnGidChanging(int value);
    partial void OnGidChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    partial void OnGphoneChanging(string value);
    partial void OnGphoneChanged();
    #endregion
		
		public RequestInfo()
		{
			this._GuestInfo = default(EntityRef<GuestInfo>);
			this._DonorInfo = default(EntityRef<DonorInfo>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RequestId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RequestId
		{
			get
			{
				return this._RequestId;
			}
			set
			{
				if ((this._RequestId != value))
				{
					this.OnRequestIdChanging(value);
					this.SendPropertyChanging();
					this._RequestId = value;
					this.SendPropertyChanged("RequestId");
					this.OnRequestIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonorId", DbType="Int NOT NULL")]
		public int DonorId
		{
			get
			{
				return this._DonorId;
			}
			set
			{
				if ((this._DonorId != value))
				{
					if (this._DonorInfo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDonorIdChanging(value);
					this.SendPropertyChanging();
					this._DonorId = value;
					this.SendPropertyChanged("DonorId");
					this.OnDonorIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gid", DbType="Int NOT NULL")]
		public int Gid
		{
			get
			{
				return this._Gid;
			}
			set
			{
				if ((this._Gid != value))
				{
					if (this._GuestInfo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnGidChanging(value);
					this.SendPropertyChanging();
					this._Gid = value;
					this.SendPropertyChanged("Gid");
					this.OnGidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="VarChar(50)")]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gphone", DbType="VarChar(50)")]
		public string Gphone
		{
			get
			{
				return this._Gphone;
			}
			set
			{
				if ((this._Gphone != value))
				{
					this.OnGphoneChanging(value);
					this.SendPropertyChanging();
					this._Gphone = value;
					this.SendPropertyChanged("Gphone");
					this.OnGphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="GuestInfo_RequestInfo", Storage="_GuestInfo", ThisKey="Gid", OtherKey="Gid", IsForeignKey=true)]
		public GuestInfo GuestInfo
		{
			get
			{
				return this._GuestInfo.Entity;
			}
			set
			{
				GuestInfo previousValue = this._GuestInfo.Entity;
				if (((previousValue != value) 
							|| (this._GuestInfo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._GuestInfo.Entity = null;
						previousValue.RequestInfos.Remove(this);
					}
					this._GuestInfo.Entity = value;
					if ((value != null))
					{
						value.RequestInfos.Add(this);
						this._Gid = value.Gid;
					}
					else
					{
						this._Gid = default(int);
					}
					this.SendPropertyChanged("GuestInfo");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonorInfo_RequestInfo", Storage="_DonorInfo", ThisKey="DonorId", OtherKey="DonorId", IsForeignKey=true)]
		public DonorInfo DonorInfo
		{
			get
			{
				return this._DonorInfo.Entity;
			}
			set
			{
				DonorInfo previousValue = this._DonorInfo.Entity;
				if (((previousValue != value) 
							|| (this._DonorInfo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DonorInfo.Entity = null;
						previousValue.RequestInfos.Remove(this);
					}
					this._DonorInfo.Entity = value;
					if ((value != null))
					{
						value.RequestInfos.Add(this);
						this._DonorId = value.DonorId;
					}
					else
					{
						this._DonorId = default(int);
					}
					this.SendPropertyChanged("DonorInfo");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AdminInfo")]
	public partial class AdminInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AdminId;
		
		private string _Name;
		
		private string _Phone;
		
		private string _Password;
		
		private string _Username;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAdminIdChanging(int value);
    partial void OnAdminIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    #endregion
		
		public AdminInfo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdminId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AdminId
		{
			get
			{
				return this._AdminId;
			}
			set
			{
				if ((this._AdminId != value))
				{
					this.OnAdminIdChanging(value);
					this.SendPropertyChanging();
					this._AdminId = value;
					this.SendPropertyChanged("AdminId");
					this.OnAdminIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(50)")]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
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
}
#pragma warning restore 1591