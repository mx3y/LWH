using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Text;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// queryTest 的摘要说明
    /// </summary>
    public class queryTest : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string callback = context.Request.QueryString["callback"].ToString();
            BLL.ask_city adlBLL = new BLL.ask_city();
            Model.ask_city adlModel = new Model.ask_city();
            DataSet set = adlBLL.GetList("");
            int count = adlBLL.GetRecordCount("");
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(set, Newtonsoft.Json.Formatting.Indented);
            //将查出记录数与json拼接到前台进行分页
            string zz = "draw\":1,\"recordsTotal\":" + count + ",\"recordsFiltered\":" + count + ",\"data";
            string json1 = json.Replace("ds", zz);
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