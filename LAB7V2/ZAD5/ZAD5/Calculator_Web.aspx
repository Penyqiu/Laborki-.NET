<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator_Web.aspx.cs" Inherits="ZAD5.Calculator_Web" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Height="62px" OnTextChanged="TextBox1_TextChanged" Width="125px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Divide" runat="server" OnClick="Divide_Click" Text="/" Width="45px" />
            <asp:Button ID="Button14" runat="server" OnClick="Button14_Click" Text="0" Width="45px" />
            <asp:Button ID="Button15" runat="server" OnClick="Button15_Click" Text="OK" Width="45px" />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="1" Width="45px" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="2" Width="45px" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="3" Width="45px" />
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="4" Width="45px" />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="5" Width="45px" />
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="6" Width="45px" />
            <br />
            <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="7" Width="45px" />
            <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="8" Width="45px" />
            <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="9" Width="45px" />
            <br />
            <asp:Button ID="Add" runat="server" OnClick="Button10_Click" Text="+" Width="45px" />
            <asp:Button ID="Sub" runat="server" OnClick="Button11_Click" Text="-" Width="45px" />
            <asp:Button ID="mult" runat="server" OnClick="Button12_Click" Text="*" Width="45px" />
            <asp:Button ID="clear" runat="server" OnClick="ButtonClear_Click" Text="Clear" Width="45px" />
        </div>
    </form>
</body>
</html>
