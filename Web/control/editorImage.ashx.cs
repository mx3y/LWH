using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// editorImage 的摘要说明
    /// </summary>
    public class editorImage : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string path = context.Server.MapPath("~/editor_image/");
            //HttpFileCollection files = context.Request.Files;
            HttpPostedFile img = context.Request.Files[0];
            string name1 = img.FileName;
            string name2 = name1.Substring(name1.LastIndexOf("."), name1.Length - name1.LastIndexOf("."));
            string currentFileName = (new Random()).Next() + name2;
            string imgpath = path + currentFileName;
            img.SaveAs(imgpath);
            string url = "http://192.168.1.172/editor_image/" + currentFileName;
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