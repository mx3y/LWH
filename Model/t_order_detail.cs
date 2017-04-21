using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_order_detail:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_order_detail
	{
		public t_order_detail()
		{}
		#region Model
		private decimal _detail_id;
		private int? _number;
		private decimal? _price;
		private decimal? _total_amount;
		private decimal? _order_id;
		private decimal? _goods_id;
		private int _is_valuation=0;
		private int _is_repair=0;
		private int _repair_num=0;
		/// <summary>
		/// 
		/// </summary>
		public decimal detail_id
		{
			set{ _detail_id=value;}
			get{return _detail_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? number
		{
			set{ _number=value;}
			get{return _number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? total_amount
		{
			set{ _total_amount=value;}
			get{return _total_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? order_id
		{
			set{ _order_id=value;}
			get{return _order_id;}
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
		public int is_valuation
		{
			set{ _is_valuation=value;}
			get{return _is_valuation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_repair
		{
			set{ _is_repair=value;}
			get{return _is_repair;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int repair_num
		{
			set{ _repair_num=value;}
			get{return _repair_num;}
		}
		#endregion Model

	}
}

