using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// sys_param:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class sys_param
	{
		public sys_param()
		{}
		#region Model
		private decimal _param_id;
		private string _param_code;
		private string _param_name;
		private string _param_value;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public decimal param_id
		{
			set{ _param_id=value;}
			get{return _param_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string param_code
		{
			set{ _param_code=value;}
			get{return _param_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string param_name
		{
			set{ _param_name=value;}
			get{return _param_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string param_value
		{
			set{ _param_value=value;}
			get{return _param_value;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

