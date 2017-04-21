using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_check_package_item:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_check_package_item
	{
		public t_check_package_item()
		{}
		#region Model
		private int _id;
		private string _itemid;
		private decimal? _standardprice;
		private decimal? _guideprice;
		private string _packagename;
		private string _status;
		private int? _packageid;
		private int? _typeid;
		private decimal? _contractid;
		private string _contractname;
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
		public string itemid
		{
			set{ _itemid=value;}
			get{return _itemid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? standardprice
		{
			set{ _standardprice=value;}
			get{return _standardprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? guideprice
		{
			set{ _guideprice=value;}
			get{return _guideprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string packagename
		{
			set{ _packagename=value;}
			get{return _packagename;}
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
		public int? packageid
		{
			set{ _packageid=value;}
			get{return _packageid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? typeid
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? contractid
		{
			set{ _contractid=value;}
			get{return _contractid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string contractname
		{
			set{ _contractname=value;}
			get{return _contractname;}
		}
		#endregion Model

	}
}

