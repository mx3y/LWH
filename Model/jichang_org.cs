using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// jichang_org:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class jichang_org
	{
		public jichang_org()
		{}
		#region Model
		private string _name;
		private string _date;
		private string _monery;
		private string _org;
		/// <summary>
		/// 
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string date
		{
			set{ _date=value;}
			get{return _date;}
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
		public string org
		{
			set{ _org=value;}
			get{return _org;}
		}
		#endregion Model

	}
}

