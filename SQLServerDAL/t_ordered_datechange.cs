using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:t_ordered_datechange
	/// </summary>
	public partial class t_ordered_datechange:It_ordered_datechange
	{
		public t_ordered_datechange()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(LW_AskOnline.Model.t_ordered_datechange model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_ordered_datechange(");
			strSql.Append("tco_id,tco_uid,old_order_date,new_order_data,chnage_date)");
			strSql.Append(" values (");
			strSql.Append("@tco_id,@tco_uid,@old_order_date,@new_order_data,@chnage_date)");
			SqlParameter[] parameters = {
					new SqlParameter("@tco_id", SqlDbType.Int,4),
					new SqlParameter("@tco_uid", SqlDbType.Int,4),
					new SqlParameter("@old_order_date", SqlDbType.DateTime),
					new SqlParameter("@new_order_data", SqlDbType.DateTime),
					new SqlParameter("@chnage_date", SqlDbType.DateTime)};
			parameters[0].Value = model.tco_id;
			parameters[1].Value = model.tco_uid;
			parameters[2].Value = model.old_order_date;
			parameters[3].Value = model.new_order_data;
			parameters[4].Value = model.chnage_date;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(LW_AskOnline.Model.t_ordered_datechange model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_ordered_datechange set ");
			strSql.Append("tco_id=@tco_id,");
			strSql.Append("tco_uid=@tco_uid,");
			strSql.Append("old_order_date=@old_order_date,");
			strSql.Append("new_order_data=@new_order_data,");
			strSql.Append("chnage_date=@chnage_date");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@tco_id", SqlDbType.Int,4),
					new SqlParameter("@tco_uid", SqlDbType.Int,4),
					new SqlParameter("@old_order_date", SqlDbType.DateTime),
					new SqlParameter("@new_order_data", SqlDbType.DateTime),
					new SqlParameter("@chnage_date", SqlDbType.DateTime)};
			parameters[0].Value = model.tco_id;
			parameters[1].Value = model.tco_uid;
			parameters[2].Value = model.old_order_date;
			parameters[3].Value = model.new_order_data;
			parameters[4].Value = model.chnage_date;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_ordered_datechange ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public LW_AskOnline.Model.t_ordered_datechange GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 tco_id,tco_uid,old_order_date,new_order_data,chnage_date from t_ordered_datechange ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			LW_AskOnline.Model.t_ordered_datechange model=new LW_AskOnline.Model.t_ordered_datechange();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public LW_AskOnline.Model.t_ordered_datechange DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_ordered_datechange model=new LW_AskOnline.Model.t_ordered_datechange();
			if (row != null)
			{
				if(row["tco_id"]!=null && row["tco_id"].ToString()!="")
				{
					model.tco_id=int.Parse(row["tco_id"].ToString());
				}
				if(row["tco_uid"]!=null && row["tco_uid"].ToString()!="")
				{
					model.tco_uid=int.Parse(row["tco_uid"].ToString());
				}
				if(row["old_order_date"]!=null && row["old_order_date"].ToString()!="")
				{
					model.old_order_date=DateTime.Parse(row["old_order_date"].ToString());
				}
				if(row["new_order_data"]!=null && row["new_order_data"].ToString()!="")
				{
					model.new_order_data=DateTime.Parse(row["new_order_data"].ToString());
				}
				if(row["chnage_date"]!=null && row["chnage_date"].ToString()!="")
				{
					model.chnage_date=DateTime.Parse(row["chnage_date"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select tco_id,tco_uid,old_order_date,new_order_data,chnage_date ");
			strSql.Append(" FROM t_ordered_datechange ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" tco_id,tco_uid,old_order_date,new_order_data,chnage_date ");
			strSql.Append(" FROM t_ordered_datechange ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM t_ordered_datechange ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.order_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_ordered_datechange T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "t_ordered_datechange";
			parameters[1].Value = "order_id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

