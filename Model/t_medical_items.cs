using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_medical_items:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_medical_items
	{
		public t_medical_items()
		{}
		#region Model
		private int _id;
		private int? _org_id;
		private string _item_name;
		private string _item_code;
		private decimal? _item_price;
		private int? _base_item_id;
		private int? _item_type;
		private int? _recommend_index;
		private string _org_name;
		private decimal? _type_id;
		private string _usesex;
		private string _orgitemcode;
		private string _orgitemname;
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
		public int? org_id
		{
			set{ _org_id=value;}
			get{return _org_id;}
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
		public string item_code
		{
			set{ _item_code=value;}
			get{return _item_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? item_price
		{
			set{ _item_price=value;}
			get{return _item_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? base_item_id
		{
			set{ _base_item_id=value;}
			get{return _base_item_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? item_type
		{
			set{ _item_type=value;}
			get{return _item_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? recommend_index
		{
			set{ _recommend_index=value;}
			get{return _recommend_index;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string org_name
		{
			set{ _org_name=value;}
			get{return _org_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? type_id
		{
			set{ _type_id=value;}
			get{return _type_id;}
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
		/// 
		/// </summary>
		public string orgitemcode
		{
			set{ _orgitemcode=value;}
			get{return _orgitemcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string orgitemname
		{
			set{ _orgitemname=value;}
			get{return _orgitemname;}
		}
		#endregion Model

	}
}

