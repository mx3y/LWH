using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// masterEdit 的摘要说明
    /// </summary>
    public class masterEdit : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string callback = context.Request.QueryString["callback"].ToString();
            Model.ask_master adlModel = new Model.ask_master();
            BLL.ask_master adlBll = new BLL.ask_master();
            if (context.Request.Cookies["mid"] != null)
            {
                string mid = context.Request.Cookies["mid"].Value;
                adlModel = adlBll.GetModel(int.Parse(mid));
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(adlModel, Newtonsoft.Json.Formatting.Indented);
                context.Response.Write(callback + "(" + json + ")");
            }
            else
            {
                context.Response.Write("error");
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