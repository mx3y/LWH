using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// doctorImg 的摘要说明
    /// </summary>
    public class doctorImg : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string name = context.Request.Form["img_name"];
            HttpPostedFile img = context.Request.Files["upload_file"];
            int length = img.ContentLength;
            string type = img.ContentType;
            string fileExt = VirtualPathUtility.GetExtension(img.FileName).ToLower();
            string fileFilt = ".gif|.jpg|.php|.jsp|.jpeg|.png|";
            if (length > 1048576)
            {
                context.Response.Write("文件大于1M，不能上传");
            }
            else if (fileFilt.IndexOf(fileExt) <= -1)
            {
                context.Response.Write("对不起！请上传图片！");
            }
            else
            {
                string path = "~/upload/" + name.Substring(name.LastIndexOf("//") + 1);
                img.SaveAs(context.Server.MapPath(path));
                context.Response.Write(name);
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