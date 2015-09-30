<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Editor.aspx.cs" Inherits="tx_mvc_tutorial.Editor" %>

<%@ Register assembly="TXTextControl.Web, Version=22.0.200.500, Culture=neutral, PublicKeyToken=6b83fe9a75cfb638" namespace="TXTextControl.Web" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <p>Document name:</p>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Save Document" OnClick="Button1_Click" />
                <asp:Label ID="lblInfo" runat="server" Text="Document has been saved!" Visible="False"></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
        
        <cc1:TextControl ID="TextControl1" runat="server" />

    </div>
    </form>
</body>
</html>
