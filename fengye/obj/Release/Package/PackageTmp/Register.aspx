<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="fengye.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <title>FengYe-Register</title>
	
	<!-- Styles -->
    <link href="backstage/assets/fontAwesome/css/fontawesome-all.min.css" rel="stylesheet">
    <link href="backstage/assets/css/lib/themify-icons.css" rel="stylesheet">
    <link href="backstage/assets/css/lib/bootstrap.min.css" rel="stylesheet">
    <link href="backstage/assets/css/lib/nixon.css" rel="stylesheet">
    <link href="backstage/assets/css/style.css" rel="stylesheet">
    <link href="login.css" rel="stylesheet" />
    <!--Load Jquery-->
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script>
        /*更改背景图片*/
        var changeBackgroundT;
        var n = 0;//图片序号
        var divcount = $('#bg').children('div').length;
        function changeBackground() {
            changeBackgroundT = setTimeout("changeBackground()", 10000);
            n = (n % divcount) + 1;
            //前一张图片淡出
            $("#bg" + String(n)).fadeToggle(3000);
            $("#bg" + String(n)).css("z-index", "-1");
            //当前显示图片
            $("#bg" + String((n % divcount) + 1)).css("z-index", "-2");
            $("#bg" + String((n % divcount) + 1)).css("display", "block");
            //下一张作为底图
            $("#bg" + String(((n + 1) % divcount) + 1)).css("z-index", "-3");
        }
        </script>
</head>
<body onload="changeBackground();">
    <!-- 网页背景 -->
    <div id="bg">
        <div id="bg1" class="bgdiv" style="background-image: url(../img/1.jpg);"></div>
        <div id="bg2" class="bgdiv" style="background-image: url(../img/2.jpg);"></div>
        <div id="bg3" class="bgdiv" style="background-image: url(../img/3.jpg);"></div>
    </div>
    <div class="Nixon-login">
        <div class="container">
            <div class="row">
                <div class="col-lg-6 col-lg-offset-3">
                    <div class="login-content">
                        <div class="login-form">
                            <h4>Register to User</h4>
                            <form runat="server">
                                <div class="form-group">
                                    <label>User Name</label>
                                    <input type="text" class="form-control" placeholder="User Name" id="txtUserName" runat="server"/>
                                </div>
                                <div class="form-group">
                                    <label>Password</label>
                                    <input type="password" class="form-control" placeholder="Password" id="txtPassword" runat="server"/>
                                </div>
                                <div class="checkbox">
                                    <label>
                                        <input type="checkbox"  id="chkReadMe" runat="server"/>
                                        Agree the terms and policy 
								
                                    </label>
                                </div>
                                <asp:Button ID="btnRegister" class="btn btn-primary btn-flat m-b-30 m-t-30" runat="server" Text="Register" OnClick="btnRegister_Click" />
                                <div class="register-link m-t-15 text-center">
                                    <p>Already have account ? <a href="Login.aspx">Sign in</a></p>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
