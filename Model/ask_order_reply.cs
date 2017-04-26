using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// ask_order_reply:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ask_order_reply
	{
		public ask_order_reply()
		{}
		#region Model
		private int _orid;
		private int _oid;
		private int _did;
		private int _uuid;
		private string _orcontent;
		private DateTime? _ordate;
		private int? _orstate;
		/// <summary>
		/// 
		/// </summary>
		public int orid
		{
			set{ _orid=value;}
			get{return _orid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int oid
		{
			set{ _oid=value;}
			get{return _oid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int did
		{
			set{ _did=value;}
			get{return _did;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int uuid
		{
			set{ _uuid=value;}
			get{return _uuid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string orcontent
		{
			set{ _orcontent=value;}
			get{return _orcontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ordate
		{
			set{ _ordate=value;}
			get{return _ordate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? orstate
		{
			set{ _orstate=value;}
			get{return _orstate;}
		}
		#endregion Model

	}
}

