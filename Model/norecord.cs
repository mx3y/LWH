using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// norecord:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class norecord
	{
		public norecord()
		{}
		#region Model
		private int _nr_id;
		private string _nr_phone;
		private string _nr_name;
		private string _nr_uid;
		private string _nr_status;
		private DateTime? _nr_date;
		/// <summary>
		/// 
		/// </summary>
		public int nr_id
		{
			set{ _nr_id=value;}
			get{return _nr_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string nr_phone
		{
			set{ _nr_phone=value;}
			get{return _nr_phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string nr_name
		{
			set{ _nr_name=value;}
			get{return _nr_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string nr_uid
		{
			set{ _nr_uid=value;}
			get{return _nr_uid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string nr_status
		{
			set{ _nr_status=value;}
			get{return _nr_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? nr_date
		{
			set{ _nr_date=value;}
			get{return _nr_date;}
		}
		#endregion Model

	}
}

