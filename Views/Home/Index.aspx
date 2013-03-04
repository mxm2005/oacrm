<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>首 页</title>
    <meta http-equiv="Content-Type" content="text/html;charset=gb2312" />
</head>
<frameset rows="64,*" frameborder="NO" border="0" framespacing="0">
	<frame src="<%=Url.Action("admin_top") %>" noresize="noresize" frameborder="NO" name="topFrame" scrolling="no" marginwidth="0" marginheight="0" target="main" />
  <frameset cols="260,*"  rows="560,*" id="frame">
	<frame src="<%=Url.Action("left") %>" name="leftFrame" noresize="noresize" marginwidth="0" marginheight="0" frameborder="0" scrolling="no" target="main" />
    <frameset rows="40,*" frameborder="NO" border="0" framespacing="0" id="frame-main">
    <frame src="<%=Url.Action("right_tool") %>" name="tool" marginwidth="0" marginheight="0" frameborder="0" scrolling="no" target="_self" />
    <frame src="<%=Url.Action("right") %>" name="main" marginwidth="0" marginheight="0" frameborder="0" scrolling="auto" target="_self" />
    </frameset>
	
  </frameset>
<noframes>
  <body></body>
    </noframes>
</html>
