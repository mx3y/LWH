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
    /// CREATE 2017-4-21
    /// AUTHOR:SU
    /// </summary>
    public class hospitalUpdate : IHttpHandler
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
            BLL.ask_hospital adlBll = new BLL.ask_hospital();
            //将数据放到model
            Model.ask_hospital adlModel = new Model.ask_hospital()
            {
                hid = int.Parse(o["id"].ToString()),
                hcityid = int.Parse(o["hcityid"].ToString()),
                hcity = o["hcity"].ToString(),
                hname = o["hname"].ToString(),
                himage = "isnull",
                hlevel = o["hlevel"].ToString(),
                haddress = o["haddress"].ToString(),
                hcontent = o["hcontent"].ToString(),
                hstatus = int.Parse(o["hstatus"].ToString())
            };
            bool check = adlBll.Update(adlModel);
            //写入日志
            if (check)
            {
                string ip = log.GetIP();
                DateTime time = log.GetTime();
                string handle = "UPDATE";
                string user = "HOSPITAL";
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