using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// user_refund_record:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class user_refund_record
	{
		public user_refund_record()
		{}
		#region Model
		private int _urr_id;
		private int _urr_user_id;
		private int _urr_order_id;
		private string _urr_weixin_number;
		private string _urr_weixin_busseiss_number;
		private decimal _urr_monery;
		private int _urr_state;
		private DateTime _urr_date;
		/// <summary>
		/// 
		/// </summary>
		public int urr_id
		{
			set{ _urr_id=value;}
			get{return _urr_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int urr_user_id
		{
			set{ _urr_user_id=value;}
			get{return _urr_user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int urr_order_id
		{
			set{ _urr_order_id=value;}
			get{return _urr_order_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string urr_weixin_number
		{
			set{ _urr_weixin_number=value;}
			get{return _urr_weixin_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string urr_weixin_busseiss_number
		{
			set{ _urr_weixin_busseiss_number=value;}
			get{return _urr_weixin_busseiss_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal urr_monery
		{
			set{ _urr_monery=value;}
			get{return _urr_monery;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int urr_state
		{
			set{ _urr_state=value;}
			get{return _urr_state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime urr_date
		{
			set{ _urr_date=value;}
			get{return _urr_date;}
		}
		#endregion Model

	}
}

