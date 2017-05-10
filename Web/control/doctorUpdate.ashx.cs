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
            if (context.Request.Cookies["mid"] != null)
            {
                Common.Log log = new Common.Log();
                string callback = context.Request.QueryString["callback"].ToString();
                string parameter = context.Request["json"].ToString();
                //读json
                Object ja = JsonConvert.DeserializeObject(parameter);
                JObject o = (JObject)ja;
                BLL.ask_doctor_list adlBll = new BLL.ask_doctor_list();
                Model.ask_doctor_list model = adlBll.GetModel(int.Parse(o["did"].ToString()));
                //将数据放到model
                model.dname = o["dname"].ToString();
                model.dimage = o["dimage"].ToString();
                model.ddept = o["ddept"].ToString();
                model.ddeptid = o["ddeptid"].ToString();
                model.dtype = o["dtype"].ToString();
                model.dhospital = o["dhospital"].ToString();
                model.dcityid = o["dcityid"].ToString();
                model.dcity = o["dcity"].ToString();
                model.dhospitalid = int.Parse(o["dhospitalid"].ToString());
                model.dprofessor = o["dprofessor"].ToString();
                model.dcontent = o["dcontent"].ToString();
                model.dmonery = int.Parse(o["dmonery"].ToString());
                model.dtell = o["dtell"].ToString();
                model.ddiscount = o["ddiscount"].ToString();
                model.dshowregister = o["dshowregister"].ToString();
                model.dsrealregister = o["dsrealregister"].ToString();
                model.dshowtell = o["dshowtell"].ToString();
                model.dsrealtell = o["dsrealtell"].ToString();
                model.dshowvideo = o["dshowvideo"].ToString();
                model.dsrealvideo = o["dsrealvideo"].ToString();
                model.dbankaccount = o["dbankaccount"].ToString();
                model.dbankaname = o["dbankaname"].ToString();
                model.dbanktype = o["dbanktype"].ToString();
                model.dqq = o["dqq"].ToString();
                model.daccount = o["daccount"].ToString();
                model.dpassword = o["dpassword"].ToString();
                //model.dcreadate = model.dcreadate;
                //model.dlastlogin = model.dlastlogin;
                model.dsort = int.Parse(o["dsort"].ToString());
                model.dishot = int.Parse(o["dishot"].ToString());
                model.dstate = int.Parse(o["dstate"].ToString());
                //d_onlinedate = o["d_onlinedate"].ToString(),
                model.d_onlinedate = "123";
                model.d_message = o["d_message"].ToString();
                model.d_count = int.Parse(o["d_count"].ToString());
                model.d_score = o["d_score"].ToString();
                model.d_professionscore = o["d_professionscore"].ToString();
                model.d_professioncount = o["d_professioncount"].ToString();
                model.d_servicesscore = o["d_servicesscore"].ToString();
                model.d_servicescount = o["d_servicescount"].ToString();
                model.d_replyscore = o["d_replyscore"].ToString();
                model.d_replycount = o["d_replycount"].ToString();
                bool check = adlBll.Update(model);
                //写入日志
                if (check)
                {
                    string ip = log.GetIP();
                    DateTime time = log.GetTime();
                    string handle = "UPDATE";
                    string user = "DOCTOR";
                    string master = context.Request.Cookies["mname"].Value.ToString();
                    log.WriteLogFile(handle, ip, user, time, master);
                }
                context.Response.Write(callback + "()");
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