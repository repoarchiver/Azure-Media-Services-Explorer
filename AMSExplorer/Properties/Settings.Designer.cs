﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AMSExplorer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection LoginList {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["LoginList"]));
            }
            set {
                this["LoginList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string WAMEPresetXMLFilesCurrentFolder {
            get {
                return ((string)(this["WAMEPresetXMLFilesCurrentFolder"]));
            }
            set {
                this["WAMEPresetXMLFilesCurrentFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CallUpgrade {
            get {
                return ((bool)(this["CallUpgrade"]));
            }
            set {
                this["CallUpgrade"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DisplayAssetIDinGrid {
            get {
                return ((bool)(this["DisplayAssetIDinGrid"]));
            }
            set {
                this["DisplayAssetIDinGrid"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DisplayJobIDinGrid {
            get {
                return ((bool)(this["DisplayJobIDinGrid"]));
            }
            set {
                this["DisplayJobIDinGrid"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool useStorageEncryption {
            get {
                return ((bool)(this["useStorageEncryption"]));
            }
            set {
                this["useStorageEncryption"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool useProtectedConfiguration {
            get {
                return ((bool)(this["useProtectedConfiguration"]));
            }
            set {
                this["useProtectedConfiguration"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool useTransferQueue {
            get {
                return ((bool)(this["useTransferQueue"]));
            }
            set {
                this["useTransferQueue"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public int NbItemsDisplayedInGrid {
            get {
                return ((int)(this["NbItemsDisplayedInGrid"]));
            }
            set {
                this["NbItemsDisplayedInGrid"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DisplayLiveChannelIDinGrid {
            get {
                return ((bool)(this["DisplayLiveChannelIDinGrid"]));
            }
            set {
                this["DisplayLiveChannelIDinGrid"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DisplayLiveProgramIDinGrid {
            get {
                return ((bool)(this["DisplayLiveProgramIDinGrid"]));
            }
            set {
                this["DisplayLiveProgramIDinGrid"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DisplayOriginIDinGrid {
            get {
                return ((bool)(this["DisplayOriginIDinGrid"]));
            }
            set {
                this["DisplayOriginIDinGrid"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoRefresh {
            get {
                return ((bool)(this["AutoRefresh"]));
            }
            set {
                this["AutoRefresh"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60")]
        public int AutoRefreshTime {
            get {
                return ((int)(this["AutoRefreshTime"]));
            }
            set {
                this["AutoRefreshTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:02")]
        public global::System.TimeSpan LiveKeyFrameInterval {
            get {
                return ((global::System.TimeSpan)(this["LiveKeyFrameInterval"]));
            }
            set {
                this["LiveKeyFrameInterval"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public short LiveHLSFragmentsPerSegment {
            get {
                return ((short)(this["LiveHLSFragmentsPerSegment"]));
            }
            set {
                this["LiveHLSFragmentsPerSegment"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://amsplayer.azurewebsites.net/?player=flash&format=smooth&url={manifest url}" +
            "")]
        public string CustomPlayerUrl {
            get {
                return ((string)(this["CustomPlayerUrl"]));
            }
            set {
                this["CustomPlayerUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CustomPlayerEnabled {
            get {
                return ((bool)(this["CustomPlayerEnabled"]));
            }
            set {
                this["CustomPlayerEnabled"] = value;
            }
        }
    }
}
