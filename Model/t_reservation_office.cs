using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_reservation_office:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_reservation_office
	{
		public t_reservation_office()
		{}
		#region Model
		private decimal _office_id;
		private int _capacity;
		private string _office_name;
		private int _serial_number;
		/// <summary>
		/// 
		/// </summary>
		public decimal office_id
		{
			set{ _office_id=value;}
			get{return _office_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int capacity
		{
			set{ _capacity=value;}
			get{return _capacity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string office_name
		{
			set{ _office_name=value;}
			get{return _office_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int serial_number
		{
			set{ _serial_number=value;}
			get{return _serial_number;}
		}
		#endregion Model

	}
}

