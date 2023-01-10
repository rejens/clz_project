<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="clz_project.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>
    <div runat="server" id="divMessage" class="message" style="margin: 10px">this is a simple div</div>


    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>

    <div>
        <div>
            <label>Name</label>
            <asp:TextBox ID="name" runat="server"> </asp:TextBox>
        </div>
        <div>
            <label>Email</label>
            <asp:TextBox ID="email" runat="server"> </asp:TextBox>
        </div>
        <div>
            <label>your favorite color:</label>
            <asp:DropDownList ID="ddlcolor" runat="server">
                <asp:ListItem Value="blue">blue</asp:ListItem>
                <asp:ListItem Value="red">red</asp:ListItem>
                <asp:ListItem Value="yellow">yellow</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div>
            <asp:Button Text="submit" ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" />
        </div>
        <div class="message">
            <asp:Literal ID="ltMessage" runat="server"></asp:Literal>
        </div>
</asp:Content>
