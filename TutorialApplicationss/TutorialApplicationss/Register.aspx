<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="TutorialApplicationss.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><h1>Register</h1>
            <hr />
            <table>
                <tr>
                    <td>FirstName</td>
                    <td>
                        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>LastName</td>
                    <td>
                       <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td>Email</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Mobile</td>
                    <td>
                       <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                       <asp:TextBox ID="txtPwd" TextMode="Password" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="BtnRegister" runat="server" Text="Register" OnClick="BtnRegister_Click" />
                        <asp:Button ID="BtnReset" runat="server" Text="Reset" />
                    </td>
                </tr>
            </table>
            <div>
                <asp:Label Text="" ID="lblResult" runat="server"/>
                
                   <h2> User details</h2>
                
                <hr />
                <asp:GridView ID="gvUserInfo" runat="server"></asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
