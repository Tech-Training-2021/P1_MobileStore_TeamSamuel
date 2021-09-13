<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Products.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="margin:10px;">
        <h3>Login</h3>
        <br />
        <div class="col-md-12 form-group row">
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
                <asp:TextBox for="Label1" ID="txt_UserName" runat="server" placeholder="User Name" class="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label6" runat="server" Text="Password"></asp:Label>
                <asp:TextBox for="Label6" ID="txt_Password" runat="server" placeholder="Password" class="form-control"></asp:TextBox>
            </div>

            <br />

            <asp:Button ID="btnlogin" runat="server" OnClick="btnlogin_Click" Text="Login" Class="btn btn-primary" />
            <asp:Button ID="btnSignUp" runat="server" OnClick="btnSignUp_Click" Text="SignUp" Class="btn btn-primary"/>
        </div>
        <asp:Label ID="lbl_error" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
