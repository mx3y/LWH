using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// doctorAdd 的摘要说明
    /// </summary>
    public class doctorAdd : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            Common.Log log = new Common.Log();
            string callback = context.Request.QueryString["callback"].ToString();
            string addParameter = context.Request.QueryString["json"].ToString();
            //读json
            Object ja = JsonConvert.DeserializeObject(addParameter);
            JObject o = (JObject)ja;
            //将数据放到model
            Model.ask_doctor_list adlModel = new Model.ask_doctor_list()
            {
                dname = o["dname"].ToString(),
                dimage = "isnull",
                ddept = o["ddept"].ToString(),
                ddeptid = o["ddeptid"].ToString(),
                dtype = o["dtype"].ToString(),
                dhospital = "isnull",
                dcityid = o["dcityid"].ToString(),
                dcity = o["dcity"].ToString(),
                dhospitalid = 0,
                dprofessor = o["dprofessor"].ToString(),
                dcontent = o["dcontent"].ToString(),
                dmonery = int.Parse(o["dmonery"].ToString()),
                dtell = o["dtell"].ToString(),
                ddiscount = o["ddiscount"].ToString(),
                dshowregister = o["dshowregister"].ToString(),
                dsrealregister = o["dsrealregister"].ToString(),
                dshowtell = o["dshowtell"].ToString(),
                dsrealtell = o["dsrealtell"].ToString(),
                dshowvideo = o["dshowvideo"].ToString(),
                dsrealvideo = o["dsrealvideo"].ToString(),
                dbankaccount = o["dbankaccount"].ToString(),
                dbankaname = o["dbankaname"].ToString(),
                dbanktype = o["dbanktype"].ToString(),
                dqq = o["dqq"].ToString(),
                daccount = o["daccount"].ToString(),
                dpassword = o["dpassword"].ToString(),
                dcreadate = DateTime.Parse("1988-8-8"),
                dlastlogin = DateTime.Parse("2018-1-8"),
                dsort = 0,
                dishot = 0,
                dstate = 1
            };
            BLL.ask_doctor_list adlBll = new BLL.ask_doctor_list();
            int check = adlBll.Add(adlModel);
            //写入日志
            if (check != 0)
            {
                string handle = "ADD";
                string ip = log.GetIP();
                string user = "DOCTOR";
                DateTime time = log.GetTime();
                log.WriteLogFile(handle, ip, user, time); 
            }
            context.Response.Write(callback + "(" + o + ")");
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