using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_member_base_info:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_member_base_info
	{
		public t_member_base_info()
		{}
		#region Model
		private decimal _base_id;
		private string _degree;
		private string _income;
		private string _industry;
		private string _marital_status;
		private string _position;
		private string _scale;
		private string _school;
		private decimal? _member_id;
		private string _birthday;
		private string _picture;
		private string _member_type;
		/// <summary>
		/// 
		/// </summary>
		public decimal base_id
		{
			set{ _base_id=value;}
			get{return _base_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string degree
		{
			set{ _degree=value;}
			get{return _degree;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string income
		{
			set{ _income=value;}
			get{return _income;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string industry
		{
			set{ _industry=value;}
			get{return _industry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string marital_status
		{
			set{ _marital_status=value;}
			get{return _marital_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string position
		{
			set{ _position=value;}
			get{return _position;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string scale
		{
			set{ _scale=value;}
			get{return _scale;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string school
		{
			set{ _school=value;}
			get{return _school;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? member_id
		{
			set{ _member_id=value;}
			get{return _member_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string birthday
		{
			set{ _birthday=value;}
			get{return _birthday;}
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
		public string member_type
		{
			set{ _member_type=value;}
			get{return _member_type;}
		}
		#endregion Model

	}
}

