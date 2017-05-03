using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// doctorOrder 的摘要说明
    /// </summary>
    public class doctorOrder : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string callback = context.Request.QueryString["callback"].ToString();
            string did = context.Request.QueryString["id"].ToString();
            BLL.ask_order adlBll = new BLL.ask_order();
            List<Model.ask_order> list = new List<Model.ask_order>();
            list = adlBll.GetModelList("odid = " + int.Parse(did) + "");
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(list, Newtonsoft.Json.Formatting.Indented);
            context.Response.Write(callback + "(" + json + ")");
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