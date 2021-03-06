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
    [System.Xml.Serialization.XmlRootAttribute("AssessmentOrderRequest", Namespace = "http://ns.hr-xml.org/2007-04-15", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "AssessmentOrderRequestType", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class AssessmentOrderRequestType : EntityBase<AssessmentOrderRequestType>
    {

        private EntityIdType clientIdField;

        private EntityIdType packageIdField;

        private EntityIdType providerIdField;

        private List<EntityIdType> comparisonGroupIdField;

        private EntityIdType clientOrderIdField;

        private string assessmentRequesterField;

        private AssessmentSubjectType assessmentSubjectField;

        private List<string> assessmentLanguageField;

        private List<string> resultLanguageField;

        private UserAreaType userAreaField;

        private string langField;

        /// <summary>
        /// AssessmentOrderRequestType class constructor
        /// </summary>
        public AssessmentOrderRequestType()
        {
            this.userAreaField = new UserAreaType();
            this.resultLanguageField = new List<string>();
            this.assessmentLanguageField = new List<string>();
            this.assessmentSubjectField = new AssessmentSubjectType();
            this.clientOrderIdField = new EntityIdType();
            this.comparisonGroupIdField = new List<EntityIdType>();
            this.providerIdField = new EntityIdType();
            this.packageIdField = new EntityIdType();
            this.clientIdField = new EntityIdType();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public EntityIdType ClientId
        {
            get
            {
                return this.clientIdField;
            }
            set
            {
                if ((this.clientIdField != null))
                {
                    if ((clientIdField.Equals(value) != true))
                    {
                        this.clientIdField = value;
                        this.OnPropertyChanged("ClientId");
                    }
                }
                else
                {
                    this.clientIdField = value;
                    this.OnPropertyChanged("ClientId");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public EntityIdType PackageId
        {
            get
            {
                return this.packageIdField;
            }
            set
            {
                if ((this.packageIdField != null))
                {
                    if ((packageIdField.Equals(value) != true))
                    {
                        this.packageIdField = value;
                        this.OnPropertyChanged("PackageId");
                    }
                }
                else
                {
                    this.packageIdField = value;
                    this.OnPropertyChanged("PackageId");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public EntityIdType ProviderId
        {
            get
            {
                return this.providerIdField;
            }
            set
            {
                if ((this.providerIdField != null))
                {
                    if ((providerIdField.Equals(value) != true))
                    {
                        this.providerIdField = value;
                        this.OnPropertyChanged("ProviderId");
                    }
                }
                else
                {
                    this.providerIdField = value;
                    this.OnPropertyChanged("ProviderId");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ComparisonGroupId", Order = 3)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<EntityIdType> ComparisonGroupId
        {
            get
            {
                return this.comparisonGroupIdField;
            }
            set
            {
                if ((this.comparisonGroupIdField != null))
                {
                    if ((comparisonGroupIdField.Equals(value) != true))
                    {
                        this.comparisonGroupIdField = value;
                        this.OnPropertyChanged("ComparisonGroupId");
                    }
                }
                else
                {
                    this.comparisonGroupIdField = value;
                    this.OnPropertyChanged("ComparisonGroupId");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public EntityIdType ClientOrderId
        {
            get
            {
                return this.clientOrderIdField;
            }
            set
            {
                if ((this.clientOrderIdField != null))
                {
                    if ((clientOrderIdField.Equals(value) != true))
                    {
                        this.clientOrderIdField = value;
                        this.OnPropertyChanged("ClientOrderId");
                    }
                }
                else
                {
                    this.clientOrderIdField = value;
                    this.OnPropertyChanged("ClientOrderId");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AssessmentRequester
        {
            get
            {
                return this.assessmentRequesterField;
            }
            set
            {
                if ((this.assessmentRequesterField != null))
                {
                    if ((assessmentRequesterField.Equals(value) != true))
                    {
                        this.assessmentRequesterField = value;
                        this.OnPropertyChanged("AssessmentRequester");
                    }
                }
                else
                {
                    this.assessmentRequesterField = value;
                    this.OnPropertyChanged("AssessmentRequester");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AssessmentSubjectType AssessmentSubject
        {
            get
            {
                return this.assessmentSubjectField;
            }
            set
            {
                if ((this.assessmentSubjectField != null))
                {
                    if ((assessmentSubjectField.Equals(value) != true))
                    {
                        this.assessmentSubjectField = value;
                        this.OnPropertyChanged("AssessmentSubject");
                    }
                }
                else
                {
                    this.assessmentSubjectField = value;
                    this.OnPropertyChanged("AssessmentSubject");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("AssessmentLanguage", DataType = "language", Order = 7)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<string> AssessmentLanguage
        {
            get
            {
                return this.assessmentLanguageField;
            }
            set
            {
                if ((this.assessmentLanguageField != null))
                {
                    if ((assessmentLanguageField.Equals(value) != true))
                    {
                        this.assessmentLanguageField = value;
                        this.OnPropertyChanged("AssessmentLanguage");
                    }
                }
                else
                {
                    this.assessmentLanguageField = value;
                    this.OnPropertyChanged("AssessmentLanguage");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ResultLanguage", DataType = "language", Order = 8)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<string> ResultLanguage
        {
            get
            {
                return this.resultLanguageField;
            }
            set
            {
                if ((this.resultLanguageField != null))
                {
                    if ((resultLanguageField.Equals(value) != true))
                    {
                        this.resultLanguageField = value;
                        this.OnPropertyChanged("ResultLanguage");
                    }
                }
                else
                {
                    this.resultLanguageField = value;
                    this.OnPropertyChanged("ResultLanguage");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
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


}
