using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using XIOT.Data;
using AjaxControlToolkit;

namespace XIOT.Web
{
	public partial class MembershipBarExtender : MembershipBarExtenderBase
    {
    }
    
    [TargetControlType(typeof(HtmlGenericControl))]
    [ToolboxItem(false)]
    [ClientCssResource("XIOT.Theme.Aquarium.css")]
    public class MembershipBarExtenderBase : AquariumExtenderBase
    {
        
        public MembershipBarExtenderBase() : 
                base("Web.Membership")
        {
        }
        
        protected override void ConfigureDescriptor(ScriptBehaviorDescriptor descriptor)
        {
            descriptor.AddProperty("displayRememberMe", Properties["DisplayRememberMe"]);
            descriptor.AddProperty("rememberMeSet", Properties["RememberMeSet"]);
            descriptor.AddProperty("displaySignUp", Properties["DisplaySignUp"]);
            descriptor.AddProperty("displayPasswordRecovery", Properties["DisplayPasswordRecovery"]);
            descriptor.AddProperty("displayMyAccount", Properties["DisplayMyAccount"]);
            string s = ((string)(Properties["Welcome"]));
            if (!(String.IsNullOrEmpty(s)))
            	descriptor.AddProperty("welcome", Properties["Welcome"]);
            s = ((string)(Properties["User"]));
            if (!(String.IsNullOrEmpty(s)))
            	descriptor.AddProperty("user", Properties["User"]);
            descriptor.AddProperty("displayHelp", Properties["DisplayHelp"]);
            descriptor.AddProperty("enableHistory", Properties["EnableHistory"]);
            descriptor.AddProperty("enablePermalinks", Properties["EnablePermalinks"]);
            descriptor.AddProperty("displayLogin", Properties["DisplayLogin"]);
            if (Properties.ContainsKey("IdleUserTimeout"))
            	descriptor.AddProperty("idleTimeout", Properties["IdleUserTimeout"]);
            string cultures = ((string)(Properties["Cultures"]));
            if (cultures.Split(new char[] {
                        ';'}, StringSplitOptions.RemoveEmptyEntries).Length > 1)
            	descriptor.AddProperty("cultures", cultures);
        }
        
        protected override void ConfigureScripts(List<ScriptReference> scripts)
        {
            scripts.Add(new ScriptReference(CultureManager.ResolveEmbeddedResourceName("XIOT.Scripts.Web.MembershipResources.js"), GetType().Assembly.FullName));
            scripts.Add(new ScriptReference("XIOT.Scripts.Web.Membership.js", GetType().Assembly.FullName));
        }
    }
}
