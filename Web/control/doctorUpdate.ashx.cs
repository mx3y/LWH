using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// CREATE 2017-04-21
    /// AUTHOR:SU
    /// UDATE:2017-4-21 15:37 PM AUTHOR：MENG
    /// </summary>
    public class doctorUpdate : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            Common.Log log = new Common.Log();
            string callback = context.Request.QueryString["callback"].ToString();
            string parameter = context.Request.QueryString["json"].ToString();
            //读json
            Object ja = JsonConvert.DeserializeObject(parameter);
            JObject o = (JObject)ja;
            BLL.ask_doctor_list adlBll = new BLL.ask_doctor_list();
            //将数据放到model
            Model.ask_doctor_list adlModel = new Model.ask_doctor_list()
            {
                did = int.Parse(o["did"].ToString()),
                dname = o["dname"].ToString(),
                dimage = "isnull",
                ddept = o["ddept"].ToString(),
                ddeptid = o["ddeptid"].ToString(),
                dtype = o["dtype"].ToString(),
                dhospital = o["dhospital"].ToString(),
                dcityid = o["dcityid"].ToString(),
                dcity = o["dcity"].ToString(),
                dhospitalid = int.Parse(o["dhospitalid"].ToString()),
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
                dsort = int.Parse(o["dsort"].ToString()),
                dishot = int.Parse(o["dishot"].ToString()),
                dstate = int.Parse(o["dstate"].ToString()),
                d_onlinedate = o["d_onlinedate"].ToString(),
                d_message = o["d_message"].ToString(),
                d_count = int.Parse(o["d_count"].ToString()),
                d_score = o["d_score"].ToString(),
                d_professionscore = o["d_professionscore"].ToString(),
                d_professioncount = o["d_professioncount"].ToString(),
                d_servicesscore = o["d_servicesscore"].ToString(),
                d_servicescount = o["d_servicescount"].ToString(),
                d_replyscore = o["d_replyscore"].ToString(),
                d_replycount = o["d_replycount"].ToString()
            };
            bool check = adlBll.Update(adlModel);
            //写入日志
            if (check)
            {
                string handle = "UPDATE";
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