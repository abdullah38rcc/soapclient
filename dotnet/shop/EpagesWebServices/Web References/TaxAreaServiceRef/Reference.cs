//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.18444
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EpagesWebServices.TaxAreaServiceRef {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="bind_TaxArea_SOAP", Namespace="urn://epages.de/WebService/TaxAreaService/2006/07")]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(TGetList_Return))]
    public partial class TaxAreaService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public TaxAreaService() {
            this.Url = "http://localhost/epages/Store.soap";
        }
        
        public TaxAreaService(string url) {
            this.Url = url;
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn://epages.de/WebService/TaxAreaService/2006/07#getList", RequestNamespace="urn://epages.de/WebService/TaxAreaService/2006/07", ResponseNamespace="urn://epages.de/WebService/TaxAreaService/2006/07")]
        [return: System.Xml.Serialization.SoapElementAttribute("TaxAreas")]
        public TGetList_Return[] getList() {
            object[] results = this.Invoke("getList", new object[0]);
            return ((TGetList_Return[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetList(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getList", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public TGetList_Return[] EndgetList(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((TGetList_Return[])(results[0]));
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn://epages.de/WebService/TaxAreaTypes/2006/07")]
    public partial class TGetList_Return {
        
        /// <remarks/>
        public string Path;
    }
}
