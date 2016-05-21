<%@ Page Language="C#" AutoEventWireup="true"  %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
  <head runat="server">
    <title>Sandbox</title>
    <script runat="server">
protected void Page_Load(object sender, EventArgs e)
{
    Extender1.Controller = ControllerDropDown.SelectedValue;
}
</script>
  </head>
  <body style="margin:0px;">
    <form id="form1" runat="server">
      <div style="padding:8px">
        <act:ToolkitScriptManager ID="sm1" runat="server" ScriptMode="Release" />
        <asp:DropDownList ID="ControllerDropDown" runat="server" AutoPostBack="true" Font-Names="Tahoma" Style="margin-bottom: 8px" Font-Size="8.5pt">
          <asp:ListItem Text="CB_DataElement" Value="CB_DataElement" />
          <asp:ListItem Text="CB_ExpressionOperator" Value="CB_ExpressionOperator" />
          <asp:ListItem Text="CB_PassFailCriteria" Value="CB_PassFailCriteria" />
          <asp:ListItem Text="CB_QueryTemplate" Value="CB_QueryTemplate" />
          <asp:ListItem Text="CB_TestCriteria" Value="CB_TestCriteria" />
          <asp:ListItem Text="CB_TestExpressions" Value="CB_TestExpressions" Selected="true" />
          <asp:ListItem Text="CB_TestPopulation" Value="CB_TestPopulation" />
          <asp:ListItem Text="CB_Tests" Value="CB_Tests" />
          <asp:ListItem Text="Dim_EventAttribute" Value="Dim_EventAttribute" />
          <asp:ListItem Text="DIM_Events" Value="DIM_Events" />
          <asp:ListItem Text="DIM_Objects" Value="DIM_Objects" />
          <asp:ListItem Text="DIM_People" Value="DIM_People" />
          <asp:ListItem Text="Groups_People" Value="Groups_People" />
          <asp:ListItem Text="LU_EventTypes" Value="LU_EventTypes" />
          <asp:ListItem Text="LU_Groups" Value="LU_Groups" />
          <asp:ListItem Text="LU_LogSource" Value="LU_LogSource" />
          <asp:ListItem Text="LU_ObjectType" Value="LU_ObjectType" />
          <asp:ListItem Text="LU_TimeSource" Value="LU_TimeSource" />
          <asp:ListItem Text="People_Objects" Value="People_Objects" />
        </asp:DropDownList>
        <div id="Div1" runat="server" />
        <aquarium:DataViewExtender ID="Extender1" runat="server" TargetControlID="Div1" />
      </div>
    </form>
  </body>
</html>