﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2032
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// 이 소스 코드가 Microsoft.VSDesigner, 버전 1.1.4322.2032에서 자동으로 생성되었습니다.
// 
namespace COM.WebService {
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="Service1Soap", Namespace="http://tempuri.org/OraWebService/Service1")]
    public class Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public Service1() {
            this.Url = "http://203.228.108.8/OraWebService/Service1.asmx";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/OraWebService/Service1/HelloWorld", RequestNamespace="http://tempuri.org/OraWebService/Service1", ResponseNamespace="http://tempuri.org/OraWebService/Service1", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string HelloWorld() {
            object[] results = this.Invoke("HelloWorld", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginHelloWorld(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("HelloWorld", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public string EndHelloWorld(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/OraWebService/Service1/Ora_Select", RequestNamespace="http://tempuri.org/OraWebService/Service1", ResponseNamespace="http://tempuri.org/OraWebService/Service1", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet Ora_Select(string UpdUser, string StrQty) {
            object[] results = this.Invoke("Ora_Select", new object[] {
                        UpdUser,
                        StrQty});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginOra_Select(string UpdUser, string StrQty, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Ora_Select", new object[] {
                        UpdUser,
                        StrQty}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndOra_Select(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/OraWebService/Service1/Ora_MSelect", RequestNamespace="http://tempuri.org/OraWebService/Service1", ResponseNamespace="http://tempuri.org/OraWebService/Service1", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet Ora_MSelect(string UpdUser, string[] StrTN, string[] StrQty) {
            object[] results = this.Invoke("Ora_MSelect", new object[] {
                        UpdUser,
                        StrTN,
                        StrQty});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginOra_MSelect(string UpdUser, string[] StrTN, string[] StrQty, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Ora_MSelect", new object[] {
                        UpdUser,
                        StrTN,
                        StrQty}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndOra_MSelect(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/OraWebService/Service1/Ora_Modify", RequestNamespace="http://tempuri.org/OraWebService/Service1", ResponseNamespace="http://tempuri.org/OraWebService/Service1", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public object Ora_Modify(string UpdUser, string[] StrSql) {
            object[] results = this.Invoke("Ora_Modify", new object[] {
                        UpdUser,
                        StrSql});
            return ((object)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginOra_Modify(string UpdUser, string[] StrSql, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Ora_Modify", new object[] {
                        UpdUser,
                        StrSql}, callback, asyncState);
        }
        
        /// <remarks/>
        public object EndOra_Modify(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((object)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/OraWebService/Service1/Ora_Procedure", RequestNamespace="http://tempuri.org/OraWebService/Service1", ResponseNamespace="http://tempuri.org/OraWebService/Service1", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public object Ora_Procedure(string UpdUser, string Proc_Name, string[] Para_Name, string[] Para_Value) {
            object[] results = this.Invoke("Ora_Procedure", new object[] {
                        UpdUser,
                        Proc_Name,
                        Para_Name,
                        Para_Value});
            return ((object)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginOra_Procedure(string UpdUser, string Proc_Name, string[] Para_Name, string[] Para_Value, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Ora_Procedure", new object[] {
                        UpdUser,
                        Proc_Name,
                        Para_Name,
                        Para_Value}, callback, asyncState);
        }
        
        /// <remarks/>
        public object EndOra_Procedure(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((object)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/OraWebService/Service1/Ora_Proc", RequestNamespace="http://tempuri.org/OraWebService/Service1", ResponseNamespace="http://tempuri.org/OraWebService/Service1", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public object Ora_Proc(string UpdUser, string Proc_Name) {
            object[] results = this.Invoke("Ora_Proc", new object[] {
                        UpdUser,
                        Proc_Name});
            return ((object)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginOra_Proc(string UpdUser, string Proc_Name, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Ora_Proc", new object[] {
                        UpdUser,
                        Proc_Name}, callback, asyncState);
        }
        
        /// <remarks/>
        public object EndOra_Proc(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((object)(results[0]));
        }
    }
}