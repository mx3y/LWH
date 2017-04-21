using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_check_people_record:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_check_people_record
	{
		public t_check_people_record()
		{}
		#region Model
		private decimal _record_id;
		private string _check_people_name;
		private decimal? _booking_id;
		private string _check_people_mobile;
		/// <summary>
		/// 
		/// </summary>
		public decimal record_id
		{
			set{ _record_id=value;}
			get{return _record_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string check_people_name
		{
			set{ _check_people_name=value;}
			get{return _check_people_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? booking_id
		{
			set{ _booking_id=value;}
			get{return _booking_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string check_people_mobile
		{
			set{ _check_people_mobile=value;}
			get{return _check_people_mobile;}
		}
		#endregion Model

	}
}

