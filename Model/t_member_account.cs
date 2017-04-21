using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_member_account:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_member_account
	{
		public t_member_account()
		{}
		#region Model
		private decimal _account_id;
		private decimal? _amount;
		private string _status;
		private decimal? _member_id;
		private decimal _card_amount=0M;
		private string _member_type;
		/// <summary>
		/// 
		/// </summary>
		public decimal account_id
		{
			set{ _account_id=value;}
			get{return _account_id;}
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
		public string status
		{
			set{ _status=value;}
			get{return _status;}
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
		public decimal card_amount
		{
			set{ _card_amount=value;}
			get{return _card_amount;}
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

