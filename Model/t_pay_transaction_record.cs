using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_pay_transaction_record:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_pay_transaction_record
	{
		public t_pay_transaction_record()
		{}
		#region Model
		private long _id;
		private string _out_trade_no;
		private string _transaction_id;
		private long? _memberid;
		private decimal? _transaction_price;
		private string _status;
		private DateTime? _create_date;
		private DateTime? _update_date;
		private decimal? _member_id;
		private string _openid;
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
		public string out_trade_no
		{
			set{ _out_trade_no=value;}
			get{return _out_trade_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string transaction_id
		{
			set{ _transaction_id=value;}
			get{return _transaction_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? memberId
		{
			set{ _memberid=value;}
			get{return _memberid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? transaction_price
		{
			set{ _transaction_price=value;}
			get{return _transaction_price;}
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
		public DateTime? create_date
		{
			set{ _create_date=value;}
			get{return _create_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? update_date
		{
			set{ _update_date=value;}
			get{return _update_date;}
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
		public string openid
		{
			set{ _openid=value;}
			get{return _openid;}
		}
		#endregion Model

	}
}

