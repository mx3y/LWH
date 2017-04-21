using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_member:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_member
	{
		public t_member()
		{}
		#region Model
		private decimal _member_id;
		private string _address;
		private string _auth_flag;
		private string _auth_remark;
		private DateTime? _auth_time;
		private string _card_image1;
		private string _card_image2;
		private string _cash_pwd;
		private string _city;
		private string _company;
		private string _county;
		private DateTime? _create_date;
		private string _email;
		private string _id_number;
		private DateTime? _last_check_date;
		private decimal? _last_check_id;
		private DateTime? _last_review_date;
		private string _login_name;
		private string _login_pwd;
		private string _member_name;
		private string _member_no;
		private string _member_type;
		private string _mobile;
		private string _open_id;
		private string _province;
		private string _sex;
		/// <summary>
		/// 
		/// </summary>
		public decimal member_id
		{
			set{ _member_id=value;}
			get{return _member_id;}
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
		public string auth_flag
		{
			set{ _auth_flag=value;}
			get{return _auth_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string auth_remark
		{
			set{ _auth_remark=value;}
			get{return _auth_remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? auth_time
		{
			set{ _auth_time=value;}
			get{return _auth_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string card_image1
		{
			set{ _card_image1=value;}
			get{return _card_image1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string card_image2
		{
			set{ _card_image2=value;}
			get{return _card_image2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cash_pwd
		{
			set{ _cash_pwd=value;}
			get{return _cash_pwd;}
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
		public string company
		{
			set{ _company=value;}
			get{return _company;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string county
		{
			set{ _county=value;}
			get{return _county;}
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
		public string email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string id_number
		{
			set{ _id_number=value;}
			get{return _id_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? last_check_date
		{
			set{ _last_check_date=value;}
			get{return _last_check_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? last_check_id
		{
			set{ _last_check_id=value;}
			get{return _last_check_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? last_review_date
		{
			set{ _last_review_date=value;}
			get{return _last_review_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string login_name
		{
			set{ _login_name=value;}
			get{return _login_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string login_pwd
		{
			set{ _login_pwd=value;}
			get{return _login_pwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string member_name
		{
			set{ _member_name=value;}
			get{return _member_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string member_no
		{
			set{ _member_no=value;}
			get{return _member_no;}
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
		public string mobile
		{
			set{ _mobile=value;}
			get{return _mobile;}
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
		public string province
		{
			set{ _province=value;}
			get{return _province;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		#endregion Model

	}
}

