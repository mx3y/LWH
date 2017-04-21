using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_environment:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_environment
	{
		public t_environment()
		{}
		#region Model
		private decimal _environment_id;
		private string _environment_name;
		private string _picture;
		private string _remark;
		private string _type;
		/// <summary>
		/// 
		/// </summary>
		public decimal environment_id
		{
			set{ _environment_id=value;}
			get{return _environment_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string environment_name
		{
			set{ _environment_name=value;}
			get{return _environment_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string picture
		{
			set{ _picture=value;}
			get{return _picture;}
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
		public string type
		{
			set{ _type=value;}
			get{return _type;}
		}
		#endregion Model

	}
}

