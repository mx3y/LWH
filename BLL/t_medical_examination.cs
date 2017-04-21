﻿using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using LW_AskOnline.Model;
using LW_AskOnline.DALFactory;
using LW_AskOnline.IDAL;
namespace LW_AskOnline.BLL
{
	/// <summary>
	/// t_medical_examination
	/// </summary>
	public partial class t_medical_examination
	{
		private readonly It_medical_examination dal=DataAccess.Createt_medical_examination();
		public t_medical_examination()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal medical_id)
		{
			return dal.Exists(medical_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_medical_examination model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(LW_AskOnline.Model.t_medical_examination model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(decimal medical_id)
		{
			
			return dal.Delete(medical_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string medical_idlist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(medical_idlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public LW_AskOnline.Model.t_medical_examination GetModel(decimal medical_id)
		{
			
			return dal.GetModel(medical_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public LW_AskOnline.Model.t_medical_examination GetModelByCache(decimal medical_id)
		{
			
			string CacheKey = "t_medical_examinationModel-" + medical_id;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(medical_id);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (LW_AskOnline.Model.t_medical_examination)objModel;
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
		public List<LW_AskOnline.Model.t_medical_examination> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<LW_AskOnline.Model.t_medical_examination> DataTableToList(DataTable dt)
		{
			List<LW_AskOnline.Model.t_medical_examination> modelList = new List<LW_AskOnline.Model.t_medical_examination>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				LW_AskOnline.Model.t_medical_examination model;
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

