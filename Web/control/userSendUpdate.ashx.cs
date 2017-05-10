using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// userSendUpdate 的摘要说明
    /// </summary>
    public class userSendUpdate : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            if (context.Request.Cookies["mid"] != null)
            {
                string callback = context.Request.QueryString["callback"].ToString();
                string parameter = context.Request["id"].ToString();
                int id = Convert.ToInt32(parameter);
                BLL.ask_user adlBll = new BLL.ask_user();
                BLL.t_company tcom = new BLL.t_company();
                Model.ask_user adlModel = new Model.ask_user();
                adlModel = adlBll.GetModel(id);
                int comid = adlModel.ucompanyid;
                string comname = tcom.GetModel(comid).company_name;
                //string json = Newtonsoft.Json.JsonConvert.SerializeObject(adlModel, Newtonsoft.Json.Formatting.Indented);
                string lastJson = string.Format("{{\"name\": \"{0}\",\"utijtid\": \"{1}\",\"ucompanymonery\": \"{2}\",\"umonery\": \"{3}\",\"uaccount\": \"{4}\",\"upassword\": \"{5}\",\"ucardnumber\": \"{6}\",\"uopenid\": \"{7}\",\"umail\": \"{8}\",\"ubrithday\": \"{9}\",\"usex\": \"{10}\",\"ucompanyid\": \"{11}\",\"uregisterdatetime\": \"{12}\",\"uregisterip\": \"{13}\",\"ulastdatetime\": \"{14}\",\"ulastip\": \"{15}\",\"ustate\": \"{16}\",\"uname\": \"{17}\"}}",
                                                    comname, adlModel.utijtid, adlModel.ucompanymonery, adlModel.umonery, adlModel.uaccount, adlModel.upassword, adlModel.ucardnumber, adlModel.uopenid, adlModel.umail, adlModel.ubrithday, adlModel.usex, adlModel.ucompanyid, adlModel.uregisterdatetime, adlModel.uregisterip, adlModel.ulastdatetime, adlModel.ulastip, adlModel.ustate, adlModel.uname);
                context.Response.Write(callback + "(" + lastJson + ")");
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