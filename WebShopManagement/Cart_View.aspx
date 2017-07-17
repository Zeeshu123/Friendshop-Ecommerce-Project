<%@ Page Title="Cart View" Language="C#" MasterPageFile="~/Web.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="Cart_View.aspx.cs" Inherits="WebShopManagement.Cart_View" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="container">
        <div class="content">
            <div class="row">
                <div class="col-md-12" style="margin: 20px">
                    <asp:GridView CssClass="table table-responsive" RowStyle-Height="100px" OnRowCommand="Products_gw_RowCommand" ShowFooter="true" runat="server" ID="Products_gw" AutoGenerateColumns="false" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDataBound="Products_gw_RowDataBound">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775"></AlternatingRowStyle>
                        <Columns>
                            <asp:TemplateField HeaderText="Sl." HeaderStyle-Width="10%">
                                <ItemTemplate><%# Container.DataItemIndex +1 %></ItemTemplate>
                            </asp:TemplateField>
                            <asp:ImageField DataImageUrlField="Product_Image" ItemStyle-Height="200px" ItemStyle-Width="200px"></asp:ImageField>
                            <asp:BoundField DataField="Product_Name" HeaderText="Product Name" />
                            <asp:BoundField DataField="Product_Id" HeaderText="ID" />
                            <asp:BoundField DataField="Category_Id" HeaderText="Category" />
                            <asp:BoundField DataField="Sell_Rate" HeaderText="Product Price" />
                            <asp:BoundField DataField="Quantity" HeaderText="Available" />
                            <asp:TemplateField HeaderText="Quantity">
                                <ItemTemplate>
                                    <asp:TextBox runat="server" ID="txtQuantity" OnTextChanged="txtQuantity_TextChanged" AutoPostBack="true"></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Amount">
                                <ItemTemplate >

                                    <asp:Label ID="lblAmount" runat="server" Text='<%# Convert.ToInt32(Eval("Sell_Rate"))%>'></asp:Label>
                                </ItemTemplate>


                                <FooterTemplate>
                                    <%--<asp:Label ID="Label1" CssClass="glyphicon-font:bold" ForeColor="Black" runat="server" Text="Total = "></asp:Label>--%>
                                    <asp:Label ID="totalAmount" CssClass="glyphicon-font:bold" ForeColor="Black" runat="server" Text=""></asp:Label>
                                </FooterTemplate>

                            </asp:TemplateField>

                            <asp:TemplateField>

                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkDelete" CommandArgument='<%# Container.DataItemIndex %>' CommandName="Delete" CssClass="DeleteRow" runat="server"> Delete </asp:LinkButton>
                                    <%--<asp:LinkButton ID="btnDelete" runat="server" CommandName="Delete" OnClientClick="return isDelete();" Text="Delete"></asp:LinkButton>--%>
                                </ItemTemplate>

                            </asp:TemplateField>

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
                    <br />
                    <div class="text-center">
                        <asp:Button runat="server" class="btn btn-success" Text="Proceed to Checkout" ID="btnProceed" OnClick="btnProceed_Click" />
                    </div>
                    <br />
                </div>
            </div>
        </div>
    </div>

</asp:Content>
