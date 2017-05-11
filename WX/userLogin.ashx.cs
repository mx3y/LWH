using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;
using System.Net;

namespace WX
{
    /// <summary>
    /// userLogin 的摘要说明
    /// </summary>
    public class userLogin : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string callback = context.Request.QueryString["callback"].ToString();
            string userName = context.Request.QueryString["userName"].ToString();
            string userPassword = context.Request.QueryString["userPassword"].ToString();
            string code = "error";
            code = LoginCheck(userName, userPassword) ? "success" : "error";
     
            string mes = callback + "(\"" + code + "\")";
            context.Response.Write(mes);
        }

        private void setCookie(string id,string name,string company,string edu)
        {
           // HttpContext.Current.Response.Cookies["lwhd"].Value = System.Web.HttpUtility.UrlEncode(string.Format("{0}|{1}|{2}|{3}", id, name, company, edu));
            HttpContext.Current.Response.Cookies["lwhd"].Value = string.Format("{0}|{1}|{2}|{3}", id, name, company, edu);
        }
        private string GetCompany(string companyid)
        {
            string sql = string.Format(" select company_name from t_company where id={0}",companyid);
            DataSet ds = SqlHelper.Query(sql);
            return ds.Tables[0].Rows[0]["company_name"].ToString();
        }

        private bool LoginCheck(string name, string card)
        {
            string sql = string.Format("select * from ask_user where ucardnumber='{0}'",card);
            DataSet dsAskUser =  SqlHelper.Query(sql);
            bool returnCode = false;
            if (dsAskUser.Tables[0].Rows.Count != 0)
            {
                if (dsAskUser.Tables[0].Rows[0]["uname"].ToString().Equals(name))
                {
                    string uid = dsAskUser.Tables[0].Rows[0]["utijtid"].ToString();
                    decimal nowedu = Convert.ToDecimal(GetUserEdu(uid));//体检通额度
                    string uuid = dsAskUser.Tables[0].Rows[0]["uuid"].ToString();
                    string cedus = GetUserConsume(uuid);
                    decimal cedu = Convert.ToDecimal(cedus);
                    decimal edu = nowedu - cedu;
                    string ip = GetAddressIP();
                    string date = DateTime.Now.ToString();
                    string updateSQL = string.Format(" update ask_user set ucompanymonery={0},  ulastip='{1}',ulastdatetime='{2}' where utijtid={3}", edu.ToString(), ip, date, uid);
                //    string updateOrderFeiyong = string.Format("update ask_order set oresult=1 where opublicmonery!=0 and ouid={0}", uuid);
                    SqlHelper.ExecuteSql(updateSQL);
                //    SqlHelper.ExecuteSql(updateOrderFeiyong);
                    string companyid = dsAskUser.Tables[0].Rows[0]["ucompanyid"].ToString();

                    setCookie(dsAskUser.Tables[0].Rows[0]["uuid"].ToString(), name, GetCompany(companyid), edu.ToString());
                    returnCode = true;
                }
            }
            else
            {
                string sqlTJT = string.Format("select * from t_member_info where card='{0}'", card);
                DataSet dsMemberInfo = SqlHelper.Query(sqlTJT);
                if (dsMemberInfo.Tables[0].Rows.Count != 0)
                {
                    if (dsMemberInfo.Tables[0].Rows[0]["name"].ToString().Equals(name))
                    {
                        string uid = dsMemberInfo.Tables[0].Rows[0]["id"].ToString();
                        string edu = GetUserEdu(uid);
                        string phone = dsMemberInfo.Tables[0].Rows[0]["mobile"].ToString();
                        string companyID = dsMemberInfo.Tables[0].Rows[0]["company_id"].ToString();
                        string uuid = InsertUser(uid,edu,phone,card,companyID,name);
                        setCookie(uuid, name, GetCompany(companyID), edu.ToString());
                        returnCode = true;
                    }
                }
            }
            return returnCode;
        }

        private string GetUserConsume(string id)
        {
            try
            {
                string sql = string.Format("select  sum(opublicmonery) as 'consume' from ask_order where ouid ={0} and oresult=1", id);
                DataSet ds = SqlHelper.Query(sql);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    if (ds.Tables[0].Rows[0]["consume"].ToString().Length != 0)
                        return ds.Tables[0].Rows[0]["consume"].ToString();
                    else
                        return "0";
                }
                else
                {
                    return "0";
                }
            }
            catch
            {
                return "0";
            }
        }

   
        private string GetUserEdu(string uid)
        {
            string sql = string.Format("select users.id as '编号',users.name as '姓名',tcpe.price as '原始额度',orders.amount as '已使用', orders.status as '订单状态',(case when orders.actual_amount=0 and orders.status in (2,3) then tcpe.price-orders.amount  when  orders.status in (0,1) then tcpe.price  when orders.amount is null  then tcpe.price else 0 end)as '实际额度' from t_member_info users left join t_check_ordered  orders on users.id = orders.member_id left join t_member_package_rel tmpr on users.card = tmpr.membercard left join t_check_package tcpe on tmpr.packageid = tcpe.id where   users.id={0} order by orders.status desc", uid);
            DataSet ds = SqlHelper.Query(sql);
            return ds.Tables[0].Rows[0]["实际额度"].ToString();
        }

        private string  InsertUser(string uid,string edu,string phone,string card,string companyID,string name)
        {
            //  insert ask_user
  //select 1,剩余额度,0,手机号码,密码为NULL,身份证号码,微信标识NULL,邮箱null,出生日期null,性别null,用户公司编号,用户注册时间,用户注册IP,用户登录时间,//用户登录IP,用户状态1,用户姓名
            string ip = GetAddressIP();
            string date = DateTime.Now.ToString();
            string sql = string.Format("insert ask_user select {9},{0},0,'{1}','','{2}','','','','','{3}','{4}','{5}','{6}','{7}',1,'{8}' select @@identity", edu, phone, card, companyID, date, ip, date, ip, name, uid);
            return SqlHelper.GetSingle(sql).ToString();
        }

       private string  GetAddressIP()
        {
            ///获取本地的IP地址
            string AddressIP = string.Empty;
            foreach (IPAddress _IPAddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (_IPAddress.AddressFamily.ToString() == "InterNetwork")
                {
                    AddressIP = _IPAddress.ToString();
                }
            }
           return AddressIP;
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