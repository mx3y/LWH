﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// CREATE 2017-4-21
    /// AUTHOR:SU
    /// </summary>
    public class hospitalAdd : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            if (context.Request.Cookies["mid"] != null)
            {
                Common.Log log = new Common.Log();
                string callback = context.Request.QueryString["callback"].ToString();
                string addParameter = context.Request["json"].ToString();
                //读json
                Object ja = JsonConvert.DeserializeObject(addParameter);
                JObject o = (JObject)ja;
                //将数据放到model
                Model.ask_hospital adlModel = new Model.ask_hospital()
                {
                    hcityid = int.Parse(o["hcityid"].ToString()),
                    hcity = o["hcity"].ToString(),
                    hname = o["hname"].ToString(),
                    himage = "isnull",
                    hlevel = o["hlevel"].ToString(),
                    haddress = o["haddress"].ToString(),
                    hcontent = o["hcontent"].ToString(),
                    hstatus = 1
                };
                BLL.ask_hospital adlBll = new BLL.ask_hospital();
                int check = adlBll.Add(adlModel);
                //写入日志
                if (check != 0)
                {
                    string ip = log.GetIP();
                    DateTime time = log.GetTime();
                    string handle = "ADD";
                    string user = "HOSPITAL";
                    string master = context.Request.Cookies["mname"].Value.ToString();
                    log.WriteLogFile(handle, ip, user, time, master);
                }
                context.Response.Write(callback + "(" + o + ")");
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