// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.33213
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




    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.450")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "LanguageData", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class LanguageData : EntityBase<LanguageData>
    {

        private string languageCodeField;

        private LanguageDataLanguageUsage languageUsageField;

        private string languageCodeQualifierField;

        private LanguageDataUse useField;

        private bool useFieldSpecified;

        public LanguageData()
        {
            this.languageCodeQualifierField = "ISO-639";
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LanguageCode
        {
            get
            {
                return this.languageCodeField;
            }
            set
            {
                if ((this.languageCodeField != null))
                {
                    if ((languageCodeField.Equals(value) != true))
                    {
                        this.languageCodeField = value;
                        this.OnPropertyChanged("LanguageCode");
                    }
                }
                else
                {
                    this.languageCodeField = value;
                    this.OnPropertyChanged("LanguageCode");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LanguageDataLanguageUsage LanguageUsage
        {
            get
            {
                return this.languageUsageField;
            }
            set
            {
                if ((languageUsageField.Equals(value) != true))
                {
                    this.languageUsageField = value;
                    this.OnPropertyChanged("LanguageUsage");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string languageCodeQualifier
        {
            get
            {
                return this.languageCodeQualifierField;
            }
            set
            {
                if ((this.languageCodeQualifierField != null))
                {
                    if ((languageCodeQualifierField.Equals(value) != true))
                    {
                        this.languageCodeQualifierField = value;
                        this.OnPropertyChanged("languageCodeQualifier");
                    }
                }
                else
                {
                    this.languageCodeQualifierField = value;
                    this.OnPropertyChanged("languageCodeQualifier");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LanguageDataUse use
        {
            get
            {
                return this.useField;
            }
            set
            {
                if ((useField.Equals(value) != true))
                {
                    this.useField = value;
                    this.OnPropertyChanged("use");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool useSpecified
        {
            get
            {
                return this.useFieldSpecified;
            }
            set
            {
                if ((useFieldSpecified.Equals(value) != true))
                {
                    this.useFieldSpecified = value;
                    this.OnPropertyChanged("useSpecified");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.450")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public enum LanguageDataLanguageUsage
    {

        /// <remarks/>
        Written,

        /// <remarks/>
        Spoken,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.450")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public enum LanguageDataUse
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Native Language")]
        NativeLanguage,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Reading Language")]
        ReadingLanguage,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Speaking Language")]
        SpeakingLanguage,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.450")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "IdCardData", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class IdCardData : EntityBase<IdCardData>
    {

        private string planCoverageDescriptionField;

        private string quantityField;

        private IdCardDataActionCode actionCodeField;

        private bool actionCodeFieldSpecified;

        private IdCardDataIdCardType idCardTypeField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PlanCoverageDescription
        {
            get
            {
                return this.planCoverageDescriptionField;
            }
            set
            {
                if ((this.planCoverageDescriptionField != null))
                {
                    if ((planCoverageDescriptionField.Equals(value) != true))
                    {
                        this.planCoverageDescriptionField = value;
                        this.OnPropertyChanged("PlanCoverageDescription");
                    }
                }
                else
                {
                    this.planCoverageDescriptionField = value;
                    this.OnPropertyChanged("PlanCoverageDescription");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger", Order = 1)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                if ((this.quantityField != null))
                {
                    if ((quantityField.Equals(value) != true))
                    {
                        this.quantityField = value;
                        this.OnPropertyChanged("Quantity");
                    }
                }
                else
                {
                    this.quantityField = value;
                    this.OnPropertyChanged("Quantity");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public IdCardDataActionCode ActionCode
        {
            get
            {
                return this.actionCodeField;
            }
            set
            {
                if ((actionCodeField.Equals(value) != true))
                {
                    this.actionCodeField = value;
                    this.OnPropertyChanged("ActionCode");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool ActionCodeSpecified
        {
            get
            {
                return this.actionCodeFieldSpecified;
            }
            set
            {
                if ((actionCodeFieldSpecified.Equals(value) != true))
                {
                    this.actionCodeFieldSpecified = value;
                    this.OnPropertyChanged("ActionCodeSpecified");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public IdCardDataIdCardType idCardType
        {
            get
            {
                return this.idCardTypeField;
            }
            set
            {
                if ((idCardTypeField.Equals(value) != true))
                {
                    this.idCardTypeField = value;
                    this.OnPropertyChanged("idCardType");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.450")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public enum IdCardDataActionCode
    {

        /// <remarks/>
        Add,

        /// <remarks/>
        Change,

        /// <remarks/>
        Replace,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.450")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public enum IdCardDataIdCardType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Dental Insurance")]
        DentalInsurance,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Health Insurance")]
        HealthInsurance,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Prescription Drug Service Insurance")]
        PrescriptionDrugServiceInsurance,
    }

}
