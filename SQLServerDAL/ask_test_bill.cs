using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:ask_test_bill
	/// </summary>
	public partial class ask_test_bill:Iask_test_bill
	{
		public ask_test_bill()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("tid", "ask_test_bill"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int tid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ask_test_bill");
			strSql.Append(" where tid=@tid");
			SqlParameter[] parameters = {
					new SqlParameter("@tid", SqlDbType.Int,4)
			};
			parameters[0].Value = tid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(LW_AskOnline.Model.ask_test_bill model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ask_test_bill(");
			strSql.Append("tvalue,tdate)");
			strSql.Append(" values (");
			strSql.Append("@tvalue,@tdate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@tvalue", SqlDbType.NVarChar,2000),
					new SqlParameter("@tdate", SqlDbType.NVarChar,2000)};
			parameters[0].Value = model.tvalue;
			parameters[1].Value = model.tdate;

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
		public bool Update(LW_AskOnline.Model.ask_test_bill model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ask_test_bill set ");
			strSql.Append("tvalue=@tvalue,");
			strSql.Append("tdate=@tdate");
			strSql.Append(" where tid=@tid");
			SqlParameter[] parameters = {
					new SqlParameter("@tvalue", SqlDbType.NVarChar,2000),
					new SqlParameter("@tdate", SqlDbType.NVarChar,2000),
					new SqlParameter("@tid", SqlDbType.Int,4)};
			parameters[0].Value = model.tvalue;
			parameters[1].Value = model.tdate;
			parameters[2].Value = model.tid;

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
		public bool Delete(int tid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ask_test_bill ");
			strSql.Append(" where tid=@tid");
			SqlParameter[] parameters = {
					new SqlParameter("@tid", SqlDbType.Int,4)
			};
			parameters[0].Value = tid;

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
		public bool DeleteList(string tidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ask_test_bill ");
			strSql.Append(" where tid in ("+tidlist + ")  ");
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
		public LW_AskOnline.Model.ask_test_bill GetModel(int tid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 tid,tvalue,tdate from ask_test_bill ");
			strSql.Append(" where tid=@tid");
			SqlParameter[] parameters = {
					new SqlParameter("@tid", SqlDbType.Int,4)
			};
			parameters[0].Value = tid;

			LW_AskOnline.Model.ask_test_bill model=new LW_AskOnline.Model.ask_test_bill();
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
		public LW_AskOnline.Model.ask_test_bill DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.ask_test_bill model=new LW_AskOnline.Model.ask_test_bill();
			if (row != null)
			{
				if(row["tid"]!=null && row["tid"].ToString()!="")
				{
					model.tid=int.Parse(row["tid"].ToString());
				}
				if(row["tvalue"]!=null)
				{
					model.tvalue=row["tvalue"].ToString();
				}
				if(row["tdate"]!=null)
				{
					model.tdate=row["tdate"].ToString();
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
			strSql.Append("select tid,tvalue,tdate ");
			strSql.Append(" FROM ask_test_bill ");
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
			strSql.Append(" tid,tvalue,tdate ");
			strSql.Append(" FROM ask_test_bill ");
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
			strSql.Append("select count(1) FROM ask_test_bill ");
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
				strSql.Append("order by T.tid desc");
			}
			strSql.Append(")AS Row, T.*  from ask_test_bill T ");
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
			parameters[0].Value = "ask_test_bill";
			parameters[1].Value = "tid";
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

