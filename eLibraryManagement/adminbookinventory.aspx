<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminbookinventory.aspx.cs" Inherits="eLibraryManagement.adminbookinventory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


        <div class="container-fluid">
        <div class="row">
            <div class="col-md-5">
                <div class="card">
                    <div class="card-body">

                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Book Details</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img src="img/books.png" alt="general User Profile Image" width="80" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <asp:FileUpload class="form-control" ID="FileUpload1" runat="server" />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-3">
                                <label>Book ID</label>
                                <div class="input-group">
                                     <asp:TextBox class="form-control" ID="TextBox2" runat="server" placeholder="ID"></asp:TextBox>
                                    <asp:Button class="btn btn-primary " ID="Button1" runat="server" Text="Go" />
                                </div>
                            </div>
                            <div class="col-md-9">
                                <label>Book Name</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="TextBox1" runat="server" placeholder="Book Name" ></asp:TextBox>
                                </div>
                            </div>
                            
                        </div>



                        <div class="row">
                            <div class="col-md-4">
                                <div class="row">
                                    <div class="col">
                                        <label>Language</label>
                                        <div class="form-group">
                                            <asp:DropDownList class="form-control" ID="DropDownList1" runat="server">
                                                <asp:ListItem Text="Select.." Value="Select.."/>                                                
                                                <asp:ListItem Text="English" Value="English"/>
                                                <asp:ListItem Text="Hindi" Value="Hindi"/>
                                                <asp:ListItem Text="Marathi" Value="Marathi"/>
                                                <asp:ListItem Text="French" Value="French"/>
                                                <asp:ListItem Text="German" Value="German"/>
                                                <asp:ListItem Text="Urdu" Value="Urdu"/>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <label>Publisher Name</label>
                                        <div class="form-group">
                                            <asp:DropDownList class="form-control" ID="DropDownList2" runat="server">
                                                <asp:ListItem Text="Select.." Value="Select.."/>                                                
                                                <asp:ListItem Text="Publisher-1" Value="Publisher-1"/>
                                                <asp:ListItem Text="Publisher-2" Value="Publisher-2"/>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>Author Name</label>
                                        <div class="form-group">
                                            <asp:DropDownList class="form-control" ID="DropDownList3" runat="server">
                                                <asp:ListItem Text="Select.." Value="Select.."/>                                                
                                                <asp:ListItem Text="A1" Value="A1"/>
                                                <asp:ListItem Text="A2" Value="A2"/>
                                            </asp:DropDownList>
                                        </div>
                                <label>Publish Date</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="TextBox3" runat="server" TextMode="Date"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>Genre</label>
                                <div class="form-group">
                                    <asp:ListBox class="form-control" ID="ListBox1" runat="server" SelectionMode="Multiple" Rows="4">
                                        <asp:ListItem Text="Adventure" Value="Adventure"/>
                                        <asp:ListItem Text="Comic Book" Value="Comic Book"/>
                                        <asp:ListItem Text="Self Help" Value="Self Help"/>
                                        <asp:ListItem Text="Motivation" Value="Motivation"/>
                                        <asp:ListItem Text="Healthy Living" Value="Healthy Living"/>
                                        <asp:ListItem Text="Wellness" Value="Wellness"/>
                                        <asp:ListItem Text="Crime" Value="Crime"/>
                                        <asp:ListItem Text="Drama" Value="Drama"/>
                                        <asp:ListItem Text="Fantacy" Value="Fantacy"/>
                                        <asp:ListItem Text="Horror" Value="Horror"/>
                                        <asp:ListItem Text="Poetry" Value="Poetry"/>
                                        <asp:ListItem Text="Personal Development" Value="Personal Development"/>
                                        <asp:ListItem Text="Romance" Value="Romance"/>
                                        <asp:ListItem Text="Science Fiction" Value="Science Fiction"/>
                                        <asp:ListItem Text="Thriller" Value="Thriller"/>
                                        <asp:ListItem Text="Suspense" Value="Suspense"/>
                                        <asp:ListItem Text="Art" Value="Art"/>
                                        <asp:ListItem Text="Autobiography" Value="Autobiography"/>
                                        <asp:ListItem Text="Encyclopedia" Value="Encyclopedia"/>
                                        <asp:ListItem Text="Health" Value="Health"/>
                                        <asp:ListItem Text="History" Value="History"/>
                                        <asp:ListItem Text="Math" Value="Math"/>
                                        <asp:ListItem Text="Textbook" Value="Textbook"/>
                                        <asp:ListItem Text="Science" Value="Science"/>
                                        <asp:ListItem Text="Travel" Value="Travel"/>


                                    </asp:ListBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <label>Edition</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="TextBox7" runat="server" placeholder="Edition"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>Book Cost(per unit)</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="TextBox8" runat="server" TextMode="Number" placeholder="Cost" ></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>Pages</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="TextBox9" runat="server" TextMode="Number" placeholder="Pages" ></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <label>Actual Stock</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="TextBox4" runat="server" placeholder="Actual Stock"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>Current Stock</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="TextBox5" runat="server"  placeholder="Current Stock" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>Issued Book</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="TextBox6" runat="server" TextMode="Number" placeholder="Issued Book" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <label>Book Description</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="TextBox10" runat="server" TextMode="MultiLine" Rows="2" placeholder="Description"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row my-3">
                            <div class="col-md-4 d-grid">
                                <asp:Button class="btn btn-success btn-md" ID="Button2" runat="server" Text="Add" />
                            </div>
                            <div class="col-md-4 d-grid">
                                <asp:Button class="btn btn-warning btn-md" ID="Button3" runat="server" Text="Update" />
                            </div>
                            <div class="col-md-4 d-grid">
                                <asp:Button class="btn btn-danger btn-md" ID="Button4" runat="server" Text="Delete" />
                            </div>
                        </div>
                        <div class="row">
                            <a href="homepage.aspx"><< Back To Home</a>
                        </div>
                    </div>
                </div>
            </div>

            <div class="col-md-7">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Book Inventory List</h4>
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
                                <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server"></asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
