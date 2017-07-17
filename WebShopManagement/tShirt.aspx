<%@ Page Title="" Language="C#" MasterPageFile="~/Web.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="tShirt.aspx.cs" Inherits="WebShopManagement.tShirt" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="content">
        <div class="container">
            <div class="content-top">
                <%--<h1>Recent Products</h1>--%>
                <ul class="memenu skyblue">
                    <li>

                        <asp:DropDownList CssClass="form-control" Height="31px" ID="ddlLowest_Price" runat="server" AutoPostBack="True">
                            <asp:ListItem>Lowest_Price</asp:ListItem>
                            <asp:ListItem>0</asp:ListItem>
                            <asp:ListItem>500</asp:ListItem>
                            <asp:ListItem>1000</asp:ListItem>
                            <asp:ListItem>1500</asp:ListItem>
                        </asp:DropDownList>
                    </li>
                    <li>

                        <asp:DropDownList CssClass="form-control" Height="31px" ID="ddlHighest_Price" runat="server" AutoPostBack="True">
                            <asp:ListItem>Highest_Price</asp:ListItem>
                            <asp:ListItem>500</asp:ListItem>
                            <asp:ListItem>1000</asp:ListItem>
                            <asp:ListItem>2000</asp:ListItem>
                            <asp:ListItem>3000</asp:ListItem>
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
                            <h3><%=product.Product_Name%></h3>
                            <div class="price">
                                <h5 class="item_price"><%=Convert.ToInt32(product.Sell_Rate)%>-Tk</h5>
                                <a href="tShirt.aspx?pro_id=<%=product.Product_Id %>&action=add" class="item_add">Add To Cart</a>
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
