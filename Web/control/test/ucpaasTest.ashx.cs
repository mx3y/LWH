using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace LW_AskOnline.Web.control.test
{
    /// <summary>
    /// ucpaasTest 的摘要说明
    /// </summary>
    public class ucpaasTest : IHttpHandler
    {
        public class Acount
        {
            public int ucid { get; set; }
            public int oid { get; set; }
            public string ucevent { get; set; }
        }
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string callback = context.Request.QueryString["callback"].ToString();
            string id = context.Request.QueryString["id"].ToString();
            BLL.ask_ucpaas adlBll = new BLL.ask_ucpaas();
            Model.ask_ucpaas adlModel = new Model.ask_ucpaas();
            adlModel = adlBll.GetModel(int.Parse(id));
            Acount ac = new Acount
            {
                ucid = adlModel.ucid,
                oid = adlModel.oid,
                ucevent = adlModel.ucevent
            };
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(ac, Newtonsoft.Json.Formatting.Indented);
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