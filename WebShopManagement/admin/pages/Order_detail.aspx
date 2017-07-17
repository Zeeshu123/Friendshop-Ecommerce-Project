<%@ Page Title="Details" Language="C#" MasterPageFile="~/admin/pages/Admin.Master" AutoEventWireup="true" CodeBehind="Order_detail.aspx.cs" Inherits="Shopping_Cart.admin.pages.Order_detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
            <h1>Order Details
            </h1>

        </section>

        <!-- Main content -->
        <section class="content">

            <asp:GridView CssClass="table table-responsive" runat="server" ID="gw" AutoGenerateColumns="False" DataSourceID="detail_Ds">

                <Columns>
                    
                    <asp:BoundField DataField="Product_Id" HeaderText="Product_Id" SortExpression="Product_Id"></asp:BoundField>
                    <asp:BoundField DataField="Product_Name" HeaderText="Product_Name" SortExpression="Product_Name"></asp:BoundField>
                    <asp:BoundField DataField="Sell_Rate" HeaderText="Price" SortExpression="Sell_Rate"></asp:BoundField>
                </Columns>
            </asp:GridView>

            <asp:SqlDataSource runat="server" ID="detail_Ds" ConnectionString='<%$ ConnectionStrings:WebshopManagementConnectionString %>' SelectCommand="Select p.Product_Name,p.Sell_Rate,p.Product_Id from tbl_Order o Inner Join tbl_Cart c on c.Session_id = o.Session_id inner join tbl_ProductInfo p on c.Product_Id = p.Product_Id Where o.Session_id=@Session_id">
                <SelectParameters>
                    <asp:QueryStringParameter QueryStringField="order_id" Name="Session_id"></asp:QueryStringParameter>
                </SelectParameters>
            </asp:SqlDataSource>
        </section>
        <!-- /.content -->
    </div>
</asp:Content>
