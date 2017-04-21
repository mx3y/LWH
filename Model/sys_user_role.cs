using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// sys_user_role:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class sys_user_role
	{
		public sys_user_role()
		{}
		#region Model
		private decimal _user_role_id;
		private decimal? _role_id;
		private decimal? _user_id;
		/// <summary>
		/// 
		/// </summary>
		public decimal user_role_id
		{
			set{ _user_role_id=value;}
			get{return _user_role_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? role_id
		{
			set{ _role_id=value;}
			get{return _role_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? user_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		#endregion Model

	}
}

