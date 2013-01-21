<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>left</title>
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <link href="/Content/main.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div class="menu-left">
        <div>
            <div class="menu-bar">
                <ul class="ul-tab">
                    <li><a href="javascript:;">�ɹ�����</a></li>
                    <li><a href="javascript:;">���۹���</a></li>
                    <li><a href="javascript:;">�������</a></li>
                    <li><a href="javascript:;">ѧϰ԰��</a></li>
                </ul>
            </div>
            <div class="menu-tree">
                �˴���ʾ class "menu-bar" ������</div>
            <div class="clear">
            </div>
        </div>
        <div class="menu-foot">
            <a href="javascript:;">�˵�</a>
        </div>
    </div>
    <%--<div style="width: 182px; vertical-align: top; min-height: 280px; background: #EEF2FB;">
        <div id="container">
            <h1 class="type">
                <a href="javascript:void(0)">�ͻ���ϵ����</a></h1>
            <div class="content">
                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                        <td style="font-size: 0px;">
                            <img src="/Content/images/menu_topline.gif" width="182" height="5" />
                        </td>
                    </tr>
                </table>
                <ul class="MM">
                    <li><a href="/Cus/CusList" target="main">�б����</a></li>
                    <li><a href="/Cus/Add" target="main">�������</a></li>
                </ul>
            </div>
            <h1 class="type">
                <a href="javascript:void(0)">���ڹ���</a></h1>
            <div class="content">
                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                        <td style="font-size: 0px;">
                            <img src="/Content/images/menu_topline.gif" width="182" height="5" />
                        </td>
                    </tr>
                </table>
                <ul class="MM">
                    <li><a href="/KaoQin/" target="main">��Ϣ�鿴</a></li>
                </ul>
            </div>
            <h1 class="type">
                <a href="javascript:void(0)">վ���Ź���</a></h1>
            <div class="content">
                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                        <td style="font-size: 0px;">
                            <img src="/Content/images/menu_topline.gif" width="182" height="5" />
                        </td>
                    </tr>
                </table>
                <ul class="MM">
                    <li><a href="/Msg/Index" target="main">�ռ���</a></li>
                    <li><a href="/Msg/SendBox" target="main">������</a></li>
                    <li><a href="/Msg/Add" target="main">д��</a></li>
                    <li><a href="/Msg/Detail" target="main">����</a></li>
                    <li><a href="/Msg/System" target="main">ϵͳ֪ͨ</a></li>
                </ul>
            </div>
            <h1 class="type">
                <a href="javascript:void(0)">�û�����</a></h1>
            <div class="content">
                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                        <td style="font-size: 0px;">
                            <img src="/Content/images/menu_topline.gif" width="182" height="5" />
                        </td>
                    </tr>
                </table>
                <ul class="MM">
                    <li><a href="/User/Index" target="main">�û��б�</a></li>
                    <li><a href="/User/Add" target="main">����û�</a></li>
                </ul>
            </div>
            <h1 class="type" style="height: 2px; overflow: hidden;">
                <a href="javascript:void(0)">&nbsp;</a></h1>
        </div>
    </div>--%>
</body>
</html>
<script src="/Scripts/prototype.lite.js" type="text/javascript"></script>
<script src="/Scripts/moo.fx.js" type="text/javascript"></script>
<script src="/Scripts/moo.fx.pack.js" type="text/javascript"></script>
<script type="text/javascript">
    var contents = document.getElementsByClassName('content');
    var toggles = document.getElementsByClassName('type');

    var myAccordion = new fx.Accordion(
			toggles, contents, { opacity: true, duration: 400 }
		);
    myAccordion.showThisHideOpen(contents[0]);
</script>
