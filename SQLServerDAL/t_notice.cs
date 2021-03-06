﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:t_notice
	/// </summary>
	public partial class t_notice:It_notice
	{
		public t_notice()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal msg_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_notice");
			strSql.Append(" where msg_id=@msg_id");
			SqlParameter[] parameters = {
					new SqlParameter("@msg_id", SqlDbType.Decimal)
			};
			parameters[0].Value = msg_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_notice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_notice(");
			strSql.Append("message,send_time,title,type)");
			strSql.Append(" values (");
			strSql.Append("@message,@send_time,@title,@type)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@message", SqlDbType.VarChar,400),
					new SqlParameter("@send_time", SqlDbType.DateTime),
					new SqlParameter("@title", SqlDbType.VarChar,40),
					new SqlParameter("@type", SqlDbType.VarChar,4)};
			parameters[0].Value = model.message;
			parameters[1].Value = model.send_time;
			parameters[2].Value = model.title;
			parameters[3].Value = model.type;

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
		public bool Update(LW_AskOnline.Model.t_notice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_notice set ");
			strSql.Append("message=@message,");
			strSql.Append("send_time=@send_time,");
			strSql.Append("title=@title,");
			strSql.Append("type=@type");
			strSql.Append(" where msg_id=@msg_id");
			SqlParameter[] parameters = {
					new SqlParameter("@message", SqlDbType.VarChar,400),
					new SqlParameter("@send_time", SqlDbType.DateTime),
					new SqlParameter("@title", SqlDbType.VarChar,40),
					new SqlParameter("@type", SqlDbType.VarChar,4),
					new SqlParameter("@msg_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.message;
			parameters[1].Value = model.send_time;
			parameters[2].Value = model.title;
			parameters[3].Value = model.type;
			parameters[4].Value = model.msg_id;

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
		public bool Delete(decimal msg_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_notice ");
			strSql.Append(" where msg_id=@msg_id");
			SqlParameter[] parameters = {
					new SqlParameter("@msg_id", SqlDbType.Decimal)
			};
			parameters[0].Value = msg_id;

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
		public bool DeleteList(string msg_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_notice ");
			strSql.Append(" where msg_id in ("+msg_idlist + ")  ");
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
		public LW_AskOnline.Model.t_notice GetModel(decimal msg_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 msg_id,message,send_time,title,type from t_notice ");
			strSql.Append(" where msg_id=@msg_id");
			SqlParameter[] parameters = {
					new SqlParameter("@msg_id", SqlDbType.Decimal)
			};
			parameters[0].Value = msg_id;

			LW_AskOnline.Model.t_notice model=new LW_AskOnline.Model.t_notice();
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
		public LW_AskOnline.Model.t_notice DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_notice model=new LW_AskOnline.Model.t_notice();
			if (row != null)
			{
				if(row["msg_id"]!=null && row["msg_id"].ToString()!="")
				{
					model.msg_id=decimal.Parse(row["msg_id"].ToString());
				}
				if(row["message"]!=null)
				{
					model.message=row["message"].ToString();
				}
				if(row["send_time"]!=null && row["send_time"].ToString()!="")
				{
					model.send_time=DateTime.Parse(row["send_time"].ToString());
				}
				if(row["title"]!=null)
				{
					model.title=row["title"].ToString();
				}
				if(row["type"]!=null)
				{
					model.type=row["type"].ToString();
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
			strSql.Append("select msg_id,message,send_time,title,type ");
			strSql.Append(" FROM t_notice ");
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
			strSql.Append(" msg_id,message,send_time,title,type ");
			strSql.Append(" FROM t_notice ");
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
			strSql.Append("select count(1) FROM t_notice ");
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
				strSql.Append("order by T.msg_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_notice T ");
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
			parameters[0].Value = "t_notice";
			parameters[1].Value = "msg_id";
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

