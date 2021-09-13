<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Products.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />
    <style>
        body, html {
            height: 100%;
            margin: 0;
            font-family: Arial, Helvetica, sans-serif;
        }


        .bg-image {
            /* The image used */
           /* background-image: url("mainPage.jpg");*/
           background-image: linear-gradient(to right, #ffd89b,#19547b);
            /* Add the blur effect */
            filter: blur(8px);
            -webkit-filter: blur(8px);
            /* Full height */
            height: 125%;
            background-attachment:fixed;
            /* Center and scale the image nicely */
         
        }

        /* Position text in the middle of the page/image */
        .bg-text {
            /* Black w/opacity/see-through */
            color: grey;
            font-weight: bold;
            position: absolute;
            top: 60%;
            left: 50%;
            transform: translate(-50%, -50%);
            z-index: 2;
            width: 30%;
            padding: 20px;
            text-align: left;
        }

                h1{
            color:white;
        }
    </style>
</head>
<body>
        <div class="bg-image"></div>
    <div class="bg-text">
            <form id="reg" runat="server" style="margin: 10px; align-content: center;" novalidate="novalidate">
        <h1>Login</h1>
        <br />
        <div class="form-floating mb-3">    

                <asp:TextBox ID="txt_UserName" runat="server" class="form-control" placeholder="Enter User Name"></asp:TextBox>
                 <label for="txt_UserName">Last Name</label>
            </div>
       
              <div class="form-floating mb-3">

                <asp:TextBox for="Label6" ID="txt_Password" runat="server" placeholder="Enter the Password" class="form-control"></asp:TextBox>
                  <label for="txt_Password">Password</label>
            </div>

            <br />

            <asp:Button ID="btnlogin" runat="server" OnClick="btnlogin_Click" Text="Login" Class="btn btn-primary" />
            <asp:Button ID="btnSignUp" runat="server" OnClick="btnSignUp_Click" Text="SignUp" Class="btn btn-primary"/>
        
        <asp:Label ID="lbl_error" runat="server" Text=""></asp:Label>
    </form>
        </div>
</body>
</html>
