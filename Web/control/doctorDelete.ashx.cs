using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// doctorDelete 的摘要说明
    /// </summary>
    public class doctorDelete : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            Common.Log log = new Common.Log();
            string callback = context.Request.QueryString["callback"].ToString();
            string parameter = context.Request.QueryString["id"].ToString();
            int id = Convert.ToInt32(parameter);
            BLL.ask_doctor_list adlBll = new BLL.ask_doctor_list();
            Model.ask_doctor_list adlModel = new Model.ask_doctor_list();
            adlModel = adlBll.GetModel(id);
            adlModel.dstate = 0;
            bool check = adlBll.Update(adlModel);
            //写入日志
            if (check)
            {
                string handle = "DELETE";
                string ip = log.GetIP();
                string user = "DOCTOR";
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