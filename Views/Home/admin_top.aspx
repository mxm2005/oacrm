<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>admin_top</title>
    <link href="/Content/main.css" rel="stylesheet" type="text/css" />
</head>
<body leftmargin="0" topmargin="0">
    <div class="head-bar" id="header">        
        <div class="head-right">
            <div class="label-login">
                <a href="javascript:;">登录</a> <a href="javascript:;">退出</a></div>
            <div class="tab1">
                <span><a href="javascript:;">便笺</a></span>&nbsp;&nbsp;<span><a href="javascript:;">日历</a></span>
                </div>
        </div>
        <div class="clear">
        </div>
    </div>
</body>
</html>
<script type="text/javascript">
    function logout() {
        if (confirm("您确定要退出控制面板吗？"))
            top.location = "/Home/Login";
        return false;
    }
</script>
<script type="text/javascript">
    function showsubmenu(sid) {
        var whichEl = eval("submenu" + sid);
        var menuTitle = eval("menuTitle" + sid);
        if (whichEl.style.display == "none") {
            eval("submenu" + sid + ".style.display=\"\";");
        } else {
            eval("submenu" + sid + ".style.display=\"none\";");
        }
    }
</script>
