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
namespace DemoDatabaseModel
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DemoDatabaseDB : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DemoDatabaseDB object using the connection string found in the 'DemoDatabaseDB' section of the application configuration file.
        /// </summary>
        public DemoDatabaseDB() : base("name=DemoDatabaseDB", "DemoDatabaseDB")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DemoDatabaseDB object.
        /// </summary>
        public DemoDatabaseDB(string connectionString) : base(connectionString, "DemoDatabaseDB")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DemoDatabaseDB object.
        /// </summary>
        public DemoDatabaseDB(EntityConnection connection) : base(connection, "DemoDatabaseDB")
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
        public ObjectSet<File> Files
        {
            get
            {
                if ((_Files == null))
                {
                    _Files = base.CreateObjectSet<File>("Files");
                }
                return _Files;
            }
        }
        private ObjectSet<File> _Files;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<GlobalLanguage> GlobalLanguages
        {
            get
            {
                if ((_GlobalLanguages == null))
                {
                    _GlobalLanguages = base.CreateObjectSet<GlobalLanguage>("GlobalLanguages");
                }
                return _GlobalLanguages;
            }
        }
        private ObjectSet<GlobalLanguage> _GlobalLanguages;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Menu> Menus
        {
            get
            {
                if ((_Menus == null))
                {
                    _Menus = base.CreateObjectSet<Menu>("Menus");
                }
                return _Menus;
            }
        }
        private ObjectSet<Menu> _Menus;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<PersonalDetail> PersonalDetails
        {
            get
            {
                if ((_PersonalDetails == null))
                {
                    _PersonalDetails = base.CreateObjectSet<PersonalDetail>("PersonalDetails");
                }
                return _PersonalDetails;
            }
        }
        private ObjectSet<PersonalDetail> _PersonalDetails;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Files EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToFiles(File file)
        {
            base.AddObject("Files", file);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the GlobalLanguages EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToGlobalLanguages(GlobalLanguage globalLanguage)
        {
            base.AddObject("GlobalLanguages", globalLanguage);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Menus EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMenus(Menu menu)
        {
            base.AddObject("Menus", menu);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the PersonalDetails EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPersonalDetails(PersonalDetail personalDetail)
        {
            base.AddObject("PersonalDetails", personalDetail);
        }

        #endregion

        #region Function Imports
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="autoId">No Metadata Documentation available.</param>
        public ObjectResult<GetRecords_Result> GetRecords(Nullable<global::System.Int32> autoId)
        {
            ObjectParameter autoIdParameter;
            if (autoId.HasValue)
            {
                autoIdParameter = new ObjectParameter("AutoId", autoId);
            }
            else
            {
                autoIdParameter = new ObjectParameter("AutoId", typeof(global::System.Int32));
            }
    
            return base.ExecuteFunction<GetRecords_Result>("GetRecords", autoIdParameter);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DemoDatabaseModel", Name="File")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class File : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new File object.
        /// </summary>
        /// <param name="autoId">Initial value of the AutoId property.</param>
        /// <param name="fileName">Initial value of the FileName property.</param>
        /// <param name="fileContent">Initial value of the FileContent property.</param>
        public static File CreateFile(global::System.Int32 autoId, global::System.String fileName, global::System.Byte[] fileContent)
        {
            File file = new File();
            file.AutoId = autoId;
            file.FileName = fileName;
            file.FileContent = fileContent;
            return file;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 AutoId
        {
            get
            {
                return _AutoId;
            }
            set
            {
                if (_AutoId != value)
                {
                    OnAutoIdChanging(value);
                    ReportPropertyChanging("AutoId");
                    _AutoId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("AutoId");
                    OnAutoIdChanged();
                }
            }
        }
        private global::System.Int32 _AutoId;
        partial void OnAutoIdChanging(global::System.Int32 value);
        partial void OnAutoIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FileName
        {
            get
            {
                return _FileName;
            }
            set
            {
                OnFileNameChanging(value);
                ReportPropertyChanging("FileName");
                _FileName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("FileName");
                OnFileNameChanged();
            }
        }
        private global::System.String _FileName;
        partial void OnFileNameChanging(global::System.String value);
        partial void OnFileNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Byte[] FileContent
        {
            get
            {
                return StructuralObject.GetValidValue(_FileContent);
            }
            set
            {
                OnFileContentChanging(value);
                ReportPropertyChanging("FileContent");
                _FileContent = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("FileContent");
                OnFileContentChanged();
            }
        }
        private global::System.Byte[] _FileContent;
        partial void OnFileContentChanging(global::System.Byte[] value);
        partial void OnFileContentChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> Active
        {
            get
            {
                return _Active;
            }
            set
            {
                OnActiveChanging(value);
                ReportPropertyChanging("Active");
                _Active = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Active");
                OnActiveChanged();
            }
        }
        private Nullable<global::System.Boolean> _Active;
        partial void OnActiveChanging(Nullable<global::System.Boolean> value);
        partial void OnActiveChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> PersonalDetailsId
        {
            get
            {
                return _PersonalDetailsId;
            }
            set
            {
                OnPersonalDetailsIdChanging(value);
                ReportPropertyChanging("PersonalDetailsId");
                _PersonalDetailsId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("PersonalDetailsId");
                OnPersonalDetailsIdChanged();
            }
        }
        private Nullable<global::System.Int32> _PersonalDetailsId;
        partial void OnPersonalDetailsIdChanging(Nullable<global::System.Int32> value);
        partial void OnPersonalDetailsIdChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DemoDatabaseModel", Name="GlobalLanguage")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class GlobalLanguage : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new GlobalLanguage object.
        /// </summary>
        /// <param name="autoId">Initial value of the AutoId property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        public static GlobalLanguage CreateGlobalLanguage(global::System.Int32 autoId, global::System.String title)
        {
            GlobalLanguage globalLanguage = new GlobalLanguage();
            globalLanguage.AutoId = autoId;
            globalLanguage.Title = title;
            return globalLanguage;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 AutoId
        {
            get
            {
                return _AutoId;
            }
            set
            {
                if (_AutoId != value)
                {
                    OnAutoIdChanging(value);
                    ReportPropertyChanging("AutoId");
                    _AutoId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("AutoId");
                    OnAutoIdChanged();
                }
            }
        }
        private global::System.Int32 _AutoId;
        partial void OnAutoIdChanging(global::System.Int32 value);
        partial void OnAutoIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                if (_Title != value)
                {
                    OnTitleChanging(value);
                    ReportPropertyChanging("Title");
                    _Title = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Title");
                    OnTitleChanged();
                }
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DemoDatabaseModel", Name="Menu")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Menu : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Menu object.
        /// </summary>
        /// <param name="menuId">Initial value of the MenuId property.</param>
        /// <param name="menuName">Initial value of the MenuName property.</param>
        /// <param name="menuDescription">Initial value of the MenuDescription property.</param>
        public static Menu CreateMenu(global::System.Int32 menuId, global::System.String menuName, global::System.String menuDescription)
        {
            Menu menu = new Menu();
            menu.MenuId = menuId;
            menu.MenuName = menuName;
            menu.MenuDescription = menuDescription;
            return menu;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 MenuId
        {
            get
            {
                return _MenuId;
            }
            set
            {
                if (_MenuId != value)
                {
                    OnMenuIdChanging(value);
                    ReportPropertyChanging("MenuId");
                    _MenuId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("MenuId");
                    OnMenuIdChanged();
                }
            }
        }
        private global::System.Int32 _MenuId;
        partial void OnMenuIdChanging(global::System.Int32 value);
        partial void OnMenuIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String MenuName
        {
            get
            {
                return _MenuName;
            }
            set
            {
                OnMenuNameChanging(value);
                ReportPropertyChanging("MenuName");
                _MenuName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("MenuName");
                OnMenuNameChanged();
            }
        }
        private global::System.String _MenuName;
        partial void OnMenuNameChanging(global::System.String value);
        partial void OnMenuNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String MenuDescription
        {
            get
            {
                return _MenuDescription;
            }
            set
            {
                OnMenuDescriptionChanging(value);
                ReportPropertyChanging("MenuDescription");
                _MenuDescription = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("MenuDescription");
                OnMenuDescriptionChanged();
            }
        }
        private global::System.String _MenuDescription;
        partial void OnMenuDescriptionChanging(global::System.String value);
        partial void OnMenuDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> ParentMenuId
        {
            get
            {
                return _ParentMenuId;
            }
            set
            {
                OnParentMenuIdChanging(value);
                ReportPropertyChanging("ParentMenuId");
                _ParentMenuId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ParentMenuId");
                OnParentMenuIdChanged();
            }
        }
        private Nullable<global::System.Int32> _ParentMenuId;
        partial void OnParentMenuIdChanging(Nullable<global::System.Int32> value);
        partial void OnParentMenuIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String MenuUrl
        {
            get
            {
                return _MenuUrl;
            }
            set
            {
                OnMenuUrlChanging(value);
                ReportPropertyChanging("MenuUrl");
                _MenuUrl = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("MenuUrl");
                OnMenuUrlChanged();
            }
        }
        private global::System.String _MenuUrl;
        partial void OnMenuUrlChanging(global::System.String value);
        partial void OnMenuUrlChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DemoDatabaseModel", Name="PersonalDetail")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class PersonalDetail : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new PersonalDetail object.
        /// </summary>
        /// <param name="autoId">Initial value of the AutoId property.</param>
        public static PersonalDetail CreatePersonalDetail(global::System.Int32 autoId)
        {
            PersonalDetail personalDetail = new PersonalDetail();
            personalDetail.AutoId = autoId;
            return personalDetail;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 AutoId
        {
            get
            {
                return _AutoId;
            }
            set
            {
                if (_AutoId != value)
                {
                    OnAutoIdChanging(value);
                    ReportPropertyChanging("AutoId");
                    _AutoId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("AutoId");
                    OnAutoIdChanged();
                }
            }
        }
        private global::System.Int32 _AutoId;
        partial void OnAutoIdChanging(global::System.Int32 value);
        partial void OnAutoIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Age
        {
            get
            {
                return _Age;
            }
            set
            {
                OnAgeChanging(value);
                ReportPropertyChanging("Age");
                _Age = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Age");
                OnAgeChanged();
            }
        }
        private Nullable<global::System.Int32> _Age;
        partial void OnAgeChanging(Nullable<global::System.Int32> value);
        partial void OnAgeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> Active
        {
            get
            {
                return _Active;
            }
            set
            {
                OnActiveChanging(value);
                ReportPropertyChanging("Active");
                _Active = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Active");
                OnActiveChanged();
            }
        }
        private Nullable<global::System.Boolean> _Active;
        partial void OnActiveChanging(Nullable<global::System.Boolean> value);
        partial void OnActiveChanged();

        #endregion

    
    }

    #endregion

    #region ComplexTypes
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmComplexTypeAttribute(NamespaceName="DemoDatabaseModel", Name="GetRecords_Result")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class GetRecords_Result : ComplexObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new GetRecords_Result object.
        /// </summary>
        /// <param name="autoID">Initial value of the AutoID property.</param>
        public static GetRecords_Result CreateGetRecords_Result(global::System.Int32 autoID)
        {
            GetRecords_Result getRecords_Result = new GetRecords_Result();
            getRecords_Result.AutoID = autoID;
            return getRecords_Result;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 AutoID
        {
            get
            {
                return _AutoID;
            }
            set
            {
                OnAutoIDChanging(value);
                ReportPropertyChanging("AutoID");
                _AutoID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("AutoID");
                OnAutoIDChanged();
            }
        }
        private global::System.Int32 _AutoID;
        partial void OnAutoIDChanging(global::System.Int32 value);
        partial void OnAutoIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Age
        {
            get
            {
                return _Age;
            }
            set
            {
                OnAgeChanging(value);
                ReportPropertyChanging("Age");
                _Age = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Age");
                OnAgeChanged();
            }
        }
        private Nullable<global::System.Int32> _Age;
        partial void OnAgeChanging(Nullable<global::System.Int32> value);
        partial void OnAgeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> Active
        {
            get
            {
                return _Active;
            }
            set
            {
                OnActiveChanging(value);
                ReportPropertyChanging("Active");
                _Active = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Active");
                OnActiveChanged();
            }
        }
        private Nullable<global::System.Boolean> _Active;
        partial void OnActiveChanging(Nullable<global::System.Boolean> value);
        partial void OnActiveChanged();

        #endregion

    }

    #endregion

    
}
