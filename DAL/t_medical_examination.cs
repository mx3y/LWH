using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:t_medical_examination
	/// </summary>
	public partial class t_medical_examination
	{
		public t_medical_examination()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal medical_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_medical_examination");
			strSql.Append(" where medical_id=@medical_id");
			SqlParameter[] parameters = {
					new SqlParameter("@medical_id", SqlDbType.Decimal)
			};
			parameters[0].Value = medical_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_medical_examination model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_medical_examination(");
			strSql.Append("booking_date,booking_dept_name,booking_doctor,check_mark,check_result,check_subject,medical_package,status,member_id,order_id)");
			strSql.Append(" values (");
			strSql.Append("@booking_date,@booking_dept_name,@booking_doctor,@check_mark,@check_result,@check_subject,@medical_package,@status,@member_id,@order_id)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@booking_date", SqlDbType.DateTime),
					new SqlParameter("@booking_dept_name", SqlDbType.VarChar,100),
					new SqlParameter("@booking_doctor", SqlDbType.VarChar,50),
					new SqlParameter("@check_mark", SqlDbType.VarChar,2),
					new SqlParameter("@check_result", SqlDbType.Text),
					new SqlParameter("@check_subject", SqlDbType.VarChar,10),
					new SqlParameter("@medical_package", SqlDbType.VarChar,100),
					new SqlParameter("@status", SqlDbType.VarChar,100),
					new SqlParameter("@member_id", SqlDbType.Decimal,9),
					new SqlParameter("@order_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.booking_date;
			parameters[1].Value = model.booking_dept_name;
			parameters[2].Value = model.booking_doctor;
			parameters[3].Value = model.check_mark;
			parameters[4].Value = model.check_result;
			parameters[5].Value = model.check_subject;
			parameters[6].Value = model.medical_package;
			parameters[7].Value = model.status;
			parameters[8].Value = model.member_id;
			parameters[9].Value = model.order_id;

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
		public bool Update(LW_AskOnline.Model.t_medical_examination model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_medical_examination set ");
			strSql.Append("booking_date=@booking_date,");
			strSql.Append("booking_dept_name=@booking_dept_name,");
			strSql.Append("booking_doctor=@booking_doctor,");
			strSql.Append("check_mark=@check_mark,");
			strSql.Append("check_result=@check_result,");
			strSql.Append("check_subject=@check_subject,");
			strSql.Append("medical_package=@medical_package,");
			strSql.Append("status=@status,");
			strSql.Append("member_id=@member_id,");
			strSql.Append("order_id=@order_id");
			strSql.Append(" where medical_id=@medical_id");
			SqlParameter[] parameters = {
					new SqlParameter("@booking_date", SqlDbType.DateTime),
					new SqlParameter("@booking_dept_name", SqlDbType.VarChar,100),
					new SqlParameter("@booking_doctor", SqlDbType.VarChar,50),
					new SqlParameter("@check_mark", SqlDbType.VarChar,2),
					new SqlParameter("@check_result", SqlDbType.Text),
					new SqlParameter("@check_subject", SqlDbType.VarChar,10),
					new SqlParameter("@medical_package", SqlDbType.VarChar,100),
					new SqlParameter("@status", SqlDbType.VarChar,100),
					new SqlParameter("@member_id", SqlDbType.Decimal,9),
					new SqlParameter("@order_id", SqlDbType.Decimal,9),
					new SqlParameter("@medical_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.booking_date;
			parameters[1].Value = model.booking_dept_name;
			parameters[2].Value = model.booking_doctor;
			parameters[3].Value = model.check_mark;
			parameters[4].Value = model.check_result;
			parameters[5].Value = model.check_subject;
			parameters[6].Value = model.medical_package;
			parameters[7].Value = model.status;
			parameters[8].Value = model.member_id;
			parameters[9].Value = model.order_id;
			parameters[10].Value = model.medical_id;

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
		public bool Delete(decimal medical_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_medical_examination ");
			strSql.Append(" where medical_id=@medical_id");
			SqlParameter[] parameters = {
					new SqlParameter("@medical_id", SqlDbType.Decimal)
			};
			parameters[0].Value = medical_id;

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
		public bool DeleteList(string medical_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_medical_examination ");
			strSql.Append(" where medical_id in ("+medical_idlist + ")  ");
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
		public LW_AskOnline.Model.t_medical_examination GetModel(decimal medical_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 medical_id,booking_date,booking_dept_name,booking_doctor,check_mark,check_result,check_subject,medical_package,status,member_id,order_id from t_medical_examination ");
			strSql.Append(" where medical_id=@medical_id");
			SqlParameter[] parameters = {
					new SqlParameter("@medical_id", SqlDbType.Decimal)
			};
			parameters[0].Value = medical_id;

			LW_AskOnline.Model.t_medical_examination model=new LW_AskOnline.Model.t_medical_examination();
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
		public LW_AskOnline.Model.t_medical_examination DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_medical_examination model=new LW_AskOnline.Model.t_medical_examination();
			if (row != null)
			{
				if(row["medical_id"]!=null && row["medical_id"].ToString()!="")
				{
					model.medical_id=decimal.Parse(row["medical_id"].ToString());
				}
				if(row["booking_date"]!=null && row["booking_date"].ToString()!="")
				{
					model.booking_date=DateTime.Parse(row["booking_date"].ToString());
				}
				if(row["booking_dept_name"]!=null)
				{
					model.booking_dept_name=row["booking_dept_name"].ToString();
				}
				if(row["booking_doctor"]!=null)
				{
					model.booking_doctor=row["booking_doctor"].ToString();
				}
				if(row["check_mark"]!=null)
				{
					model.check_mark=row["check_mark"].ToString();
				}
				if(row["check_result"]!=null)
				{
					model.check_result=row["check_result"].ToString();
				}
				if(row["check_subject"]!=null)
				{
					model.check_subject=row["check_subject"].ToString();
				}
				if(row["medical_package"]!=null)
				{
					model.medical_package=row["medical_package"].ToString();
				}
				if(row["status"]!=null)
				{
					model.status=row["status"].ToString();
				}
				if(row["member_id"]!=null && row["member_id"].ToString()!="")
				{
					model.member_id=decimal.Parse(row["member_id"].ToString());
				}
				if(row["order_id"]!=null && row["order_id"].ToString()!="")
				{
					model.order_id=decimal.Parse(row["order_id"].ToString());
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
			strSql.Append("select medical_id,booking_date,booking_dept_name,booking_doctor,check_mark,check_result,check_subject,medical_package,status,member_id,order_id ");
			strSql.Append(" FROM t_medical_examination ");
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
			strSql.Append(" medical_id,booking_date,booking_dept_name,booking_doctor,check_mark,check_result,check_subject,medical_package,status,member_id,order_id ");
			strSql.Append(" FROM t_medical_examination ");
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
			strSql.Append("select count(1) FROM t_medical_examination ");
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
				strSql.Append("order by T.medical_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_medical_examination T ");
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
			parameters[0].Value = "t_medical_examination";
			parameters[1].Value = "medical_id";
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

