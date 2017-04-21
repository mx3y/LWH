using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_check_ordered:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_check_ordered
	{
		public t_check_ordered()
		{}
		#region Model
		private long _id;
		private long? _member_id;
		private int? _package_id;
		private decimal? _amount;
		private decimal? _actual_amount;
		private DateTime? _ordered_date;
		private int? _org_id;
		private string _period;
		private string _status;
		private string _name;
		private string _item_ids;
		private DateTime? _createtime;
		private decimal? _baseprice;
		private decimal? _optionalprice;
		private decimal? _contractid;
		private string _orderno;
		private string _jxbids;
		private string _reportstatus;
		/// <summary>
		/// 
		/// </summary>
		public long id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? member_id
		{
			set{ _member_id=value;}
			get{return _member_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? package_id
		{
			set{ _package_id=value;}
			get{return _package_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? amount
		{
			set{ _amount=value;}
			get{return _amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? actual_amount
		{
			set{ _actual_amount=value;}
			get{return _actual_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ordered_date
		{
			set{ _ordered_date=value;}
			get{return _ordered_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? org_id
		{
			set{ _org_id=value;}
			get{return _org_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string period
		{
			set{ _period=value;}
			get{return _period;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string item_ids
		{
			set{ _item_ids=value;}
			get{return _item_ids;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? createtime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? baseprice
		{
			set{ _baseprice=value;}
			get{return _baseprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? optionalprice
		{
			set{ _optionalprice=value;}
			get{return _optionalprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? contractid
		{
			set{ _contractid=value;}
			get{return _contractid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string orderNo
		{
			set{ _orderno=value;}
			get{return _orderno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jxbids
		{
			set{ _jxbids=value;}
			get{return _jxbids;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string reportstatus
		{
			set{ _reportstatus=value;}
			get{return _reportstatus;}
		}
		#endregion Model

	}
}

