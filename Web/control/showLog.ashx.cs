using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Text.RegularExpressions;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// showLog 的摘要说明
    /// </summary>
    public class showLog : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string callback = context.Request.QueryString["callback"].ToString();
            Common.Log log1 = new Common.Log();
            string[] lines = log1.ReadLogFile();
            string json1 = "";
            /*foreach (string line in lines)
            {
                json1 += string.Format("{{\"handle\": \"{0}\",\"ip\": \"{1},\"user\": \"{2}\",\"datetime\": \"{3}\"}},", lines[0], lines[1], lines[2], lines[3]);
            }
            json1 = json1.Substring(0, json1.Length - 1);
            json1 = string.Format("[{0}]", json1);*/
            List<Object> list = new List<Object>();
            for (int i = 0; i < lines.Length; i++)
            {
                string[] line = Regex.Split(lines[i], " ", RegexOptions.IgnoreCase);
                list.Add(line);
            }
            foreach (string line in list)
            {
                json1 += string.Format("{{\"handle\": \"{0}\",\"ip\": \"{1},\"user\": \"{2}\",\"datetime\": \"{3}\"}},", lines[0], lines[1], lines[2], lines[3]);
            }
            context.Response.Write(callback+"("+json1+")");
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