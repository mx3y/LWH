using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LW_AskOnline.Web.control.test
{
    /// <summary>
    /// update 的摘要说明
    /// </summary>
    public class update : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string callback = context.Request.QueryString["callback"].ToString();
            string parameter = context.Request.QueryString["json"].ToString();
            Object ja = JsonConvert.DeserializeObject(parameter);
            JObject o = (JObject)ja;
            BLL.ask_city adlBll = new BLL.ask_city();
            Model.ask_city adlModel = new Model.ask_city();
            adlModel.carea_code = "ss";
            adlModel.cparent_id = "11";
            adlModel.cregion_grade = "11";
            adlModel.cdistrict_code = "ss";
            adlModel.cstatus = 1;
            adlModel.cid = "3";
            adlModel.cregion_name = o["name"].ToString();
            adlBll.Update(adlModel);
            context.Response.Write(callback+"("+o+")");
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