<%@ Page Title="" Language="C#" MasterPageFile="~/Web.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="SymphonyPage.aspx.cs" Inherits="WebShopManagement.SymphonyPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="banner">
        <div class="col-sm-3">
            <div style="margin-left: 80px">
                <h3 style="border-bottom:double; text-align:center; margin-bottom:8px">Categories</h3>

                <a href="#" style="margin-left:20px;"> >>  Apple</a><br />
                <a href="#" style="margin-left:20px;"> >>  Oppo</a><br />
                <a href="#" style="margin-left:20px;"> >>  Nokia</a><br />
                <a href="#" style="margin-left:20px;"> >>  Symphony</a><br />
                <a href="#" style="margin-left:20px;"> >>  Samsung</a><br />
                <a href="#" style="margin-left:20px;"> >>  Huwei</a><br />
                <a href="#" style="margin-left:20px;"> >>  Others</a>

            </div>
        </div>
        <div class="col-sm-6 matter-banner">
            <div class="slider">
                <div class="callbacks_container">
                    <ul class="rslides callbacks callbacks1" id="slider">
                        <li id="callbacks1_s1" style="float: none; position: absolute; opacity: 0; z-index: 1; display: list-item; transition: opacity 500ms ease-in-out;" class="">
                            <img src="images/banner-mobile2.png" alt="" />
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
            <label style="margin-top:15px;margin-left:30px; font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif">> Cash on Delivery</label><br />
            <label style="margin-top:10px;margin-left:30px; font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif">> Paypal Delivery</label><br />
            <label style="margin-top:10px;margin-left:30px;font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif">> Cash on bkash</label>
       
        </div>

        <div class="clearfix"></div>
    </div>

    <div class="content">
        <div class="container">
            <div class="content-top">
                <h3 style="color:blueviolet">Get your Products by Selecting your demand...</h3>
                <ul class="memenu skyblue">
                    <li>

                        <asp:DropDownList CssClass="form-control" Height="31px" ID="ddlLowest_Price" runat="server">
                            <asp:ListItem>Lowest_Price</asp:ListItem>
                            <asp:ListItem>0</asp:ListItem>
                            <asp:ListItem>2000</asp:ListItem>
                            <asp:ListItem>5000</asp:ListItem>
                            <asp:ListItem>10000</asp:ListItem>
                            <asp:ListItem>20000</asp:ListItem>
                        </asp:DropDownList>
                    </li>
                    <li>

                        <asp:DropDownList CssClass="form-control" Height="31px" ID="ddlHighest_Price" runat="server" AutoPostBack="True">
                            <asp:ListItem>Highest_Price</asp:ListItem>
                            <asp:ListItem>2000</asp:ListItem>
                            <asp:ListItem>3000</asp:ListItem>
                            <asp:ListItem>5000</asp:ListItem>
                            <asp:ListItem>10000</asp:ListItem>
                            <asp:ListItem>20000</asp:ListItem>
                            <asp:ListItem>30000</asp:ListItem>
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
                                <a href="SymphonyPage.aspx?pro_id=<%=product.Product_Id %>&action=add" class="item_add">Add To Cart</a>
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
