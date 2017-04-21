using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_org_base_packages:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_org_base_packages
	{
		public t_org_base_packages()
		{}
		#region Model
		private decimal _id;
		private string _itemid;
		private decimal? _orgid;
		private string _orgname;
		private string _packagename;
		private string _packageprice;
		private string _sexlimit;
		private string _typeid;
		private string _recindex;
		private string _zzitemids;
		private DateTime? _createtime;
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
		public string itemid
		{
			set{ _itemid=value;}
			get{return _itemid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? orgid
		{
			set{ _orgid=value;}
			get{return _orgid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string orgname
		{
			set{ _orgname=value;}
			get{return _orgname;}
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
		public string packageprice
		{
			set{ _packageprice=value;}
			get{return _packageprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sexlimit
		{
			set{ _sexlimit=value;}
			get{return _sexlimit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string typeid
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string recindex
		{
			set{ _recindex=value;}
			get{return _recindex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zzitemids
		{
			set{ _zzitemids=value;}
			get{return _zzitemids;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? createtime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		#endregion Model

	}
}

