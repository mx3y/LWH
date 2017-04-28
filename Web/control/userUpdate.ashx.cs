using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// userUpdate 的摘要说明
    /// </summary>
    public class userUpdate : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            Common.Log log = new Common.Log();
            string callback = context.Request.QueryString["callback"].ToString();
            string parameter = context.Request.QueryString["json"].ToString();
            //读json
            Object ja = JsonConvert.DeserializeObject(parameter);
            JObject o = (JObject)ja;
            BLL.ask_user adlBll = new BLL.ask_user();
            Model.ask_user adlModel = new Model.ask_user()
            {
                uuid = int.Parse(o["uuid"].ToString()),
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
                uregisterdatetime = DateTime.Parse("2000-8-8"),
                uregisterip = "isnull",
                ulastdatetime = DateTime.Parse("2022-5-9"),
                ulastip = "isnull",
                ustate = int.Parse(o["ustate"].ToString()),
                uname = o["uname"].ToString()
            };
            bool check = adlBll.Update(adlModel);
            //写入日志
            if (check)
            {
                string ip = log.GetIP();
                DateTime time = log.GetTime();
                string handle = "UPDATE";
                string user = "USER";
                //string master = context.Request.Cookies["mname"].Value;
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