using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_reservation_record:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_reservation_record
	{
		public t_reservation_record()
		{}
		#region Model
		private decimal _record_id;
		private string _booking_date;
		private string _booking_people;
		private decimal? _office_id;
		private string _status;
		private string _booking_day;
		private int? _booking_number;
		private string _booking_period;
		private string _check_code;
		private DateTime? _create_date;
		private string _booking_people_type;
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
		public string booking_date
		{
			set{ _booking_date=value;}
			get{return _booking_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string booking_people
		{
			set{ _booking_people=value;}
			get{return _booking_people;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? office_id
		{
			set{ _office_id=value;}
			get{return _office_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string booking_day
		{
			set{ _booking_day=value;}
			get{return _booking_day;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? booking_number
		{
			set{ _booking_number=value;}
			get{return _booking_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string booking_period
		{
			set{ _booking_period=value;}
			get{return _booking_period;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string check_code
		{
			set{ _check_code=value;}
			get{return _check_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? create_date
		{
			set{ _create_date=value;}
			get{return _create_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string booking_people_type
		{
			set{ _booking_people_type=value;}
			get{return _booking_people_type;}
		}
		#endregion Model

	}
}

