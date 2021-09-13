<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Registeration.aspx.cs" Inherits="Products.Registeration" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <h1>Registration Page</h1>
        </div>
    <div>
        <form>
          <div class="form-group row">
              <asp:Label for="tb_F_Name" ID="lbl_F_Name" runat="server" Text="First Name" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_F_Name" runat="server" class="form-control" placeholder="Please enter the First name"></asp:TextBox>
            </div>
          </div>
          <div class="form-group row">
              <asp:Label for="tb_L_Name" ID="lbl_Zipcode" runat="server" Text="Last Name" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_L_Name" runat="server" class="form-control" placeholder="Enter Last Name"></asp:TextBox>
            </div>
          </div>
          <div class="form-group row">
              <asp:Label for="tb_Dob" ID="lbl_Dob" runat="server" Text="Dob" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_Dob" runat="server" class="form-control" placeholder="Enter DOB"></asp:TextBox>
            </div>
          </div>
          <div class="form-group row">
              <asp:Label for="tb_Phone" ID="lbl_Phone" runat="server" Text="Phone" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_Phone" runat="server" class="form-control" placeholder="Enter Mobile No"></asp:TextBox>
            </div>
          </div>
          <div class="form-group row">
              <asp:Label for="tb_Email" ID="lbl_Email" runat="server" Text="Email" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_Email" runat="server" class="form-control" placeholder="Enter Email"></asp:TextBox>
            </div>
          </div>
           <div class="form-group row">
              <asp:Label for="tb_Username" ID="lbl_Username" runat="server" Text="Username" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_Username" runat="server" class="form-control" placeholder="Enter Username"></asp:TextBox>
            </div>
          </div>
          <div class="form-group row">
              <asp:Label for="tb_Password" ID="lbl_Password" runat="server" Text="Password" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_Password" runat="server" class="form-control" placeholder="Enter Password" TextMode="Password"></asp:TextBox>
            </div>
          </div>
          <div class="form-group row">
              <asp:Label for="tb_Locations" ID="lbl_Locations" runat="server" Text="Location" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_Locations" runat="server" class="form-control" placeholder="Enter Location"></asp:TextBox>
            </div>
          </div>
          <div class="form-group row">
            <div class="col-sm-10 offset-sm-2">
                <asp:Button ID="btn_Add" class="btn btn-primary" runat="server" Text="Register" OnClick="btn_Add_Click" />
            </div>
          </div>
    </form>
    </div>
</asp:Content> 
