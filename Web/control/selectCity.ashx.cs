using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// selectCity 的摘要说明
    /// </summary>
    public class selectCity : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string callback = context.Request.QueryString["callback"].ToString();
            string getCid;
            BLL.ask_city adlBll = new BLL.ask_city();
            if (context.Request.QueryString["cid"].ToString() != "")
            {
                getCid = context.Request.QueryString["cid"].ToString();
                DataSet set = adlBll.GetList("cparent_id = '" + getCid + "'");
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(set, Newtonsoft.Json.Formatting.Indented);
                string zz = "data";
                int index = json.IndexOf("d");
                string json1 = json.Remove(index, 2).Insert(index, zz);
                context.Response.Write(callback + "(" + json1 + ")");
            }
            else
            { 
                DataSet set = adlBll.GetList("cparent_id='0'");
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(set, Newtonsoft.Json.Formatting.Indented);
                
                context.Response.Write(callback + "(" + json + ")");
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