using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:t_suggestion_record
	/// </summary>
	public partial class t_suggestion_record:It_suggestion_record
	{
		public t_suggestion_record()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal suggestion_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_suggestion_record");
			strSql.Append(" where suggestion_id=@suggestion_id");
			SqlParameter[] parameters = {
					new SqlParameter("@suggestion_id", SqlDbType.Decimal)
			};
			parameters[0].Value = suggestion_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_suggestion_record model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_suggestion_record(");
			strSql.Append("content,title,member_id,suggestion_time,member_name,member_type)");
			strSql.Append(" values (");
			strSql.Append("@content,@title,@member_id,@suggestion_time,@member_name,@member_type)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@content", SqlDbType.VarChar,1000),
					new SqlParameter("@title", SqlDbType.VarChar,60),
					new SqlParameter("@member_id", SqlDbType.Decimal,9),
					new SqlParameter("@suggestion_time", SqlDbType.DateTime),
					new SqlParameter("@member_name", SqlDbType.VarChar,255),
					new SqlParameter("@member_type", SqlDbType.VarChar,10)};
			parameters[0].Value = model.content;
			parameters[1].Value = model.title;
			parameters[2].Value = model.member_id;
			parameters[3].Value = model.suggestion_time;
			parameters[4].Value = model.member_name;
			parameters[5].Value = model.member_type;

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
		public bool Update(LW_AskOnline.Model.t_suggestion_record model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_suggestion_record set ");
			strSql.Append("content=@content,");
			strSql.Append("title=@title,");
			strSql.Append("member_id=@member_id,");
			strSql.Append("suggestion_time=@suggestion_time,");
			strSql.Append("member_name=@member_name,");
			strSql.Append("member_type=@member_type");
			strSql.Append(" where suggestion_id=@suggestion_id");
			SqlParameter[] parameters = {
					new SqlParameter("@content", SqlDbType.VarChar,1000),
					new SqlParameter("@title", SqlDbType.VarChar,60),
					new SqlParameter("@member_id", SqlDbType.Decimal,9),
					new SqlParameter("@suggestion_time", SqlDbType.DateTime),
					new SqlParameter("@member_name", SqlDbType.VarChar,255),
					new SqlParameter("@member_type", SqlDbType.VarChar,10),
					new SqlParameter("@suggestion_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.content;
			parameters[1].Value = model.title;
			parameters[2].Value = model.member_id;
			parameters[3].Value = model.suggestion_time;
			parameters[4].Value = model.member_name;
			parameters[5].Value = model.member_type;
			parameters[6].Value = model.suggestion_id;

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
		public bool Delete(decimal suggestion_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_suggestion_record ");
			strSql.Append(" where suggestion_id=@suggestion_id");
			SqlParameter[] parameters = {
					new SqlParameter("@suggestion_id", SqlDbType.Decimal)
			};
			parameters[0].Value = suggestion_id;

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
		public bool DeleteList(string suggestion_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_suggestion_record ");
			strSql.Append(" where suggestion_id in ("+suggestion_idlist + ")  ");
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
		public LW_AskOnline.Model.t_suggestion_record GetModel(decimal suggestion_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 suggestion_id,content,title,member_id,suggestion_time,member_name,member_type from t_suggestion_record ");
			strSql.Append(" where suggestion_id=@suggestion_id");
			SqlParameter[] parameters = {
					new SqlParameter("@suggestion_id", SqlDbType.Decimal)
			};
			parameters[0].Value = suggestion_id;

			LW_AskOnline.Model.t_suggestion_record model=new LW_AskOnline.Model.t_suggestion_record();
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
		public LW_AskOnline.Model.t_suggestion_record DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_suggestion_record model=new LW_AskOnline.Model.t_suggestion_record();
			if (row != null)
			{
				if(row["suggestion_id"]!=null && row["suggestion_id"].ToString()!="")
				{
					model.suggestion_id=decimal.Parse(row["suggestion_id"].ToString());
				}
				if(row["content"]!=null)
				{
					model.content=row["content"].ToString();
				}
				if(row["title"]!=null)
				{
					model.title=row["title"].ToString();
				}
				if(row["member_id"]!=null && row["member_id"].ToString()!="")
				{
					model.member_id=decimal.Parse(row["member_id"].ToString());
				}
				if(row["suggestion_time"]!=null && row["suggestion_time"].ToString()!="")
				{
					model.suggestion_time=DateTime.Parse(row["suggestion_time"].ToString());
				}
				if(row["member_name"]!=null)
				{
					model.member_name=row["member_name"].ToString();
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
			strSql.Append("select suggestion_id,content,title,member_id,suggestion_time,member_name,member_type ");
			strSql.Append(" FROM t_suggestion_record ");
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
			strSql.Append(" suggestion_id,content,title,member_id,suggestion_time,member_name,member_type ");
			strSql.Append(" FROM t_suggestion_record ");
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
			strSql.Append("select count(1) FROM t_suggestion_record ");
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
				strSql.Append("order by T.suggestion_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_suggestion_record T ");
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
			parameters[0].Value = "t_suggestion_record";
			parameters[1].Value = "suggestion_id";
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

