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
            if (context.Request.Cookies["mid"] != null)
            {
                Common.Log log = new Common.Log();
                string callback = context.Request.QueryString["callback"].ToString();
                string parameter = context.Request["json"].ToString();
                //读json
                Object ja = JsonConvert.DeserializeObject(parameter);
                JObject o = (JObject)ja;
                BLL.ask_user adlBll = new BLL.ask_user();
                Model.ask_user model = adlBll.GetModel(int.Parse(o["uuid"].ToString()));
                model.uaccount = o["uaccount"].ToString();
                model.umail = o["umail"].ToString();
                model.ubrithday = DateTime.Parse(o["ubrithday"].ToString());
                model.uname = o["uname"].ToString();
                bool check = adlBll.Update(model);
                //写入日志
                if (check)
                {
                    string ip = log.GetIP();
                    DateTime time = log.GetTime();
                    string handle = "UPDATE";
                    string user = "USER";
                    string master = context.Request.Cookies["mname"].Value.ToString();
                    log.WriteLogFile(handle, ip, user, time, master);
                }
                context.Response.Write(callback + "(" + o + ")");
            }
            else
            {
                context.Response.Write("请先登录");
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