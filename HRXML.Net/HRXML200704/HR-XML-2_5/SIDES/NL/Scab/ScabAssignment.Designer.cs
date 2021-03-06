// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.32989
//    <NameSpace>HRXML.Net</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>True</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>True</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace HRXML.Net {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.32990")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.scabadvies.nl/2016-05")]
    [System.Xml.Serialization.XmlRootAttribute("ScabAssignment", Namespace="http://www.scabadvies.nl/2016-05", IsNullable=false)]
    public partial class ScabAssignmentType : EntityBase<ScabAssignmentType> {
        
        private int collectiveSocialAgreementIdField;
        
        private bool collectiveSocialAgreementIdFieldSpecified;
        
        private string collectiveSocialAgreementDescriptionField;
        
        private string riskGroupField;
        
        private string functionGroupField;
        
        private string functionField;
        
        private string functionDescriptionField;
        
        private string tableField;
        
        private string gradeField;
        
        private string costCenterIdField;
        
        private string costCenterDescriptionField;
        
        private System.DateTime lastContractEndDateField;
        
        private bool lastContractEndDateFieldSpecified;
        
        private int numberOfContractsField;
        
        private bool numberOfContractsFieldSpecified;
        
        private int weeksWorkedField;
        
        private bool weeksWorkedFieldSpecified;
        
        private bool continuanceField;
        
        private bool continuanceFieldSpecified;

        private bool taxReductionSeafaringField;

        private bool taxReductionSeafaringFieldSpecified;

        private System.DateTime modifiedField;
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int CollectiveSocialAgreementId {
            get {
                return this.collectiveSocialAgreementIdField;
            }
            set {
                this.collectiveSocialAgreementIdField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CollectiveSocialAgreementIdSpecified {
            get {
                return this.collectiveSocialAgreementIdFieldSpecified;
            }
            set {
                this.collectiveSocialAgreementIdFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string CollectiveSocialAgreementDescription {
            get {
                return this.collectiveSocialAgreementDescriptionField;
            }
            set {
                this.collectiveSocialAgreementDescriptionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string RiskGroup {
            get {
                return this.riskGroupField;
            }
            set {
                this.riskGroupField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string FunctionGroup {
            get {
                return this.functionGroupField;
            }
            set {
                this.functionGroupField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Function {
            get {
                return this.functionField;
            }
            set {
                this.functionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string FunctionDescription {
            get {
                return this.functionDescriptionField;
            }
            set {
                this.functionDescriptionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Table {
            get {
                return this.tableField;
            }
            set {
                this.tableField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string Grade {
            get {
                return this.gradeField;
            }
            set {
                this.gradeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string CostCenterId {
            get {
                return this.costCenterIdField;
            }
            set {
                this.costCenterIdField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string CostCenterDescription {
            get {
                return this.costCenterDescriptionField;
            }
            set {
                this.costCenterDescriptionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=10)]
        public System.DateTime LastContractEndDate {
            get {
                return this.lastContractEndDateField;
            }
            set {
                this.lastContractEndDateField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastContractEndDateSpecified {
            get {
                return this.lastContractEndDateFieldSpecified;
            }
            set {
                this.lastContractEndDateFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public int NumberOfContracts {
            get {
                return this.numberOfContractsField;
            }
            set {
                this.numberOfContractsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberOfContractsSpecified {
            get {
                return this.numberOfContractsFieldSpecified;
            }
            set {
                this.numberOfContractsFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public int WeeksWorked {
            get {
                return this.weeksWorkedField;
            }
            set {
                this.weeksWorkedField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WeeksWorkedSpecified {
            get {
                return this.weeksWorkedFieldSpecified;
            }
            set {
                this.weeksWorkedFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public bool Continuance {
            get {
                return this.continuanceField;
            }
            set {
                this.continuanceField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ContinuanceSpecified {
            get {
                return this.continuanceFieldSpecified;
            }
            set {
                this.continuanceFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public bool TaxReductionSeafaring
        {
            get
            {
                return this.taxReductionSeafaringField;
            }
            set
            {
                this.taxReductionSeafaringField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxReductionSeafaringSpecified
        {
            get
            {
                return this.taxReductionSeafaringFieldSpecified;
            }
            set
            {
                this.taxReductionSeafaringFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public System.DateTime Modified {
            get {
                return this.modifiedField;
            }
            set {
                this.modifiedField = value;
            }
        }
    }
}
