<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="clz_project.AddStudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="editForm">
        <div class="card card-primary" style="width: 50%;">
            <div class="card-header">
                <h3 class="card-title">Add Student</h3>
            </div>
            <!-- /.card-header -->
            <!-- form start -->
            <div class="card-body">

                <div class="form-group">
                    <label for="id">Id</label>
                    <asp:TextBox runat="server" class="form-control" ID="Id" placeholder="Enter Student's Id" />
                </div>

                <div class="form-group">
                    <label for="name">Name</label>
                    <asp:TextBox runat="server" class="form-control" ID="Name" placeholder="Enter Student's name" />
                </div>

                <div class="form-group">
                    <label for="address">Address</label>
                    <asp:TextBox runat="server" class="form-control" ID="Address" placeholder="Enter Student's address" />
                </div>

                <div class="form-group">
                    <label for="faculty">Faculty</label>
                    <asp:TextBox runat="server" class="form-control" ID="Faculty" placeholder="Enter Faculty" />
                </div>


            </div>
            <!-- /.card-body -->

            <div class="card-footer">
                <asp:Button Text="submit" runat="server" class="btn btn-primary" ID="submit" OnClick="add_student" />
            </div>
        </div>
    </div>


    <script type="text/javascript">


        document.addEventListener("keypress", function (e) {
            if (e.key == "Enter") {
                document.getElementById("submit").click()
            }
        });
    </script>

</asp:Content>
