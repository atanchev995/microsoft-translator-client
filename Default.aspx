<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Microsoft Translator Client</title>
    <style type="text/css">
        #txtInput {
            height: 200px;
            width: 500px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2 style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; font-size: xx-large; font-weight: normal; background-color: #E1E1E1; border-top-style: solid; border-color: #006600">Microsoft Translator Client</h2>
    </div>
        <div>
        <asp:DropDownList ID="ddlTranslateFrom" runat="server" BackColor="#EBEBEB" Font-Names="Segoe UI" Font-Size="Large">
        </asp:DropDownList>
        <asp:Button ID="btnDetect" runat="server" Text="Detect" BorderStyle="Solid" Font-Names="Segoe UI" Font-Size="Large" BackColor="#CCCCCC" BorderColor="#CCCCCC" OnClick="btnDetect_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlTranslateTo" runat="server" BackColor="#EBEBEB" Font-Names="Segoe UI" Font-Size="Large">
        </asp:DropDownList>
        </div>
    <textarea id="txtInput" name="txtInput" style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; font-size: medium; font-weight: normal; border: 2px solid #CCCCCC; resize: none; width: 500px; height: 200px; margin-right: 110px;" runat="server"></textarea>
        <asp:Button ID="btnTranslate" runat="server" Text="Translate" BackColor="#006600" BorderStyle="None" Font-Names="Segoe UI" Font-Size="X-Large" ForeColor="White" />
    <textarea id="txtOutput" name="txtOutput" style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; font-size: medium; font-weight: normal; border: 2px solid #CCCCCC; resize: none; width: 500px; height: 200px; margin-left: 110px;" runat="server"></textarea>
&nbsp;<p>
            <asp:Label ID="lblError" runat="server" Font-Names="Segoe UI" Font-Size="Medium" ForeColor="Red"></asp:Label>
        </p>
    </form>
    </body>
</html>
