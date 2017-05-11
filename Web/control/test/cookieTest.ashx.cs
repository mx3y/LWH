using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
namespace LW_AskOnline.Web.control.test
{
    /// <summary>
    /// cokkieTest 的摘要说明
    /// </summary>
    public class cokkieTest : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string name = "";
            string pwd = "";
            if (name != null && pwd != null)
            {
                if (name.Equals("") && pwd.Equals(""))
                {
                    context.Response.Write("success");
                }
                else
                {
                    context.Response.Write("fail");
                }
            }
            else
            {
                context.Response.Write("cookie not ");
            }
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