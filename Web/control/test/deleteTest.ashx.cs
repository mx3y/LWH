using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace LW_AskOnline.Web.control.test
{
    /// <summary>
    /// deleteTest 的摘要说明
    /// </summary>
    public class deleteTest : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string callback = context.Request.QueryString["callback"].ToString();
            string parameter = context.Request.QueryString["id"].ToString();
            //int id = Convert.ToInt32(parameter);
            BLL.ask_city adlBll = new BLL.ask_city();
            adlBll.Delete(parameter);

            context.Response.Write(callback+"()");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}