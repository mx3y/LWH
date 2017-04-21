using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// userDelete 的摘要说明
    /// </summary>
    public class userDelete : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            Common.Log log = new Common.Log();
            string callback = context.Request.QueryString["callback"].ToString();
            string parameter = context.Request.QueryString["id"].ToString();
            int id = Convert.ToInt32(parameter);
            BLL.ask_user adlBll = new BLL.ask_user();
            Model.ask_user adlModel = new Model.ask_user();
            adlModel = adlBll.GetModel(id);
            adlModel.ustate = 0;
            bool check = adlBll.Update(adlModel);
            //写入日志
            if (check)
            {
                string handle = "DELETE";
                string ip = log.GetIP();
                string user = "USER";
                DateTime time = log.GetTime();
                log.WriteLogFile(handle, ip, user, time);
            }
            context.Response.Write(callback + "()");
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