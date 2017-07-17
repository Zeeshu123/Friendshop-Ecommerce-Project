<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/admin/pages/Admin.Master" AutoEventWireup="true" CodeBehind="ReportPage.aspx.cs" Inherits="WebShopManagement.admin.pages.ReportPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
            <asp:Button runat="server" Font-Bold ID="btnStockFullProduct" Text="Stock_Now" CssClass="btn btn-info" OnClick="btnStockFullProduct_Click" />
            &nbsp;&nbsp;
            <asp:Button runat="server" Font-Bold ID="btnStockLowProduct" Text="Stock_Low" CssClass="btn btn-default" OnClick="btnStockLowProduct_Click" />
            &nbsp;&nbsp;
            <asp:Button runat="server" Font-Bold ID="btnDailySaleProduct" Text="DailySale_Product" CssClass="btn btn-info" />
            &nbsp;&nbsp;
            <asp:Button runat="server" Font-Bold ID="btnTotalSale" Text="TotalSale_Product" CssClass="btn btn-default" />
            &nbsp;&nbsp;
            <asp:Button runat="server" Font-Bold ID="btnNoStockProduct" Text="No Stock" CssClass="btn btn-info" OnClick="btnNoStockProduct_Click" />
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
                        <div class="panel-heading"></div>
                        <div class="panel-body">
                            <div class="col-md-7" style="margin-top: 8px">
        <asp:GridView ID="dgvEmployee" runat="server" BackColor="White" BorderColor="#E7E7FF"
            BorderStyle="None" BorderWidth="1px" CellPadding="3" Font-Names="Calibri" Font-Size="Larger"
            GridLines="Horizontal" AutoGenerateColumns="false" Width="150%">

            <Columns>
                <asp:TemplateField HeaderText="Sl." HeaderStyle-HorizontalAlign="Justify" HeaderStyle-Width="10%">
                    <ItemTemplate><%# Container.DataItemIndex +1 %></ItemTemplate>
                </asp:TemplateField>              

                <asp:BoundField DataField="Product_Id" HeaderText="Product Id" HeaderStyle-Width="20%" />

                <asp:BoundField DataField="Product_Name" HeaderText="Product Name" HeaderStyle-Width="20%" ItemStyle-HorizontalAlign="Justify" />

                <asp:BoundField DataField="Category_Id" HeaderText="Category Id" HeaderStyle-Width="20%" ItemStyle-HorizontalAlign="Justify" />

                <asp:BoundField DataField="Category_Name" HeaderText="Category Name" HeaderStyle-Width="20%" ItemStyle-HorizontalAlign="Justify" />

                <asp:BoundField DataField="Quantity" HeaderText="Quantity" HeaderStyle-Width="20%" ItemStyle-HorizontalAlign="Justify" />

                <asp:BoundField DataField="ReorderLebel" HeaderText="Reorder level" HeaderStyle-Width="20%" ItemStyle-HorizontalAlign="Justify" />

            </Columns>


            <AlternatingRowStyle BackColor="#F7F7F7" />

            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />

            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />

            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />

            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />

            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />

            <SortedAscendingCellStyle BackColor="#F4F4FD" />

            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />


            <SortedDescendingCellStyle BackColor="#D8D8F0" />

            <SortedDescendingHeaderStyle BackColor="#3E3277" />

        </asp:GridView>
    </div>
                        </div>
                    </div>
                </div>
            </div>

        </section>
        <!-- /.content -->
    </div>
    <!-- /.content-wrapper -->

</asp:Content>
