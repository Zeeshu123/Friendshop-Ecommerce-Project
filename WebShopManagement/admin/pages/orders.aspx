<%@ Page Title="Orders" Language="C#" MasterPageFile="~/admin/pages/Admin.Master" AutoEventWireup="true" CodeBehind="orders.aspx.cs" Inherits="Shopping_Cart.admin.pages.orders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="content-wrapper">
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <h1>
        New Orders
      </h1>
     
    </section>

    <!-- Main content -->
    <section class="content">

      <div class="row">
          <div class="col-md-12">
              <asp:HiddenField id="hdnproductId" runat="server"/>
              <asp:GridView runat="server" ID="orders_gw" CssClass="table table-responsive" Width="100%" AutoGenerateColumns="False" DataSourceID="ORDER_DS" CellPadding="4" ForeColor="#333333" GridLines="None">

                  <AlternatingRowStyle BackColor="White" ForeColor="#284775"></AlternatingRowStyle>
                  <Columns>
                      <asp:HyperLinkField DataNavigateUrlFields="Session_id" DataNavigateUrlFormatString="Order_detail.aspx?order_id={0}" HeaderText="Order_Id" DataTextField="Session_id" />

                      <%--<asp:BoundField DataField="Session_Id" HeaderText="Session_Id" SortExpression="Session_Id"></asp:BoundField>--%>
                      <asp:BoundField DataField="Customer_Name" HeaderText="Customer_Name" SortExpression="Customer_Name"></asp:BoundField>
                      <asp:BoundField DataField="Customer_Phone" HeaderText="Customer_Phone" SortExpression="Customer_Phone"></asp:BoundField>

                      <asp:BoundField DataField="Customer_Address" HeaderText="Customer_Address" SortExpression="Customer_Address"></asp:BoundField>
                      <asp:BoundField DataField="Order_Price" HeaderText="Order_Price" SortExpression="Order_Price"></asp:BoundField>
                      <asp:BoundField DataField="Edit_Date" HeaderText="Edit_Date" SortExpression="Edit_Date"></asp:BoundField>
                  </Columns>
                  <EditRowStyle BackColor="#999999"></EditRowStyle>

                  <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></FooterStyle>

                  <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></HeaderStyle>

                  <PagerStyle HorizontalAlign="Center" BackColor="#284775" ForeColor="White"></PagerStyle>

                  <RowStyle BackColor="#F7F6F3" ForeColor="#333333"></RowStyle>

                  <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333"></SelectedRowStyle>

                  <SortedAscendingCellStyle BackColor="#E9E7E2"></SortedAscendingCellStyle>

                  <SortedAscendingHeaderStyle BackColor="#506C8C"></SortedAscendingHeaderStyle>

                  <SortedDescendingCellStyle BackColor="#FFFDF8"></SortedDescendingCellStyle>

                  <SortedDescendingHeaderStyle BackColor="#6F8DAE"></SortedDescendingHeaderStyle>
              </asp:GridView>
              <asp:SqlDataSource runat="server" ID="ORDER_DS" ConnectionString='<%$ ConnectionStrings:WebshopManagementConnectionString %>' SelectCommand="SELECT [Session_Id], [Customer_Name], [Customer_Phone], [Customer_Address], [Order_Price], [Edit_Date] FROM [tbl_Order] ORDER BY [Edit_Date] DESC"></asp:SqlDataSource>
          </div>
      </div>

    </section>
    <!-- /.content -->
  </div>
  <!-- /.content-wrapper -->
</asp:Content>
