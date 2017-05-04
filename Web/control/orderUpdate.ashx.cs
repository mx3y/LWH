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
    /// orderUpdate 的摘要说明
    /// </summary>
    public class orderUpdate : IHttpHandler
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
            BLL.ask_order adlBll = new BLL.ask_order();
            //将数据放到model
            Model.ask_order adlModel = adlBll.GetModel(int.Parse(o["oid"].ToString()));
            adlModel.ocommittime = DateTime.Parse(o["ocommittime"].ToString());
            bool check = adlBll.Update(adlModel);
            //写入日志
            if (check)
            {
                string ip = log.GetIP();
                DateTime time = log.GetTime();
                string handle = "UPDATE";
                string user = "ORDER";
                string master = context.Request.Cookies["mname"].Value.ToString();
                log.WriteLogFile(handle, ip, user, time, master); 
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