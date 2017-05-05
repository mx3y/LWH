using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// orderList 的摘要说明
    /// </summary>
    public class orderList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            if (context.Request.Cookies["mid"] != null)
            {
                string callback = context.Request.QueryString["callback"].ToString();
                BLL.ask_order adlBLL = new BLL.ask_order();
                Model.ask_order adlModel = new Model.ask_order();
                DataSet set = adlBLL.GetList("");
                int count = set.Tables[0].Rows.Count;
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(set, Newtonsoft.Json.Formatting.Indented);
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