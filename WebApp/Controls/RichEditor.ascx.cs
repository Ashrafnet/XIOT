using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



[XIOT.Web.AquariumFieldEditor()]
public partial class Controls_RichEditor : System.Web.UI.UserControl
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!(IsPostBack))
        	Page.ClientScript.RegisterClientScriptBlock(GetType(), "ClientScripts", String.Format(@"
                                    function FieldEditor_GetValue(){{return $get('{0}$HtmlEditorExtenderBehavior_ExtenderContentEditable').innerHTML;}}
function FieldEditor_SetValue(value) {{$get('{0}$HtmlEditorExtenderBehavior_ExtenderContentEditable').innerHTML=value;}}
                                  ", Controls[0].ClientID), true);
    }
}
