﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:t_news_column
	/// </summary>
	public partial class t_news_column:It_news_column
	{
		public t_news_column()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal column_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_news_column");
			strSql.Append(" where column_id=@column_id");
			SqlParameter[] parameters = {
					new SqlParameter("@column_id", SqlDbType.Decimal)
			};
			parameters[0].Value = column_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_news_column model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_news_column(");
			strSql.Append("column_code,column_name,remark)");
			strSql.Append(" values (");
			strSql.Append("@column_code,@column_name,@remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@column_code", SqlDbType.VarChar,20),
					new SqlParameter("@column_name", SqlDbType.VarChar,50),
					new SqlParameter("@remark", SqlDbType.VarChar,500)};
			parameters[0].Value = model.column_code;
			parameters[1].Value = model.column_name;
			parameters[2].Value = model.remark;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToDecimal(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(LW_AskOnline.Model.t_news_column model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_news_column set ");
			strSql.Append("column_code=@column_code,");
			strSql.Append("column_name=@column_name,");
			strSql.Append("remark=@remark");
			strSql.Append(" where column_id=@column_id");
			SqlParameter[] parameters = {
					new SqlParameter("@column_code", SqlDbType.VarChar,20),
					new SqlParameter("@column_name", SqlDbType.VarChar,50),
					new SqlParameter("@remark", SqlDbType.VarChar,500),
					new SqlParameter("@column_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.column_code;
			parameters[1].Value = model.column_name;
			parameters[2].Value = model.remark;
			parameters[3].Value = model.column_id;

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
		public bool Delete(decimal column_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_news_column ");
			strSql.Append(" where column_id=@column_id");
			SqlParameter[] parameters = {
					new SqlParameter("@column_id", SqlDbType.Decimal)
			};
			parameters[0].Value = column_id;

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
		public bool DeleteList(string column_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_news_column ");
			strSql.Append(" where column_id in ("+column_idlist + ")  ");
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
		public LW_AskOnline.Model.t_news_column GetModel(decimal column_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 column_id,column_code,column_name,remark from t_news_column ");
			strSql.Append(" where column_id=@column_id");
			SqlParameter[] parameters = {
					new SqlParameter("@column_id", SqlDbType.Decimal)
			};
			parameters[0].Value = column_id;

			LW_AskOnline.Model.t_news_column model=new LW_AskOnline.Model.t_news_column();
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
		public LW_AskOnline.Model.t_news_column DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_news_column model=new LW_AskOnline.Model.t_news_column();
			if (row != null)
			{
				if(row["column_id"]!=null && row["column_id"].ToString()!="")
				{
					model.column_id=decimal.Parse(row["column_id"].ToString());
				}
				if(row["column_code"]!=null)
				{
					model.column_code=row["column_code"].ToString();
				}
				if(row["column_name"]!=null)
				{
					model.column_name=row["column_name"].ToString();
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
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
			strSql.Append("select column_id,column_code,column_name,remark ");
			strSql.Append(" FROM t_news_column ");
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
			strSql.Append(" column_id,column_code,column_name,remark ");
			strSql.Append(" FROM t_news_column ");
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
			strSql.Append("select count(1) FROM t_news_column ");
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
				strSql.Append("order by T.column_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_news_column T ");
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
			parameters[0].Value = "t_news_column";
			parameters[1].Value = "column_id";
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

