<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="userlogin.aspx.cs" Inherits="eLibraryManagement.userlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row" >
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img src="img/generaluser.png" alt="user-login-icon" class="img-fluid" width="150"/>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>Member Login</h3>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <label class="form-label">Member ID</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Member ID"></asp:TextBox>
                                </div>

                                <label class="form-label">Password</label>
                                <div class="form-group mb-4">
                                    <asp:TextBox Cssclass="form-control" ID="TextBox2" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                                </div>

                                
                                <div class="form-group d-grid gap-2">
                                    <asp:Button class="btn btn-success btn-lg" ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                                    <asp:Button class="btn btn-primary btn-lg" ID="Button3" PostBackUrl="usersignup.aspx" runat="server" Text="Sign Up" />
                                </div>
                                


                            </div>
                        </div>

                    </div>
                </div>

                <a href="homepage.aspx"><< Back to Home</a>
                <br />
                <br />
            </div>
        </div>

    </div>

</asp:Content>
