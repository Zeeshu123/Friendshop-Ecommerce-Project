<%@ Page Title="" Language="C#" MasterPageFile="~/Web.Master" AutoEventWireup="true" CodeBehind="SearchBtnFivePage.aspx.cs" Inherits="WebShopManagement.SearchBtnFivePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content">
        <div class="container">
            <div class="content-top">
                <h1>Recent Products</h1>
                <div class="content-top1">

                    <% 
                        if (products_list.Count > 0)
                        {
                            foreach (var product in products_list)
                            { %>

                    <div class="col-md-3 col-md-2">
                        <div class="col-md1 simpleCart_shelfItem">
                            <a href="single.html">
                                <img class="img-responsive" src="<%=product.Product_Image %>" alt="" />
                            </a>
                            <h3><a href="single.html"><%=product.Product_Name%></a></h3>
                            <div class="price">
                                <h5 class="item_price"><%=Convert.ToInt32(product.Sell_Rate)%>-Tk</h5>
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
