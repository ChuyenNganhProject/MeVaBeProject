﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.8.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=MSI;Initial Catalog=MeVaBeDB;Integrated Security=True")]
        public string MeVaBeDBConnectionString {
            get {
                return ((string)(this["MeVaBeDBConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=ADMIN-PC\\SQLEXPRESS;Initial Catalog=MeVaBeDB;Integrated Security=True" +
            "")]
        public string MeVaBeDBConnectionString1 {
            get {
                return ((string)(this["MeVaBeDBConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-TQS1O50\\SQLEXPRESS;Initial Catalog=MeVaBeDB1;Integrated Secur" +
            "ity=True;TrustServerCertificate=True")]
        public string MeVaBeDB1ConnectionString {
            get {
                return ((string)(this["MeVaBeDB1ConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=ADMIN-PC\\SQLEXPRESS;Initial Catalog=MeVaBeDB;Integrated Security=True" +
            ";Encrypt=True;TrustServerCertificate=True")]
        public string MeVaBeDBConnectionString2 {
            get {
                return ((string)(this["MeVaBeDBConnectionString2"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=MSI;Initial Catalog=MeVaBeDB;Integrated Security=True;Trust Server Ce" +
            "rtificate=True")]
        public string MeVaBeDBConnectionString3 {
            get {
                return ((string)(this["MeVaBeDBConnectionString3"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=ADMIN-PC;Initial Catalog=MeVaBeDB;Integrated Security=True;Encrypt=Tr" +
            "ue;TrustServerCertificate=True")]
        public string MeVaBeDBConnectionString4 {
            get {
                return ((string)(this["MeVaBeDBConnectionString4"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-TQS1O50\\SQLEXPRESS;Initial Catalog=MeVaBeDB5;Integrated Secur" +
            "ity=True;TrustServerCertificate=True")]
        public string MeVaBeDB5ConnectionString {
            get {
                return ((string)(this["MeVaBeDB5ConnectionString"]));
            }
        }
    }
}
