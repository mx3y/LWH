using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_product_schedule:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_product_schedule
	{
		public t_product_schedule()
		{}
		#region Model
		private decimal _schedule_id;
		private int? _eval_count;
		private int? _sell_count;
		private int? _stock;
		private decimal? _goods_id;
		private int? _bad_eval;
		private int? _comment_eval;
		private int? _high_eval;
		private int _turn_num=0;
		/// <summary>
		/// 
		/// </summary>
		public decimal schedule_id
		{
			set{ _schedule_id=value;}
			get{return _schedule_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? eval_count
		{
			set{ _eval_count=value;}
			get{return _eval_count;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sell_count
		{
			set{ _sell_count=value;}
			get{return _sell_count;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? stock
		{
			set{ _stock=value;}
			get{return _stock;}
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
		public int? bad_eval
		{
			set{ _bad_eval=value;}
			get{return _bad_eval;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? comment_eval
		{
			set{ _comment_eval=value;}
			get{return _comment_eval;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? high_eval
		{
			set{ _high_eval=value;}
			get{return _high_eval;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int turn_num
		{
			set{ _turn_num=value;}
			get{return _turn_num;}
		}
		#endregion Model

	}
}

