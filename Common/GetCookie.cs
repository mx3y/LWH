using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LW_AskOnline.Common
{
   public class GetCookie
    {
        public string getCookie(string cookieName)
        {
            System.Web.HttpCookie cookie = System.Web.HttpContext.Current.Request.Cookies[cookieName];
            if (cookie != null)
            {
                return cookie.Value.ToString();
            }
            else
            {
                return null;
            }
        }
        
    }
}
