using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:t_case_info
	/// </summary>
	public partial class t_case_info
	{
		public t_case_info()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal case_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_case_info");
			strSql.Append(" where case_id=@case_id");
			SqlParameter[] parameters = {
					new SqlParameter("@case_id", SqlDbType.Decimal)
			};
			parameters[0].Value = case_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_case_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_case_info(");
			strSql.Append("attending_doctor,case_details,date_of_visit,member_id,booking_dept_name,uploadDate,visitDate,upload_date,visit_date,member_type)");
			strSql.Append(" values (");
			strSql.Append("@attending_doctor,@case_details,@date_of_visit,@member_id,@booking_dept_name,@uploadDate,@visitDate,@upload_date,@visit_date,@member_type)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@attending_doctor", SqlDbType.VarChar,50),
					new SqlParameter("@case_details", SqlDbType.Text),
					new SqlParameter("@date_of_visit", SqlDbType.VarChar,10),
					new SqlParameter("@member_id", SqlDbType.Decimal,9),
					new SqlParameter("@booking_dept_name", SqlDbType.VarChar,100),
					new SqlParameter("@uploadDate", SqlDbType.DateTime),
					new SqlParameter("@visitDate", SqlDbType.VarChar,255),
					new SqlParameter("@upload_date", SqlDbType.DateTime),
					new SqlParameter("@visit_date", SqlDbType.DateTime),
					new SqlParameter("@member_type", SqlDbType.VarChar,10)};
			parameters[0].Value = model.attending_doctor;
			parameters[1].Value = model.case_details;
			parameters[2].Value = model.date_of_visit;
			parameters[3].Value = model.member_id;
			parameters[4].Value = model.booking_dept_name;
			parameters[5].Value = model.uploadDate;
			parameters[6].Value = model.visitDate;
			parameters[7].Value = model.upload_date;
			parameters[8].Value = model.visit_date;
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
		public bool Update(LW_AskOnline.Model.t_case_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_case_info set ");
			strSql.Append("attending_doctor=@attending_doctor,");
			strSql.Append("case_details=@case_details,");
			strSql.Append("date_of_visit=@date_of_visit,");
			strSql.Append("member_id=@member_id,");
			strSql.Append("booking_dept_name=@booking_dept_name,");
			strSql.Append("uploadDate=@uploadDate,");
			strSql.Append("visitDate=@visitDate,");
			strSql.Append("upload_date=@upload_date,");
			strSql.Append("visit_date=@visit_date,");
			strSql.Append("member_type=@member_type");
			strSql.Append(" where case_id=@case_id");
			SqlParameter[] parameters = {
					new SqlParameter("@attending_doctor", SqlDbType.VarChar,50),
					new SqlParameter("@case_details", SqlDbType.Text),
					new SqlParameter("@date_of_visit", SqlDbType.VarChar,10),
					new SqlParameter("@member_id", SqlDbType.Decimal,9),
					new SqlParameter("@booking_dept_name", SqlDbType.VarChar,100),
					new SqlParameter("@uploadDate", SqlDbType.DateTime),
					new SqlParameter("@visitDate", SqlDbType.VarChar,255),
					new SqlParameter("@upload_date", SqlDbType.DateTime),
					new SqlParameter("@visit_date", SqlDbType.DateTime),
					new SqlParameter("@member_type", SqlDbType.VarChar,10),
					new SqlParameter("@case_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.attending_doctor;
			parameters[1].Value = model.case_details;
			parameters[2].Value = model.date_of_visit;
			parameters[3].Value = model.member_id;
			parameters[4].Value = model.booking_dept_name;
			parameters[5].Value = model.uploadDate;
			parameters[6].Value = model.visitDate;
			parameters[7].Value = model.upload_date;
			parameters[8].Value = model.visit_date;
			parameters[9].Value = model.member_type;
			parameters[10].Value = model.case_id;

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
		public bool Delete(decimal case_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_case_info ");
			strSql.Append(" where case_id=@case_id");
			SqlParameter[] parameters = {
					new SqlParameter("@case_id", SqlDbType.Decimal)
			};
			parameters[0].Value = case_id;

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
		public bool DeleteList(string case_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_case_info ");
			strSql.Append(" where case_id in ("+case_idlist + ")  ");
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
		public LW_AskOnline.Model.t_case_info GetModel(decimal case_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 case_id,attending_doctor,case_details,date_of_visit,member_id,booking_dept_name,uploadDate,visitDate,upload_date,visit_date,member_type from t_case_info ");
			strSql.Append(" where case_id=@case_id");
			SqlParameter[] parameters = {
					new SqlParameter("@case_id", SqlDbType.Decimal)
			};
			parameters[0].Value = case_id;

			LW_AskOnline.Model.t_case_info model=new LW_AskOnline.Model.t_case_info();
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
		public LW_AskOnline.Model.t_case_info DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_case_info model=new LW_AskOnline.Model.t_case_info();
			if (row != null)
			{
				if(row["case_id"]!=null && row["case_id"].ToString()!="")
				{
					model.case_id=decimal.Parse(row["case_id"].ToString());
				}
				if(row["attending_doctor"]!=null)
				{
					model.attending_doctor=row["attending_doctor"].ToString();
				}
				if(row["case_details"]!=null)
				{
					model.case_details=row["case_details"].ToString();
				}
				if(row["date_of_visit"]!=null)
				{
					model.date_of_visit=row["date_of_visit"].ToString();
				}
				if(row["member_id"]!=null && row["member_id"].ToString()!="")
				{
					model.member_id=decimal.Parse(row["member_id"].ToString());
				}
				if(row["booking_dept_name"]!=null)
				{
					model.booking_dept_name=row["booking_dept_name"].ToString();
				}
				if(row["uploadDate"]!=null && row["uploadDate"].ToString()!="")
				{
					model.uploadDate=DateTime.Parse(row["uploadDate"].ToString());
				}
				if(row["visitDate"]!=null)
				{
					model.visitDate=row["visitDate"].ToString();
				}
				if(row["upload_date"]!=null && row["upload_date"].ToString()!="")
				{
					model.upload_date=DateTime.Parse(row["upload_date"].ToString());
				}
				if(row["visit_date"]!=null && row["visit_date"].ToString()!="")
				{
					model.visit_date=DateTime.Parse(row["visit_date"].ToString());
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
			strSql.Append("select case_id,attending_doctor,case_details,date_of_visit,member_id,booking_dept_name,uploadDate,visitDate,upload_date,visit_date,member_type ");
			strSql.Append(" FROM t_case_info ");
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
			strSql.Append(" case_id,attending_doctor,case_details,date_of_visit,member_id,booking_dept_name,uploadDate,visitDate,upload_date,visit_date,member_type ");
			strSql.Append(" FROM t_case_info ");
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
			strSql.Append("select count(1) FROM t_case_info ");
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
				strSql.Append("order by T.case_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_case_info T ");
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
			parameters[0].Value = "t_case_info";
			parameters[1].Value = "case_id";
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

