using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;

namespace LW_AskOnline.Web.control.test
{
    /// <summary>
    /// ucpassListTest 的摘要说明
    /// </summary>
    public class ucpassListTest : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string callback = context.Request.QueryString["callback"].ToString();
            Model.ask_ucpaas adlModel = new Model.ask_ucpaas();
            BLL.ask_ucpaas adlBll = new BLL.ask_ucpaas();
            DataSet set = adlBll.GetList("");
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(set,Newtonsoft.Json.Formatting.Indented);
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