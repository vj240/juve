﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Juve.Model.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ModelResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ModelResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Juve.Model.Resources.ModelResources", typeof(ModelResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Country Name.
        /// </summary>
        public static string CountryName {
            get {
                return ResourceManager.GetString("CountryName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Country name field cannot be null.
        /// </summary>
        public static string CountryNameErrorMessage {
            get {
                return ResourceManager.GetString("CountryNameErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Player Type.
        /// </summary>
        public static string PlayerTypeName {
            get {
                return ResourceManager.GetString("PlayerTypeName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Player type field cannot be null.
        /// </summary>
        public static string PlayerTypeNameErrorMessage {
            get {
                return ResourceManager.GetString("PlayerTypeNameErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Team Name.
        /// </summary>
        public static string TeamName {
            get {
                return ResourceManager.GetString("TeamName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Team Name field cannot be null.
        /// </summary>
        public static string TeamNameErrorMessage {
            get {
                return ResourceManager.GetString("TeamNameErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Year of Foundation.
        /// </summary>
        public static string YearOfFoundation {
            get {
                return ResourceManager.GetString("YearOfFoundation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Year of Foundation field cannot be null.
        /// </summary>
        public static string YearOfFoundationErrorMessage {
            get {
                return ResourceManager.GetString("YearOfFoundationErrorMessage", resourceCulture);
            }
        }
    }
}
