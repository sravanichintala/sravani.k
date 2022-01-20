<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Post.aspx.cs" Inherits="DiscussionForum.Post" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DiscussionForum</title>
      DiscussionForum
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color:aqua">
            <table>
                <tr>
                    <td><asp:Label ID="Label1" runat="server" Text="Post_Id"></asp:Label></td>
                     <td><asp:TextBox ID="txtPost_Id" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="Label2" runat="server" Text="Post_Title"></asp:Label></td>
                     <td><asp:TextBox ID="txtPost_Title" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td> <asp:Label ID="Label3" runat="server" Text="Post_Subtitle"></asp:Label></td>
                     <td> <asp:TextBox ID="txtPost_Subtitle" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td> <asp:Label ID="Label4" runat="server" Text="Post_Content"></asp:Label></td>
                     <td><asp:TextBox ID="txtPost_Content" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="Label6" runat="server" Text="Post_status"></asp:Label></td>
                     <td><asp:TextBox ID="txtPost_status" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Button ID="BtnSave" runat="server" Text="Save" OnClick="BtnSave_Click" />
            <asp:Button ID="BtnReset" runat="server" Text="Reset" OnClick="BtnReset_Click" /></td>
                </tr>
              
                </table>
             <hr />
           
            <h2>Post Details</h2>
            <asp:GridView ID="gvPostDetails" runat="server"></asp:GridView>
            

        </div>
    </form>
</body>
</html>
