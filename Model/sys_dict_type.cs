using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// sys_dict_type:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class sys_dict_type
	{
		public sys_dict_type()
		{}
		#region Model
		private decimal _type_id;
		private string _remark;
		private string _type_code;
		private string _type_name;
		/// <summary>
		/// 
		/// </summary>
		public decimal type_id
		{
			set{ _type_id=value;}
			get{return _type_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string type_code
		{
			set{ _type_code=value;}
			get{return _type_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string type_name
		{
			set{ _type_name=value;}
			get{return _type_name;}
		}
		#endregion Model

	}
}

