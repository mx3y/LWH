using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_ordered_datechange:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_ordered_datechange
	{
		public t_ordered_datechange()
		{}
		#region Model
		private int _tco_id;
		private int _tco_uid;
		private DateTime _old_order_date;
		private DateTime _new_order_data;
		private DateTime _chnage_date;
		/// <summary>
		/// 
		/// </summary>
		public int tco_id
		{
			set{ _tco_id=value;}
			get{return _tco_id;}
		}
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
		public DateTime old_order_date
		{
			set{ _old_order_date=value;}
			get{return _old_order_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime new_order_data
		{
			set{ _new_order_data=value;}
			get{return _new_order_data;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime chnage_date
		{
			set{ _chnage_date=value;}
			get{return _chnage_date;}
		}
		#endregion Model

	}
}

