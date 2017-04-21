using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_base_item_info:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_base_item_info
	{
		public t_base_item_info()
		{}
		#region Model
		private int _id;
		private string _item_code;
		private string _item_name;
		private decimal? _guide_price;
		private string _type_id;
		private string _remark;
		private string _usesex;
		private string _recindex;
		private DateTime? _create_time;
		private string _details;
		private string _recommend_age_end;
		private string _recommend_age_start;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string item_code
		{
			set{ _item_code=value;}
			get{return _item_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string item_name
		{
			set{ _item_name=value;}
			get{return _item_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? guide_price
		{
			set{ _guide_price=value;}
			get{return _guide_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string type_id
		{
			set{ _type_id=value;}
			get{return _type_id;}
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
		public string usesex
		{
			set{ _usesex=value;}
			get{return _usesex;}
		}
		/// <summary>
		/// 推荐指数
		/// </summary>
		public string recindex
		{
			set{ _recindex=value;}
			get{return _recindex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? create_time
		{
			set{ _create_time=value;}
			get{return _create_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string details
		{
			set{ _details=value;}
			get{return _details;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string recommend_age_end
		{
			set{ _recommend_age_end=value;}
			get{return _recommend_age_end;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string recommend_age_start
		{
			set{ _recommend_age_start=value;}
			get{return _recommend_age_start;}
		}
		#endregion Model

	}
}

