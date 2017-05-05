using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// orderReplyList 的摘要说明
    /// </summary>
    public class orderReplyList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            if (context.Request.Cookies["mid"] != null)
            {
                string callback = context.Request.QueryString["callback"].ToString();
                BLL.ask_order_reply adlBll = new BLL.ask_order_reply();
                List<Model.ask_order_reply> list = adlBll.GetModelList("");
                int count = list.Count();
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(list, Newtonsoft.Json.Formatting.Indented);
                string zz = string.Format("{{\"draw\": \"{0}\", \"recordsTotal\": \"{1}\",\"recordsFiltered\": \"{2}\",\"data\":{3}}}", 1, count, count, json);
                context.Response.Write(callback + "(" + zz + ")");
            }
            else
            {
                context.Response.Write("请想登录");
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