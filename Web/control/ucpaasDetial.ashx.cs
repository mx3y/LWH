using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// ucpaasDetial 的摘要说明
    /// </summary>
    public class ucpaasDetial : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string callback = context.Request.QueryString["callback"].ToString();
            string id = context.Request.QueryString["id"].ToString();
            BLL.ask_ucpaas adlBll = new BLL.ask_ucpaas();
            Model.ask_ucpaas adlModel = new Model.ask_ucpaas();
            adlModel = adlBll.GetModel(int.Parse(id));
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(adlModel,Newtonsoft.Json.Formatting.Indented);
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