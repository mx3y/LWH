using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:t_medical_report
	/// </summary>
	public partial class t_medical_report:It_medical_report
	{
		public t_medical_report()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal report_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_medical_report");
			strSql.Append(" where report_id=@report_id");
			SqlParameter[] parameters = {
					new SqlParameter("@report_id", SqlDbType.Decimal)
			};
			parameters[0].Value = report_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_medical_report model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_medical_report(");
			strSql.Append("check_date,check_man,inspection_date,inspection_man,project_type,medical_id)");
			strSql.Append(" values (");
			strSql.Append("@check_date,@check_man,@inspection_date,@inspection_man,@project_type,@medical_id)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@check_date", SqlDbType.VarChar,10),
					new SqlParameter("@check_man", SqlDbType.VarChar,50),
					new SqlParameter("@inspection_date", SqlDbType.VarChar,10),
					new SqlParameter("@inspection_man", SqlDbType.VarChar,50),
					new SqlParameter("@project_type", SqlDbType.VarChar,100),
					new SqlParameter("@medical_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.check_date;
			parameters[1].Value = model.check_man;
			parameters[2].Value = model.inspection_date;
			parameters[3].Value = model.inspection_man;
			parameters[4].Value = model.project_type;
			parameters[5].Value = model.medical_id;

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
		public bool Update(LW_AskOnline.Model.t_medical_report model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_medical_report set ");
			strSql.Append("check_date=@check_date,");
			strSql.Append("check_man=@check_man,");
			strSql.Append("inspection_date=@inspection_date,");
			strSql.Append("inspection_man=@inspection_man,");
			strSql.Append("project_type=@project_type,");
			strSql.Append("medical_id=@medical_id");
			strSql.Append(" where report_id=@report_id");
			SqlParameter[] parameters = {
					new SqlParameter("@check_date", SqlDbType.VarChar,10),
					new SqlParameter("@check_man", SqlDbType.VarChar,50),
					new SqlParameter("@inspection_date", SqlDbType.VarChar,10),
					new SqlParameter("@inspection_man", SqlDbType.VarChar,50),
					new SqlParameter("@project_type", SqlDbType.VarChar,100),
					new SqlParameter("@medical_id", SqlDbType.Decimal,9),
					new SqlParameter("@report_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.check_date;
			parameters[1].Value = model.check_man;
			parameters[2].Value = model.inspection_date;
			parameters[3].Value = model.inspection_man;
			parameters[4].Value = model.project_type;
			parameters[5].Value = model.medical_id;
			parameters[6].Value = model.report_id;

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
		public bool Delete(decimal report_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_medical_report ");
			strSql.Append(" where report_id=@report_id");
			SqlParameter[] parameters = {
					new SqlParameter("@report_id", SqlDbType.Decimal)
			};
			parameters[0].Value = report_id;

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
		public bool DeleteList(string report_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_medical_report ");
			strSql.Append(" where report_id in ("+report_idlist + ")  ");
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
		public LW_AskOnline.Model.t_medical_report GetModel(decimal report_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 report_id,check_date,check_man,inspection_date,inspection_man,project_type,medical_id from t_medical_report ");
			strSql.Append(" where report_id=@report_id");
			SqlParameter[] parameters = {
					new SqlParameter("@report_id", SqlDbType.Decimal)
			};
			parameters[0].Value = report_id;

			LW_AskOnline.Model.t_medical_report model=new LW_AskOnline.Model.t_medical_report();
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
		public LW_AskOnline.Model.t_medical_report DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_medical_report model=new LW_AskOnline.Model.t_medical_report();
			if (row != null)
			{
				if(row["report_id"]!=null && row["report_id"].ToString()!="")
				{
					model.report_id=decimal.Parse(row["report_id"].ToString());
				}
				if(row["check_date"]!=null)
				{
					model.check_date=row["check_date"].ToString();
				}
				if(row["check_man"]!=null)
				{
					model.check_man=row["check_man"].ToString();
				}
				if(row["inspection_date"]!=null)
				{
					model.inspection_date=row["inspection_date"].ToString();
				}
				if(row["inspection_man"]!=null)
				{
					model.inspection_man=row["inspection_man"].ToString();
				}
				if(row["project_type"]!=null)
				{
					model.project_type=row["project_type"].ToString();
				}
				if(row["medical_id"]!=null && row["medical_id"].ToString()!="")
				{
					model.medical_id=decimal.Parse(row["medical_id"].ToString());
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
			strSql.Append("select report_id,check_date,check_man,inspection_date,inspection_man,project_type,medical_id ");
			strSql.Append(" FROM t_medical_report ");
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
			strSql.Append(" report_id,check_date,check_man,inspection_date,inspection_man,project_type,medical_id ");
			strSql.Append(" FROM t_medical_report ");
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
			strSql.Append("select count(1) FROM t_medical_report ");
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
				strSql.Append("order by T.report_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_medical_report T ");
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
			parameters[0].Value = "t_medical_report";
			parameters[1].Value = "report_id";
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

