using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_org_contract_rel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_org_contract_rel
	{
		public t_org_contract_rel()
		{}
		#region Model
		private int _id;
		private int? _orgid;
		private string _orgname;
		private int? _contractid;
		private string _contractname;
		private string _disrate;
		private string _orgpackageids;
		private string _orgspecialtime;
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
		public int? orgid
		{
			set{ _orgid=value;}
			get{return _orgid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string orgname
		{
			set{ _orgname=value;}
			get{return _orgname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? contractid
		{
			set{ _contractid=value;}
			get{return _contractid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string contractname
		{
			set{ _contractname=value;}
			get{return _contractname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string disrate
		{
			set{ _disrate=value;}
			get{return _disrate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string orgPackageids
		{
			set{ _orgpackageids=value;}
			get{return _orgpackageids;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string orgspecialtime
		{
			set{ _orgspecialtime=value;}
			get{return _orgspecialtime;}
		}
		#endregion Model

	}
}

