<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="post.aspx.cs" Inherits="MyProject.post" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>POST</title>
    POST
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color:aqua">
        <table>     
           
            <tr>
                <td><asp:Label ID="Label1" runat="server" Text="Title"></asp:Label></td>
                <td><asp:TextBox ID="txttitle" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label2" runat="server" Text="Subtitle"></asp:Label></td>
                <td>  <asp:TextBox ID="txtSubtitle" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label3" runat="server" Text="Content"></asp:Label></td>
                <td><asp:TextBox ID="txtContent" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td><asp:Button ID="BtnSave" runat="server" Text="Save" OnClick="BtnSave_Click"/>
             <asp:Button ID="BtnReset" runat="server" Text="Reset" OnClick="BtnReset_Click" /></td>
            </tr>
            
        </table>
            
            <hr />
             <asp:Label text="" ID="lblResult" runat="server" />
              <hr />
            
        </div>
    </form>
</body>
</html>
