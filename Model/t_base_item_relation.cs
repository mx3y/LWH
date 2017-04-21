using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_base_item_relation:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_base_item_relation
	{
		public t_base_item_relation()
		{}
		#region Model
		private decimal _id;
		private string _discription;
		private decimal? _itemaid;
		private string _itemaname;
		private decimal? _itembid;
		private string _itembname;
		private string _relation;
		private string _relationid;
		/// <summary>
		/// 
		/// </summary>
		public decimal id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string discription
		{
			set{ _discription=value;}
			get{return _discription;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? itemAid
		{
			set{ _itemaid=value;}
			get{return _itemaid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string itemAname
		{
			set{ _itemaname=value;}
			get{return _itemaname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? itemBid
		{
			set{ _itembid=value;}
			get{return _itembid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string itemBname
		{
			set{ _itembname=value;}
			get{return _itembname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string relation
		{
			set{ _relation=value;}
			get{return _relation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string relationid
		{
			set{ _relationid=value;}
			get{return _relationid;}
		}
		#endregion Model

	}
}

