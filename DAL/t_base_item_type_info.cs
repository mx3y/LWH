﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:t_base_item_type_info
	/// </summary>
	public partial class t_base_item_type_info
	{
		public t_base_item_type_info()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public long Add(LW_AskOnline.Model.t_base_item_type_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_base_item_type_info(");
			strSql.Append("type_code,type_name,paixu)");
			strSql.Append(" values (");
			strSql.Append("@type_code,@type_name,@paixu)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@type_code", SqlDbType.VarChar,20),
					new SqlParameter("@type_name", SqlDbType.VarChar,50),
					new SqlParameter("@paixu", SqlDbType.Decimal,9)};
			parameters[0].Value = model.type_code;
			parameters[1].Value = model.type_name;
			parameters[2].Value = model.paixu;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt64(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(LW_AskOnline.Model.t_base_item_type_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_base_item_type_info set ");
			strSql.Append("type_code=@type_code,");
			strSql.Append("type_name=@type_name,");
			strSql.Append("paixu=@paixu");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@type_code", SqlDbType.VarChar,20),
					new SqlParameter("@type_name", SqlDbType.VarChar,50),
					new SqlParameter("@paixu", SqlDbType.Decimal,9),
					new SqlParameter("@id", SqlDbType.BigInt,8)};
			parameters[0].Value = model.type_code;
			parameters[1].Value = model.type_name;
			parameters[2].Value = model.paixu;
			parameters[3].Value = model.id;

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
		public bool Delete(long id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_base_item_type_info ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.BigInt)
			};
			parameters[0].Value = id;

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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_base_item_type_info ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public LW_AskOnline.Model.t_base_item_type_info GetModel(long id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,type_code,type_name,paixu from t_base_item_type_info ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.BigInt)
			};
			parameters[0].Value = id;

			LW_AskOnline.Model.t_base_item_type_info model=new LW_AskOnline.Model.t_base_item_type_info();
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
		public LW_AskOnline.Model.t_base_item_type_info DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_base_item_type_info model=new LW_AskOnline.Model.t_base_item_type_info();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=long.Parse(row["id"].ToString());
				}
				if(row["type_code"]!=null)
				{
					model.type_code=row["type_code"].ToString();
				}
				if(row["type_name"]!=null)
				{
					model.type_name=row["type_name"].ToString();
				}
				if(row["paixu"]!=null && row["paixu"].ToString()!="")
				{
					model.paixu=decimal.Parse(row["paixu"].ToString());
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
			strSql.Append("select id,type_code,type_name,paixu ");
			strSql.Append(" FROM t_base_item_type_info ");
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
			strSql.Append(" id,type_code,type_name,paixu ");
			strSql.Append(" FROM t_base_item_type_info ");
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
			strSql.Append("select count(1) FROM t_base_item_type_info ");
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
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from t_base_item_type_info T ");
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
			parameters[0].Value = "t_base_item_type_info";
			parameters[1].Value = "id";
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

