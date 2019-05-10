<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="fengye.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/login.css" rel="stylesheet" />
</head>
<body onload="changeBackground();">
    <%-- 网页背景 --%>
    <div id="bg">
        <div id="bg1" class="bgdiv" style="background-image:url(../img/tm-img-01.jpg);"></div>
        <div id="bg2" class="bgdiv" style="background-image:url(../img/tm-img-02.jpg);"></div>
        <div id="bg3" class="bgdiv" style="background-image:url(../img/tm-img-03.jpg);"></div>
        <div id="bg4" class="bgdiv" style="background-image:url(../img/tm-img-04.jpg);"></div>
        <div id="bg5" class="bgdiv" style="background-image:url(../img/tm-img-05.jpg);"></div>
        <div id="bg6" class="bgdiv" style="background-image:url(../img/tm-img-06.jpg);"></div>
        <div id="bg7" class="bgdiv" style="background-image:url(../img/tm-img-07.jpg);"></div>
        <div id="bg8" class="bgdiv" style="background-image:url(../img/tm-img-08.jpg);"></div>
        <div id="bg9" class="bgdiv" style="background-image:url(../img/tm-img-09.jpg);"></div>
        <div id="bg10" class="bgdiv" style="background-image:url(../img/tm-img-10.jpg);"></div>
        <div id="bg11" class="bgdiv" style="background-image:url(../img/tm-img-11.jpg);"></div>
        <div id="bg12" class="bgdiv" style="background-image:url(../img/tm-img-12.jpg);"></div>
        <div id="bg13" class="bgdiv" style="background-image:url(../img/tm-img-13.jpg);"></div>
        <div id="bg14" class="bgdiv" style="background-image:url(../img/tm-img-14.jpg);"></div>
        <div id="bg15" class="bgdiv" style="background-image:url(../img/tm-img-15.jpg);"></div>
        <div id="bg16" class="bgdiv" style="background-image:url(../img/tm-img-16.jpg);"></div>
    </div>
    <%-- 信息框 --%>
    <div id="messagebox"></div>
    

    <form id="loginbg" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div id="logindiv">
                    账号：<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></br>
                    密码：<asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></br>
                    <asp:CheckBox ID="chkRememberMe" runat="server" Checked="True" />记住我
                    <asp:Button ID="btnLogin" runat="server" Text="登录" OnClick="btnLogin_Click" />
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>


    
    


    <!--Load Jquery-->
    <script src="js/jquery-1.11.3.min.js"></script>
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
            $("#bg" + String(((n+1) % divcount) + 1)).css("z-index", "-3");
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
