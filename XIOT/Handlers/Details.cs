using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using XIOT.Data;

namespace XIOT.Handlers
{
	public partial class Details : XIOT.Web.PageBase
    {
        
        public System.Web.UI.HtmlControls.HtmlForm form1;
        
        public System.Web.UI.HtmlControls.HtmlGenericControl Div1;
        
        public XIOT.Web.DataViewExtender Extender1;
        
        public System.Web.UI.HtmlControls.HtmlInputHidden ExtenderFilter;
        
        protected void Page_Init(object sender, EventArgs e)
        {
            Controls.Add(new LiteralControl("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org" +
                        "/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\r\n<html xmlns=\"http://www.w3.org/1999/xh" +
                        "tml\">"));
            Controls.Add(new System.Web.UI.HtmlControls.HtmlHead());
            Controls.Add(new LiteralControl("<body>"));
            form1 = new System.Web.UI.HtmlControls.HtmlForm();
            Controls.Add(form1);
            // script manager
            AjaxControlToolkit.ToolkitScriptManager sm = new AjaxControlToolkit.ToolkitScriptManager();
            sm.ID = "sm";
            sm.ScriptMode = ScriptMode.Release;
            form1.Controls.Add(sm);
            // Div1
            Div1 = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
            Div1.ID = "Div1";
            Div1.Visible = false;
            form1.Controls.Add(Div1);
            // Extender1
            Extender1 = new XIOT.Web.DataViewExtender();
            Extender1.ID = "Extender1";
            Extender1.TargetControlID = "Div1";
            Extender1.FilterSource = "ExtenderFilter";
            Extender1.View = "editForm1";
            Extender1.ShowActionBar = false;
            form1.Controls.Add(Extender1);
            // ExtenderFilter
            ExtenderFilter = new System.Web.UI.HtmlControls.HtmlInputHidden();
            ExtenderFilter.Name = "ExtenderFilter";
            ExtenderFilter.ID = "ExtenderFilter";
            form1.Controls.Add(ExtenderFilter);
            Controls.Add(new LiteralControl("</body></html>"));
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(IsPostBack))
            {
                string link = Request.QueryString["l"];
                if (String.IsNullOrEmpty(link))
                {
                    StringEncryptor se = new StringEncryptor();
                    link = se.Decrypt(Request.QueryString["_link"]);
                    link = HttpUtility.UrlDecode(link.Substring(2));
                }
                if (!(String.IsNullOrEmpty(link)))
                {
                    if (!(link.Contains("&")))
                    	link = Encoding.Default.GetString(Convert.FromBase64String(link));
                    Match m = Regex.Match(link, "(.+?)(&|$)");
                    if (m.Success)
                    {
                        Div1.Visible = true;
                        Extender1.Controller = m.Groups[1].Value;
                        m = m.NextMatch();
                        while (m.Success)
                        {
                            Match pair = Regex.Match(m.Groups[1].Value, "^(\\w+)=(.+)$");
                            if (pair.Success)
                            {
                                if (!(String.IsNullOrEmpty(Extender1.FilterFields)))
                                {
                                    Extender1.FilterFields = (Extender1.FilterFields + ",");
                                    ExtenderFilter.Value = (ExtenderFilter.Value + ",");
                                }
                                Extender1.FilterFields = (Extender1.FilterFields + pair.Groups[1].Value);
                                ExtenderFilter.Value = (ExtenderFilter.Value + pair.Groups[2].Value);
                            }
                            m = m.NextMatch();
                        }
                    }
                }
            }
        }
    }
}
