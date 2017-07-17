<%@ Page Title="" Language="C#" MasterPageFile="~/Web.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="Product_ViewPage.aspx.cs" Inherits="WebShopManagement.Product_ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="content-top1" style="margin-left: 50px; margin-right: 50px">

        <% 
            if (products_list.Count > 0)
            {
                foreach (var product in products_list)
                { %>
        <%--<div class="col-md2 simpleCart_shelfItem">--%>
            <div class="col-md-12">
                <div class="col-md-6">
                    <div style="margin-left:200px">
                    <img class="img-responsive" src="<%=product.Product_Image %>" alt="" />
                    <h3><a><%=product.Product_Name%></a></h3>
                        </div>
                    <div class="price">
                        
                        <h2 class="item_price" style="text-align: center">Price: <%=Convert.ToInt32(product.Sell_Rate)%>-Tk</h2>
                        <a href="Home.aspx?pro_id=<%=product.Product_Id %>&action=add" class="item_add">Add To Cart</a>

                        <div class="clearfix"></div>
                    </div>
                </div>
                <div class="col-md-6" style="margin-top:50px">
                    <p style="text-decoration:underline; font-size:large; font:bolder">Description:</p>
                    <p style=""><%=product.Product_Description%></p>
                    <p>Available: <%=product.Quantity%></p>
                    <p style="font-size:large; font:bolder">Quantity: <asp:TextBox runat="server" ID="txtQuantity"></asp:TextBox></p>
                </div>
            <%--</div>--%>
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

</asp:Content>
