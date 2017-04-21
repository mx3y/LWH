using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_company:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_company
	{
		public t_company()
		{}
		#region Model
		private int _id;
		private string _company_name;
		private string _address;
		private string _logo;
		private string _weixin_name;
		private string _province;
		private string _city;
		private string _area;
		private DateTime? _create_date;
		private DateTime? _update_time;
		private int? _platform_id;
		private string _platform_name;
		private string _company_img;
		private string _company_info;
		private string _platform_img;
		private string _platform_info;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string company_name
		{
			set{ _company_name=value;}
			get{return _company_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string logo
		{
			set{ _logo=value;}
			get{return _logo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string weixin_name
		{
			set{ _weixin_name=value;}
			get{return _weixin_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string province
		{
			set{ _province=value;}
			get{return _province;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string city
		{
			set{ _city=value;}
			get{return _city;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string area
		{
			set{ _area=value;}
			get{return _area;}
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
		public DateTime? update_time
		{
			set{ _update_time=value;}
			get{return _update_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? platform_id
		{
			set{ _platform_id=value;}
			get{return _platform_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string platform_name
		{
			set{ _platform_name=value;}
			get{return _platform_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string company_img
		{
			set{ _company_img=value;}
			get{return _company_img;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string company_info
		{
			set{ _company_info=value;}
			get{return _company_info;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string platform_img
		{
			set{ _platform_img=value;}
			get{return _platform_img;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string platform_info
		{
			set{ _platform_info=value;}
			get{return _platform_info;}
		}
		#endregion Model

	}
}

