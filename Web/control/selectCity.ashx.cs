using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// selectCity 的摘要说明
    /// </summary>
    public class selectCity : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string callback = context.Request.QueryString["callback"].ToString();
            string getCid;
            BLL.ask_city adlBll = new BLL.ask_city();
            if (context.Request["cid"].ToString() != "")
            {
                getCid = context.Request["cid"].ToString();
                List<Model.ask_city> list = adlBll.GetModelList("cparent_id = '" + getCid + "'");
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(list, Newtonsoft.Json.Formatting.Indented);
                context.Response.Write(callback + "(" + json + ")");
            }
            else
            {
                List<Model.ask_city> list = adlBll.GetModelList("cparent_id='0'");
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(list, Newtonsoft.Json.Formatting.Indented);
                context.Response.Write(callback + "(" + json + ")");
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