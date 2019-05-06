<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="fengye.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/login.css" rel="stylesheet" />
</head>
<body onload="timedCount();">
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
    <form id="form1" runat="server">
    <div>
        <p>asdasfas</p>
    </div>
    </form>
    <!--Load Jquery-->
    <script src="js/jquery-1.11.3.min.js"></script>
    <script>
        var t;
        var n = 0;
        var divcount = $('#bg').children('div').length;
        function timedCount() {
            t = setTimeout("timedCount()", 10000);
            n = (n % divcount) + 1;
            changeBackground(n);
        }
        function changeBackground(n) {
            
            $("#bg" + String(n)).fadeToggle(3000);
            $("#bg" + String(n)).css("z-index", "-1");
            n = (n % divcount) + 1;
            $("#bg" + String(n)).css("z-index", "-2");
            $("#bg" + String(n)).css("display", "block");
            n = (n % divcount) + 1;
            $("#bg" + String(n)).css("z-index", "-3");
            
        }
    </script>
</body>
</html>
