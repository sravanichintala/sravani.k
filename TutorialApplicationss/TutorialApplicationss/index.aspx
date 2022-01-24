<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/TutorialMaster.Master" CodeBehind="index.aspx.cs"  Inherits="TutorialApplicationss.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div style="background-color:aqua">
           <table>
               <tr>
                   <td> <asp:Label ID="Label1" runat="server" Text="Tutorial Id"></asp:Label></td>
                   <td> <asp:TextBox ID="txtTutorialId" runat="server"></asp:TextBox></td>
               </tr>
               <tr>
                   <td><asp:Label ID="Label2" runat="server" Text="Tutorial Name"></asp:Label></td>
                   <td> <asp:TextBox ID="txtTutorialName" runat="server"></asp:TextBox></td>
               </tr>
               <tr>
                   <td>  <asp:Label ID="Label4" runat="server" Text="Desc"></asp:Label></td>
                   <td><asp:TextBox ID="txtDesc" runat="server"></asp:TextBox></td>
               </tr>
               <tr>
                   <td>
                       <asp:Label ID="Label3" runat="server" Text="Published"></asp:Label></td>
                   <td>
                       <asp:TextBox ID="txtPublished" runat="server"></asp:TextBox></td>
               </tr>
               <tr>
                   <td></td>
                   <td><asp:Button ID="BtnSave" runat="server" Text="Save" OnClick="BtnSave_Click" />
                       <asp:Button ID="BtnEdit" runat="server" Text="Edit" OnClick="BtnEdit_Click" />
                       <asp:Button ID="BtnUpdate" runat="server" Text="Update" OnClick="BtnUpdate_Click" />
                       <asp:Button ID="BtnDelete" runat="server" Text="Delete" OnClick="BtnDelete_Click" />
                      <asp:Button ID="BtnReset" runat="server" Text="Reset" OnClick="BtnReset_Click" />
                       
                   </td>
               </tr>
               
           </table>
           
           
              <asp:Label Text="" ID="lblResult" runat="server"/>
            <hr />
            <h2>Tutorial Details</h2>
            <asp:GridView ID="gvTutorialDetails" runat="server"></asp:GridView>

            
        </div>
   
    </asp:Content>