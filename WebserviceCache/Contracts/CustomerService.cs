﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.0
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=4.0.30319.33440.
// 
namespace FP.Spartakiade2015.WebserviceCache.Contracts {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
    [System.Web.Services.WebServiceBindingAttribute(Name="CustomerInfo_Binding", Namespace="http://www.pommerening-online.de/wsdl/CustomerService/")]
    public interface ICustomerInfo_Binding {
        
        /// <remarks/>
        [System.Web.Services.WebMethodAttribute()]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.pommerening-online.de/wsdl/CustomerService/CustomerInfo", RequestElementName="CustomerInfoRequest", RequestNamespace="http://www.pommerening-online.de/wsdl/CustomerService/", ResponseNamespace="http://www.pommerening-online.de/wsdl/CustomerService/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("request")]
        CustomerInfoResponseType CustomerInfo(CustomerInfoRequestType request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.pommerening-online.de/wsdl/CustomerService/")]
    public partial class CustomerInfoRequestType {
        
        private string nameField;
        
        private string firstNameField;
        
        private string streetField;
        
        private string zipCodeField;
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string FirstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
            }
        }
        
        /// <remarks/>
        public string Street {
            get {
                return this.streetField;
            }
            set {
                this.streetField = value;
            }
        }
        
        /// <remarks/>
        public string ZipCode {
            get {
                return this.zipCodeField;
            }
            set {
                this.zipCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.pommerening-online.de/wsdl/CustomerService/")]
    public partial class CustomerInfoResponseType {
        
        private int customerIdField;
        
        private Title titleField;
        
        private string nameField;
        
        private string firstNameField;
        
        private string streetField;
        
        private string zipCodeField;
        
        private decimal reliabilityIndexField;
        
        /// <remarks/>
        public int CustomerId {
            get {
                return this.customerIdField;
            }
            set {
                this.customerIdField = value;
            }
        }
        
        /// <remarks/>
        public Title Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string FirstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
            }
        }
        
        /// <remarks/>
        public string Street {
            get {
                return this.streetField;
            }
            set {
                this.streetField = value;
            }
        }
        
        /// <remarks/>
        public string ZipCode {
            get {
                return this.zipCodeField;
            }
            set {
                this.zipCodeField = value;
            }
        }
        
        /// <remarks/>
        public decimal ReliabilityIndex {
            get {
                return this.reliabilityIndexField;
            }
            set {
                this.reliabilityIndexField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.pommerening-online.de/wsdl/CustomerService/")]
    public enum Title {
        
        /// <remarks/>
        Herr,
        
        /// <remarks/>
        Frau,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Dr.")]
        Dr,
    }
}