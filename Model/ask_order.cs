using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// ask_order:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ask_order
	{
		public ask_order()
		{}
		#region Model
		private int _oid;
		private int _ouid;
		private int _odid;
		private int _otype;
		private int _oresult;
		private int _ostate;
		private DateTime _ocreatetime;
		private DateTime _ocommittime;
		private decimal _opublicmonery;
		private decimal _oprivatemonery;
		private decimal _ototalmonery;
		private int _otransid;
		private string _ocallresult;
		private string _ocallid;
		private string _ocalldate;
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
		public int ouid
		{
			set{ _ouid=value;}
			get{return _ouid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int odid
		{
			set{ _odid=value;}
			get{return _odid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int otype
		{
			set{ _otype=value;}
			get{return _otype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int oresult
		{
			set{ _oresult=value;}
			get{return _oresult;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ostate
		{
			set{ _ostate=value;}
			get{return _ostate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ocreatetime
		{
			set{ _ocreatetime=value;}
			get{return _ocreatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ocommittime
		{
			set{ _ocommittime=value;}
			get{return _ocommittime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal opublicmonery
		{
			set{ _opublicmonery=value;}
			get{return _opublicmonery;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal oprivatemonery
		{
			set{ _oprivatemonery=value;}
			get{return _oprivatemonery;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal ototalmonery
		{
			set{ _ototalmonery=value;}
			get{return _ototalmonery;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int otransid
		{
			set{ _otransid=value;}
			get{return _otransid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ocallresult
		{
			set{ _ocallresult=value;}
			get{return _ocallresult;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ocallid
		{
			set{ _ocallid=value;}
			get{return _ocallid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ocalldate
		{
			set{ _ocalldate=value;}
			get{return _ocalldate;}
		}
		#endregion Model

	}
}

