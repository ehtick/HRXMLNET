// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.0.0.19662
//    <NameSpace>HRXML.Net</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>True</UseBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>True</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><AutomaticProperties>False</AutomaticProperties><DisableDebug>False</DisableDebug><CustomUsings></CustomUsings>
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
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DressCodeType", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class DressCodeType : EntityBase<DressCodeType>
    {

        private bool suppliedByOrganizationField;

        private bool suppliedByOrganizationFieldSpecified;

        private string valueField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool suppliedByOrganization
        {
            get
            {
                return this.suppliedByOrganizationField;
            }
            set
            {
                if ((suppliedByOrganizationField.Equals(value) != true))
                {
                    this.suppliedByOrganizationField = value;
                    this.OnPropertyChanged("suppliedByOrganization");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool suppliedByOrganizationSpecified
        {
            get
            {
                return this.suppliedByOrganizationFieldSpecified;
            }
            set
            {
                if ((suppliedByOrganizationFieldSpecified.Equals(value) != true))
                {
                    this.suppliedByOrganizationFieldSpecified = value;
                    this.OnPropertyChanged("suppliedByOrganizationSpecified");
                }
            }
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                if ((this.valueField != null))
                {
                    if ((valueField.Equals(value) != true))
                    {
                        this.valueField = value;
                        this.OnPropertyChanged("Value");
                    }
                }
                else
                {
                    this.valueField = value;
                    this.OnPropertyChanged("Value");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "SafetyEquipmentType", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class SafetyEquipmentType : EntityBase<SafetyEquipmentType>
    {

        private bool suppliedByOrganizationField;

        private bool suppliedByOrganizationFieldSpecified;

        private string valueField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool suppliedByOrganization
        {
            get
            {
                return this.suppliedByOrganizationField;
            }
            set
            {
                if ((suppliedByOrganizationField.Equals(value) != true))
                {
                    this.suppliedByOrganizationField = value;
                    this.OnPropertyChanged("suppliedByOrganization");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool suppliedByOrganizationSpecified
        {
            get
            {
                return this.suppliedByOrganizationFieldSpecified;
            }
            set
            {
                if ((suppliedByOrganizationFieldSpecified.Equals(value) != true))
                {
                    this.suppliedByOrganizationFieldSpecified = value;
                    this.OnPropertyChanged("suppliedByOrganizationSpecified");
                }
            }
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                if ((this.valueField != null))
                {
                    if ((valueField.Equals(value) != true))
                    {
                        this.valueField = value;
                        this.OnPropertyChanged("Value");
                    }
                }
                else
                {
                    this.valueField = value;
                    this.OnPropertyChanged("Value");
                }
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Xml.Serialization.XmlRootAttribute("WorkSiteEnvironment", Namespace = "http://ns.hr-xml.org/2007-04-15", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "WorkSiteEnvironmentType", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class WorkSiteEnvironmentType : EntityBase<WorkSiteEnvironmentType>
    {

        private string environmentNameField;

        private EntityIdType environmentIdField;

        private EntityIdType workSiteIdField;

        private WorkSiteEnvironmentTypeDescription descriptionField;

        private List<WorkSiteEnvironmentTypeConsiderations> considerationsField;

        private UserAreaType userAreaField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EnvironmentName
        {
            get
            {
                return this.environmentNameField;
            }
            set
            {
                if ((this.environmentNameField != null))
                {
                    if ((environmentNameField.Equals(value) != true))
                    {
                        this.environmentNameField = value;
                        this.OnPropertyChanged("EnvironmentName");
                    }
                }
                else
                {
                    this.environmentNameField = value;
                    this.OnPropertyChanged("EnvironmentName");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public EntityIdType EnvironmentId
        {
            get
            {
                return this.environmentIdField;
            }
            set
            {
                if ((this.environmentIdField != null))
                {
                    if ((environmentIdField.Equals(value) != true))
                    {
                        this.environmentIdField = value;
                        this.OnPropertyChanged("EnvironmentId");
                    }
                }
                else
                {
                    this.environmentIdField = value;
                    this.OnPropertyChanged("EnvironmentId");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public EntityIdType WorkSiteId
        {
            get
            {
                return this.workSiteIdField;
            }
            set
            {
                if ((this.workSiteIdField != null))
                {
                    if ((workSiteIdField.Equals(value) != true))
                    {
                        this.workSiteIdField = value;
                        this.OnPropertyChanged("WorkSiteId");
                    }
                }
                else
                {
                    this.workSiteIdField = value;
                    this.OnPropertyChanged("WorkSiteId");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public WorkSiteEnvironmentTypeDescription Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                if ((this.descriptionField != null))
                {
                    if ((descriptionField.Equals(value) != true))
                    {
                        this.descriptionField = value;
                        this.OnPropertyChanged("Description");
                    }
                }
                else
                {
                    this.descriptionField = value;
                    this.OnPropertyChanged("Description");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("Considerations")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<WorkSiteEnvironmentTypeConsiderations> Considerations
        {
            get
            {
                return this.considerationsField;
            }
            set
            {
                if ((this.considerationsField != null))
                {
                    if ((considerationsField.Equals(value) != true))
                    {
                        this.considerationsField = value;
                        this.OnPropertyChanged("Considerations");
                    }
                }
                else
                {
                    this.considerationsField = value;
                    this.OnPropertyChanged("Considerations");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserAreaType UserArea
        {
            get
            {
                return this.userAreaField;
            }
            set
            {
                if ((this.userAreaField != null))
                {
                    if ((userAreaField.Equals(value) != true))
                    {
                        this.userAreaField = value;
                        this.OnPropertyChanged("UserArea");
                    }
                }
                else
                {
                    this.userAreaField = value;
                    this.OnPropertyChanged("UserArea");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "WorkSiteEnvironmentTypeDescription", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class WorkSiteEnvironmentTypeDescription : EntityBase<WorkSiteEnvironmentTypeDescription>
    {

        private string langField;

        private string valueField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                if ((this.langField != null))
                {
                    if ((langField.Equals(value) != true))
                    {
                        this.langField = value;
                        this.OnPropertyChanged("lang");
                    }
                }
                else
                {
                    this.langField = value;
                    this.OnPropertyChanged("lang");
                }
            }
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                if ((this.valueField != null))
                {
                    if ((valueField.Equals(value) != true))
                    {
                        this.valueField = value;
                        this.OnPropertyChanged("Value");
                    }
                }
                else
                {
                    this.valueField = value;
                    this.OnPropertyChanged("Value");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "WorkSiteEnvironmentTypeConsiderations", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class WorkSiteEnvironmentTypeConsiderations : EntityBase<WorkSiteEnvironmentTypeConsiderations>
    {

        private List<string> generalField;

        private List<string> physicalField;

        private List<SafetyEquipmentType> safetyEquipmentField;

        private List<DressCodeType> dressCodeField;

        private UserAreaType userAreaField;

        private string langField;

        [System.Xml.Serialization.XmlElementAttribute("General")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<string> General
        {
            get
            {
                if ((this.generalField == null))
                {
                    this.generalField = new List<string>();
                }
                return this.generalField;
            }
            set
            {
                if ((this.generalField != null))
                {
                    if ((generalField.Equals(value) != true))
                    {
                        this.generalField = value;
                        this.OnPropertyChanged("General");
                    }
                }
                else
                {
                    this.generalField = value;
                    this.OnPropertyChanged("General");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("Physical")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<string> Physical
        {
            get
            {
                if ((this.physicalField == null))
                {
                    this.physicalField = new List<string>();
                }
                return this.physicalField;
            }
            set
            {
                if ((this.physicalField != null))
                {
                    if ((physicalField.Equals(value) != true))
                    {
                        this.physicalField = value;
                        this.OnPropertyChanged("Physical");
                    }
                }
                else
                {
                    this.physicalField = value;
                    this.OnPropertyChanged("Physical");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("SafetyEquipment")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<SafetyEquipmentType> SafetyEquipment
        {
            get
            {
                if ((this.safetyEquipmentField == null))
                {
                    this.safetyEquipmentField = new List<SafetyEquipmentType>();
                }
                return this.safetyEquipmentField;
            }
            set
            {
                if ((this.safetyEquipmentField != null))
                {
                    if ((safetyEquipmentField.Equals(value) != true))
                    {
                        this.safetyEquipmentField = value;
                        this.OnPropertyChanged("SafetyEquipment");
                    }
                }
                else
                {
                    this.safetyEquipmentField = value;
                    this.OnPropertyChanged("SafetyEquipment");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("DressCode")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<DressCodeType> DressCode
        {
            get
            {
                if ((this.dressCodeField == null))
                {
                    this.dressCodeField = new List<DressCodeType>();
                }
                return this.dressCodeField;
            }
            set
            {
                if ((this.dressCodeField != null))
                {
                    if ((dressCodeField.Equals(value) != true))
                    {
                        this.dressCodeField = value;
                        this.OnPropertyChanged("DressCode");
                    }
                }
                else
                {
                    this.dressCodeField = value;
                    this.OnPropertyChanged("DressCode");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserAreaType UserArea
        {
            get
            {
                return this.userAreaField;
            }
            set
            {
                if ((this.userAreaField != null))
                {
                    if ((userAreaField.Equals(value) != true))
                    {
                        this.userAreaField = value;
                        this.OnPropertyChanged("UserArea");
                    }
                }
                else
                {
                    this.userAreaField = value;
                    this.OnPropertyChanged("UserArea");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                if ((this.langField != null))
                {
                    if ((langField.Equals(value) != true))
                    {
                        this.langField = value;
                        this.OnPropertyChanged("lang");
                    }
                }
                else
                {
                    this.langField = value;
                    this.OnPropertyChanged("lang");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Xml.Serialization.XmlRootAttribute("WorkSite", Namespace = "http://ns.hr-xml.org/2007-04-15", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "WorkSiteType", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class WorkSiteType : EntityBase<WorkSiteType>
    {

        private string workSiteNameField;

        private EntityIdType workSiteIdField;

        private List<WorkSiteTypeDetails> detailsField;

        private PostalAddressType postalAddressField;

        private List<LanguageDependentTextType> travelDirectionsField;

        private List<LanguageDependentTextType> parkingInstructionsField;

        private List<WorkSiteEnvironmentType> workSiteEnvironmentField;

        private UserAreaType userAreaField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WorkSiteName
        {
            get
            {
                return this.workSiteNameField;
            }
            set
            {
                if ((this.workSiteNameField != null))
                {
                    if ((workSiteNameField.Equals(value) != true))
                    {
                        this.workSiteNameField = value;
                        this.OnPropertyChanged("WorkSiteName");
                    }
                }
                else
                {
                    this.workSiteNameField = value;
                    this.OnPropertyChanged("WorkSiteName");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public EntityIdType WorkSiteId
        {
            get
            {
                return this.workSiteIdField;
            }
            set
            {
                if ((this.workSiteIdField != null))
                {
                    if ((workSiteIdField.Equals(value) != true))
                    {
                        this.workSiteIdField = value;
                        this.OnPropertyChanged("WorkSiteId");
                    }
                }
                else
                {
                    this.workSiteIdField = value;
                    this.OnPropertyChanged("WorkSiteId");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("Details")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<WorkSiteTypeDetails> Details
        {
            get
            {
                if ((this.detailsField == null))
                {
                    this.detailsField = new List<WorkSiteTypeDetails>();
                }
                return this.detailsField;
            }
            set
            {
                if ((this.detailsField != null))
                {
                    if ((detailsField.Equals(value) != true))
                    {
                        this.detailsField = value;
                        this.OnPropertyChanged("Details");
                    }
                }
                else
                {
                    this.detailsField = value;
                    this.OnPropertyChanged("Details");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public PostalAddressType PostalAddress
        {
            get
            {
                return this.postalAddressField;
            }
            set
            {
                if ((this.postalAddressField != null))
                {
                    if ((postalAddressField.Equals(value) != true))
                    {
                        this.postalAddressField = value;
                        this.OnPropertyChanged("PostalAddress");
                    }
                }
                else
                {
                    this.postalAddressField = value;
                    this.OnPropertyChanged("PostalAddress");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("TravelDirections")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<LanguageDependentTextType> TravelDirections
        {
            get
            {
                if ((this.travelDirectionsField == null))
                {
                    this.travelDirectionsField = new List<LanguageDependentTextType>();
                }
                return this.travelDirectionsField;
            }
            set
            {
                if ((this.travelDirectionsField != null))
                {
                    if ((travelDirectionsField.Equals(value) != true))
                    {
                        this.travelDirectionsField = value;
                        this.OnPropertyChanged("TravelDirections");
                    }
                }
                else
                {
                    this.travelDirectionsField = value;
                    this.OnPropertyChanged("TravelDirections");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ParkingInstructions")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<LanguageDependentTextType> ParkingInstructions
        {
            get
            {
                if ((this.parkingInstructionsField == null))
                {
                    this.parkingInstructionsField = new List<LanguageDependentTextType>();
                }
                return this.parkingInstructionsField;
            }
            set
            {
                if ((this.parkingInstructionsField != null))
                {
                    if ((parkingInstructionsField.Equals(value) != true))
                    {
                        this.parkingInstructionsField = value;
                        this.OnPropertyChanged("ParkingInstructions");
                    }
                }
                else
                {
                    this.parkingInstructionsField = value;
                    this.OnPropertyChanged("ParkingInstructions");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("WorkSiteEnvironment")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<WorkSiteEnvironmentType> WorkSiteEnvironment
        {
            get
            {
                if ((this.workSiteEnvironmentField == null))
                {
                    this.workSiteEnvironmentField = new List<WorkSiteEnvironmentType>();
                }
                return this.workSiteEnvironmentField;
            }
            set
            {
                if ((this.workSiteEnvironmentField != null))
                {
                    if ((workSiteEnvironmentField.Equals(value) != true))
                    {
                        this.workSiteEnvironmentField = value;
                        this.OnPropertyChanged("WorkSiteEnvironment");
                    }
                }
                else
                {
                    this.workSiteEnvironmentField = value;
                    this.OnPropertyChanged("WorkSiteEnvironment");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserAreaType UserArea
        {
            get
            {
                return this.userAreaField;
            }
            set
            {
                if ((this.userAreaField != null))
                {
                    if ((userAreaField.Equals(value) != true))
                    {
                        this.userAreaField = value;
                        this.OnPropertyChanged("UserArea");
                    }
                }
                else
                {
                    this.userAreaField = value;
                    this.OnPropertyChanged("UserArea");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "WorkSiteTypeDetails", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class WorkSiteTypeDetails : LanguageDependentTextType
    {

        private string typeField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                if ((this.typeField != null))
                {
                    if ((typeField.Equals(value) != true))
                    {
                        this.typeField = value;
                        this.OnPropertyChanged("type");
                    }
                }
                else
                {
                    this.typeField = value;
                    this.OnPropertyChanged("type");
                }
            }
        }
    }

}
