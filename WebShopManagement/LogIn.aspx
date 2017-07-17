<%@ Page Title="Welcome to LogIn" Language="C#" MasterPageFile="~/Web.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="WebShopManagement.LogIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <div class="container">
            <asp:Label runat="server" ID="litStatus"></asp:Label>
            <div class="row" style="margin-bottom: 8px; border: groove; border-color: blue; margin-top: 12px; margin-left: 360px; margin-right: 360px">
                <div class="row" style="margin:20px;">
                    <h2 style="text-align:center; border-bottom:groove; text-decoration-style:wavy; color:blue">LogIn</h2><br />

                    <asp:Label runat="server">Name: </asp:Label><br />
                    <asp:TextBox runat="server" required ID="txtUserName" CssClass="form-control" Width="100%"></asp:TextBox><br />

                    <asp:Label runat="server">Password: </asp:Label><br />
                    <asp:TextBox runat="server" required ID="txtPassword" CssClass="form-control" Width="100%"></asp:TextBox><br />                   

                    <asp:Button runat="server" ID="btnSignIn" CssClass="btn btn-info" Text="SignIn" OnClick="btnSignIn_Click" />

                </div>
            </div>
        </div>
    </div>

</asp:Content>
