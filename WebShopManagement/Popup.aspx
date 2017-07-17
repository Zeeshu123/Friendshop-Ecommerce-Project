<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Popup.aspx.cs" Inherits="WebShopManagement.Popup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/StyleSheet.css" rel="stylesheet" />
    <link href="css/bootstrap.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div>
            
             <div class="container">
            <div class="row">
                <div class="col-xs-12">
                    <button class="btn btn-primary btn-sm pull-right" data-target="loginmodal" data-toggole="modal">Login</button>
                    <div class="modal" id="loginmodal" tabindex="-1">
                        <div class="modal-dialog">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <button class="close" data-dismiss="modal">&times;</button>
                                    <h4 class="modal-title">Login</h4>
                                </div>
                                <div class="modal-body">
                                    <form>
                                        <div class="form-group">
                                            <label for="inputUserName">Username</label>
                                            <input class="form-control" placeholder="Login Username" type="text" id="inputusername" />
                                        </div>
                                        <div class="form-group">
                                            <label for="inputUserName">Username</label>
                                            <input class="form-control" placeholder="Login Username" type="password" id="inputpassword" />
                                        </div>
                                    </form>
                                </div>
                                <div class="modal-footer">
                                    <button class="btn btn-primary">Login</button>
                                    <button class="btn btn-primary" data-dismiss="modal">Close</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        </div>
    </form>
</body>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
<script src="js/bootstrap.js"></script>

</html>
