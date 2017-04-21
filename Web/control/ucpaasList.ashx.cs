using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// ucpaasList 的摘要说明
    /// </summary>
    public class ucpaasList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string callback = context.Request.QueryString["callback"].ToString();
            BLL.ask_ucpaas adlBll = new BLL.ask_ucpaas();
            DataSet set = adlBll.GetAllList();
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(set, Newtonsoft.Json.Formatting.Indented);
            int count = adlBll.GetRecordCount("");
            string zz = "draw\":1,\"recordsTotal\":" + count + ",\"recordsFiltered\":" + count + ",\"data";
            int index = json.IndexOf("d");
            string json1 = json.Remove(index, 2).Insert(index, zz);
            context.Response.Write(callback + "(" + json1 + ")");
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