using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;

namespace WX
{
    /// <summary>
    /// queryOrderList 的摘要说明
    /// </summary>
    public class queryOrderList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string callback = context.Request.QueryString["callback"].ToString();
            string uid = context.Request.QueryString["uid"].ToString();
            string code = "0";
            code = QueryOrderList(uid);

            string mes = callback + "(\"" + code + "\")";
            context.Response.Write(mes);
            //<li><div class='myadviceList-box'><em>宝宝肩上有块豆豆大的湿疹</em><span><i><img src='static/images/icon_11.png' alt='' title=''></i></span></div><div class='myadviceList-bottom'><em>价格</em><span class='myadviceList-bottom-span'>超时</span><span class='myadviceList-bottom-last'>2016-04-08 08:00</span></div></li>
        }

        public string QueryOrderList(string uid)
        {
            string result = "0";
            string sql = string.Format("select * from ask_order where ouid={0}",uid);
            DataSet ds = SqlHelper.Query(sql);
            if (ds.Tables[0].Rows.Count != 0)
            {
                string list = "";
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    string did = dr["odid"].ToString();
                    string type = dr["otype"].ToString();
                    string monery = dr["ototalmonery"].ToString();
                    string date = dr["ocreatetime"].ToString();
                    string state1 = dr["oresult"].ToString();//预约状态
                    string state2 = dr["ostate"].ToString();
                    string oid = dr["oid"].ToString();
                    if (did == "1")
                        did = "王黎明";
                    else if (did == "2")
                        did = "黄海蓉";
                    else if (did == "3")
                        did = "庞志学";
                    else if (did == "4")
                        did = "曾玉祥";
                    else if (did == "5")
                        did = "敖杰男";
                    else if (did == "6")
                        did = "李军";
                    if (type == "1")
                        type = "电话咨询";
                    else
                        type = "视频咨询";
                    if(state2 == "1")
                        state2 ="已完成";
                    else
                    {
                        if(state1 =="1")
                            state2="已预约";
                        else
                            state2="已取消";
                    }

                    list += string.Format("<li><div class='myadviceList-box'><a href='order.html?oid={4}&did={5}&dtype={6}&dcdate={7}&ddate={8}'><em>{0}</em></a><span><i><img src='static/images/icon_11.png' alt='' title=''></i></span></div><div class='myadviceList-bottom'><em>{1}</em><span class='myadviceList-bottom-span'>{2}</span><span class='myadviceList-bottom-last'>{3}</span></div></li>", did + "医生" + type, "￥" + monery, state2, date, oid, dr["odid"].ToString(), dr["otype"].ToString(), date, dr["ocommittime"].ToString());
                }
                result = list;
            }
            return result;

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