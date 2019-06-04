<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="fengye.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>FengYe-Login</title>
    <link href="login.css" rel="stylesheet" />
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- Styles -->
    <link href="backstage/assets/fontAwesome/css/fontawesome-all.min.css" rel="stylesheet">
    <link href="backstage/assets/css/lib/themify-icons.css" rel="stylesheet">
    <link href="backstage/assets/css/lib/bootstrap.min.css" rel="stylesheet">
    <link href="backstage/assets/css/lib/nixon.css" rel="stylesheet">
    <link href="backstage/assets/css/style.css" rel="stylesheet">
</head>
<body onload="changeBackground();">
    <!-- 网页背景 -->
    <div id="bg">
        <div id="bg1" class="bgdiv" style="background-image: url(../img/1.jpg);"></div>
        <div id="bg2" class="bgdiv" style="background-image: url(../img/2.jpg);"></div>
        <div id="bg3" class="bgdiv" style="background-image: url(../img/3.jpg);"></div>
    </div>
    <!-- 信息框 -->
    <div id="messagebox"></div>
    <!-- 登录控件 -->
    <div class="Nixon-login">
        <div class="container">
            <div class="row">
                <div class="col-lg-6 col-lg-offset-3">
                    <div class="login-content">
                        <div class="login-form">
                            <h4>User Login</h4>
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
                                        <input type="checkbox" id="chkRememberMe" runat="server"/>
                                        Remember Me
								
                                    </label>
                                    <label class="pull-right">
                                        <a href="page-reset-password.html">Forgotten Password?</a>
                                    </label>

                                </div>
                                <asp:Button ID="Button1" runat="server" Text="Sign in" class="btn btn-primary btn-flat m-b-30 m-t-30" OnClick="btnLogin_Click"/>

                                <div class="register-link m-t-15 text-center">
                                    <p>Don't have account ? <a href="Register.aspx">Sign Up Here</a></p>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>






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

        /*提示信息框动态效果*/
        var messageboxT;
        var top1 = 10;
        var opacity = 0;
        //初始化数据
        function initMessagebox(info) {
            top1 = 10;
            opacity = 0;
            opacity1 = 1;
            $("#messagebox").html(info);
            $("#messagebox").css({ 'display': 'block' });
            appearMessagebox();
        }
        //出现信息框
        function appearMessagebox() {
            top1 += 0.5;
            opacity += 0.05;
            if (opacity < 1) {
                messageboxT = setTimeout("appearMessagebox()", 10);
            }
            else {
                disappearMessagebox();
            }
            $("#messagebox").css({ 'top': String(top1) + 'px' });
            $("#messagebox").css({ 'opacity': String(opacity) });
        }
        //隐藏信息框
        function disappearMessagebox() {
            opacity -= 0.05;
            if (opacity > 0.05) {
                messageboxT = setTimeout("disappearMessagebox()", 50);
            }
            else {
                opacity = 0;
                $("#messagebox").css({ 'display': 'none' });
            }
            $("#messagebox").css({ 'opacity': String(opacity) });
        }
    </script>
</body>
</html>
