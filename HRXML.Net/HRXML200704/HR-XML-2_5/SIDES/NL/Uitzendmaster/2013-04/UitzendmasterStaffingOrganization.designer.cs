// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>HRXML.Net</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>True</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>True</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>ASCII</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace HRXML.Net
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.IO;
    using System.Text;
    using System.Collections.Generic;
    using System.Runtime.Serialization;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.combil.nl/2013-04")]
    [System.Xml.Serialization.XmlRootAttribute("UitzendmasterStaffingOrganization", Namespace = "http://www.combil.nl/2013-04", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "UitzendmasterStaffingOrganizationType", Namespace = "http://www.combil.nl/2013-04")]
    public partial class UitzendmasterStaffingOrganizationType : EntityBase<UitzendmasterStaffingOrganizationType>
    {

        private UitzendmasterAccountManagerType accountManagerField;

        private string vATNumberField;

        private UitzendmasterLocationType locationField;

        private System.DateTime modifiedField;

        private List<UitzendmasterCostCenterType> costCenterField;

        private List<UitzendmasterContactType> contactField;

        /// <summary>
        /// UitzendmasterStaffingOrganizationType class constructor
        /// </summary>
        public UitzendmasterStaffingOrganizationType()
        {
            this.contactField = new List<UitzendmasterContactType>();
            this.costCenterField = new List<UitzendmasterCostCenterType>();
            this.locationField = new UitzendmasterLocationType();
            this.accountManagerField = new UitzendmasterAccountManagerType();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UitzendmasterAccountManagerType AccountManager
        {
            get
            {
                return this.accountManagerField;
            }
            set
            {
                if ((this.accountManagerField != null))
                {
                    if ((accountManagerField.Equals(value) != true))
                    {
                        this.accountManagerField = value;
                        this.OnPropertyChanged("AccountManager");
                    }
                }
                else
                {
                    this.accountManagerField = value;
                    this.OnPropertyChanged("AccountManager");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VATNumber
        {
            get
            {
                return this.vATNumberField;
            }
            set
            {
                if ((this.vATNumberField != null))
                {
                    if ((vATNumberField.Equals(value) != true))
                    {
                        this.vATNumberField = value;
                        this.OnPropertyChanged("VATNumber");
                    }
                }
                else
                {
                    this.vATNumberField = value;
                    this.OnPropertyChanged("VATNumber");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UitzendmasterLocationType Location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                if ((this.locationField != null))
                {
                    if ((locationField.Equals(value) != true))
                    {
                        this.locationField = value;
                        this.OnPropertyChanged("Location");
                    }
                }
                else
                {
                    this.locationField = value;
                    this.OnPropertyChanged("Location");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Modified
        {
            get
            {
                return this.modifiedField;
            }
            set
            {
                if ((modifiedField.Equals(value) != true))
                {
                    this.modifiedField = value;
                    this.OnPropertyChanged("Modified");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("CostCenter", Order = 4)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<UitzendmasterCostCenterType> CostCenter
        {
            get
            {
                return this.costCenterField;
            }
            set
            {
                if ((this.costCenterField != null))
                {
                    if ((costCenterField.Equals(value) != true))
                    {
                        this.costCenterField = value;
                        this.OnPropertyChanged("CostCenter");
                    }
                }
                else
                {
                    this.costCenterField = value;
                    this.OnPropertyChanged("CostCenter");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("Contact", Order = 5)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<UitzendmasterContactType> Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                if ((this.contactField != null))
                {
                    if ((contactField.Equals(value) != true))
                    {
                        this.contactField = value;
                        this.OnPropertyChanged("Contact");
                    }
                }
                else
                {
                    this.contactField = value;
                    this.OnPropertyChanged("Contact");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.combil.nl/2013-04")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.combil.nl/2013-04", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "UitzendmasterAccountManagerType", Namespace = "http://www.combil.nl/2013-04")]
    public partial class UitzendmasterAccountManagerType : EntityBase<UitzendmasterAccountManagerType>
    {

        private string codeField;

        private string nameField;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer", Order = 0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                if ((this.codeField != null))
                {
                    if ((codeField.Equals(value) != true))
                    {
                        this.codeField = value;
                        this.OnPropertyChanged("Code");
                    }
                }
                else
                {
                    this.codeField = value;
                    this.OnPropertyChanged("Code");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                if ((this.nameField != null))
                {
                    if ((nameField.Equals(value) != true))
                    {
                        this.nameField = value;
                        this.OnPropertyChanged("Name");
                    }
                }
                else
                {
                    this.nameField = value;
                    this.OnPropertyChanged("Name");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.combil.nl/2013-04")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.combil.nl/2013-04", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "UitzendmasterContactType", Namespace = "http://www.combil.nl/2013-04")]
    public partial class UitzendmasterContactType : EntityBase<UitzendmasterContactType>
    {

        private List<EntityIdType> contactIdField;

        private string initialsField;

        private SexType sexField;

        /// <summary>
        /// UitzendmasterContactType class constructor
        /// </summary>
        public UitzendmasterContactType()
        {
            this.contactIdField = new List<EntityIdType>();
        }

        [System.Xml.Serialization.XmlElementAttribute("ContactId", Order = 0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<EntityIdType> ContactId
        {
            get
            {
                return this.contactIdField;
            }
            set
            {
                if ((this.contactIdField != null))
                {
                    if ((contactIdField.Equals(value) != true))
                    {
                        this.contactIdField = value;
                        this.OnPropertyChanged("ContactId");
                    }
                }
                else
                {
                    this.contactIdField = value;
                    this.OnPropertyChanged("ContactId");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Initials
        {
            get
            {
                return this.initialsField;
            }
            set
            {
                if ((this.initialsField != null))
                {
                    if ((initialsField.Equals(value) != true))
                    {
                        this.initialsField = value;
                        this.OnPropertyChanged("Initials");
                    }
                }
                else
                {
                    this.initialsField = value;
                    this.OnPropertyChanged("Initials");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SexType Sex
        {
            get
            {
                return this.sexField;
            }
            set
            {
                if ((sexField.Equals(value) != true))
                {
                    this.sexField = value;
                    this.OnPropertyChanged("Sex");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.combil.nl/2013-04")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.combil.nl/2013-04", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "UitzendmasterCostCenterType", Namespace = "http://www.combil.nl/2013-04")]
    public partial class UitzendmasterCostCenterType : EntityBase<UitzendmasterCostCenterType>
    {

        private string codeField;

        private string nameField;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer", Order = 0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                if ((this.codeField != null))
                {
                    if ((codeField.Equals(value) != true))
                    {
                        this.codeField = value;
                        this.OnPropertyChanged("Code");
                    }
                }
                else
                {
                    this.codeField = value;
                    this.OnPropertyChanged("Code");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                if ((this.nameField != null))
                {
                    if ((nameField.Equals(value) != true))
                    {
                        this.nameField = value;
                        this.OnPropertyChanged("Name");
                    }
                }
                else
                {
                    this.nameField = value;
                    this.OnPropertyChanged("Name");
                }
            }
        }
    }

}
