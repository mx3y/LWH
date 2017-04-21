using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace LW_AskOnline.Web.control.test
{
    /// <summary>
    /// imgTest 的摘要说明
    /// </summary>
    public class imgTest : IHttpHandler
    {
        public class Account
        {
            public string error { get; set; }
            public string msg { get; set; }
            public string url { get; set; }
        }

        public void ProcessRequest(HttpContext context)
        {
           /* context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string callback = context.Request.QueryString["callback"].ToString();
            HttpPostedFile img = context.Request.Files["file"];
            string s = img.FileName;
            string path = "~/upload/" + s.Substring(s.LastIndexOf("//") + 1);
            img.SaveAs(context.Server.MapPath(path));
            string data = HttpRuntime.AppDomainAppVirtualPath + path.Substring(1);
            //string json = Newtonsoft.Json.JsonConvert.SerializeObject(formData, Newtonsoft.Json.Formatting.Indented);
            context.Response.Write(s);*/





          
                context.Response.ContentType = "text/plain";
                context.Response.ContentEncoding = Encoding.UTF8;
               // string temp= context.Request.Form["file"];
                HttpPostedFile img = context.Request.Files["file"];
                string filename = context.Request.Form["filename"];
               // string callback = context.Request.QueryString["callback"].ToString();
                string s = img.FileName;
                string path = "~/upload/" + s.Substring(s.LastIndexOf("//") + 1);
                img.SaveAs(context.Server.MapPath(path));
                string data = HttpRuntime.AppDomainAppVirtualPath + path.Substring(1);
                //string json = Newtonsoft.Json.JsonConvert.SerializeObject(formData, Newtonsoft.Json.Formatting.Indented);
                context.Response.Write(s);
           
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