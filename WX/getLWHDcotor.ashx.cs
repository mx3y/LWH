using System;
using System.Collections.Generic;
using System.Web;
using System.Text;

namespace WX
{
    /// <summary>
    /// getLWHDcotor 的摘要说明
    /// </summary>
    public class getLWHDcotor : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
           // string callback = context.Request.QueryString["callback"].ToString();

            string returnJson = "";
            if (context.Request.QueryString["dept"] != null)
            {
                returnJson = context.Request.QueryString["dept"].ToString() + "haha";
            }
            else
            {
                returnJson = "haha";
            }
            context.Response.Write(returnJson);
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