<%@ Page Title="" Language="C#" MasterPageFile="~/Web.Master" AutoEventWireup="true" CodeBehind="AccerComputerPage.aspx.cs" Inherits="WebShopManagement.AccerComputerPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content">
        <div class="container">
            <div class="content-top">
                <h3>Search Your own demand by selecting price...</h3>
                <ul class="memenu skyblue">
                    <li>

                        <asp:DropDownList CssClass="form-control" Height="31px" ID="ddlLowest_Price" runat="server">
                            <asp:ListItem>Lowest_Price</asp:ListItem>
                            <asp:ListItem>10000</asp:ListItem>
                            <asp:ListItem>20000</asp:ListItem>
                            <asp:ListItem>30000</asp:ListItem>
                        </asp:DropDownList>
                    </li>
                    <li>

                        <asp:DropDownList CssClass="form-control" Height="31px" ID="ddlHighest_Price" runat="server" AutoPostBack="True">
                            <asp:ListItem>Highest_Price</asp:ListItem>
                            <%--<asp:ListItem>5000</asp:ListItem>--%>
                            <asp:ListItem>10000</asp:ListItem>
                            <asp:ListItem>20000</asp:ListItem>
                            <asp:ListItem>30000</asp:ListItem>
                            <asp:ListItem>50000</asp:ListItem>
                        </asp:DropDownList>
                    </li>
                </ul>
                <div class="content-top1">

                    <% 
                        if (products_list.Count > 0)
                        {
                            foreach (var product in products_list)
                            { %>

                    <div class="col-md-3 col-md-2">
                        <div class="col-md1 simpleCart_shelfItem">                           
                                <a href="Product_ViewPage.aspx?pro_id=<%=product.Product_Id %>">
                                <img class="img-responsive" src="<%=product.Product_Image %>" alt="" />
                            </a>
                            <h3><a href="Product_ViewPage.aspx"><%=product.Product_Name%></a></h3>
                            <div class="price">
                                <h5 class="item_price"><%=product.Sell_Rate %></h5>
                                <a href="AccerComputerPage.aspx?pro_id=<%=product.Product_Id %>&action=add" class="item_add">Add To Cart</a>
                                <div class="clearfix"></div>
                            </div>
                        </div>
                    </div>
                    <%}
                        }
                        else
                        {
                    %>
                    <h2>No Products Available</h2>
                    <%} %>
                    <div class="clearfix"></div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
