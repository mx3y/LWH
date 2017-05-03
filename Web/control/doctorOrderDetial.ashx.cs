using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// doctorOrderDetial 的摘要说明
    /// </summary>
    public class doctorOrderDetial : IHttpHandler
    {
        public class Detial
        {
            public string dhospital { get; set; }
            public string ddept { get; set; }
            public string dname { get; set; }
            public DateTime ocommittime { get; set; }
            public Decimal ototalmonery { get; set; }
            public string iname { get; set; }
            public string icard { get; set; }
            public string iphone { get; set; }
            public int oid { get; set; }
            public DateTime ocreatetime { get; set; }
            public int otype { get; set; }
        }
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string callback = context.Request.QueryString["callback"].ToString();
            string parameter = context.Request.QueryString["id"].ToString();
            BLL.ask_doctor_list dBll = new BLL.ask_doctor_list();
            BLL.ask_order oBll = new BLL.ask_order();
            BLL.ask_illpersion iBll = new BLL.ask_illpersion();
            Model.ask_order oModel = oBll.GetModel(int.Parse(parameter));//订单
            
            Model.ask_illpersion iModel = iBll.GetModel(1);//就诊
            Model.ask_doctor_list dModel = dBll.GetModel(1);//医生
            Detial detial = new Detial()
            {
                dhospital = dModel.dhospital,
                ddept = dModel.ddept,
                dname = dModel.dname,
                ocommittime = oModel.ocommittime,
                ototalmonery = oModel.ototalmonery,
                iname = iModel.iname,
                icard = iModel.icard,
                iphone = iModel.iphone,
                oid = oModel.oid,
                ocreatetime = oModel.ocreatetime,
                otype = oModel.otype
            };


            string json = Newtonsoft.Json.JsonConvert.SerializeObject(detial, Newtonsoft.Json.Formatting.Indented);
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