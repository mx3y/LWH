﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// doctorSendUpdate 的摘要说明
    /// </summary>
    public class doctorSendUpdate : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string callback = context.Request.QueryString["callback"].ToString();
            string parameter = context.Request.QueryString["id"].ToString();
            int id = Convert.ToInt32(parameter);
            BLL.ask_doctor_list adlBll = new BLL.ask_doctor_list();
            Model.ask_doctor_list adlModel = new Model.ask_doctor_list();
            adlModel = adlBll.GetModel(id);
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(adlModel, Newtonsoft.Json.Formatting.Indented);
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