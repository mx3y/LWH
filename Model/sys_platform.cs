using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// sys_platform:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class sys_platform
	{
		public sys_platform()
		{}
		#region Model
		private int _id;
		private string _platfrom;
		private string _province;
		private string _city;
		private string _area;
		private string _address;
		private string _phone;
		private int? _parent_id;
		private string _status= "0";
		private int? _mark;
		private string _aboutus;
		private DateTime? _createtime;
		private string _homepageimage;
		private string _logo;
		private string _payment;
		private string _paymentkey;
		private string _platformdescription;
		private string _shortplatform;
		private string _using_this;
		private string _weurl;
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
		public string platfrom
		{
			set{ _platfrom=value;}
			get{return _platfrom;}
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
		public string address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? parent_id
		{
			set{ _parent_id=value;}
			get{return _parent_id;}
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
		public int? mark
		{
			set{ _mark=value;}
			get{return _mark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string aboutus
		{
			set{ _aboutus=value;}
			get{return _aboutus;}
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
		public string homepageimage
		{
			set{ _homepageimage=value;}
			get{return _homepageimage;}
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
		public string payment
		{
			set{ _payment=value;}
			get{return _payment;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string paymentkey
		{
			set{ _paymentkey=value;}
			get{return _paymentkey;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string platformdescription
		{
			set{ _platformdescription=value;}
			get{return _platformdescription;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string shortplatform
		{
			set{ _shortplatform=value;}
			get{return _shortplatform;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string using_this
		{
			set{ _using_this=value;}
			get{return _using_this;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string weurl
		{
			set{ _weurl=value;}
			get{return _weurl;}
		}
		#endregion Model

	}
}

