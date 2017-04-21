using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_shopping_cart:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_shopping_cart
	{
		public t_shopping_cart()
		{}
		#region Model
		private decimal _cart_id;
		private int? _number;
		private decimal? _member_id;
		private decimal? _goods_id;
		private string _member_type;
		/// <summary>
		/// 
		/// </summary>
		public decimal cart_id
		{
			set{ _cart_id=value;}
			get{return _cart_id;}
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
		public string member_type
		{
			set{ _member_type=value;}
			get{return _member_type;}
		}
		#endregion Model

	}
}

