﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:t_trading_account_record
	/// </summary>
	public partial class t_trading_account_record
	{
		public t_trading_account_record()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal record_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_trading_account_record");
			strSql.Append(" where record_id=@record_id");
			SqlParameter[] parameters = {
					new SqlParameter("@record_id", SqlDbType.Decimal)
			};
			parameters[0].Value = record_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_trading_account_record model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_trading_account_record(");
			strSql.Append("amount,trade_balance,trade_time,trade_type,account_id,busi_type,member_id,remark,order_id,member_type)");
			strSql.Append(" values (");
			strSql.Append("@amount,@trade_balance,@trade_time,@trade_type,@account_id,@busi_type,@member_id,@remark,@order_id,@member_type)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@amount", SqlDbType.Float,8),
					new SqlParameter("@trade_balance", SqlDbType.Float,8),
					new SqlParameter("@trade_time", SqlDbType.DateTime),
					new SqlParameter("@trade_type", SqlDbType.VarChar,10),
					new SqlParameter("@account_id", SqlDbType.Decimal,9),
					new SqlParameter("@busi_type", SqlDbType.VarChar,10),
					new SqlParameter("@member_id", SqlDbType.Decimal,9),
					new SqlParameter("@remark", SqlDbType.VarChar,500),
					new SqlParameter("@order_id", SqlDbType.VarBinary,255),
					new SqlParameter("@member_type", SqlDbType.VarChar,10)};
			parameters[0].Value = model.amount;
			parameters[1].Value = model.trade_balance;
			parameters[2].Value = model.trade_time;
			parameters[3].Value = model.trade_type;
			parameters[4].Value = model.account_id;
			parameters[5].Value = model.busi_type;
			parameters[6].Value = model.member_id;
			parameters[7].Value = model.remark;
			parameters[8].Value = model.order_id;
			parameters[9].Value = model.member_type;

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
		public bool Update(LW_AskOnline.Model.t_trading_account_record model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_trading_account_record set ");
			strSql.Append("amount=@amount,");
			strSql.Append("trade_balance=@trade_balance,");
			strSql.Append("trade_time=@trade_time,");
			strSql.Append("trade_type=@trade_type,");
			strSql.Append("account_id=@account_id,");
			strSql.Append("busi_type=@busi_type,");
			strSql.Append("member_id=@member_id,");
			strSql.Append("remark=@remark,");
			strSql.Append("order_id=@order_id,");
			strSql.Append("member_type=@member_type");
			strSql.Append(" where record_id=@record_id");
			SqlParameter[] parameters = {
					new SqlParameter("@amount", SqlDbType.Float,8),
					new SqlParameter("@trade_balance", SqlDbType.Float,8),
					new SqlParameter("@trade_time", SqlDbType.DateTime),
					new SqlParameter("@trade_type", SqlDbType.VarChar,10),
					new SqlParameter("@account_id", SqlDbType.Decimal,9),
					new SqlParameter("@busi_type", SqlDbType.VarChar,10),
					new SqlParameter("@member_id", SqlDbType.Decimal,9),
					new SqlParameter("@remark", SqlDbType.VarChar,500),
					new SqlParameter("@order_id", SqlDbType.VarBinary,255),
					new SqlParameter("@member_type", SqlDbType.VarChar,10),
					new SqlParameter("@record_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.amount;
			parameters[1].Value = model.trade_balance;
			parameters[2].Value = model.trade_time;
			parameters[3].Value = model.trade_type;
			parameters[4].Value = model.account_id;
			parameters[5].Value = model.busi_type;
			parameters[6].Value = model.member_id;
			parameters[7].Value = model.remark;
			parameters[8].Value = model.order_id;
			parameters[9].Value = model.member_type;
			parameters[10].Value = model.record_id;

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
		public bool Delete(decimal record_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_trading_account_record ");
			strSql.Append(" where record_id=@record_id");
			SqlParameter[] parameters = {
					new SqlParameter("@record_id", SqlDbType.Decimal)
			};
			parameters[0].Value = record_id;

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
		public bool DeleteList(string record_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_trading_account_record ");
			strSql.Append(" where record_id in ("+record_idlist + ")  ");
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
		public LW_AskOnline.Model.t_trading_account_record GetModel(decimal record_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 record_id,amount,trade_balance,trade_time,trade_type,account_id,busi_type,member_id,remark,order_id,member_type from t_trading_account_record ");
			strSql.Append(" where record_id=@record_id");
			SqlParameter[] parameters = {
					new SqlParameter("@record_id", SqlDbType.Decimal)
			};
			parameters[0].Value = record_id;

			LW_AskOnline.Model.t_trading_account_record model=new LW_AskOnline.Model.t_trading_account_record();
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
		public LW_AskOnline.Model.t_trading_account_record DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_trading_account_record model=new LW_AskOnline.Model.t_trading_account_record();
			if (row != null)
			{
				if(row["record_id"]!=null && row["record_id"].ToString()!="")
				{
					model.record_id=decimal.Parse(row["record_id"].ToString());
				}
				if(row["amount"]!=null && row["amount"].ToString()!="")
				{
					model.amount=decimal.Parse(row["amount"].ToString());
				}
				if(row["trade_balance"]!=null && row["trade_balance"].ToString()!="")
				{
					model.trade_balance=decimal.Parse(row["trade_balance"].ToString());
				}
				if(row["trade_time"]!=null && row["trade_time"].ToString()!="")
				{
					model.trade_time=DateTime.Parse(row["trade_time"].ToString());
				}
				if(row["trade_type"]!=null)
				{
					model.trade_type=row["trade_type"].ToString();
				}
				if(row["account_id"]!=null && row["account_id"].ToString()!="")
				{
					model.account_id=decimal.Parse(row["account_id"].ToString());
				}
				if(row["busi_type"]!=null)
				{
					model.busi_type=row["busi_type"].ToString();
				}
				if(row["member_id"]!=null && row["member_id"].ToString()!="")
				{
					model.member_id=decimal.Parse(row["member_id"].ToString());
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
				}
				if(row["order_id"]!=null && row["order_id"].ToString()!="")
				{
					model.order_id=(byte[])row["order_id"];
				}
				if(row["member_type"]!=null)
				{
					model.member_type=row["member_type"].ToString();
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
			strSql.Append("select record_id,amount,trade_balance,trade_time,trade_type,account_id,busi_type,member_id,remark,order_id,member_type ");
			strSql.Append(" FROM t_trading_account_record ");
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
			strSql.Append(" record_id,amount,trade_balance,trade_time,trade_type,account_id,busi_type,member_id,remark,order_id,member_type ");
			strSql.Append(" FROM t_trading_account_record ");
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
			strSql.Append("select count(1) FROM t_trading_account_record ");
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
				strSql.Append("order by T.record_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_trading_account_record T ");
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
			parameters[0].Value = "t_trading_account_record";
			parameters[1].Value = "record_id";
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

