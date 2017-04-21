using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_member_level:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_member_level
	{
		public t_member_level()
		{}
		#region Model
		private long _id;
		private string _level_name;
		private string _discount;
		/// <summary>
		/// 
		/// </summary>
		public long id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string level_name
		{
			set{ _level_name=value;}
			get{return _level_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string discount
		{
			set{ _discount=value;}
			get{return _discount;}
		}
		#endregion Model

	}
}

