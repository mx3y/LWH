using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Data;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// userAdd 的摘要说明
    /// </summary>
    public class userAdd : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            Common.Log log = new Common.Log();
            string callback = context.Request.QueryString["callback"].ToString();
            string addParameter = context.Request.QueryString["json"].ToString();
            //读json
            Object ja = JsonConvert.DeserializeObject(addParameter);
            JObject o = (JObject)ja;
            //将数据放到model
            Model.ask_user adlModel = new Model.ask_user()
            {
                utijtid = int.Parse(o["utijtid"].ToString()),
                ucompanymonery = int.Parse(o["ucompanymonery"].ToString()),
                umonery = int.Parse(o["umonery"].ToString()),
                uaccount = o["uaccount"].ToString(),
                upassword = o["upassword"].ToString(),
                ucardnumber = o["ucardnumber"].ToString(),
                uopenid = "isnull",
                umail = o["umail"].ToString(),
                ubrithday = DateTime.Parse(o["ubrithday"].ToString()),
                usex = o["usex"].ToString(),
                ucompanyid = int.Parse(o["ucompanyid"].ToString()),
                uregisterdatetime = DateTime.Parse("1999-9-9"),
                uregisterip = "isnull",
                ulastdatetime = DateTime.Parse("1989-8-9"),
                ulastip = "isnull",
                ustate = int.Parse(o["ustate"].ToString()),
                uname = o["uname"].ToString()
            };
            BLL.ask_user adlBll = new BLL.ask_user();
            int check = adlBll.Add(adlModel);
            //写入日志
            if (check != 0)
            { 
                string handle = "ADD";
                string ip = log.GetIP();
                string user = "USER";
                DateTime time = log.GetTime();
                log.WriteLogFile(handle, ip, user, time);
            }
            
            context.Response.Write(callback + "(" + o + ")");
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