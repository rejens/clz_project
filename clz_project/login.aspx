<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="clz_project.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        * {
            box-sizing: border-box;
        }

        body {
            display: flex;
            height: 100vh;
            justify-content: center;
            align-items: center;
        }

        .container {
            border-radius: 15px 15px;
            width: 500px;
            box-shadow: 20px 20px 80px grey;
            display: flex;
            gap: 50px;
            align-items: center;
            flex-direction: column;
            padding-bottom: 50px;
        }

        .signup {
            padding: 20px 0;
            width: 100%;
            background-color: #68b984;
            text-align: center;
            font-size: 1rem;
            border-radius: 15px 15px 0 0;
            color: #222624;
        }

        .form-group {
            display: flex;
            flex-direction: column;
            gap: 20px;
        }

        .input-group {
            font-family: "Ubuntu", sans-serif;
        }

            .input-group input {
                border-radius: 5px;
                border: none;
                height: 40px;
                box-shadow: 5px 5px 15px gray;
            }

        a {
            text-decoration: none;
            color: #222624;
            transition: all;
            transition-duration: 0.5s;
        }

            a:hover {
                color: #68b984;
                font-size: 1.1rem;
            }

        #username, #password {
            width: 300px
        }
        .signin-button{
            margin:auto;
            width:50%;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="signup">Sign In</div>
            <div class="form-group">
                <div class="input-group">
                    <asp:TextBox runat="server" ID="username" placeholder="username" />
                </div>
                <div class="input-group">
                    <asp:TextBox ID="password" runat="server" TextMode="Password" placeholder="password"></asp:TextBox>
                </div>

                <div class="input-group" style="text-align:center">
                    <asp:Button class="signin-button" Text="sign in" runat="server" OnClick="SignIn"/>
                </div>
            </div>
            <div><a href="#">forgot password?</a></div>
        </div>
    </form>
</body>
</html>
