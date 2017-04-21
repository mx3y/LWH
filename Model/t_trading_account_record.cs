using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_trading_account_record:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_trading_account_record
	{
		public t_trading_account_record()
		{}
		#region Model
		private decimal _record_id;
		private decimal? _amount;
		private decimal? _trade_balance;
		private DateTime? _trade_time;
		private string _trade_type;
		private decimal? _account_id;
		private string _busi_type;
		private decimal? _member_id;
		private string _remark;
		private byte[] _order_id;
		private string _member_type;
		/// <summary>
		/// 
		/// </summary>
		public decimal record_id
		{
			set{ _record_id=value;}
			get{return _record_id;}
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
		public decimal? trade_balance
		{
			set{ _trade_balance=value;}
			get{return _trade_balance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? trade_time
		{
			set{ _trade_time=value;}
			get{return _trade_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trade_type
		{
			set{ _trade_type=value;}
			get{return _trade_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? account_id
		{
			set{ _account_id=value;}
			get{return _account_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string busi_type
		{
			set{ _busi_type=value;}
			get{return _busi_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? member_id
		{
			set{ _member_id=value;}
			get{return _member_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] order_id
		{
			set{ _order_id=value;}
			get{return _order_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string member_type
		{
			set{ _member_type=value;}
			get{return _member_type;}
		}
		#endregion Model

	}
}

