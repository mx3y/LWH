using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:ask_city
	/// </summary>
	public partial class ask_city:Iask_city
	{
		public ask_city()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("cid", "ask_city"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int cid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ask_city");
			strSql.Append(" where cid=@cid");
			SqlParameter[] parameters = {
					new SqlParameter("@cid", SqlDbType.Int,4)
			};
			parameters[0].Value = cid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(LW_AskOnline.Model.ask_city model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ask_city(");
			strSql.Append("cparent_id,cregion_grade,cregion_name,cdistrict_code,carea_code,cstatus)");
			strSql.Append(" values (");
			strSql.Append("@cparent_id,@cregion_grade,@cregion_name,@cdistrict_code,@carea_code,@cstatus)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@cparent_id", SqlDbType.Int,4),
					new SqlParameter("@cregion_grade", SqlDbType.Int,4),
					new SqlParameter("@cregion_name", SqlDbType.NVarChar,50),
					new SqlParameter("@cdistrict_code", SqlDbType.NVarChar,50),
					new SqlParameter("@carea_code", SqlDbType.NVarChar,50),
					new SqlParameter("@cstatus", SqlDbType.TinyInt,1)};
			parameters[0].Value = model.cparent_id;
			parameters[1].Value = model.cregion_grade;
			parameters[2].Value = model.cregion_name;
			parameters[3].Value = model.cdistrict_code;
			parameters[4].Value = model.carea_code;
			parameters[5].Value = model.cstatus;

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
		public bool Update(LW_AskOnline.Model.ask_city model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ask_city set ");
			strSql.Append("cparent_id=@cparent_id,");
			strSql.Append("cregion_grade=@cregion_grade,");
			strSql.Append("cregion_name=@cregion_name,");
			strSql.Append("cdistrict_code=@cdistrict_code,");
			strSql.Append("carea_code=@carea_code,");
			strSql.Append("cstatus=@cstatus");
			strSql.Append(" where cid=@cid");
			SqlParameter[] parameters = {
					new SqlParameter("@cparent_id", SqlDbType.Int,4),
					new SqlParameter("@cregion_grade", SqlDbType.Int,4),
					new SqlParameter("@cregion_name", SqlDbType.NVarChar,50),
					new SqlParameter("@cdistrict_code", SqlDbType.NVarChar,50),
					new SqlParameter("@carea_code", SqlDbType.NVarChar,50),
					new SqlParameter("@cstatus", SqlDbType.TinyInt,1),
					new SqlParameter("@cid", SqlDbType.Int,4)};
			parameters[0].Value = model.cparent_id;
			parameters[1].Value = model.cregion_grade;
			parameters[2].Value = model.cregion_name;
			parameters[3].Value = model.cdistrict_code;
			parameters[4].Value = model.carea_code;
			parameters[5].Value = model.cstatus;
			parameters[6].Value = model.cid;

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
		public bool Delete(int cid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ask_city ");
			strSql.Append(" where cid=@cid");
			SqlParameter[] parameters = {
					new SqlParameter("@cid", SqlDbType.Int,4)
			};
			parameters[0].Value = cid;

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
		public bool DeleteList(string cidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ask_city ");
			strSql.Append(" where cid in ("+cidlist + ")  ");
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
		public LW_AskOnline.Model.ask_city GetModel(int cid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 cid,cparent_id,cregion_grade,cregion_name,cdistrict_code,carea_code,cstatus from ask_city ");
			strSql.Append(" where cid=@cid");
			SqlParameter[] parameters = {
					new SqlParameter("@cid", SqlDbType.Int,4)
			};
			parameters[0].Value = cid;

			LW_AskOnline.Model.ask_city model=new LW_AskOnline.Model.ask_city();
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
		public LW_AskOnline.Model.ask_city DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.ask_city model=new LW_AskOnline.Model.ask_city();
			if (row != null)
			{
				if(row["cid"]!=null && row["cid"].ToString()!="")
				{
					model.cid=int.Parse(row["cid"].ToString());
				}
				if(row["cparent_id"]!=null && row["cparent_id"].ToString()!="")
				{
					model.cparent_id=int.Parse(row["cparent_id"].ToString());
				}
				if(row["cregion_grade"]!=null && row["cregion_grade"].ToString()!="")
				{
					model.cregion_grade=int.Parse(row["cregion_grade"].ToString());
				}
				if(row["cregion_name"]!=null)
				{
					model.cregion_name=row["cregion_name"].ToString();
				}
				if(row["cdistrict_code"]!=null)
				{
					model.cdistrict_code=row["cdistrict_code"].ToString();
				}
				if(row["carea_code"]!=null)
				{
					model.carea_code=row["carea_code"].ToString();
				}
				if(row["cstatus"]!=null && row["cstatus"].ToString()!="")
				{
					model.cstatus=int.Parse(row["cstatus"].ToString());
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
			strSql.Append("select cid,cparent_id,cregion_grade,cregion_name,cdistrict_code,carea_code,cstatus ");
			strSql.Append(" FROM ask_city ");
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
			strSql.Append(" cid,cparent_id,cregion_grade,cregion_name,cdistrict_code,carea_code,cstatus ");
			strSql.Append(" FROM ask_city ");
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
			strSql.Append("select count(1) FROM ask_city ");
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
				strSql.Append("order by T.cid desc");
			}
			strSql.Append(")AS Row, T.*  from ask_city T ");
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
			parameters[0].Value = "ask_city";
			parameters[1].Value = "cid";
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

