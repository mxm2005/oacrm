using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OA_CRM
{
    public partial class Error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //在Global.asax中处理程序级别错误，请参见Global.asax的Application_Error方法
            //这里用的是Server.Transfer方法，直接用Server.GetLastError方法即可获取信息。
            //注意：此时浏览器URL并没有跳转，仍然是原来的URL
            //this.Lable1.Text = this.Request.QueryString["Message"];
            if (Server.GetLastError() != null)
            {
                this.Lable1.Text = this.Server.GetLastError().Message;
                Server.ClearError();
            }
        }
    }
}