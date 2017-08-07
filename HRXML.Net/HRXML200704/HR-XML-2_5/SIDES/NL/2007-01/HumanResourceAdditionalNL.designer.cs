// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.3.0.36516
//    <NameSpace>HRXML.Net.V200701</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><EnableLasyLoading>False</EnableLasyLoading><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>True</UseBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>True</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><AutomaticProperties>False</AutomaticProperties><DisableDebug>False</DisableDebug><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace HRXML.Net.V200701
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.setu.nl/2007-01")]
    [System.Xml.Serialization.XmlRootAttribute("HumanResourceAdditionalNL", Namespace = "http://ns.setu.nl/2007-01", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "HumanResourceAdditionalNLType", Namespace = "http://ns.setu.nl/2007-01")]
    public partial class HumanResourceAdditionalNLType : EntityBase<HumanResourceAdditionalNLType>
    {

        private string offerIdField;

        private StaffingShiftType staffingShiftField;

        private decimal daysPerWeekField;

        private bool daysPerWeekFieldSpecified;

        private string reasonOfChangeField;

        private System.DateTime birthDateField;

        private bool birthDateFieldSpecified;

        private SexType sexField;

        private bool sexFieldSpecified;

        private CustomerReportingRequirementsType customerReportingRequirementsField;

        private string identificationDocumentTypeField;

        private string identificationDocumentIdField;

        /// <summary>
        /// HumanResourceAdditionalNLType class constructor
        /// </summary>
        public HumanResourceAdditionalNLType()
        {
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OfferId
        {
            get
            {
                return this.offerIdField;
            }
            set
            {
                if ((this.offerIdField != null))
                {
                    if ((offerIdField.Equals(value) != true))
                    {
                        this.offerIdField = value;
                        this.OnPropertyChanged("OfferId");
                    }
                }
                else
                {
                    this.offerIdField = value;
                    this.OnPropertyChanged("OfferId");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public StaffingShiftType StaffingShift
        {
            get
            {
                return this.staffingShiftField;
            }
            set
            {
                if ((this.staffingShiftField != null))
                {
                    if ((staffingShiftField.Equals(value) != true))
                    {
                        this.staffingShiftField = value;
                        this.OnPropertyChanged("StaffingShift");
                    }
                }
                else
                {
                    this.staffingShiftField = value;
                    this.OnPropertyChanged("StaffingShift");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal DaysPerWeek
        {
            get
            {
                return this.daysPerWeekField;
            }
            set
            {
                    if ((daysPerWeekField.Equals(value) != true))
                    {
                        this.daysPerWeekField = value;
                        this.OnPropertyChanged("DaysPerWeek");
                    }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool DaysPerWeekSpecified
        {
            get
            {
                return this.daysPerWeekFieldSpecified;
            }
            set
            {
                if ((daysPerWeekFieldSpecified.Equals(value) != true))
                {
                    this.daysPerWeekFieldSpecified = value;
                    this.OnPropertyChanged("DaysPerWeekSpecified");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReasonOfChange
        {
            get
            {
                return this.reasonOfChangeField;
            }
            set
            {
                if ((this.reasonOfChangeField != null))
                {
                    if ((reasonOfChangeField.Equals(value) != true))
                    {
                        this.reasonOfChangeField = value;
                        this.OnPropertyChanged("ReasonOfChange");
                    }
                }
                else
                {
                    this.reasonOfChangeField = value;
                    this.OnPropertyChanged("ReasonOfChange");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime BirthDate
        {
            get
            {
                return this.birthDateField;
            }
            set
            {
                if ((birthDateField.Equals(value) != true))
                {
                    this.birthDateField = value;
                    this.OnPropertyChanged("BirthDate");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BirthDateSpecified
        {
            get
            {
                return this.birthDateFieldSpecified;
            }
            set
            {
                if ((birthDateFieldSpecified.Equals(value) != true))
                {
                    this.birthDateFieldSpecified = value;
                    this.OnPropertyChanged("BirthDateSpecified");
                }
            }
        }

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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool SexSpecified
        {
            get
            {
                return this.sexFieldSpecified;
            }
            set
            {
                if ((sexFieldSpecified.Equals(value) != true))
                {
                    this.sexFieldSpecified = value;
                    this.OnPropertyChanged("SexSpecified");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public CustomerReportingRequirementsType CustomerReportingRequirements
        {
            get
            {
                return this.customerReportingRequirementsField;
            }
            set
            {
                if ((this.customerReportingRequirementsField != null))
                {
                    if ((customerReportingRequirementsField.Equals(value) != true))
                    {
                        this.customerReportingRequirementsField = value;
                        this.OnPropertyChanged("CustomerReportingRequirements");
                    }
                }
                else
                {
                    this.customerReportingRequirementsField = value;
                    this.OnPropertyChanged("CustomerReportingRequirements");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdentificationDocumentType
        {
            get
            {
                return this.identificationDocumentTypeField;
            }
            set
            {
                if ((this.identificationDocumentTypeField != null))
                {
                    if ((identificationDocumentTypeField.Equals(value) != true))
                    {
                        this.identificationDocumentTypeField = value;
                        this.OnPropertyChanged("IdentificationDocumentType");
                    }
                }
                else
                {
                    this.identificationDocumentTypeField = value;
                    this.OnPropertyChanged("IdentificationDocumentType");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdentificationDocumentId
        {
            get
            {
                return this.identificationDocumentIdField;
            }
            set
            {
                if ((this.identificationDocumentIdField != null))
                {
                    if ((identificationDocumentIdField.Equals(value) != true))
                    {
                        this.identificationDocumentIdField = value;
                        this.OnPropertyChanged("IdentificationDocumentId");
                    }
                }
                else
                {
                    this.identificationDocumentIdField = value;
                    this.OnPropertyChanged("IdentificationDocumentId");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.setu.nl/2007-01")]
    public enum SexType
    {

        /// <remarks/>
        male,

        /// <remarks/>
        female,

        /// <remarks/>
        unknown,
    }
}
