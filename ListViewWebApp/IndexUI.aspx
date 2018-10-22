<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexUI.aspx.cs" Inherits="ListViewWebApp.IndexUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="First Name: "></asp:Label>
        <asp:TextBox ID="firstNameTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Middle Name: "></asp:Label>
        <asp:TextBox ID="middleNameTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Last Name: "></asp:Label>
        <asp:TextBox ID="lastNameTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
        <br />
        <asp:Button ID="showFullNameButton" runat="server" OnClick="showFullNameButton_Click" Text="Show Full Name" />
        <br />
        <asp:ListBox ID="fullNameListBox" runat="server" Height="432px" Width="378px"></asp:ListBox>
    
    </div>
    </form>
</body>
</html>
