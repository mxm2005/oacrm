<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>left</title>
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <script src="/Scripts/prototype.lite.js" type="text/javascript"></script>
    <script src="/Scripts/moo.fx.js" type="text/javascript"></script>
    <script src="/Scripts/moo.fx.pack.js" type="text/javascript"></script>
    <style type="text/css">
        body
        {
            font: 12px Arial, Helvetica, sans-serif;
            color: #000;
            background-color: #EEF2FB;
            margin: 0px;
        }
        #container
        {
            width: 182px;
        }
        H1
        {
            font-size: 12px;
            margin: 0px;
            width: 182px;
            cursor: pointer;
            height: 30px;
            line-height: 20px;
        }
        H1 a
        {
            display: block;
            width: 182px;
            color: #000;
            height: 30px;
            text-decoration: none;
            moz-outline-style: none;
            background-image: url(/Content/images/menu_bgS.gif);
            background-repeat: no-repeat;
            line-height: 30px;
            text-align: center;
            margin: 0px;
            padding: 0px;
        }
        .content
        {
            width: 182px;
            height: 26px;
        }
        .MM ul
        {
            list-style-type: none;
            margin: 0px;
            padding: 0px;
            display: block;
        }
        .MM li
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 12px;
            line-height: 26px;
            color: #333333;
            list-style-type: none;
            display: block;
            text-decoration: none;
            height: 26px;
            width: 182px;
            padding-left: 0px;
        }
        .MM
        {
            width: 182px;
            margin: 0px;
            padding: 0px;
            left: 0px;
            top: 0px;
            right: 0px;
            bottom: 0px;
            clip: rect(0px,0px,0px,0px);
        }
        .MM a:link
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 12px;
            line-height: 26px;
            color: #333333;
            background-image: url(/Content/images/menu_bg1.gif);
            background-repeat: no-repeat;
            height: 26px;
            width: 182px;
            display: block;
            text-align: center;
            margin: 0px;
            padding: 0px;
            overflow: hidden;
            text-decoration: none;
        }
        .MM a:visited
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 12px;
            line-height: 26px;
            color: #333333;
            background-image: url(/Content/images/menu_bg1.gif);
            background-repeat: no-repeat;
            display: block;
            text-align: center;
            margin: 0px;
            padding: 0px;
            height: 26px;
            width: 182px;
            text-decoration: none;
        }
        .MM a:active
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 12px;
            line-height: 26px;
            color: #333333;
            background-image: url(/Content/images/menu_bg1.gif);
            background-repeat: no-repeat;
            height: 26px;
            width: 182px;
            display: block;
            text-align: center;
            margin: 0px;
            padding: 0px;
            overflow: hidden;
            text-decoration: none;
        }
        .MM a:hover
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 12px;
            line-height: 26px;
            font-weight: bold;
            color: #006600;
            background-image: url(/Content/images/menu_bg2.gif);
            background-repeat: no-repeat;
            text-align: center;
            display: block;
            margin: 0px;
            padding: 0px;
            height: 26px;
            width: 182px;
            text-decoration: none;
        }
    </style>
</head>
<body>
    <div style="width: 182px; vertical-align: top; min-height: 280px; background: #EEF2FB;">
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
    </div>
</body>
</html>
<script type="text/javascript">
    var contents = document.getElementsByClassName('content');
    var toggles = document.getElementsByClassName('type');

    var myAccordion = new fx.Accordion(
			toggles, contents, { opacity: true, duration: 400 }
		);
    myAccordion.showThisHideOpen(contents[0]);
</script>
