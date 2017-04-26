using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using LW_AskOnline.Model;
using LW_AskOnline.DALFactory;
using LW_AskOnline.IDAL;
namespace LW_AskOnline.BLL
{
	/// <summary>
	/// ask_master
	/// </summary>
	public partial class ask_master
	{
		private readonly Iask_master dal=DataAccess.Createask_master();
		public ask_master()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int mid)
		{
			return dal.Exists(mid);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(LW_AskOnline.Model.ask_master model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(LW_AskOnline.Model.ask_master model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int mid)
		{
			
			return dal.Delete(mid);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string midlist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(midlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public LW_AskOnline.Model.ask_master GetModel(int mid)
		{
			
			return dal.GetModel(mid);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public LW_AskOnline.Model.ask_master GetModelByCache(int mid)
		{
			
			string CacheKey = "ask_masterModel-" + mid;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(mid);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (LW_AskOnline.Model.ask_master)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<LW_AskOnline.Model.ask_master> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<LW_AskOnline.Model.ask_master> DataTableToList(DataTable dt)
		{
			List<LW_AskOnline.Model.ask_master> modelList = new List<LW_AskOnline.Model.ask_master>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				LW_AskOnline.Model.ask_master model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

