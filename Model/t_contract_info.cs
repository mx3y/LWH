using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_contract_info:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_contract_info
	{
		public t_contract_info()
		{}
		#region Model
		private int _id;
		private string _contract_name;
		private DateTime _sign_date;
		private DateTime? _start_date;
		private DateTime? _end_date;
		private string _salesman;
		private decimal? _amount;
		private string _link_man;
		private string _phone;
		private string _position;
		private string _status;
		private int? _company_id;
		private int? _org_id;
		private DateTime? _createtime;
		private string _jctjx;
		private string _jxbids;
		private string _kxtjx;
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
		public string contract_name
		{
			set{ _contract_name=value;}
			get{return _contract_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime sign_date
		{
			set{ _sign_date=value;}
			get{return _sign_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? start_date
		{
			set{ _start_date=value;}
			get{return _start_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? end_date
		{
			set{ _end_date=value;}
			get{return _end_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string salesman
		{
			set{ _salesman=value;}
			get{return _salesman;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? amount
		{
			set{ _amount=value;}
			get{return _amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string link_man
		{
			set{ _link_man=value;}
			get{return _link_man;}
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
		public string position
		{
			set{ _position=value;}
			get{return _position;}
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
		public int? company_id
		{
			set{ _company_id=value;}
			get{return _company_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? org_id
		{
			set{ _org_id=value;}
			get{return _org_id;}
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
		public string jctjx
		{
			set{ _jctjx=value;}
			get{return _jctjx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jxbids
		{
			set{ _jxbids=value;}
			get{return _jxbids;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string kxtjx
		{
			set{ _kxtjx=value;}
			get{return _kxtjx;}
		}
		#endregion Model

	}
}

