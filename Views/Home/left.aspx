<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>left</title>
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <link type="text/css" rel="stylesheet" href="/Content/main.css" />
    <link type="text/css" rel="stylesheet" href="/Content/ztree/zTreeStyle.css" />
</head>
<body>
    <div class="menu-left">
        <div>
            <div class="menu-bar">
                <ul class="menu-ul">
                    <li><a href="javascript:;">�ɹ�����</a></li>
                    <li><a href="javascript:;">���۹���</a></li>
                    <li><a href="javascript:;">�������</a></li>
                    <li><a href="javascript:;">ѧϰ԰��</a></li>
                </ul>
            </div>
            <div class="menu-tree">
                <ul id='tree' class='tree'>
                </ul>
            </div>
            <div class="clear">
            </div>
        </div>
        <div class="menu-foot">
            <a href="javascript:;" target="main">�˵��˵��˵�</a>
            <a href="javascript:;" target="main">�˵��˵��˵�</a>
        </div>
    </div>    
</body>
</html>
<script type="text/javascript" src="/Scripts/jquery-1.4.4.min.js"></script>
<script type="text/javascript" src="/Scripts/json2-min.js"></script>
<script type="text/javascript" src="/Content/ztree/ztree2.6.js"></script>
<script type="text/javascript">
    var zTree1;
    var setting;
    setting = {
        checkable: false,
        callback : {
        click: zTreeOnClick
        }
    };
    function zTreeOnClick(event, treeId, treeNode) {
        if($("#"+treeNode.tId+"_a").attr("href")=="javascript:void(0)"){
            $("#"+treeNode.tId+"_switch").click();
        }
    }
    var zNodes=<%= ViewBag.users %>;
    function loadData() {
        zTree1 = $("#tree").zTree(setting, zNodes);
    }

    $(function () {
        loadData();
    });
</script>
