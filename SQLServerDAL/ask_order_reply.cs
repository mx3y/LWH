using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:ask_order_reply
	/// </summary>
	public partial class ask_order_reply:Iask_order_reply
	{
		public ask_order_reply()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("orid", "ask_order_reply"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int orid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ask_order_reply");
			strSql.Append(" where orid=@orid");
			SqlParameter[] parameters = {
					new SqlParameter("@orid", SqlDbType.Int,4)
			};
			parameters[0].Value = orid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(LW_AskOnline.Model.ask_order_reply model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ask_order_reply(");
			strSql.Append("oid,did,uuid,orcontent,ordate,orstate)");
			strSql.Append(" values (");
			strSql.Append("@oid,@did,@uuid,@orcontent,@ordate,@orstate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@oid", SqlDbType.Int,4),
					new SqlParameter("@did", SqlDbType.Int,4),
					new SqlParameter("@uuid", SqlDbType.Int,4),
					new SqlParameter("@orcontent", SqlDbType.NVarChar,200),
					new SqlParameter("@ordate", SqlDbType.DateTime),
					new SqlParameter("@orstate", SqlDbType.TinyInt,1)};
			parameters[0].Value = model.oid;
			parameters[1].Value = model.did;
			parameters[2].Value = model.uuid;
			parameters[3].Value = model.orcontent;
			parameters[4].Value = model.ordate;
			parameters[5].Value = model.orstate;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(LW_AskOnline.Model.ask_order_reply model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ask_order_reply set ");
			strSql.Append("oid=@oid,");
			strSql.Append("did=@did,");
			strSql.Append("uuid=@uuid,");
			strSql.Append("orcontent=@orcontent,");
			strSql.Append("ordate=@ordate,");
			strSql.Append("orstate=@orstate");
			strSql.Append(" where orid=@orid");
			SqlParameter[] parameters = {
					new SqlParameter("@oid", SqlDbType.Int,4),
					new SqlParameter("@did", SqlDbType.Int,4),
					new SqlParameter("@uuid", SqlDbType.Int,4),
					new SqlParameter("@orcontent", SqlDbType.NVarChar,200),
					new SqlParameter("@ordate", SqlDbType.DateTime),
					new SqlParameter("@orstate", SqlDbType.TinyInt,1),
					new SqlParameter("@orid", SqlDbType.Int,4)};
			parameters[0].Value = model.oid;
			parameters[1].Value = model.did;
			parameters[2].Value = model.uuid;
			parameters[3].Value = model.orcontent;
			parameters[4].Value = model.ordate;
			parameters[5].Value = model.orstate;
			parameters[6].Value = model.orid;

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
		public bool Delete(int orid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ask_order_reply ");
			strSql.Append(" where orid=@orid");
			SqlParameter[] parameters = {
					new SqlParameter("@orid", SqlDbType.Int,4)
			};
			parameters[0].Value = orid;

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
		public bool DeleteList(string oridlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ask_order_reply ");
			strSql.Append(" where orid in ("+oridlist + ")  ");
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
		public LW_AskOnline.Model.ask_order_reply GetModel(int orid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 orid,oid,did,uuid,orcontent,ordate,orstate from ask_order_reply ");
			strSql.Append(" where orid=@orid");
			SqlParameter[] parameters = {
					new SqlParameter("@orid", SqlDbType.Int,4)
			};
			parameters[0].Value = orid;

			LW_AskOnline.Model.ask_order_reply model=new LW_AskOnline.Model.ask_order_reply();
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
		public LW_AskOnline.Model.ask_order_reply DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.ask_order_reply model=new LW_AskOnline.Model.ask_order_reply();
			if (row != null)
			{
				if(row["orid"]!=null && row["orid"].ToString()!="")
				{
					model.orid=int.Parse(row["orid"].ToString());
				}
				if(row["oid"]!=null && row["oid"].ToString()!="")
				{
					model.oid=int.Parse(row["oid"].ToString());
				}
				if(row["did"]!=null && row["did"].ToString()!="")
				{
					model.did=int.Parse(row["did"].ToString());
				}
				if(row["uuid"]!=null && row["uuid"].ToString()!="")
				{
					model.uuid=int.Parse(row["uuid"].ToString());
				}
				if(row["orcontent"]!=null)
				{
					model.orcontent=row["orcontent"].ToString();
				}
				if(row["ordate"]!=null && row["ordate"].ToString()!="")
				{
					model.ordate=DateTime.Parse(row["ordate"].ToString());
				}
				if(row["orstate"]!=null && row["orstate"].ToString()!="")
				{
					model.orstate=int.Parse(row["orstate"].ToString());
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
			strSql.Append("select orid,oid,did,uuid,orcontent,ordate,orstate ");
			strSql.Append(" FROM ask_order_reply ");
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
			strSql.Append(" orid,oid,did,uuid,orcontent,ordate,orstate ");
			strSql.Append(" FROM ask_order_reply ");
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
			strSql.Append("select count(1) FROM ask_order_reply ");
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
				strSql.Append("order by T.orid desc");
			}
			strSql.Append(")AS Row, T.*  from ask_order_reply T ");
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
			parameters[0].Value = "ask_order_reply";
			parameters[1].Value = "orid";
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

