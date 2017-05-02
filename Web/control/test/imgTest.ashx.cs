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
       /* public class Account
        {
            public string error { get; set; }
            public string msg { get; set; }
            public string url { get; set; }
        }*/

        public void ProcessRequest(HttpContext context)
        {
            HttpPostedFile _upfile = context.Request.Files["file"];
            if (_upfile == null)
            {
                ResponseWriteEnd(context, "4");//请选择要上传的文件   
            }
            else
            {
                string fileName = _upfile.FileName;/*获取文件名： C:\Documents and Settings\Administrator\桌面\123.jpg*/
                string suffix = fileName.Substring(fileName.LastIndexOf(".") + 1).ToLower();/*获取后缀名并转为小写： jpg*/
                int bytes = _upfile.ContentLength;//获取文件的字节大小   

                if (suffix != "jpg")
                    ResponseWriteEnd(context, "2"); //只能上传JPG格式图片   
                if (bytes > 1024 * 1024)
                    ResponseWriteEnd(context, "3"); //图片不能大于1M   

                _upfile.SaveAs(HttpContext.Current.Server.MapPath("~/images/logo.jpg"));//保存图片   
                ResponseWriteEnd(context, "1"); //上传成功   
            }
        }

        private void ResponseWriteEnd(HttpContext context, string msg)
        {
            context.Response.Write(msg);
            context.Response.End();  





          
               /* context.Response.ContentType = "text/plain";
                context.Response.ContentEncoding = Encoding.UTF8;
                HttpPostedFile file = context.Request.Files[0];
                String fileName = System.IO.Path.GetFileName(file.FileName);
                file.SaveAs(context.Server.MapPath("~/") + fileName);*/
                //HttpPostedFile img = context.Request.Files["file"];
               // string filename = context.Request.Form["filename"];
               // string callback = context.Request.QueryString["callback"].ToString();
               /* string s = img.FileName;
                string path = "~/upload/" + s.Substring(s.LastIndexOf("//") + 1);
                img.SaveAs(context.Server.MapPath(path));
                string data = HttpRuntime.AppDomainAppVirtualPath + path.Substring(1);*/
                //string json = Newtonsoft.Json.JsonConvert.SerializeObject(formData, Newtonsoft.Json.Formatting.Indented);
               // context.Response.Write("OK");
           
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