﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:t_base_item_relation
	/// </summary>
	public partial class t_base_item_relation:It_base_item_relation
	{
		public t_base_item_relation()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_base_item_relation");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Decimal)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_base_item_relation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_base_item_relation(");
			strSql.Append("discription,itemAid,itemAname,itemBid,itemBname,relation,relationid)");
			strSql.Append(" values (");
			strSql.Append("@discription,@itemAid,@itemAname,@itemBid,@itemBname,@relation,@relationid)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@discription", SqlDbType.VarChar,255),
					new SqlParameter("@itemAid", SqlDbType.Decimal,9),
					new SqlParameter("@itemAname", SqlDbType.VarChar,255),
					new SqlParameter("@itemBid", SqlDbType.Decimal,9),
					new SqlParameter("@itemBname", SqlDbType.VarChar,255),
					new SqlParameter("@relation", SqlDbType.VarChar,255),
					new SqlParameter("@relationid", SqlDbType.VarChar,255)};
			parameters[0].Value = model.discription;
			parameters[1].Value = model.itemAid;
			parameters[2].Value = model.itemAname;
			parameters[3].Value = model.itemBid;
			parameters[4].Value = model.itemBname;
			parameters[5].Value = model.relation;
			parameters[6].Value = model.relationid;

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
		public bool Update(LW_AskOnline.Model.t_base_item_relation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_base_item_relation set ");
			strSql.Append("discription=@discription,");
			strSql.Append("itemAid=@itemAid,");
			strSql.Append("itemAname=@itemAname,");
			strSql.Append("itemBid=@itemBid,");
			strSql.Append("itemBname=@itemBname,");
			strSql.Append("relation=@relation,");
			strSql.Append("relationid=@relationid");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@discription", SqlDbType.VarChar,255),
					new SqlParameter("@itemAid", SqlDbType.Decimal,9),
					new SqlParameter("@itemAname", SqlDbType.VarChar,255),
					new SqlParameter("@itemBid", SqlDbType.Decimal,9),
					new SqlParameter("@itemBname", SqlDbType.VarChar,255),
					new SqlParameter("@relation", SqlDbType.VarChar,255),
					new SqlParameter("@relationid", SqlDbType.VarChar,255),
					new SqlParameter("@id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.discription;
			parameters[1].Value = model.itemAid;
			parameters[2].Value = model.itemAname;
			parameters[3].Value = model.itemBid;
			parameters[4].Value = model.itemBname;
			parameters[5].Value = model.relation;
			parameters[6].Value = model.relationid;
			parameters[7].Value = model.id;

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
		public bool Delete(decimal id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_base_item_relation ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Decimal)
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
			strSql.Append("delete from t_base_item_relation ");
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
		public LW_AskOnline.Model.t_base_item_relation GetModel(decimal id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,discription,itemAid,itemAname,itemBid,itemBname,relation,relationid from t_base_item_relation ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Decimal)
			};
			parameters[0].Value = id;

			LW_AskOnline.Model.t_base_item_relation model=new LW_AskOnline.Model.t_base_item_relation();
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
		public LW_AskOnline.Model.t_base_item_relation DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_base_item_relation model=new LW_AskOnline.Model.t_base_item_relation();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=decimal.Parse(row["id"].ToString());
				}
				if(row["discription"]!=null)
				{
					model.discription=row["discription"].ToString();
				}
				if(row["itemAid"]!=null && row["itemAid"].ToString()!="")
				{
					model.itemAid=decimal.Parse(row["itemAid"].ToString());
				}
				if(row["itemAname"]!=null)
				{
					model.itemAname=row["itemAname"].ToString();
				}
				if(row["itemBid"]!=null && row["itemBid"].ToString()!="")
				{
					model.itemBid=decimal.Parse(row["itemBid"].ToString());
				}
				if(row["itemBname"]!=null)
				{
					model.itemBname=row["itemBname"].ToString();
				}
				if(row["relation"]!=null)
				{
					model.relation=row["relation"].ToString();
				}
				if(row["relationid"]!=null)
				{
					model.relationid=row["relationid"].ToString();
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
			strSql.Append("select id,discription,itemAid,itemAname,itemBid,itemBname,relation,relationid ");
			strSql.Append(" FROM t_base_item_relation ");
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
			strSql.Append(" id,discription,itemAid,itemAname,itemBid,itemBname,relation,relationid ");
			strSql.Append(" FROM t_base_item_relation ");
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
			strSql.Append("select count(1) FROM t_base_item_relation ");
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
			strSql.Append(")AS Row, T.*  from t_base_item_relation T ");
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
			parameters[0].Value = "t_base_item_relation";
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

