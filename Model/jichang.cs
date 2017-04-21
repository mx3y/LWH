using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// jichang:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class jichang
	{
		public jichang()
		{}
		#region Model
		private int _jichang_id;
		private string _jichang_name;
		private string _jichang_sex;
		private string _jichang_age;
		private string _jichang_org;
		private DateTime? _jichang_order_date;
		private string _jichang_edu;
		private string _jichang_monery;
		private string _jichang_company;
		private string _jigou_monery;
		private string _jigou_order_date;
		private string _jigou;
		private string _monery;
		private string _dept;
		private string _company;
		/// <summary>
		/// 
		/// </summary>
		public int jichang_id
		{
			set{ _jichang_id=value;}
			get{return _jichang_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jichang_name
		{
			set{ _jichang_name=value;}
			get{return _jichang_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jichang_sex
		{
			set{ _jichang_sex=value;}
			get{return _jichang_sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jichang_age
		{
			set{ _jichang_age=value;}
			get{return _jichang_age;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jichang_org
		{
			set{ _jichang_org=value;}
			get{return _jichang_org;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? jichang_order_date
		{
			set{ _jichang_order_date=value;}
			get{return _jichang_order_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jichang_edu
		{
			set{ _jichang_edu=value;}
			get{return _jichang_edu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jichang_monery
		{
			set{ _jichang_monery=value;}
			get{return _jichang_monery;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jichang_company
		{
			set{ _jichang_company=value;}
			get{return _jichang_company;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jigou_monery
		{
			set{ _jigou_monery=value;}
			get{return _jigou_monery;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jigou_order_date
		{
			set{ _jigou_order_date=value;}
			get{return _jigou_order_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jigou
		{
			set{ _jigou=value;}
			get{return _jigou;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string monery
		{
			set{ _monery=value;}
			get{return _monery;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string dept
		{
			set{ _dept=value;}
			get{return _dept;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string company
		{
			set{ _company=value;}
			get{return _company;}
		}
		#endregion Model

	}
}

