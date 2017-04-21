using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// sys_dict:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class sys_dict
	{
		public sys_dict()
		{}
		#region Model
		private string _dict_id;
		private string _dict_code;
		private int? _order_no;
		private string _param_name;
		private string _param_remark;
		private decimal? _type_id;
		/// <summary>
		/// 
		/// </summary>
		public string dict_id
		{
			set{ _dict_id=value;}
			get{return _dict_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string dict_code
		{
			set{ _dict_code=value;}
			get{return _dict_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? order_no
		{
			set{ _order_no=value;}
			get{return _order_no;}
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
		public string param_remark
		{
			set{ _param_remark=value;}
			get{return _param_remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? type_id
		{
			set{ _type_id=value;}
			get{return _type_id;}
		}
		#endregion Model

	}
}

