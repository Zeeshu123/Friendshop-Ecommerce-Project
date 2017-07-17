<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/Web.Master" AutoEventWireup="true" CodeBehind="checkout.aspx.cs" Inherits="WebShopManagement.checkout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="content">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    Personal Information Required
                </div>
                <div class="panel-body">
                    <asp:Label runat="server" Font-Size="Large" ForeColor="Tomato" Visible="false" ID="msg_Notice"></asp:Label><br />
                    <div class="col-md-12">
                        <div class="col-md-6">

                            <label>Name:
                                <asp:TextBox required runat="server" ID="txtName" CssClass="form-control"></asp:TextBox></label>
                            <br />
                            <label>Email:
                                <asp:TextBox required runat="server" ID="txtEmail" CssClass="form-control"></asp:TextBox></label>
                            <br />
                            <label>Phone:
                                <asp:TextBox required runat="server" ID="txtPhone" CssClass="form-control"></asp:TextBox></label>
                            <br />
                            <label>Address:
                                <asp:TextBox TextMode="MultiLine" required runat="server" ID="txtAddress" CssClass="form-control"></asp:TextBox></label>
                            <br />
                        </div>
                        <div class="col-md-6">

                            <asp:Label runat="server" Font-Size="Large" ForeColor="Tomato" Visible="false" ID="lbl_msg"></asp:Label><br />
                               <label>Your Shopping Amount = <asp:label runat="server" ID="lblAmount" Font-Size="Large"></asp:label></label>

                        </div>
                    </div>
                </div>

                <div class="panel-footer">
                    <asp:Button runat="server" ID="btn_Checkout" CssClass="btn btn-primary" Text="Checkout" OnClick="btn_Checkout_Click" />
                </div>

            </div>
        </div>
    </div>
</asp:Content>
