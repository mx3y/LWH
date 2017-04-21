using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// sys_role_func:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class sys_role_func
	{
		public sys_role_func()
		{}
		#region Model
		private decimal _role_func_id;
		private decimal? _func_code;
		private decimal? _role_id;
		/// <summary>
		/// 
		/// </summary>
		public decimal role_func_id
		{
			set{ _role_func_id=value;}
			get{return _role_func_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? func_code
		{
			set{ _func_code=value;}
			get{return _func_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? role_id
		{
			set{ _role_id=value;}
			get{return _role_id;}
		}
		#endregion Model

	}
}

