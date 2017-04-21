using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_member_card:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_member_card
	{
		public t_member_card()
		{}
		#region Model
		private decimal _card_id;
		private string _card_no;
		private decimal? _face_price;
		private decimal? _market_price;
		private decimal? _member_id;
		private decimal? _residual_amount;
		private string _member_type;
		/// <summary>
		/// 
		/// </summary>
		public decimal card_id
		{
			set{ _card_id=value;}
			get{return _card_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string card_no
		{
			set{ _card_no=value;}
			get{return _card_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? face_price
		{
			set{ _face_price=value;}
			get{return _face_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? market_price
		{
			set{ _market_price=value;}
			get{return _market_price;}
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
		public decimal? residual_amount
		{
			set{ _residual_amount=value;}
			get{return _residual_amount;}
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

