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
    /// doctorLogin 的摘要说明
    /// </summary>
    public class doctorLogin : IHttpHandler
    {
        public class Acount
        {
            public int status { get; set; }
            public string dname { get; set; }
            public int did { get; set; }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string parameter = context.Request.QueryString["json"].ToString();
            string callback = context.Request.QueryString["callback"].ToString();
            //读json
            Object ja = JsonConvert.DeserializeObject(parameter);
            JObject o = (JObject)ja;
            string dname = o["account"].ToString();
            string pwd = o["password"].ToString();
            Acount acount = new Acount();
            BLL.ask_doctor_list adlBll = new BLL.ask_doctor_list();
            List<Model.ask_doctor_list> dlist = adlBll.GetModelList("");
            Common.Log log = new Common.Log();
            int check = 0;
            int index = 0;
            for (int i = 0; i < dlist.Count; i++)
            {
                if (dlist[i].daccount.Equals(dname)&&dlist[i].dpassword.Equals(pwd))
                {
                    index = i;
                    check = 1;
                    Model.ask_doctor_list adlModel = dlist[i];
                    adlModel.dlastlogin = log.GetTime();
                    adlBll.Update(adlModel);
                    break;
                }
            }
            if (check==0)
            {
                acount.dname = null;
                acount.did = 0;
                acount.status = 0;
            }
            else
            {
                acount.dname = dlist[index].dname;
                acount.did = dlist[index].did;
                acount.status = 1; 
                
            }
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(acount, Newtonsoft.Json.Formatting.Indented);
            context.Response.Write(callback + "(" + json + ")");
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