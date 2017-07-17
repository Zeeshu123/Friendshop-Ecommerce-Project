<%@ Page Title="" Language="C#" MasterPageFile="~/Web.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="ComputerPage.aspx.cs" Inherits="WebShopManagement.Pages.ComputerPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="banner">
        <div class="col-sm-3" >
            <div style="margin-left: 80px">
                <div class="row" >
                    <ul class="memenu skyblue">

                        <li class="showhide" style="display: none;"><span class="title">MENU</span><span class="icon1"></span><span class="icon2"></span></li>

                        <h3 style="border-bottom: double; text-align: center; margin-bottom: 8px">Categories</h3>
                        <li class="row" style="display: block">
                            <a href="HPComputerPage.aspx" style="margin-left: 95px;">>> HP</a><br />
                        </li>
                        <li><a href="ASUSComputerPage.aspx" style="margin-left: 10px;">>> ASUS</a><br /></li>
                       <li> <a href="SONYCoputerPage.aspx" style="margin-left: 10px;">>> SONY</a><br /></li>
                       <li> <a href="AccerComputerPage.aspx" style="margin-left: 10px;">>> ACCER</a><br /></li>
                       <%--<li> <a href="#" style="margin-left: 10px;">>> APPLE</a><br /></li>--%>
                       <li> <a href="SamsungComputerPage.aspx" style="margin-left: 10px;">>> SAMSUNG</a><br /></li>
                       <li> <a href="OtherComputerPage.aspx" style="margin-left: 10px;">>> OTHERS</a></li>
                    </ul>
                </div>

            </div>
        </div>
        <div class="col-sm-6 matter-banner">
            <div class="slider">
                <div class="callbacks_container">
                    <ul class="rslides callbacks callbacks1" id="slider">
                        <li id="callbacks1_s0" class="callbacks1_on" style="display: block; float: left; position: relative; opacity: 1; z-index: 2; transition: opacity 500ms ease-in-out;">
                            <img src="images/banner-computer5.jpg" alt="" />
                        </li>
                    </ul>
                    <ul class="callbacks_tabs callbacks1_tabs">
                        <li class="callbacks1_s1 callbacks_here"><a href="#" class="callbacks1_s1">1</a></li>
                        <li class="callbacks1_s2"><a href="#" class="callbacks1_s2">2</a></li>
                        <li class="callbacks1_s3"><a href="#" class="callbacks1_s3">3</a></li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="col-sm-3">
            <label style="margin-top: 15px; margin-left: 30px; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif">> Cash on Delivery</label><br />
            <label style="margin-top: 10px; margin-left: 30px; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif">> Paypal Delivery</label><br />
            <label style="margin-top: 10px; margin-left: 30px; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif">> Cash on bkash</label>

        </div>

        <div class="clearfix"></div>
    </div>


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
                            <h3><%=product.Product_Name%></h3>
                            <div class="price">
                                <h5 class="item_price"><%=product.Sell_Rate %></h5>
                                <a href="ComputerPage.aspx?pro_id=<%=product.Product_Id %>&action=add" class="item_add">Add To Cart</a>
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
