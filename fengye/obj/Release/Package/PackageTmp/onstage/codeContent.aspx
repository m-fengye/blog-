<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="codeContent.aspx.cs" Inherits="fengye.codeContent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="../backstage/ueditorUTF8/third-party/SyntaxHighlighter/shCore.js"></script>
    <link href="../backstage/ueditorUTF8/third-party/SyntaxHighlighter/shCoreDefault.css" rel="stylesheet" />
    <script type="text/javascript">
        SyntaxHighlighter.all();
    </script>
</head>
<body style="background-color:#eeeeee">
    <form id="form1" runat="server">
    <div style="width:800px;margin:0 auto">
        <asp:PlaceHolder ID="PlaceHolder1" runat="server">

        </asp:PlaceHolder>
    </div>
    </form>
</body>
</html>
