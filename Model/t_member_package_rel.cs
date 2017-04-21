using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_member_package_rel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_member_package_rel
	{
		public t_member_package_rel()
		{}
		#region Model
		private int _id;
		private string _membercard;
		private int? _packageid;
		private string _packagename;
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
		public string membercard
		{
			set{ _membercard=value;}
			get{return _membercard;}
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
		public string packagename
		{
			set{ _packagename=value;}
			get{return _packagename;}
		}
		#endregion Model

	}
}

