﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// login 的摘要说明
    /// </summary>
    public class login : IHttpHandler
    {
        public class Acount
        { 
            public string status {get;set;}
            public string mname {get;set;}
            public string mid {get;set;}
        }
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string parameter = context.Request["json"].ToString();
            string callback = context.Request.QueryString["callback"].ToString();
            //读json
            Object ja = JsonConvert.DeserializeObject(parameter);
            JObject o = (JObject)ja;
            string mname = o["account"].ToString();
            string pwd = o["password"].ToString();
            BLL.ask_master adlBll = new BLL.ask_master();
            Common.Log log = new Common.Log();
            DateTime time = log.GetTime();
            string ip = log.GetIP();
            Acount acount = new Acount();
            DataSet set = adlBll.GetAllList();
            bool check = false;
            int index = 0;
            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            { 
                if(set.Tables[0].Rows[i]["mnumber"].ToString().Equals(mname)&&set.Tables[0].Rows[i]["mpassword"].ToString().Equals(pwd))
                {
                    index = i;
                    check = true;
                    break;
                }
            }
            if(check)
            {
                int id = int.Parse(set.Tables[0].Rows[index]["mid"].ToString());
                Model.ask_master adlModel = adlBll.GetModel(id);
                adlModel.mlastlogintime = time;
                adlModel.mlastip = ip;
                adlModel.mstate = 1;
                if(adlModel.mlogincount==null)
                {
                    adlModel.mlogincount = 0;
                }
                adlModel.mlogincount =adlModel.mlogincount+1;
                adlBll.Update(adlModel);
                acount.status = "1";
                acount.mid = id.ToString();
                acount.mname = adlModel.mname;
                context.Response.Cookies["mid"].Value = acount.mid;
                context.Response.Cookies["mid"].Expires = DateTime.Now.AddDays(7);
                context.Response.Cookies["mid"].Path = "/";
                context.Response.Cookies["mname"].Value = acount.mname;
                context.Response.Cookies["mname"].Expires = DateTime.Now.AddDays(7);
                context.Response.Cookies["mname"].Path = "/";
            }
            else
            {
                acount.status = "0";
                acount.mid = null;
                acount.mname = null;
            }
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(acount, Newtonsoft.Json.Formatting.Indented);
            context.Response.Write(callback+"("+json+")");
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