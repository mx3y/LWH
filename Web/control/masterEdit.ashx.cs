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
    /// masterEdit1 的摘要说明
    /// </summary>
    public class masterEdit1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string callback = context.Request.QueryString["callback"].ToString();
            string parameter = context.Request.QueryString["json"].ToString();
            //读json
            Object ja = JsonConvert.DeserializeObject(parameter);
            JObject o = (JObject)ja;
            BLL.ask_master adlBll = new BLL.ask_master();
            Common.GetCookie cookie = new Common.GetCookie();
            string mid = cookie.getCookie("mid");
            Model.ask_master adlModel = new Model.ask_master()
            {
                mid = int.Parse(mid),
                memail = o["memail"].ToString(),
                mtell = o["mtell"].ToString(),
                mname = o["mname"].ToString(),
                msex = o["msex"].ToString(),
                maddress = o["maddress"].ToString(),
                mremark = o["mremark"].ToString()
            };
            adlBll.Update(adlModel);
            context.Response.Write(callback+"()");
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