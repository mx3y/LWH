using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// CREATE 2017-4-21
    /// AUTHOR:SU
    /// </summary>
    public class orderPayList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            if (context.Request.Cookies["mid"] != null)
            {
                string callback = context.Request.QueryString["callback"].ToString();
                BLL.ask_order_pay adlBll = new BLL.ask_order_pay();
                DataSet set = adlBll.GetAllList();
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(set, Newtonsoft.Json.Formatting.Indented);
                int count = adlBll.GetRecordCount("");
                string zz = "draw\":1,\"recordsTotal\":" + count + ",\"recordsFiltered\":" + count + ",\"data";
                int index = json.IndexOf("d");
                string json1 = json.Remove(index, 2).Insert(index, zz);
                context.Response.Write(callback + "(" + json1 + ")");
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