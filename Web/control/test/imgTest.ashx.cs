﻿using System;
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
       /* public class Account
        {
            public string error { get; set; }
            public string msg { get; set; }
            public string url { get; set; }
        }*/

        public void ProcessRequest(HttpContext context)
        {
                context.Response.ContentType = "text/plain";
                context.Response.ContentEncoding = Encoding.UTF8;
                string name = context.Request.Form["img_name"];
                HttpPostedFile img = context.Request.Files["upload_file"];
                string path = "~/upload/" + name.Substring(name.LastIndexOf("//") + 1);
                img.SaveAs(context.Server.MapPath(path));
                string url = "http://localhost:3448/upload/" + name;
                context.Response.Write(url);
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