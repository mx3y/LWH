using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_member_status:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_member_status
	{
		public t_member_status()
		{}
		#region Model
		private int _tco_uid;
		private int _tco_send_msg;
		private int _tco_order_msg;
		private int _tco_after_tell;
		private int _tco_before_tell;
		private int? _tco_istijian=0;
		private int _tco_report;
		private string _tco_pay_openid;
		private string _tco_pay_report_number;
		private string _tco_befre_tell_msg;
		private string _tco_remark_msg;
		/// <summary>
		/// 
		/// </summary>
		public int tco_uid
		{
			set{ _tco_uid=value;}
			get{return _tco_uid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int tco_send_msg
		{
			set{ _tco_send_msg=value;}
			get{return _tco_send_msg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int tco_order_msg
		{
			set{ _tco_order_msg=value;}
			get{return _tco_order_msg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int tco_after_tell
		{
			set{ _tco_after_tell=value;}
			get{return _tco_after_tell;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int tco_before_tell
		{
			set{ _tco_before_tell=value;}
			get{return _tco_before_tell;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? tco_istijian
		{
			set{ _tco_istijian=value;}
			get{return _tco_istijian;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int tco_report
		{
			set{ _tco_report=value;}
			get{return _tco_report;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tco_pay_openid
		{
			set{ _tco_pay_openid=value;}
			get{return _tco_pay_openid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tco_pay_report_number
		{
			set{ _tco_pay_report_number=value;}
			get{return _tco_pay_report_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tco_befre_tell_msg
		{
			set{ _tco_befre_tell_msg=value;}
			get{return _tco_befre_tell_msg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tco_remark_msg
		{
			set{ _tco_remark_msg=value;}
			get{return _tco_remark_msg;}
		}
		#endregion Model

	}
}

