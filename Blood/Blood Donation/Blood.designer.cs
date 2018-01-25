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
    partial void InsertAdminInfo(AdminInfo instance);
    partial void UpdateAdminInfo(AdminInfo instance);
    partial void DeleteAdminInfo(AdminInfo instance);
    partial void InsertGuestInfo(GuestInfo instance);
    partial void UpdateGuestInfo(GuestInfo instance);
    partial void DeleteGuestInfo(GuestInfo instance);
    partial void InsertRequestInfo(RequestInfo instance);
    partial void UpdateRequestInfo(RequestInfo instance);
    partial void DeleteRequestInfo(RequestInfo instance);
    partial void InsertR(R instance);
    partial void UpdateR(R instance);
    partial void DeleteR(R instance);
    partial void Insertallrequest(allrequest instance);
    partial void Updateallrequest(allrequest instance);
    partial void Deleteallrequest(allrequest instance);
    partial void InsertDonorInfo(DonorInfo instance);
    partial void UpdateDonorInfo(DonorInfo instance);
    partial void DeleteDonorInfo(DonorInfo instance);
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
		
		public System.Data.Linq.Table<AdminInfo> AdminInfos
		{
			get
			{
				return this.GetTable<AdminInfo>();
			}
		}
		
		public System.Data.Linq.Table<GuestInfo> GuestInfos
		{
			get
			{
				return this.GetTable<GuestInfo>();
			}
		}
		
		public System.Data.Linq.Table<RequestInfo> RequestInfos
		{
			get
			{
				return this.GetTable<RequestInfo>();
			}
		}
		
		public System.Data.Linq.Table<R> Rs
		{
			get
			{
				return this.GetTable<R>();
			}
		}
		
		public System.Data.Linq.Table<allrequest> allrequests
		{
			get
			{
				return this.GetTable<allrequest>();
			}
		}
		
		public System.Data.Linq.Table<DonorInfo> DonorInfos
		{
			get
			{
				return this.GetTable<DonorInfo>();
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
		
		private string _BloodGroup;
		
		private string _Status;
		
		private string _Address;
		
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
    partial void OnBloodGroupChanging(string value);
    partial void OnBloodGroupChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RequestInfo")]
	public partial class RequestInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RequestId;
		
		private int _DonorId;
		
		private int _Gid;
		
		private string _Status;
		
		private string _Gphone;
		
		private string _Identity;
		
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
    partial void OnIdentityChanging(string value);
    partial void OnIdentityChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Identity]", Storage="_Identity", DbType="VarChar(50)")]
		public string Identity
		{
			get
			{
				return this._Identity;
			}
			set
			{
				if ((this._Identity != value))
				{
					this.OnIdentityChanging(value);
					this.SendPropertyChanging();
					this._Identity = value;
					this.SendPropertyChanged("Identity");
					this.OnIdentityChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.R")]
	public partial class R : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Rid;
		
		private int _DonorId;
		
		private int _Did;
		
		private string _Status;
		
		private string _Identity;
		
		private string _Phone;
		
		private EntityRef<DonorInfo> _DonorInfo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRidChanging(int value);
    partial void OnRidChanged();
    partial void OnDonorIdChanging(int value);
    partial void OnDonorIdChanged();
    partial void OnDidChanging(int value);
    partial void OnDidChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    partial void OnIdentityChanging(string value);
    partial void OnIdentityChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    #endregion
		
		public R()
		{
			this._DonorInfo = default(EntityRef<DonorInfo>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Rid
		{
			get
			{
				return this._Rid;
			}
			set
			{
				if ((this._Rid != value))
				{
					this.OnRidChanging(value);
					this.SendPropertyChanging();
					this._Rid = value;
					this.SendPropertyChanged("Rid");
					this.OnRidChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Did", DbType="Int NOT NULL")]
		public int Did
		{
			get
			{
				return this._Did;
			}
			set
			{
				if ((this._Did != value))
				{
					this.OnDidChanging(value);
					this.SendPropertyChanging();
					this._Did = value;
					this.SendPropertyChanged("Did");
					this.OnDidChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Identity]", Storage="_Identity", DbType="VarChar(50)")]
		public string Identity
		{
			get
			{
				return this._Identity;
			}
			set
			{
				if ((this._Identity != value))
				{
					this.OnIdentityChanging(value);
					this.SendPropertyChanging();
					this._Identity = value;
					this.SendPropertyChanged("Identity");
					this.OnIdentityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonorInfo_R", Storage="_DonorInfo", ThisKey="DonorId", OtherKey="DonorId", IsForeignKey=true)]
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
						previousValue.Rs.Remove(this);
					}
					this._DonorInfo.Entity = value;
					if ((value != null))
					{
						value.Rs.Add(this);
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.allrequest")]
	public partial class allrequest : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _reqid;
		
		private string _Name;
		
		private string _Phone;
		
		private string _Address;
		
		private int _Donorid;
		
		private string _identity;
		
		private System.Nullable<int> _requestid;
		
		private System.Nullable<int> _Rid;
		
		private string _Status;
		
		private EntityRef<DonorInfo> _DonorInfo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnreqidChanging(int value);
    partial void OnreqidChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnDonoridChanging(int value);
    partial void OnDonoridChanged();
    partial void OnidentityChanging(string value);
    partial void OnidentityChanged();
    partial void OnrequestidChanging(System.Nullable<int> value);
    partial void OnrequestidChanged();
    partial void OnRidChanging(System.Nullable<int> value);
    partial void OnRidChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    #endregion
		
		public allrequest()
		{
			this._DonorInfo = default(EntityRef<DonorInfo>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_reqid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int reqid
		{
			get
			{
				return this._reqid;
			}
			set
			{
				if ((this._reqid != value))
				{
					this.OnreqidChanging(value);
					this.SendPropertyChanging();
					this._reqid = value;
					this.SendPropertyChanged("reqid");
					this.OnreqidChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Donorid", DbType="Int NOT NULL")]
		public int Donorid
		{
			get
			{
				return this._Donorid;
			}
			set
			{
				if ((this._Donorid != value))
				{
					if (this._DonorInfo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDonoridChanging(value);
					this.SendPropertyChanging();
					this._Donorid = value;
					this.SendPropertyChanged("Donorid");
					this.OnDonoridChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[identity]", Storage="_identity", DbType="VarChar(50)")]
		public string identity
		{
			get
			{
				return this._identity;
			}
			set
			{
				if ((this._identity != value))
				{
					this.OnidentityChanging(value);
					this.SendPropertyChanging();
					this._identity = value;
					this.SendPropertyChanged("identity");
					this.OnidentityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_requestid", DbType="Int")]
		public System.Nullable<int> requestid
		{
			get
			{
				return this._requestid;
			}
			set
			{
				if ((this._requestid != value))
				{
					this.OnrequestidChanging(value);
					this.SendPropertyChanging();
					this._requestid = value;
					this.SendPropertyChanged("requestid");
					this.OnrequestidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rid", DbType="Int")]
		public System.Nullable<int> Rid
		{
			get
			{
				return this._Rid;
			}
			set
			{
				if ((this._Rid != value))
				{
					this.OnRidChanging(value);
					this.SendPropertyChanging();
					this._Rid = value;
					this.SendPropertyChanged("Rid");
					this.OnRidChanged();
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonorInfo_allrequest", Storage="_DonorInfo", ThisKey="Donorid", OtherKey="DonorId", IsForeignKey=true)]
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
						previousValue.allrequests.Remove(this);
					}
					this._DonorInfo.Entity = value;
					if ((value != null))
					{
						value.allrequests.Add(this);
						this._Donorid = value.DonorId;
					}
					else
					{
						this._Donorid = default(int);
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DonorInfo")]
	public partial class DonorInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DonorId;
		
		private string _DName;
		
		private string _Password;
		
		private string _BloodGroup;
		
		private string _DPhone;
		
		private string _DAddress;
		
		private string _UserID;
		
		private string _Status;
		
		private string _identity;
		
		private EntitySet<RequestInfo> _RequestInfos;
		
		private EntitySet<R> _Rs;
		
		private EntitySet<allrequest> _allrequests;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDonorIdChanging(int value);
    partial void OnDonorIdChanged();
    partial void OnDNameChanging(string value);
    partial void OnDNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnBloodGroupChanging(string value);
    partial void OnBloodGroupChanged();
    partial void OnDPhoneChanging(string value);
    partial void OnDPhoneChanged();
    partial void OnDAddressChanging(string value);
    partial void OnDAddressChanged();
    partial void OnUserIDChanging(string value);
    partial void OnUserIDChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    partial void OnidentityChanging(string value);
    partial void OnidentityChanged();
    #endregion
		
		public DonorInfo()
		{
			this._RequestInfos = new EntitySet<RequestInfo>(new Action<RequestInfo>(this.attach_RequestInfos), new Action<RequestInfo>(this.detach_RequestInfos));
			this._Rs = new EntitySet<R>(new Action<R>(this.attach_Rs), new Action<R>(this.detach_Rs));
			this._allrequests = new EntitySet<allrequest>(new Action<allrequest>(this.attach_allrequests), new Action<allrequest>(this.detach_allrequests));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string DName
		{
			get
			{
				return this._DName;
			}
			set
			{
				if ((this._DName != value))
				{
					this.OnDNameChanging(value);
					this.SendPropertyChanging();
					this._DName = value;
					this.SendPropertyChanged("DName");
					this.OnDNameChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DPhone", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string DPhone
		{
			get
			{
				return this._DPhone;
			}
			set
			{
				if ((this._DPhone != value))
				{
					this.OnDPhoneChanging(value);
					this.SendPropertyChanging();
					this._DPhone = value;
					this.SendPropertyChanged("DPhone");
					this.OnDPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DAddress", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string DAddress
		{
			get
			{
				return this._DAddress;
			}
			set
			{
				if ((this._DAddress != value))
				{
					this.OnDAddressChanging(value);
					this.SendPropertyChanging();
					this._DAddress = value;
					this.SendPropertyChanged("DAddress");
					this.OnDAddressChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[identity]", Storage="_identity", DbType="VarChar(50)")]
		public string identity
		{
			get
			{
				return this._identity;
			}
			set
			{
				if ((this._identity != value))
				{
					this.OnidentityChanging(value);
					this.SendPropertyChanging();
					this._identity = value;
					this.SendPropertyChanged("identity");
					this.OnidentityChanged();
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonorInfo_R", Storage="_Rs", ThisKey="DonorId", OtherKey="DonorId")]
		public EntitySet<R> Rs
		{
			get
			{
				return this._Rs;
			}
			set
			{
				this._Rs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonorInfo_allrequest", Storage="_allrequests", ThisKey="DonorId", OtherKey="Donorid")]
		public EntitySet<allrequest> allrequests
		{
			get
			{
				return this._allrequests;
			}
			set
			{
				this._allrequests.Assign(value);
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
		
		private void attach_Rs(R entity)
		{
			this.SendPropertyChanging();
			entity.DonorInfo = this;
		}
		
		private void detach_Rs(R entity)
		{
			this.SendPropertyChanging();
			entity.DonorInfo = null;
		}
		
		private void attach_allrequests(allrequest entity)
		{
			this.SendPropertyChanging();
			entity.DonorInfo = this;
		}
		
		private void detach_allrequests(allrequest entity)
		{
			this.SendPropertyChanging();
			entity.DonorInfo = null;
		}
	}
}
#pragma warning restore 1591
