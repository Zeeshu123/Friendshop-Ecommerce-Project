<%@ Page Title="Add Product" Language="C#" EnableEventValidation="false" MasterPageFile="~/admin/pages/Admin.Master" AutoEventWireup="true" CodeBehind="product_add.aspx.cs" Inherits="Shopping_Cart.admin.pages.product_add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
            <h1>Page Header
        <small>Optional description</small>

            </h1>
            <ol class="breadcrumb">
                <li><a href="#"><i class="fa fa-dashboard"></i>Level</a></li>
                <li class="active">Here</li>
            </ol>
        </section>

        <!-- Main content -->
        <section class="content">

            <div class="row">
                <div class="col-md-12">
                    <asp:Label runat="server" ID="msg_lbl" />
                    <div class="panel panel-info">
                        <div class="panel-heading">Product Information Required</div>
                        <div class="panel-body">
                            <div class="col-md-6">
                                <label>
                                    Product Id:
                                    <asp:TextBox runat="server" ID="txtProductId" CssClass="form-control" />
                                </label>
                                <br />
                                <label>
                                    Product Name:
                                    <asp:TextBox runat="server" ID="txtProductName" CssClass="form-control" />
                                </label>
                                <br />
                                <label>
                                    Category:
                                    <asp:DropDownList runat="server" ID="ddlCategory" CssClass="form-control" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged" AutoPostBack="True" />
                                </label>
                                <br />
                                <label>
                                    Sub_Category:
                                    <asp:DropDownList runat="server" ID="ddlSubCategory" CssClass="form-control" />
                                </label>
                                <br />
                                <label>
                                    Brand:
                                    <asp:DropDownList runat="server" ID="ddlBrand" CssClass="form-control" />
                                </label>
                                <br />
                                <label>
                                    ReorderLevel:
                                <asp:DropDownList CssClass="form-control" runat="server" ID="ddlReorder">
                                    <asp:ListItem>--Select--</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>5</asp:ListItem>
                                    <asp:ListItem>10</asp:ListItem>
                                    <asp:ListItem>20</asp:ListItem>
                                    <asp:ListItem>30</asp:ListItem>
                                    <asp:ListItem>40</asp:ListItem>
                                    <asp:ListItem>50</asp:ListItem>
                                </asp:DropDownList>

                                </label>
                            </div>
                            <div class="col-md-6">
                                <label>
                                    Product Quantity:
                                    <asp:TextBox runat="server" ID="txtQuantity" CssClass="form-control" />
                                </label>
                                <br />
                                <label>
                                    Purchase_Rate:
                                <asp:TextBox runat="server" ID="txtPurchase" CssClass="form-control" />
                                </label>
                                <br />
                                <label>
                                    Sell_rate:
                                <asp:TextBox runat="server" ID="txtSell" CssClass="form-control" />
                                </label>
                                <br />
                                <label>
                                    Product Image:
                                <asp:TextBox runat="server" ID="txtImage" CssClass="form-control" />
                                </label>
                                <br />
                                <label>
                                    Product Description:
                                <asp:TextBox runat="server" ID="txtDescription" CssClass="form-control" TextMode="MultiLine" />
                                </label>
                            </div>

                        </div>
                        <div class="panel-footer">
                            <asp:Button runat="server" ID="add_btn" CssClass="btn btn-primary" Text="Add Product" OnClick="add_btn_Click" />


                        </div>
                    </div>
                </div>
            </div>

        </section>
        <!-- /.content -->
    </div>
    <!-- /.content-wrapper -->
</asp:Content>
