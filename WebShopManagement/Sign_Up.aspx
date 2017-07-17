<%@ Page Title="Welcome to Registration" Language="C#" EnableEventValidation="false" MasterPageFile="~/Web.Master" AutoEventWireup="true" CodeBehind="Sign_Up.aspx.cs" Inherits="WebShopManagement.Sign_Up" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <div class="container">
            <asp:Label runat="server" ID="msg_lbl" CssClass="alert-success"></asp:Label>
            <div class="row" style="margin-bottom: 8px; border: groove; border-color: blue; margin-top: 12px; margin-left: 350px; margin-right: 350px">
                <div class="row" style="margin:20px;">
                    <h2 style="text-align:center; border-bottom:groove; text-decoration-style:wavy; color:blue">Sign Up</h2><br />
                    <asp:Label runat="server">Name: </asp:Label><br />
                    <asp:TextBox runat="server" required ID="txtName" CssClass="form-control" Width="100%"></asp:TextBox><br />

                    <asp:Label runat="server">Password: </asp:Label><br />
                    <asp:TextBox runat="server" required ID="txtPassword" CssClass="form-control" Width="100%"></asp:TextBox><br />

                    <asp:Label runat="server">Email: </asp:Label><br />
                    <asp:TextBox runat="server" required ID="txtEmail" CssClass="form-control" Width="100%"></asp:TextBox><br />

                    <asp:Label runat="server">Address: </asp:Label><br />
                    <asp:TextBox runat="server" required ID="txtAddress" CssClass="form-control" Width="100%"></asp:TextBox><br />

                    <asp:Label runat="server">Phone: </asp:Label><br />
                    <asp:TextBox runat="server" required ID="txtPhone" CssClass="form-control" Width="100%"></asp:TextBox><br />

                    <asp:Button runat="server" ID="btnSignUp" CssClass="btn btn-info" Text="SignUp" OnClick="btnSignUp_Click" />
                </div>
            </div>
        </div>
    </div>

</asp:Content>
