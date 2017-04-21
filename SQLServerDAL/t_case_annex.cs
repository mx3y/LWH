using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:t_case_annex
	/// </summary>
	public partial class t_case_annex:It_case_annex
	{
		public t_case_annex()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal annex_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_case_annex");
			strSql.Append(" where annex_id=@annex_id");
			SqlParameter[] parameters = {
					new SqlParameter("@annex_id", SqlDbType.Decimal)
			};
			parameters[0].Value = annex_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_case_annex model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_case_annex(");
			strSql.Append("file_name,file_path,file_type,case_id)");
			strSql.Append(" values (");
			strSql.Append("@file_name,@file_path,@file_type,@case_id)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@file_name", SqlDbType.VarChar,100),
					new SqlParameter("@file_path", SqlDbType.VarChar,200),
					new SqlParameter("@file_type", SqlDbType.VarChar,2),
					new SqlParameter("@case_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.file_name;
			parameters[1].Value = model.file_path;
			parameters[2].Value = model.file_type;
			parameters[3].Value = model.case_id;

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
		public bool Update(LW_AskOnline.Model.t_case_annex model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_case_annex set ");
			strSql.Append("file_name=@file_name,");
			strSql.Append("file_path=@file_path,");
			strSql.Append("file_type=@file_type,");
			strSql.Append("case_id=@case_id");
			strSql.Append(" where annex_id=@annex_id");
			SqlParameter[] parameters = {
					new SqlParameter("@file_name", SqlDbType.VarChar,100),
					new SqlParameter("@file_path", SqlDbType.VarChar,200),
					new SqlParameter("@file_type", SqlDbType.VarChar,2),
					new SqlParameter("@case_id", SqlDbType.Decimal,9),
					new SqlParameter("@annex_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.file_name;
			parameters[1].Value = model.file_path;
			parameters[2].Value = model.file_type;
			parameters[3].Value = model.case_id;
			parameters[4].Value = model.annex_id;

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
		public bool Delete(decimal annex_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_case_annex ");
			strSql.Append(" where annex_id=@annex_id");
			SqlParameter[] parameters = {
					new SqlParameter("@annex_id", SqlDbType.Decimal)
			};
			parameters[0].Value = annex_id;

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
		public bool DeleteList(string annex_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_case_annex ");
			strSql.Append(" where annex_id in ("+annex_idlist + ")  ");
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
		public LW_AskOnline.Model.t_case_annex GetModel(decimal annex_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 annex_id,file_name,file_path,file_type,case_id from t_case_annex ");
			strSql.Append(" where annex_id=@annex_id");
			SqlParameter[] parameters = {
					new SqlParameter("@annex_id", SqlDbType.Decimal)
			};
			parameters[0].Value = annex_id;

			LW_AskOnline.Model.t_case_annex model=new LW_AskOnline.Model.t_case_annex();
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
		public LW_AskOnline.Model.t_case_annex DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_case_annex model=new LW_AskOnline.Model.t_case_annex();
			if (row != null)
			{
				if(row["annex_id"]!=null && row["annex_id"].ToString()!="")
				{
					model.annex_id=decimal.Parse(row["annex_id"].ToString());
				}
				if(row["file_name"]!=null)
				{
					model.file_name=row["file_name"].ToString();
				}
				if(row["file_path"]!=null)
				{
					model.file_path=row["file_path"].ToString();
				}
				if(row["file_type"]!=null)
				{
					model.file_type=row["file_type"].ToString();
				}
				if(row["case_id"]!=null && row["case_id"].ToString()!="")
				{
					model.case_id=decimal.Parse(row["case_id"].ToString());
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
			strSql.Append("select annex_id,file_name,file_path,file_type,case_id ");
			strSql.Append(" FROM t_case_annex ");
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
			strSql.Append(" annex_id,file_name,file_path,file_type,case_id ");
			strSql.Append(" FROM t_case_annex ");
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
			strSql.Append("select count(1) FROM t_case_annex ");
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
				strSql.Append("order by T.annex_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_case_annex T ");
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
			parameters[0].Value = "t_case_annex";
			parameters[1].Value = "annex_id";
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

