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
            string callback = context.Request.QueryString["callback"].ToString();
            BLL.ask_order_reply adlBll = new BLL.ask_order_reply();
            List<Model.ask_order_reply> list = adlBll.GetModelList("");
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(list, Newtonsoft.Json.Formatting.Indented);
            context.Response.Write(callback+"("+json+")");
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