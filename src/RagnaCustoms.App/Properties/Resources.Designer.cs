﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RagnaCustoms.App.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RagnaCustoms.App.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to You can request custom maps to {0} with the command !rc [map_id], to find it go to https://ragnacustoms.com and click on the twitch button (the purple one) to copy !rc [map_id] command and come back here to paste the command..
        /// </summary>
        internal static string Command_Base_Action_Message {
            get {
                return ResourceManager.GetString("Command.Base.Action.Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Display how to request map to streamer.
        /// </summary>
        internal static string Command_Base_Help {
            get {
                return ResourceManager.GetString("Command.Base.Help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Song Cancelled :.
        /// </summary>
        internal static string Command_Cancel_Action_Canceled {
            get {
                return ResourceManager.GetString("Command.Cancel.Action.Canceled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No More song to remove.
        /// </summary>
        internal static string Command_Cancel_Action_NoSongToCancel {
            get {
                return ResourceManager.GetString("Command.Cancel.Action.NoSongToCancel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove your last request.
        /// </summary>
        internal static string Command_Cancel_Help {
            get {
                return ResourceManager.GetString("Command.Cancel.Help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Commande.
        /// </summary>
        internal static string Command_Help_Action_Cmd {
            get {
                return ResourceManager.GetString("Command.Help.Action.Cmd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Liste des commandes.
        /// </summary>
        internal static string Command_Help_Action_CommandList {
            get {
                return ResourceManager.GetString("Command.Help.Action.CommandList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pour voir la description complete d&apos;une commande utiliser &quot;!rc help [nom_de_la_commande]&quot;.
        /// </summary>
        internal static string Command_Help_Action_OthersCommand {
            get {
                return ResourceManager.GetString("Command.Help.Action.OthersCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cette commande n&apos;existe pas, vérifiez le nom de la commande..
        /// </summary>
        internal static string Command_Help_Action_UnknowCommand {
            get {
                return ResourceManager.GetString("Command.Help.Action.UnknowCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to display list of commands.
        /// </summary>
        internal static string Command_Help_Help {
            get {
                return ResourceManager.GetString("Command.Help.Help", resourceCulture);
            }
        }
    }
}
