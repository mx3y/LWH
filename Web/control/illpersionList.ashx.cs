using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// illpersionList 的摘要说明
    /// </summary>
    public class illpersionList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            if (context.Request.Cookies["mid"] != null)
            {
                string callback = context.Request.QueryString["callback"].ToString();
                BLL.ask_illpersion adlBll = new BLL.ask_illpersion();
                List<Model.ask_illpersion> list = adlBll.GetModelList("");
                int count = list.Count;
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(list, Newtonsoft.Json.Formatting.Indented);
                string zz = string.Format("{{\"draw\": \"{0}\", \"recordsTotal\": \"{1}\",\"recordsFiltered\": \"{2}\",\"data\":{3}}}", 1, count, count, json);
                context.Response.Write(callback + "(" + zz + ")");
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