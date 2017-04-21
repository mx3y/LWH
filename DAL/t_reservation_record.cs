using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:t_reservation_record
	/// </summary>
	public partial class t_reservation_record
	{
		public t_reservation_record()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal record_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_reservation_record");
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
		public decimal Add(LW_AskOnline.Model.t_reservation_record model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_reservation_record(");
			strSql.Append("booking_date,booking_people,office_id,status,booking_day,booking_number,booking_period,check_code,create_date,booking_people_type)");
			strSql.Append(" values (");
			strSql.Append("@booking_date,@booking_people,@office_id,@status,@booking_day,@booking_number,@booking_period,@check_code,@create_date,@booking_people_type)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@booking_date", SqlDbType.VarChar,20),
					new SqlParameter("@booking_people", SqlDbType.VarChar,255),
					new SqlParameter("@office_id", SqlDbType.Decimal,9),
					new SqlParameter("@status", SqlDbType.VarChar,2),
					new SqlParameter("@booking_day", SqlDbType.VarChar,20),
					new SqlParameter("@booking_number", SqlDbType.Int,4),
					new SqlParameter("@booking_period", SqlDbType.VarChar,20),
					new SqlParameter("@check_code", SqlDbType.VarChar,255),
					new SqlParameter("@create_date", SqlDbType.DateTime),
					new SqlParameter("@booking_people_type", SqlDbType.VarChar,10)};
			parameters[0].Value = model.booking_date;
			parameters[1].Value = model.booking_people;
			parameters[2].Value = model.office_id;
			parameters[3].Value = model.status;
			parameters[4].Value = model.booking_day;
			parameters[5].Value = model.booking_number;
			parameters[6].Value = model.booking_period;
			parameters[7].Value = model.check_code;
			parameters[8].Value = model.create_date;
			parameters[9].Value = model.booking_people_type;

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
		public bool Update(LW_AskOnline.Model.t_reservation_record model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_reservation_record set ");
			strSql.Append("booking_date=@booking_date,");
			strSql.Append("booking_people=@booking_people,");
			strSql.Append("office_id=@office_id,");
			strSql.Append("status=@status,");
			strSql.Append("booking_day=@booking_day,");
			strSql.Append("booking_number=@booking_number,");
			strSql.Append("booking_period=@booking_period,");
			strSql.Append("check_code=@check_code,");
			strSql.Append("create_date=@create_date,");
			strSql.Append("booking_people_type=@booking_people_type");
			strSql.Append(" where record_id=@record_id");
			SqlParameter[] parameters = {
					new SqlParameter("@booking_date", SqlDbType.VarChar,20),
					new SqlParameter("@booking_people", SqlDbType.VarChar,255),
					new SqlParameter("@office_id", SqlDbType.Decimal,9),
					new SqlParameter("@status", SqlDbType.VarChar,2),
					new SqlParameter("@booking_day", SqlDbType.VarChar,20),
					new SqlParameter("@booking_number", SqlDbType.Int,4),
					new SqlParameter("@booking_period", SqlDbType.VarChar,20),
					new SqlParameter("@check_code", SqlDbType.VarChar,255),
					new SqlParameter("@create_date", SqlDbType.DateTime),
					new SqlParameter("@booking_people_type", SqlDbType.VarChar,10),
					new SqlParameter("@record_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.booking_date;
			parameters[1].Value = model.booking_people;
			parameters[2].Value = model.office_id;
			parameters[3].Value = model.status;
			parameters[4].Value = model.booking_day;
			parameters[5].Value = model.booking_number;
			parameters[6].Value = model.booking_period;
			parameters[7].Value = model.check_code;
			parameters[8].Value = model.create_date;
			parameters[9].Value = model.booking_people_type;
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
			strSql.Append("delete from t_reservation_record ");
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
			strSql.Append("delete from t_reservation_record ");
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
		public LW_AskOnline.Model.t_reservation_record GetModel(decimal record_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 record_id,booking_date,booking_people,office_id,status,booking_day,booking_number,booking_period,check_code,create_date,booking_people_type from t_reservation_record ");
			strSql.Append(" where record_id=@record_id");
			SqlParameter[] parameters = {
					new SqlParameter("@record_id", SqlDbType.Decimal)
			};
			parameters[0].Value = record_id;

			LW_AskOnline.Model.t_reservation_record model=new LW_AskOnline.Model.t_reservation_record();
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
		public LW_AskOnline.Model.t_reservation_record DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_reservation_record model=new LW_AskOnline.Model.t_reservation_record();
			if (row != null)
			{
				if(row["record_id"]!=null && row["record_id"].ToString()!="")
				{
					model.record_id=decimal.Parse(row["record_id"].ToString());
				}
				if(row["booking_date"]!=null)
				{
					model.booking_date=row["booking_date"].ToString();
				}
				if(row["booking_people"]!=null)
				{
					model.booking_people=row["booking_people"].ToString();
				}
				if(row["office_id"]!=null && row["office_id"].ToString()!="")
				{
					model.office_id=decimal.Parse(row["office_id"].ToString());
				}
				if(row["status"]!=null)
				{
					model.status=row["status"].ToString();
				}
				if(row["booking_day"]!=null)
				{
					model.booking_day=row["booking_day"].ToString();
				}
				if(row["booking_number"]!=null && row["booking_number"].ToString()!="")
				{
					model.booking_number=int.Parse(row["booking_number"].ToString());
				}
				if(row["booking_period"]!=null)
				{
					model.booking_period=row["booking_period"].ToString();
				}
				if(row["check_code"]!=null)
				{
					model.check_code=row["check_code"].ToString();
				}
				if(row["create_date"]!=null && row["create_date"].ToString()!="")
				{
					model.create_date=DateTime.Parse(row["create_date"].ToString());
				}
				if(row["booking_people_type"]!=null)
				{
					model.booking_people_type=row["booking_people_type"].ToString();
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
			strSql.Append("select record_id,booking_date,booking_people,office_id,status,booking_day,booking_number,booking_period,check_code,create_date,booking_people_type ");
			strSql.Append(" FROM t_reservation_record ");
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
			strSql.Append(" record_id,booking_date,booking_people,office_id,status,booking_day,booking_number,booking_period,check_code,create_date,booking_people_type ");
			strSql.Append(" FROM t_reservation_record ");
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
			strSql.Append("select count(1) FROM t_reservation_record ");
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
			strSql.Append(")AS Row, T.*  from t_reservation_record T ");
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
			parameters[0].Value = "t_reservation_record";
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

