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
            string[] line = new string[6];
            string json1 = "";
            for (int i = 0; i < lines.Length-1; i++)
            {
                line = Regex.Split(lines[i].Trim(), " ", RegexOptions.IgnoreCase);
                json1 += string.Format("{{\"handle\": \"{0}\",\"ip\": \"{1}\",\"user\": \"{2}\",\"master\": \"{3}\",\"date\": \"{4}\",\"time\": \"{5}\"}},", line[0], line[1], line[2], line[3], line[4], line[5]);
            }
            int count = lines.Length;
            json1 = json1.Substring(0, json1.Length - 1);
            json1 = string.Format("[{0}]", json1);
            string zz = string.Format("{{\"draw\": \"{0}\", \"recordsTotal\": \"{1}\",\"recordsFiltered\": \"{2}\",\"data\":{3}}}", 1, count, count, json1);
            context.Response.Write(callback+"("+zz+")");
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