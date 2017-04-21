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
    /// orderAdd 的摘要说明
    /// </summary>
    public class orderAdd : IHttpHandler
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
            Model.ask_order adlModel = new Model.ask_order()
            {
                ouid = int.Parse(o["ouid"].ToString()),
                odid = int.Parse(o["odid"].ToString()),
                otype = int.Parse(o["otype"].ToString()),
                oresult =int.Parse(o["oresult"].ToString()),
                ostate = int.Parse(o["ostate"].ToString()),
                ocreatetime = DateTime.Parse(o["ocreatetime"].ToString()),
                ocommittime = DateTime.Parse(o["ocommittime"].ToString()),
                opublicmonery = int.Parse(o["opublicmonery"].ToString()),
                oprivatemonery = int.Parse(o["oprivatemonery"].ToString()),
                ototalmonery = int.Parse(o["ototalmonery"].ToString()),
                otransid = int.Parse(o["otransid"].ToString()),
                ocallresult = o["ocallresult"].ToString(),
                ocallid = o["ocallid"].ToString(),
                ocalldate = o["ocalldate"].ToString()
            };
            BLL.ask_order adlBll = new BLL.ask_order();
            int check = adlBll.Add(adlModel);
            //写入日志
            if (check != 0)
            {
                string handle = "ADD";
                string ip = log.GetIP();
                string user = "ORDER";
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