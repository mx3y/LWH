using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// selectDept 的摘要说明
    /// </summary>
    public class selectDept : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string callback = context.Request.QueryString["callback"].ToString();
            string getHid;
            BLL.ask_dept adlBll = new BLL.ask_dept();
            if (context.Request.QueryString["hid"].ToString() != "")
            {
                getHid = context.Request.QueryString["hid"].ToString();
                int getDhid = int.Parse(getHid);
                List<Model.ask_dept> list = adlBll.GetModelList("dhid = " + getDhid + "");
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(list, Newtonsoft.Json.Formatting.Indented);
                context.Response.Write(callback + "(" + json + ")");
            }
            else
            {
                List<Model.ask_dept> list = adlBll.GetModelList("dhid=0");
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(list, Newtonsoft.Json.Formatting.Indented);
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