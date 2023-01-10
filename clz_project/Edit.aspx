<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="clz_project.Edit" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="editForm">
        <div class="card card-primary" style="width: 50%;">
            <div class="card-header">
                <h3 class="card-title">Edit Student</h3>
            </div>
            <!-- /.card-header -->
            <!-- form start -->
            <div class="card-body">
                <div class="form-group">
                    <label for="name">Name</label>
                    <asp:TextBox runat="server" class="form-control" ID="Name" placeholder="Enter Student's name" />
                </div>

                <div class="form-group">
                    <label for="address">Address</label>
                    <asp:TextBox runat="server" class="form-control" ID="Address" placeholder="Enter address" />
                </div>

                 <div class="form-group">
                    <label for="faculty">Faculty</label>
                    <asp:TextBox runat="server" class="form-control" ID="Faculty" placeholder="Enter Faculty" />
                </div>


            </div>
            <!-- /.card-body -->

            <div class="card-footer">
                <asp:Button Text="update" runat="server" class="btn btn-primary" ID="update" OnClick="update_Click" />
            </div>
        </div>
    </div>
    <%-- <div class="editForm">
            <div>Edit Student</div>
        <div class="innerEdit">

            <asp:TextBox runat="server" ID="name" placeholder="name"/>
        </div>
    </div>--%>
</asp:Content>
