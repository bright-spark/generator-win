﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.312
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Amnesty_Generator.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Amnesty_Generator.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to body {
        ///	margin: 0px;
        ///	background-image: url(front.png);
        ///	width: 320px;
        ///	height: 240px;
        ///}
        ///
        ///#gadget {
        ///}
        ///.
        /// </summary>
        internal static string gcss {
            get {
                return ResourceManager.GetString("gcss", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap gfront {
            get {
                object obj = ResourceManager.GetObject("gfront", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;html&gt;
        ///&lt;head&gt;
        ///	&lt;meta http-equiv=&quot;content-type&quot; content=&quot;text/html; charset=utf-8&quot;&gt;
        ///	&lt;meta name=&quot;GENERATOR&quot; content=&quot;Amnesty Generator 0.5b&quot;&gt;
        ///	&lt;style type=&quot;text/css&quot;&gt;
        ///		@import &quot;generator.css&quot;;
        ///	&lt;/style&gt;
        ///	&lt;script type=&apos;text/javascript&apos; src=&apos;generator.js&apos; charset=&quot;utf-8&quot;&gt;&lt;/script&gt;
        ///&lt;/head&gt;
        ///
        ///&lt;body onfocus=&apos;generator_setup();&apos;&gt;
        ///	&lt;div id=&quot;gadget&quot; onmouseover=&apos;generator_track();&apos;&gt;
        ///	&lt;/div&gt;
        ///&lt;/body&gt;
        ///&lt;/html&gt;
        ///.
        /// </summary>
        internal static string ghtm {
            get {
                return ResourceManager.GetString("ghtm", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap gicon {
            get {
                object obj = ResourceManager.GetObject("gicon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // Copyright 2006-2007 Mesa Dynamics, LLC
        ///
        ///var GeneratorPlugin = 0;
        ///
        ///function generator_setup()
        ///{
        ///	if(GeneratorPlugin)
        ///		GeneratorPlugin.registerWidget(&quot;com.mesadynamics.widget.Generator&quot;, &quot;0000-0000-0000-0000&quot;);
        ///
        ///	if(window.widget) {
        ///		widget.onshow = generator_onshow;
        ///		widget.onhide = generator_onhide;
        ///
        ///		window.open = generator_open;
        ///	}
        ///}
        ///
        ///function generator_dismiss()
        ///{
        ///	if(GeneratorPlugin)
        ///		widget.openURL(&apos;&apos;);
        ///}
        ///
        ///function generator_track()
        ///{
        ///	if(GeneratorPlugin)
        ///		GeneratorPl [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string gjs {
            get {
                return ResourceManager.GetString("gjs", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap glogo {
            get {
                object obj = ResourceManager.GetObject("glogo", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;gadget&gt;
        ///  &lt;name&gt;Generator&lt;/name&gt;
        ///  &lt;namespace&gt;com.mesadynamics.widget.Generator&lt;/namespace&gt;
        ///  &lt;version&gt;1.0.0.0&lt;/version&gt;
        ///  &lt;author&gt;
        ///    &lt;info url=&quot;www.mesadynamics.com&quot; /&gt;
        ///    &lt;logo src=&quot;logo.png&quot; /&gt;
        ///  &lt;/author&gt;
        ///  &lt;copyright&gt;Mesa Dynamics&lt;/copyright&gt;
        ///  &lt;description&gt;Powered by Amnesty™ Generator.&lt;/description&gt;
        ///  &lt;icons&gt;
        ///    &lt;icon width=&quot;64&quot; height=&quot;64&quot; src=&quot;icon.png&quot; /&gt;
        ///  &lt;/icons&gt;
        ///  &lt;hosts&gt;
        ///    &lt;host name=&quot;sidebar&quot;&gt;
        ///      &lt;base type=&quot;HTML&quot; apiVersion=&quot; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string gxml {
            get {
                return ResourceManager.GetString("gxml", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;html&gt;
        ///&lt;head&gt;
        ///	&lt;meta http-equiv=&quot;content-type&quot; content=&quot;text/html; charset=utf-8&quot;&gt;
        ///&lt;style type=&quot;text/css&quot;&gt;
        ///	body {
        ///		border: 0px;
        ///		font: normal 13px Arial,sans-serif;
        ///	}
        ///
        ///	table {
        ///		display: block;
        ///		position: relative;
        ///		padding-left:0px;
        ///		right:0px;
        ///		border-collapse: collapse;
        ///		table-layout: auto;
        ///	}
        ///
        ///	#title {
        ///		position: relative;
        ///		border: 1px solid #666666;
        ///		background: #eeeeee;
        ///		valign: top;
        ///	}
        ///
        ///	#titletext
        ///	{
        ///		font: bold 12px Arial,sans-serif;
        ///		text-align:center;        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Help {
            get {
                return ResourceManager.GetString("Help", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap HelpImage {
            get {
                object obj = ResourceManager.GetObject("HelpImage", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Icon Icon1 {
            get {
                object obj = ResourceManager.GetObject("Icon1", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap SplashGenerator {
            get {
                object obj = ResourceManager.GetObject("SplashGenerator", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to site requires registration.
        /// </summary>
        internal static string String1 {
            get {
                return ResourceManager.GetString("String1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All Images.
        /// </summary>
        internal static string String2 {
            get {
                return ResourceManager.GetString("String2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A gadget named {0} is already installed in your Gallery.  Do you want to replace it?.
        /// </summary>
        internal static string String3 {
            get {
                return ResourceManager.GetString("String3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A new version of Amnesty Generator is available.  Do you want to go to the download page now?.
        /// </summary>
        internal static string String4 {
            get {
                return ResourceManager.GetString("String4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your version of Amnesty Generator is up to date.  There are no updates available at this time..
        /// </summary>
        internal static string String5 {
            get {
                return ResourceManager.GetString("String5", resourceCulture);
            }
        }
    }
}
