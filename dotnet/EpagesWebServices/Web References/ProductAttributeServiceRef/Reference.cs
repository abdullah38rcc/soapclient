//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.18444
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EpagesWebServices.ProductAttributeServiceRef {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="bind_ProductAttribute_SOAP", Namespace="urn://epages.de/WebService/ProductAttributeService/2006/07")]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TGetInfoList_Return))]
    public partial class ProductAttributeService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public ProductAttributeService() {
            this.Url = "http://localhost/epages/Store.soap";
        }
        
        public ProductAttributeService(string url) {
            this.Url = url;
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn://epages.de/WebService/ProductAttributeService/2006/07#getInfoList", RequestNamespace="urn://epages.de/WebService/ProductAttributeService/2006/07", ResponseNamespace="urn://epages.de/WebService/ProductAttributeService/2006/07")]
        [return: System.Xml.Serialization.SoapElementAttribute("ProductAttributes")]
        public TGetInfoList_Return[] getInfoList() {
            object[] results = this.Invoke("getInfoList", new object[0]);
            return ((TGetInfoList_Return[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetInfoList(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getInfoList", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public TGetInfoList_Return[] EndgetInfoList(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((TGetInfoList_Return[])(results[0]));
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/ProductAttributeTypes/2006/07")]
    public partial class TGetInfoList_Return {
        
        /// <remarks/>
        public string Alias;
        
        /// <remarks/>
        public string Path;
        
        /// <remarks/>
        public string ProductType;
        
        /// <remarks/>
        public bool IsVariationAttribute;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool IsVariationAttributeSpecified;
        
        /// <remarks/>
        public TError Error;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/EpagesTypes/2005/01")]
    public partial class TError {
        
        /// <remarks/>
        public string Message;
    }
}