<%@ Page Title="Sell24" Language="C#" EnableEventValidation="false" MasterPageFile="~/Web.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebShopManagement.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="banner">
        <div class="col-sm-3">
            <div style="margin-left: 80px">
                <div class="row" >
                    <ul class="memenu skyblue" style="align-content:center">

                        <%--<li class="showhide" style="display: none;"><span class="title">MENU</span><span class="icon1"></span><span class="icon2"></span></li>--%>
                        <li ><a href="MenPage.aspx" >>> Men's Fashion</a><br /></li>                       
                        <li><a href="WomenPage.aspx" >>> Women's Fashion</a><br /></li>
                        <li> <a href="kidsPage.aspx" >>> Kid's Fashion</a><br /></li>
                        <li> <a href="MobilePage.aspx" >>> Mobile & Tablet</a><br /></li>
                        <li> <a href="ComputerPage.aspx" >>> Computer & Gaming</a><br /></li>
                        <li> <a href="TvCamera.aspx" >>> TV & Audio</a><br /></li>
                        <li> <a href="homelivingPage.aspx" ">>> Home & Living</a><br /></li>
                        <li> <a href="Appliences.aspx" >>> Appliances</a><br /></li>
                        <li> <a href="beautyhealthPage.aspx" >>> Beauty & Health</a><br /></li>                        
                        <li> <a href="SportsPage.aspx" >>> Sports & Fitness</a><br /></li>                        
                        <li> <a href="giftPage.aspx" >>> Gift Products</a></li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="col-sm-6 matter-banner">
            <div class="slider">
                <div class="callbacks_container">
                    <ul class="rslides callbacks callbacks1" id="slider">
                        <li id="callbacks1_s0" class="callbacks1_on" style="display: block; float: left; position: relative; opacity: 1; z-index: 2; transition: opacity 500ms ease-in-out;">
                            <img src="images/1.jpg" alt="" />
                        </li>
                        <li id="callbacks1_s1" style="float: none; position: absolute; opacity: 0; z-index: 1; display: list-item; transition: opacity 500ms ease-in-out;" class="">
                            <img src="images/2.jpg" alt="" />
                        </li>
                        <li id="callbacks1_s3" style="float: none; position: absolute; opacity: 0; z-index: 1; display: list-item; transition: opacity 500ms ease-in-out;" class="">
                            <img src="images/BANNER-SALE.jpg" alt="" />
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
            <label style="margin-top: 15px; margin-left: 30px; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; color:black">> Cash on Delivery</label><br />
            <label style="margin-top: 10px; margin-left: 30px; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; color:darkgrey">> Paypal Delivery</label><br />
            <label style="margin-top: 10px; margin-left: 30px; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; color:black">> Cash on bkash</label>
        </div>

        <div class="clearfix"></div>
    </div>

    <div class="content">
        <div class="container">
            <div class="content-top">
                <h1>Men's Fashion</h1>
                <div class="content-top1" style="margin-left: 50px; margin-right: 50px">

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
                            <h3><a href="single.html"><%=product.Product_Name%></a></h3>
                            <div class="price">
                                <h5 class="item_price" style="text-align: center"><%=Convert.ToInt32(product.Sell_Rate)%>-Tk</h5>
                                
                                <a href="Home.aspx?pro_id=<%=product.Product_Id %>&action=add" class="item_add">Add To Cart</a>
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


    <div class="content">
        <div class="container">
            <div class="content-top">
                <h1>Women's Fashion</h1>
                <div class="content-top1" style="margin-left: 50px; margin-right: 50px">

                    <% 
                        if (wmproducts_list.Count > 0)
                        {
                            foreach (var product in wmproducts_list)
                            { %>

                    <div class="col-md-3 col-md-2">
                        <div class="col-md1 simpleCart_shelfItem">
                            <a href="Product_ViewPage.aspx?pro_id=<%=product.Product_Id %>">
                                <img class="img-responsive" src="<%=product.Product_Image %>" alt="" />
                            </a>
                            <h3><%=product.Product_Name%></h3>
                            <div class="price">
                                <h5 class="item_price" style="text-align: center"><%=Convert.ToInt32(product.Sell_Rate)%>-Tk</h5>
                                <a href="Home.aspx?pro_id=<%=product.Product_Id %>&action=add" class="item_add">Add To Cart</a>
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

    <div class="content">
        <div class="container">
            <div class="content-top">
                <h1>Computers & Gaming</h1>
                <div class="content-top1" style="margin-left: 50px; margin-right: 50px">

                    <% 
                        if (cmproducts_list.Count > 0)
                        {
                            foreach (var product in cmproducts_list)
                            { %>

                    <div class="col-md-3 col-md-2">
                        <div class="col-md1 simpleCart_shelfItem">
                            <a href="Product_ViewPage.aspx?pro_id=<%=product.Product_Id %>">
                                <img class="img-responsive" src="<%=product.Product_Image %>" alt="" />
                            </a>
                            <h3><a href="single.html"><%=product.Product_Name%></a></h3>
                            <div class="price">
                                <h5 class="item_price" style="text-align: center"><%=Convert.ToInt32(product.Sell_Rate) %>-Tk</h5>
                                <a href="Home.aspx?pro_id=<%=product.Product_Id %>&action=add" class="item_add">Add To Cart</a>
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


    <div class="content">
        <div class="container">
            <div class="content-top">
                <h1>Mobile & Tablets</h1>
                <div class="content-top1" style="margin-left: 50px; margin-right: 50px">

                    <% 
                        if (mbproducts_list.Count > 0)
                        {
                            foreach (var product in mbproducts_list)
                            { %>

                    <div class="col-md-3 col-md-2">
                        <div class="col-md1 simpleCart_shelfItem">
                            <a href="Product_ViewPage.aspx?pro_id=<%=product.Product_Id %>">
                                <img class="img-responsive" src="<%=product.Product_Image %>" alt="" />
                            </a>
                            <h3><a href="single.html"><%=product.Product_Name%></a></h3>
                            <div class="price">
                                <h5 class="item_price" style="text-align: center"><%=Convert.ToInt32(product.Sell_Rate)%>-Tk</h5>
                                <a href="Home.aspx?pro_id=<%=product.Product_Id %>&action=add" class="item_add">Add To Cart</a>
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


    <div class="content">
        <div class="container">
            <div class="content-top">
                <h1>TV, Audio & Camera</h1>
                <div class="content-top1" style="margin-left: 50px; margin-right: 50px">

                    <% 
                        if (tvproducts_list.Count > 0)
                        {
                            foreach (var product in tvproducts_list)
                            { %>

                    <div class="col-md-3 col-md-2">
                        <div class="col-md1 simpleCart_shelfItem">
                            <a href="Product_ViewPage.aspx?pro_id=<%=product.Product_Id %>">
                                <img class="img-responsive" src="<%=product.Product_Image %>" alt="" />
                            </a>
                            <h3><a href="single.html"><%=product.Product_Name%></a></h3>
                            <div class="price">
                                <h5 class="item_price" style="text-align: center"><%=Convert.ToInt32(product.Sell_Rate)%>-Tk</h5>
                                <a href="Home.aspx?pro_id=<%=product.Product_Id %>&action=add" class="item_add">Add To Cart</a>
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


    <div class="content">
        <div class="container">
            <div class="content-top">
                <h1>Home Appliances</h1>
                <div class="content-top1" style="margin-left: 50px; margin-right: 50px">

                    <% 
                        if (approducts_list.Count > 0)
                        {
                            foreach (var product in approducts_list)
                            { %>

                    <div class="col-md-3 col-md-2">
                        <div class="col-md1 simpleCart_shelfItem">
                            <a href="Product_ViewPage.aspx?pro_id=<%=product.Product_Id %>">
                                <img class="img-responsive" src="<%=product.Product_Image %>" alt="" />
                            </a>
                            <h3><a href="single.html"><%=product.Product_Name%></a></h3>
                            <div class="price">
                                <h5 class="item_price" style="text-align: center"><%=Convert.ToInt32(product.Sell_Rate)%>-Tk</h5>
                                <a href="Home.aspx?pro_id=<%=product.Product_Id %>&action=add" class="item_add">Add To Cart</a>
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
