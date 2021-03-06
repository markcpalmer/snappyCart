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

namespace SnappyCart.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="snappycartDb")]
	public partial class SnappyDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertpassword(password instance);
    partial void Updatepassword(password instance);
    partial void Deletepassword(password instance);
    partial void Insertproduct(product instance);
    partial void Updateproduct(product instance);
    partial void Deleteproduct(product instance);
    partial void Insertuser(user instance);
    partial void Updateuser(user instance);
    partial void Deleteuser(user instance);
    partial void InsertuserProduct(userProduct instance);
    partial void UpdateuserProduct(userProduct instance);
    partial void DeleteuserProduct(userProduct instance);
    #endregion
		
		public SnappyDBDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["snappycartDbConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SnappyDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SnappyDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SnappyDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SnappyDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<password> passwords
		{
			get
			{
				return this.GetTable<password>();
			}
		}
		
		public System.Data.Linq.Table<product> products
		{
			get
			{
				return this.GetTable<product>();
			}
		}
		
		public System.Data.Linq.Table<user> users
		{
			get
			{
				return this.GetTable<user>();
			}
		}
		
		public System.Data.Linq.Table<userProduct> userProducts
		{
			get
			{
				return this.GetTable<userProduct>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.insertregistereduser")]
		public int insertregistereduser([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LastName", DbType="VarChar(255)")] string lastName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FirstName", DbType="VarChar(255)")] string firstName, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(16)")] string password)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, lastName, firstName, password);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.selectUserProductDetails")]
		public ISingleResult<selectUserProductDetailsResult> selectUserProductDetails([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> userID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userID);
			return ((ISingleResult<selectUserProductDetailsResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.password")]
	public partial class password : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _passwordID;
		
		private string _password1;
		
		private System.Nullable<int> _UserID;
		
		private EntityRef<user> _user;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnpasswordIDChanging(int value);
    partial void OnpasswordIDChanged();
    partial void Onpassword1Changing(string value);
    partial void Onpassword1Changed();
    partial void OnUserIDChanging(System.Nullable<int> value);
    partial void OnUserIDChanged();
    #endregion
		
		public password()
		{
			this._user = default(EntityRef<user>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_passwordID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int passwordID
		{
			get
			{
				return this._passwordID;
			}
			set
			{
				if ((this._passwordID != value))
				{
					this.OnpasswordIDChanging(value);
					this.SendPropertyChanging();
					this._passwordID = value;
					this.SendPropertyChanged("passwordID");
					this.OnpasswordIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="password", Storage="_password1", DbType="VarChar(16)")]
		public string password1
		{
			get
			{
				return this._password1;
			}
			set
			{
				if ((this._password1 != value))
				{
					this.Onpassword1Changing(value);
					this.SendPropertyChanging();
					this._password1 = value;
					this.SendPropertyChanged("password1");
					this.Onpassword1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int")]
		public System.Nullable<int> UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					if (this._user.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_password", Storage="_user", ThisKey="UserID", OtherKey="UserID", IsForeignKey=true)]
		public user user
		{
			get
			{
				return this._user.Entity;
			}
			set
			{
				user previousValue = this._user.Entity;
				if (((previousValue != value) 
							|| (this._user.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._user.Entity = null;
						previousValue.passwords.Remove(this);
					}
					this._user.Entity = value;
					if ((value != null))
					{
						value.passwords.Add(this);
						this._UserID = value.UserID;
					}
					else
					{
						this._UserID = default(Nullable<int>);
					}
					this.SendPropertyChanged("user");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.products")]
	public partial class product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductID;
		
		private string _ProductName;
		
		private string _ProductDescription;
		
		private System.Nullable<decimal> _ProductPrice;
		
		private EntitySet<userProduct> _userProducts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductIDChanging(int value);
    partial void OnProductIDChanged();
    partial void OnProductNameChanging(string value);
    partial void OnProductNameChanged();
    partial void OnProductDescriptionChanging(string value);
    partial void OnProductDescriptionChanged();
    partial void OnProductPriceChanging(System.Nullable<decimal> value);
    partial void OnProductPriceChanged();
    #endregion
		
		public product()
		{
			this._userProducts = new EntitySet<userProduct>(new Action<userProduct>(this.attach_userProducts), new Action<userProduct>(this.detach_userProducts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProductID
		{
			get
			{
				return this._ProductID;
			}
			set
			{
				if ((this._ProductID != value))
				{
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._ProductID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductName", DbType="VarChar(255)")]
		public string ProductName
		{
			get
			{
				return this._ProductName;
			}
			set
			{
				if ((this._ProductName != value))
				{
					this.OnProductNameChanging(value);
					this.SendPropertyChanging();
					this._ProductName = value;
					this.SendPropertyChanged("ProductName");
					this.OnProductNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductDescription", DbType="VarChar(1000)")]
		public string ProductDescription
		{
			get
			{
				return this._ProductDescription;
			}
			set
			{
				if ((this._ProductDescription != value))
				{
					this.OnProductDescriptionChanging(value);
					this.SendPropertyChanging();
					this._ProductDescription = value;
					this.SendPropertyChanged("ProductDescription");
					this.OnProductDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductPrice", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> ProductPrice
		{
			get
			{
				return this._ProductPrice;
			}
			set
			{
				if ((this._ProductPrice != value))
				{
					this.OnProductPriceChanging(value);
					this.SendPropertyChanging();
					this._ProductPrice = value;
					this.SendPropertyChanged("ProductPrice");
					this.OnProductPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="product_userProduct", Storage="_userProducts", ThisKey="ProductID", OtherKey="ProductID")]
		public EntitySet<userProduct> userProducts
		{
			get
			{
				return this._userProducts;
			}
			set
			{
				this._userProducts.Assign(value);
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
		
		private void attach_userProducts(userProduct entity)
		{
			this.SendPropertyChanging();
			entity.product = this;
		}
		
		private void detach_userProducts(userProduct entity)
		{
			this.SendPropertyChanging();
			entity.product = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.users")]
	public partial class user : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserID;
		
		private string _UserName;
		
		private string _LastName;
		
		private string _FirstName;
		
		private EntitySet<password> _passwords;
		
		private EntitySet<userProduct> _userProducts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    #endregion
		
		public user()
		{
			this._passwords = new EntitySet<password>(new Action<password>(this.attach_passwords), new Action<password>(this.detach_passwords));
			this._userProducts = new EntitySet<userProduct>(new Action<userProduct>(this.attach_userProducts), new Action<userProduct>(this.detach_userProducts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UserID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(50)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(255)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(255)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_password", Storage="_passwords", ThisKey="UserID", OtherKey="UserID")]
		public EntitySet<password> passwords
		{
			get
			{
				return this._passwords;
			}
			set
			{
				this._passwords.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_userProduct", Storage="_userProducts", ThisKey="UserID", OtherKey="UserID")]
		public EntitySet<userProduct> userProducts
		{
			get
			{
				return this._userProducts;
			}
			set
			{
				this._userProducts.Assign(value);
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
		
		private void attach_passwords(password entity)
		{
			this.SendPropertyChanging();
			entity.user = this;
		}
		
		private void detach_passwords(password entity)
		{
			this.SendPropertyChanging();
			entity.user = null;
		}
		
		private void attach_userProducts(userProduct entity)
		{
			this.SendPropertyChanging();
			entity.user = this;
		}
		
		private void detach_userProducts(userProduct entity)
		{
			this.SendPropertyChanging();
			entity.user = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.userProducts")]
	public partial class userProduct : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Nullable<int> _UserID;
		
		private System.Nullable<int> _ProductID;
		
		private System.Nullable<System.DateTime> _OrderDate;
		
		private int _ID;
		
		private EntityRef<product> _product;
		
		private EntityRef<user> _user;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(System.Nullable<int> value);
    partial void OnUserIDChanged();
    partial void OnProductIDChanging(System.Nullable<int> value);
    partial void OnProductIDChanged();
    partial void OnOrderDateChanging(System.Nullable<System.DateTime> value);
    partial void OnOrderDateChanged();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    #endregion
		
		public userProduct()
		{
			this._product = default(EntityRef<product>);
			this._user = default(EntityRef<user>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int")]
		public System.Nullable<int> UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					if (this._user.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductID", DbType="Int")]
		public System.Nullable<int> ProductID
		{
			get
			{
				return this._ProductID;
			}
			set
			{
				if ((this._ProductID != value))
				{
					if (this._product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._ProductID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> OrderDate
		{
			get
			{
				return this._OrderDate;
			}
			set
			{
				if ((this._OrderDate != value))
				{
					this.OnOrderDateChanging(value);
					this.SendPropertyChanging();
					this._OrderDate = value;
					this.SendPropertyChanged("OrderDate");
					this.OnOrderDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="product_userProduct", Storage="_product", ThisKey="ProductID", OtherKey="ProductID", IsForeignKey=true)]
		public product product
		{
			get
			{
				return this._product.Entity;
			}
			set
			{
				product previousValue = this._product.Entity;
				if (((previousValue != value) 
							|| (this._product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._product.Entity = null;
						previousValue.userProducts.Remove(this);
					}
					this._product.Entity = value;
					if ((value != null))
					{
						value.userProducts.Add(this);
						this._ProductID = value.ProductID;
					}
					else
					{
						this._ProductID = default(Nullable<int>);
					}
					this.SendPropertyChanged("product");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_userProduct", Storage="_user", ThisKey="UserID", OtherKey="UserID", IsForeignKey=true)]
		public user user
		{
			get
			{
				return this._user.Entity;
			}
			set
			{
				user previousValue = this._user.Entity;
				if (((previousValue != value) 
							|| (this._user.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._user.Entity = null;
						previousValue.userProducts.Remove(this);
					}
					this._user.Entity = value;
					if ((value != null))
					{
						value.userProducts.Add(this);
						this._UserID = value.UserID;
					}
					else
					{
						this._UserID = default(Nullable<int>);
					}
					this.SendPropertyChanged("user");
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
	
	public partial class selectUserProductDetailsResult
	{
		
		private System.Nullable<int> _UserID;
		
		private int _ProductID;
		
		private System.Nullable<System.DateTime> _OrderDate;
		
		private string _ProductName;
		
		private string _ProductDescription;
		
		private System.Nullable<decimal> _ProductPrice;
		
		public selectUserProductDetailsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int")]
		public System.Nullable<int> UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this._UserID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductID", DbType="Int NOT NULL")]
		public int ProductID
		{
			get
			{
				return this._ProductID;
			}
			set
			{
				if ((this._ProductID != value))
				{
					this._ProductID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> OrderDate
		{
			get
			{
				return this._OrderDate;
			}
			set
			{
				if ((this._OrderDate != value))
				{
					this._OrderDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductName", DbType="VarChar(255)")]
		public string ProductName
		{
			get
			{
				return this._ProductName;
			}
			set
			{
				if ((this._ProductName != value))
				{
					this._ProductName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductDescription", DbType="VarChar(1000)")]
		public string ProductDescription
		{
			get
			{
				return this._ProductDescription;
			}
			set
			{
				if ((this._ProductDescription != value))
				{
					this._ProductDescription = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductPrice", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> ProductPrice
		{
			get
			{
				return this._ProductPrice;
			}
			set
			{
				if ((this._ProductPrice != value))
				{
					this._ProductPrice = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
