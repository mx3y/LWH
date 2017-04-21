using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:t_reservation_office
	/// </summary>
	public partial class t_reservation_office
	{
		public t_reservation_office()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal office_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_reservation_office");
			strSql.Append(" where office_id=@office_id");
			SqlParameter[] parameters = {
					new SqlParameter("@office_id", SqlDbType.Decimal)
			};
			parameters[0].Value = office_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_reservation_office model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_reservation_office(");
			strSql.Append("capacity,office_name,serial_number)");
			strSql.Append(" values (");
			strSql.Append("@capacity,@office_name,@serial_number)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@capacity", SqlDbType.Int,4),
					new SqlParameter("@office_name", SqlDbType.VarChar,50),
					new SqlParameter("@serial_number", SqlDbType.Int,4)};
			parameters[0].Value = model.capacity;
			parameters[1].Value = model.office_name;
			parameters[2].Value = model.serial_number;

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
		public bool Update(LW_AskOnline.Model.t_reservation_office model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_reservation_office set ");
			strSql.Append("capacity=@capacity,");
			strSql.Append("office_name=@office_name,");
			strSql.Append("serial_number=@serial_number");
			strSql.Append(" where office_id=@office_id");
			SqlParameter[] parameters = {
					new SqlParameter("@capacity", SqlDbType.Int,4),
					new SqlParameter("@office_name", SqlDbType.VarChar,50),
					new SqlParameter("@serial_number", SqlDbType.Int,4),
					new SqlParameter("@office_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.capacity;
			parameters[1].Value = model.office_name;
			parameters[2].Value = model.serial_number;
			parameters[3].Value = model.office_id;

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
		public bool Delete(decimal office_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_reservation_office ");
			strSql.Append(" where office_id=@office_id");
			SqlParameter[] parameters = {
					new SqlParameter("@office_id", SqlDbType.Decimal)
			};
			parameters[0].Value = office_id;

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
		public bool DeleteList(string office_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_reservation_office ");
			strSql.Append(" where office_id in ("+office_idlist + ")  ");
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
		public LW_AskOnline.Model.t_reservation_office GetModel(decimal office_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 office_id,capacity,office_name,serial_number from t_reservation_office ");
			strSql.Append(" where office_id=@office_id");
			SqlParameter[] parameters = {
					new SqlParameter("@office_id", SqlDbType.Decimal)
			};
			parameters[0].Value = office_id;

			LW_AskOnline.Model.t_reservation_office model=new LW_AskOnline.Model.t_reservation_office();
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
		public LW_AskOnline.Model.t_reservation_office DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_reservation_office model=new LW_AskOnline.Model.t_reservation_office();
			if (row != null)
			{
				if(row["office_id"]!=null && row["office_id"].ToString()!="")
				{
					model.office_id=decimal.Parse(row["office_id"].ToString());
				}
				if(row["capacity"]!=null && row["capacity"].ToString()!="")
				{
					model.capacity=int.Parse(row["capacity"].ToString());
				}
				if(row["office_name"]!=null)
				{
					model.office_name=row["office_name"].ToString();
				}
				if(row["serial_number"]!=null && row["serial_number"].ToString()!="")
				{
					model.serial_number=int.Parse(row["serial_number"].ToString());
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
			strSql.Append("select office_id,capacity,office_name,serial_number ");
			strSql.Append(" FROM t_reservation_office ");
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
			strSql.Append(" office_id,capacity,office_name,serial_number ");
			strSql.Append(" FROM t_reservation_office ");
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
			strSql.Append("select count(1) FROM t_reservation_office ");
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
				strSql.Append("order by T.office_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_reservation_office T ");
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
			parameters[0].Value = "t_reservation_office";
			parameters[1].Value = "office_id";
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

