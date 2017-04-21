using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_check_package:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_check_package
	{
		public t_check_package()
		{}
		#region Model
		private int _id;
		private int? _contractid;
		private string _packages;
		private decimal? _price;
		private decimal? _avouredprice;
		private string _usesex;
		private string _contractname;
		private decimal? _avoured_price;
		private decimal? _org_id;
		private string _package;
		private string _jcitemids;
		private string _kxitemids;
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
		public int? contractid
		{
			set{ _contractid=value;}
			get{return _contractid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string packages
		{
			set{ _packages=value;}
			get{return _packages;}
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
		public decimal? avouredprice
		{
			set{ _avouredprice=value;}
			get{return _avouredprice;}
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
		public string contractname
		{
			set{ _contractname=value;}
			get{return _contractname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? avoured_price
		{
			set{ _avoured_price=value;}
			get{return _avoured_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? org_id
		{
			set{ _org_id=value;}
			get{return _org_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string package
		{
			set{ _package=value;}
			get{return _package;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jcitemids
		{
			set{ _jcitemids=value;}
			get{return _jcitemids;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string kxitemids
		{
			set{ _kxitemids=value;}
			get{return _kxitemids;}
		}
		#endregion Model

	}
}

