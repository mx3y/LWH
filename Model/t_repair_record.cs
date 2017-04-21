using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_repair_record:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_repair_record
	{
		public t_repair_record()
		{}
		#region Model
		private decimal _repair_id;
		private string _audit_remark;
		private string _audit_status;
		private string _remark;
		private int? _type;
		private decimal? _member_id;
		private decimal? _goods_id;
		private DateTime? _repair_time;
		private decimal? _amount;
		private decimal? _order_detail_id;
		private string _member_type;
		/// <summary>
		/// 
		/// </summary>
		public decimal repair_id
		{
			set{ _repair_id=value;}
			get{return _repair_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string audit_remark
		{
			set{ _audit_remark=value;}
			get{return _audit_remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string audit_status
		{
			set{ _audit_status=value;}
			get{return _audit_status;}
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
		public int? type
		{
			set{ _type=value;}
			get{return _type;}
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
		public decimal? goods_id
		{
			set{ _goods_id=value;}
			get{return _goods_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? repair_time
		{
			set{ _repair_time=value;}
			get{return _repair_time;}
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
		public decimal? order_detail_id
		{
			set{ _order_detail_id=value;}
			get{return _order_detail_id;}
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

