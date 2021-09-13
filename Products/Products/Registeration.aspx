<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registeration.aspx.cs" Inherits="Products.Registeration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Page</title>
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

        #btn_Add {
            margin-left: 100px;
        }
        h1{
            color:white;
        }
    </style>
</head>
<body class="content">

    <div class="bg-image"></div>
    <div class="bg-text">
        <form id="reg" runat="server" style="margin: 10px; align-content: center;" novalidate="novalidate">

            <div>
                <h1>Registration Page</h1>
            </div>
            <br />
            <div class="form-floating mb-3">
                <!--<asp:Label for="tb_F_Name" ID="lbl_F_Name" runat="server" Text="First Name"></asp:Label>-->
                <!--<div class="col-sm-10">-->
                <asp:TextBox ID="tb_F_Name" runat="server" class="form-control" placeholder="Please enter the First name" required="required"></asp:TextBox>
                <label for="tb_F_Name">First Name</label><span class="error FNameE"></span>

            </div>

            <div class="form-floating mb-3">
                

                <asp:TextBox ID="tb_L_Name" runat="server" class="form-control" placeholder="Enter Last Name"></asp:TextBox>
                 <label for="tb_L_Name">Last Name</label>
                <span class="error LNameE"></span>
            </div>


            <div class="form-floating mb-3">
                

                <asp:TextBox ID="tb_Dob" runat="server" class="form-control" TextMode="Date" placeholder="Enter DOB"></asp:TextBox>
            <label for="tb_Dob">Date of Birth</label>
                <span class="error DobE"></span>            
            </div>



            <div class="form-floating mb-3">
  

                <asp:TextBox ID="tb_Phone" runat="server" class="form-control" placeholder="Enter Mobile No"></asp:TextBox>
                <label for="tb_Phone">Mobile</label>
                <span class="error MobileE"></span>            
            </div>


            <div class="form-floating mb-3">

                <asp:TextBox ID="tb_Email" runat="server" class="form-control" placeholder="Enter Email"></asp:TextBox>
                <label for="tb_Email">Email</label>
                <span class="error EmailE"></span>            
            </div>



            <div class="form-floating mb-3">
              

                <asp:TextBox ID="tb_Locations" runat="server" class="form-control" placeholder="Enter Location"></asp:TextBox>
                <label for="tb_Locations">Locations</label>
                <span class="error LocE"></span>            
            </div>



            <div class="form-floating mb-3">
                
                <asp:TextBox ID="tb_Username" runat="server" class="form-control" placeholder="Enter Username"></asp:TextBox>
                <label for="tb_Username">User Name</label>
                <span class="error UserE"></span>            
            </div>



            <div class="form-floating mb-3">
                

                <asp:TextBox ID="tb_Password" runat="server" class="form-control" placeholder="Enter Password" TextMode="Password"></asp:TextBox>
                <label for="tb_Password">Password</label>
                <span class="error PasswordE"></span>            

            </div>
            <br />
            <div class="form-group row">
                <div>
                    <asp:Button ID="btn_Add" class="btn btn-primary" runat="server" Text="Register" OnClick="btn_Add_Click" />
                </div>
            </div>
        </form>
    </div>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
    <script src="Js/validation.js"></script>
</body>
</html>

