using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_member_info:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_member_info
	{
		public t_member_info()
		{}
		#region Model
		private long _id;
		private string _name;
		private string _sex;
		private int? _age;
		private string _mobile;
		private string _card;
		private int? _company_id;
		private long? _level_id;
		private string _email;
		private string _password;
		private string _office;
		private string _member_type;
		private string _open_id;
		private DateTime? _createtime;
		private string _platfrom_id;
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
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? age
		{
			set{ _age=value;}
			get{return _age;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mobile
		{
			set{ _mobile=value;}
			get{return _mobile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string card
		{
			set{ _card=value;}
			get{return _card;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? company_id
		{
			set{ _company_id=value;}
			get{return _company_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? level_id
		{
			set{ _level_id=value;}
			get{return _level_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string office
		{
			set{ _office=value;}
			get{return _office;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string member_type
		{
			set{ _member_type=value;}
			get{return _member_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string open_id
		{
			set{ _open_id=value;}
			get{return _open_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? createtime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string platfrom_id
		{
			set{ _platfrom_id=value;}
			get{return _platfrom_id;}
		}
		#endregion Model

	}
}

