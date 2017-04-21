using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:norecord
	/// </summary>
	public partial class norecord:Inorecord
	{
		public norecord()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("nr_id", "norecord"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int nr_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from norecord");
			strSql.Append(" where nr_id=@nr_id");
			SqlParameter[] parameters = {
					new SqlParameter("@nr_id", SqlDbType.Int,4)
			};
			parameters[0].Value = nr_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(LW_AskOnline.Model.norecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into norecord(");
			strSql.Append("nr_phone,nr_name,nr_uid,nr_status,nr_date)");
			strSql.Append(" values (");
			strSql.Append("@nr_phone,@nr_name,@nr_uid,@nr_status,@nr_date)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@nr_phone", SqlDbType.NVarChar,50),
					new SqlParameter("@nr_name", SqlDbType.NVarChar,50),
					new SqlParameter("@nr_uid", SqlDbType.NVarChar,50),
					new SqlParameter("@nr_status", SqlDbType.NVarChar,50),
					new SqlParameter("@nr_date", SqlDbType.DateTime)};
			parameters[0].Value = model.nr_phone;
			parameters[1].Value = model.nr_name;
			parameters[2].Value = model.nr_uid;
			parameters[3].Value = model.nr_status;
			parameters[4].Value = model.nr_date;

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
		public bool Update(LW_AskOnline.Model.norecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update norecord set ");
			strSql.Append("nr_phone=@nr_phone,");
			strSql.Append("nr_name=@nr_name,");
			strSql.Append("nr_uid=@nr_uid,");
			strSql.Append("nr_status=@nr_status,");
			strSql.Append("nr_date=@nr_date");
			strSql.Append(" where nr_id=@nr_id");
			SqlParameter[] parameters = {
					new SqlParameter("@nr_phone", SqlDbType.NVarChar,50),
					new SqlParameter("@nr_name", SqlDbType.NVarChar,50),
					new SqlParameter("@nr_uid", SqlDbType.NVarChar,50),
					new SqlParameter("@nr_status", SqlDbType.NVarChar,50),
					new SqlParameter("@nr_date", SqlDbType.DateTime),
					new SqlParameter("@nr_id", SqlDbType.Int,4)};
			parameters[0].Value = model.nr_phone;
			parameters[1].Value = model.nr_name;
			parameters[2].Value = model.nr_uid;
			parameters[3].Value = model.nr_status;
			parameters[4].Value = model.nr_date;
			parameters[5].Value = model.nr_id;

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
		public bool Delete(int nr_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from norecord ");
			strSql.Append(" where nr_id=@nr_id");
			SqlParameter[] parameters = {
					new SqlParameter("@nr_id", SqlDbType.Int,4)
			};
			parameters[0].Value = nr_id;

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
		public bool DeleteList(string nr_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from norecord ");
			strSql.Append(" where nr_id in ("+nr_idlist + ")  ");
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
		public LW_AskOnline.Model.norecord GetModel(int nr_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 nr_id,nr_phone,nr_name,nr_uid,nr_status,nr_date from norecord ");
			strSql.Append(" where nr_id=@nr_id");
			SqlParameter[] parameters = {
					new SqlParameter("@nr_id", SqlDbType.Int,4)
			};
			parameters[0].Value = nr_id;

			LW_AskOnline.Model.norecord model=new LW_AskOnline.Model.norecord();
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
		public LW_AskOnline.Model.norecord DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.norecord model=new LW_AskOnline.Model.norecord();
			if (row != null)
			{
				if(row["nr_id"]!=null && row["nr_id"].ToString()!="")
				{
					model.nr_id=int.Parse(row["nr_id"].ToString());
				}
				if(row["nr_phone"]!=null)
				{
					model.nr_phone=row["nr_phone"].ToString();
				}
				if(row["nr_name"]!=null)
				{
					model.nr_name=row["nr_name"].ToString();
				}
				if(row["nr_uid"]!=null)
				{
					model.nr_uid=row["nr_uid"].ToString();
				}
				if(row["nr_status"]!=null)
				{
					model.nr_status=row["nr_status"].ToString();
				}
				if(row["nr_date"]!=null && row["nr_date"].ToString()!="")
				{
					model.nr_date=DateTime.Parse(row["nr_date"].ToString());
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
			strSql.Append("select nr_id,nr_phone,nr_name,nr_uid,nr_status,nr_date ");
			strSql.Append(" FROM norecord ");
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
			strSql.Append(" nr_id,nr_phone,nr_name,nr_uid,nr_status,nr_date ");
			strSql.Append(" FROM norecord ");
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
			strSql.Append("select count(1) FROM norecord ");
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
				strSql.Append("order by T.nr_id desc");
			}
			strSql.Append(")AS Row, T.*  from norecord T ");
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
			parameters[0].Value = "norecord";
			parameters[1].Value = "nr_id";
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

