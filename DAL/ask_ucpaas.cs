using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:ask_ucpaas
	/// </summary>
	public partial class ask_ucpaas
	{
		public ask_ucpaas()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ucid", "ask_ucpaas"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ucid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ask_ucpaas");
			strSql.Append(" where ucid=@ucid");
			SqlParameter[] parameters = {
					new SqlParameter("@ucid", SqlDbType.Int,4)
			};
			parameters[0].Value = ucid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(LW_AskOnline.Model.ask_ucpaas model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ask_ucpaas(");
			strSql.Append("oid,ucevent,uccallid,ucaccountid,ucappid,uccalltype,uclengthA,uccallerdisnum,uccalleedisnum,uccallertype,uccallernum,uccaller,uccalledtype,uccalled,uclength,uccalltime,ucstarttime,ucstoptime,ucreason,ucsubreason)");
			strSql.Append(" values (");
			strSql.Append("@oid,@ucevent,@uccallid,@ucaccountid,@ucappid,@uccalltype,@uclengthA,@uccallerdisnum,@uccalleedisnum,@uccallertype,@uccallernum,@uccaller,@uccalledtype,@uccalled,@uclength,@uccalltime,@ucstarttime,@ucstoptime,@ucreason,@ucsubreason)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@oid", SqlDbType.Int,4),
					new SqlParameter("@ucevent", SqlDbType.NVarChar,2000),
					new SqlParameter("@uccallid", SqlDbType.NVarChar,2000),
					new SqlParameter("@ucaccountid", SqlDbType.NVarChar,2000),
					new SqlParameter("@ucappid", SqlDbType.NVarChar,2000),
					new SqlParameter("@uccalltype", SqlDbType.NVarChar,2000),
					new SqlParameter("@uclengthA", SqlDbType.NVarChar,2000),
					new SqlParameter("@uccallerdisnum", SqlDbType.NVarChar,2000),
					new SqlParameter("@uccalleedisnum", SqlDbType.NVarChar,2000),
					new SqlParameter("@uccallertype", SqlDbType.NVarChar,2000),
					new SqlParameter("@uccallernum", SqlDbType.NVarChar,2000),
					new SqlParameter("@uccaller", SqlDbType.NVarChar,2000),
					new SqlParameter("@uccalledtype", SqlDbType.NVarChar,2000),
					new SqlParameter("@uccalled", SqlDbType.NVarChar,2000),
					new SqlParameter("@uclength", SqlDbType.NVarChar,2000),
					new SqlParameter("@uccalltime", SqlDbType.NVarChar,2000),
					new SqlParameter("@ucstarttime", SqlDbType.NVarChar,2000),
					new SqlParameter("@ucstoptime", SqlDbType.NVarChar,2000),
					new SqlParameter("@ucreason", SqlDbType.NVarChar,2000),
					new SqlParameter("@ucsubreason", SqlDbType.NVarChar,2000)};
			parameters[0].Value = model.oid;
			parameters[1].Value = model.ucevent;
			parameters[2].Value = model.uccallid;
			parameters[3].Value = model.ucaccountid;
			parameters[4].Value = model.ucappid;
			parameters[5].Value = model.uccalltype;
			parameters[6].Value = model.uclengthA;
			parameters[7].Value = model.uccallerdisnum;
			parameters[8].Value = model.uccalleedisnum;
			parameters[9].Value = model.uccallertype;
			parameters[10].Value = model.uccallernum;
			parameters[11].Value = model.uccaller;
			parameters[12].Value = model.uccalledtype;
			parameters[13].Value = model.uccalled;
			parameters[14].Value = model.uclength;
			parameters[15].Value = model.uccalltime;
			parameters[16].Value = model.ucstarttime;
			parameters[17].Value = model.ucstoptime;
			parameters[18].Value = model.ucreason;
			parameters[19].Value = model.ucsubreason;

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
		public bool Update(LW_AskOnline.Model.ask_ucpaas model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ask_ucpaas set ");
			strSql.Append("oid=@oid,");
			strSql.Append("ucevent=@ucevent,");
			strSql.Append("uccallid=@uccallid,");
			strSql.Append("ucaccountid=@ucaccountid,");
			strSql.Append("ucappid=@ucappid,");
			strSql.Append("uccalltype=@uccalltype,");
			strSql.Append("uclengthA=@uclengthA,");
			strSql.Append("uccallerdisnum=@uccallerdisnum,");
			strSql.Append("uccalleedisnum=@uccalleedisnum,");
			strSql.Append("uccallertype=@uccallertype,");
			strSql.Append("uccallernum=@uccallernum,");
			strSql.Append("uccaller=@uccaller,");
			strSql.Append("uccalledtype=@uccalledtype,");
			strSql.Append("uccalled=@uccalled,");
			strSql.Append("uclength=@uclength,");
			strSql.Append("uccalltime=@uccalltime,");
			strSql.Append("ucstarttime=@ucstarttime,");
			strSql.Append("ucstoptime=@ucstoptime,");
			strSql.Append("ucreason=@ucreason,");
			strSql.Append("ucsubreason=@ucsubreason");
			strSql.Append(" where ucid=@ucid");
			SqlParameter[] parameters = {
					new SqlParameter("@oid", SqlDbType.Int,4),
					new SqlParameter("@ucevent", SqlDbType.NVarChar,2000),
					new SqlParameter("@uccallid", SqlDbType.NVarChar,2000),
					new SqlParameter("@ucaccountid", SqlDbType.NVarChar,2000),
					new SqlParameter("@ucappid", SqlDbType.NVarChar,2000),
					new SqlParameter("@uccalltype", SqlDbType.NVarChar,2000),
					new SqlParameter("@uclengthA", SqlDbType.NVarChar,2000),
					new SqlParameter("@uccallerdisnum", SqlDbType.NVarChar,2000),
					new SqlParameter("@uccalleedisnum", SqlDbType.NVarChar,2000),
					new SqlParameter("@uccallertype", SqlDbType.NVarChar,2000),
					new SqlParameter("@uccallernum", SqlDbType.NVarChar,2000),
					new SqlParameter("@uccaller", SqlDbType.NVarChar,2000),
					new SqlParameter("@uccalledtype", SqlDbType.NVarChar,2000),
					new SqlParameter("@uccalled", SqlDbType.NVarChar,2000),
					new SqlParameter("@uclength", SqlDbType.NVarChar,2000),
					new SqlParameter("@uccalltime", SqlDbType.NVarChar,2000),
					new SqlParameter("@ucstarttime", SqlDbType.NVarChar,2000),
					new SqlParameter("@ucstoptime", SqlDbType.NVarChar,2000),
					new SqlParameter("@ucreason", SqlDbType.NVarChar,2000),
					new SqlParameter("@ucsubreason", SqlDbType.NVarChar,2000),
					new SqlParameter("@ucid", SqlDbType.Int,4)};
			parameters[0].Value = model.oid;
			parameters[1].Value = model.ucevent;
			parameters[2].Value = model.uccallid;
			parameters[3].Value = model.ucaccountid;
			parameters[4].Value = model.ucappid;
			parameters[5].Value = model.uccalltype;
			parameters[6].Value = model.uclengthA;
			parameters[7].Value = model.uccallerdisnum;
			parameters[8].Value = model.uccalleedisnum;
			parameters[9].Value = model.uccallertype;
			parameters[10].Value = model.uccallernum;
			parameters[11].Value = model.uccaller;
			parameters[12].Value = model.uccalledtype;
			parameters[13].Value = model.uccalled;
			parameters[14].Value = model.uclength;
			parameters[15].Value = model.uccalltime;
			parameters[16].Value = model.ucstarttime;
			parameters[17].Value = model.ucstoptime;
			parameters[18].Value = model.ucreason;
			parameters[19].Value = model.ucsubreason;
			parameters[20].Value = model.ucid;

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
		public bool Delete(int ucid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ask_ucpaas ");
			strSql.Append(" where ucid=@ucid");
			SqlParameter[] parameters = {
					new SqlParameter("@ucid", SqlDbType.Int,4)
			};
			parameters[0].Value = ucid;

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
		public bool DeleteList(string ucidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ask_ucpaas ");
			strSql.Append(" where ucid in ("+ucidlist + ")  ");
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
		public LW_AskOnline.Model.ask_ucpaas GetModel(int ucid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ucid,oid,ucevent,uccallid,ucaccountid,ucappid,uccalltype,uclengthA,uccallerdisnum,uccalleedisnum,uccallertype,uccallernum,uccaller,uccalledtype,uccalled,uclength,uccalltime,ucstarttime,ucstoptime,ucreason,ucsubreason from ask_ucpaas ");
			strSql.Append(" where ucid=@ucid");
			SqlParameter[] parameters = {
					new SqlParameter("@ucid", SqlDbType.Int,4)
			};
			parameters[0].Value = ucid;

			LW_AskOnline.Model.ask_ucpaas model=new LW_AskOnline.Model.ask_ucpaas();
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
		public LW_AskOnline.Model.ask_ucpaas DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.ask_ucpaas model=new LW_AskOnline.Model.ask_ucpaas();
			if (row != null)
			{
				if(row["ucid"]!=null && row["ucid"].ToString()!="")
				{
					model.ucid=int.Parse(row["ucid"].ToString());
				}
				if(row["oid"]!=null && row["oid"].ToString()!="")
				{
					model.oid=int.Parse(row["oid"].ToString());
				}
				if(row["ucevent"]!=null)
				{
					model.ucevent=row["ucevent"].ToString();
				}
				if(row["uccallid"]!=null)
				{
					model.uccallid=row["uccallid"].ToString();
				}
				if(row["ucaccountid"]!=null)
				{
					model.ucaccountid=row["ucaccountid"].ToString();
				}
				if(row["ucappid"]!=null)
				{
					model.ucappid=row["ucappid"].ToString();
				}
				if(row["uccalltype"]!=null)
				{
					model.uccalltype=row["uccalltype"].ToString();
				}
				if(row["uclengthA"]!=null)
				{
					model.uclengthA=row["uclengthA"].ToString();
				}
				if(row["uccallerdisnum"]!=null)
				{
					model.uccallerdisnum=row["uccallerdisnum"].ToString();
				}
				if(row["uccalleedisnum"]!=null)
				{
					model.uccalleedisnum=row["uccalleedisnum"].ToString();
				}
				if(row["uccallertype"]!=null)
				{
					model.uccallertype=row["uccallertype"].ToString();
				}
				if(row["uccallernum"]!=null)
				{
					model.uccallernum=row["uccallernum"].ToString();
				}
				if(row["uccaller"]!=null)
				{
					model.uccaller=row["uccaller"].ToString();
				}
				if(row["uccalledtype"]!=null)
				{
					model.uccalledtype=row["uccalledtype"].ToString();
				}
				if(row["uccalled"]!=null)
				{
					model.uccalled=row["uccalled"].ToString();
				}
				if(row["uclength"]!=null)
				{
					model.uclength=row["uclength"].ToString();
				}
				if(row["uccalltime"]!=null)
				{
					model.uccalltime=row["uccalltime"].ToString();
				}
				if(row["ucstarttime"]!=null)
				{
					model.ucstarttime=row["ucstarttime"].ToString();
				}
				if(row["ucstoptime"]!=null)
				{
					model.ucstoptime=row["ucstoptime"].ToString();
				}
				if(row["ucreason"]!=null)
				{
					model.ucreason=row["ucreason"].ToString();
				}
				if(row["ucsubreason"]!=null)
				{
					model.ucsubreason=row["ucsubreason"].ToString();
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
			strSql.Append("select ucid,oid,ucevent,uccallid,ucaccountid,ucappid,uccalltype,uclengthA,uccallerdisnum,uccalleedisnum,uccallertype,uccallernum,uccaller,uccalledtype,uccalled,uclength,uccalltime,ucstarttime,ucstoptime,ucreason,ucsubreason ");
			strSql.Append(" FROM ask_ucpaas ");
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
			strSql.Append(" ucid,oid,ucevent,uccallid,ucaccountid,ucappid,uccalltype,uclengthA,uccallerdisnum,uccalleedisnum,uccallertype,uccallernum,uccaller,uccalledtype,uccalled,uclength,uccalltime,ucstarttime,ucstoptime,ucreason,ucsubreason ");
			strSql.Append(" FROM ask_ucpaas ");
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
			strSql.Append("select count(1) FROM ask_ucpaas ");
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
				strSql.Append("order by T.ucid desc");
			}
			strSql.Append(")AS Row, T.*  from ask_ucpaas T ");
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
			parameters[0].Value = "ask_ucpaas";
			parameters[1].Value = "ucid";
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

