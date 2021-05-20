﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bicep.Core {
    using System;


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class CoreResources {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CoreResources() {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Bicep.Core.CoreResources", typeof(CoreResources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Custom bicepconfig.json file found [{0}]..
        /// </summary>
        internal static string BicepConfigCustomSettingsFoundFormatMessage {
            get {
                return ResourceManager.GetString("BicepConfigCustomSettingsFoundFormatMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to No bicepconfig.json found for configuration override..
        /// </summary>
        internal static string BicepConfigNoCustomSettingsMessage {
            get {
                return ResourceManager.GetString("BicepConfigNoCustomSettingsMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Environment URLs should not be hardcoded. Access URLs via the environment() function to keep references current..
        /// </summary>
        internal static string EnvironmentUrlHardcodedRuleDescription {
            get {
                return ResourceManager.GetString("EnvironmentUrlHardcodedRuleDescription", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Dynamic variable should not use concat - string interpolation should be used..
        /// </summary>
        internal static string InterpolateNotConcatRuleDescription {
            get {
                return ResourceManager.GetString("InterpolateNotConcatRuleDescription", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Linter is disabled in settings file [{0}].
        /// </summary>
        internal static string LinterDisabledFormatMessage {
            get {
                return ResourceManager.GetString("LinterDisabledFormatMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Linter rule encountered an unexpected exception: {0}.
        /// </summary>
        internal static string LinterRuleExceptionMessageFormat {
            get {
                return ResourceManager.GetString("LinterRuleExceptionMessageFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Best practice dictates that location be through a parameter that has no default or defaults to &apos;global&apos; or resourceGroup().location..
        /// </summary>
        internal static string LocationSetByParameterRuleDescription {
            get {
                return ResourceManager.GetString("LocationSetByParameterRuleDescription", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Declared parameter must be referenced within the document scope..
        /// </summary>
        internal static string ParameterMustBeUsedRuleDescription {
            get {
                return ResourceManager.GetString("ParameterMustBeUsedRuleDescription", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Secure parameters can&apos;t have hardcoded default. This prevents storage of sensitive data in the Bicep declaration..
        /// </summary>
        internal static string SecureParameterDefaultRuleDescription {
            get {
                return ResourceManager.GetString("SecureParameterDefaultRuleDescription", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to [See : {0}].
        /// </summary>
        internal static string SeeDocLinkFormat {
            get {
                return ResourceManager.GetString("SeeDocLinkFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to String interpolation can be simplified. String variables can be directly assigned to string properties and variables..
        /// </summary>
        internal static string SimplifyInterpolationRuleDescription {
            get {
                return ResourceManager.GetString("SimplifyInterpolationRuleDescription", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Best Practice: remove unnecessary dependsOn..
        /// </summary>
        internal static string UnnecessaryDependsOnRuleDescription {
            get {
                return ResourceManager.GetString("UnnecessaryDependsOnRuleDescription", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Declared variable encountered that is not used within scope..
        /// </summary>
        internal static string UnusedVariableRuleDescription {
            get {
                return ResourceManager.GetString("UnusedVariableRuleDescription", resourceCulture);
            }
        }
    }
}
