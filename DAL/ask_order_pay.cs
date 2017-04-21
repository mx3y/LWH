using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:ask_order_pay
	/// </summary>
	public partial class ask_order_pay
	{
		public ask_order_pay()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("pid", "ask_order_pay"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int pid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ask_order_pay");
			strSql.Append(" where pid=@pid");
			SqlParameter[] parameters = {
					new SqlParameter("@pid", SqlDbType.Int,4)
			};
			parameters[0].Value = pid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(LW_AskOnline.Model.ask_order_pay model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ask_order_pay(");
			strSql.Append("oid,uuid,porder,pwxorder,pmonery,pcreatetime,povertime,popenid,pstatus)");
			strSql.Append(" values (");
			strSql.Append("@oid,@uuid,@porder,@pwxorder,@pmonery,@pcreatetime,@povertime,@popenid,@pstatus)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@oid", SqlDbType.Int,4),
					new SqlParameter("@uuid", SqlDbType.Int,4),
					new SqlParameter("@porder", SqlDbType.NVarChar,50),
					new SqlParameter("@pwxorder", SqlDbType.NVarChar,50),
					new SqlParameter("@pmonery", SqlDbType.Decimal,9),
					new SqlParameter("@pcreatetime", SqlDbType.DateTime),
					new SqlParameter("@povertime", SqlDbType.DateTime),
					new SqlParameter("@popenid", SqlDbType.NVarChar,200),
					new SqlParameter("@pstatus", SqlDbType.Int,4)};
			parameters[0].Value = model.oid;
			parameters[1].Value = model.uuid;
			parameters[2].Value = model.porder;
			parameters[3].Value = model.pwxorder;
			parameters[4].Value = model.pmonery;
			parameters[5].Value = model.pcreatetime;
			parameters[6].Value = model.povertime;
			parameters[7].Value = model.popenid;
			parameters[8].Value = model.pstatus;

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
		public bool Update(LW_AskOnline.Model.ask_order_pay model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ask_order_pay set ");
			strSql.Append("oid=@oid,");
			strSql.Append("uuid=@uuid,");
			strSql.Append("porder=@porder,");
			strSql.Append("pwxorder=@pwxorder,");
			strSql.Append("pmonery=@pmonery,");
			strSql.Append("pcreatetime=@pcreatetime,");
			strSql.Append("povertime=@povertime,");
			strSql.Append("popenid=@popenid,");
			strSql.Append("pstatus=@pstatus");
			strSql.Append(" where pid=@pid");
			SqlParameter[] parameters = {
					new SqlParameter("@oid", SqlDbType.Int,4),
					new SqlParameter("@uuid", SqlDbType.Int,4),
					new SqlParameter("@porder", SqlDbType.NVarChar,50),
					new SqlParameter("@pwxorder", SqlDbType.NVarChar,50),
					new SqlParameter("@pmonery", SqlDbType.Decimal,9),
					new SqlParameter("@pcreatetime", SqlDbType.DateTime),
					new SqlParameter("@povertime", SqlDbType.DateTime),
					new SqlParameter("@popenid", SqlDbType.NVarChar,200),
					new SqlParameter("@pstatus", SqlDbType.Int,4),
					new SqlParameter("@pid", SqlDbType.Int,4)};
			parameters[0].Value = model.oid;
			parameters[1].Value = model.uuid;
			parameters[2].Value = model.porder;
			parameters[3].Value = model.pwxorder;
			parameters[4].Value = model.pmonery;
			parameters[5].Value = model.pcreatetime;
			parameters[6].Value = model.povertime;
			parameters[7].Value = model.popenid;
			parameters[8].Value = model.pstatus;
			parameters[9].Value = model.pid;

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
		public bool Delete(int pid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ask_order_pay ");
			strSql.Append(" where pid=@pid");
			SqlParameter[] parameters = {
					new SqlParameter("@pid", SqlDbType.Int,4)
			};
			parameters[0].Value = pid;

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
		public bool DeleteList(string pidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ask_order_pay ");
			strSql.Append(" where pid in ("+pidlist + ")  ");
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
		public LW_AskOnline.Model.ask_order_pay GetModel(int pid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 pid,oid,uuid,porder,pwxorder,pmonery,pcreatetime,povertime,popenid,pstatus from ask_order_pay ");
			strSql.Append(" where pid=@pid");
			SqlParameter[] parameters = {
					new SqlParameter("@pid", SqlDbType.Int,4)
			};
			parameters[0].Value = pid;

			LW_AskOnline.Model.ask_order_pay model=new LW_AskOnline.Model.ask_order_pay();
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
		public LW_AskOnline.Model.ask_order_pay DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.ask_order_pay model=new LW_AskOnline.Model.ask_order_pay();
			if (row != null)
			{
				if(row["pid"]!=null && row["pid"].ToString()!="")
				{
					model.pid=int.Parse(row["pid"].ToString());
				}
				if(row["oid"]!=null && row["oid"].ToString()!="")
				{
					model.oid=int.Parse(row["oid"].ToString());
				}
				if(row["uuid"]!=null && row["uuid"].ToString()!="")
				{
					model.uuid=int.Parse(row["uuid"].ToString());
				}
				if(row["porder"]!=null)
				{
					model.porder=row["porder"].ToString();
				}
				if(row["pwxorder"]!=null)
				{
					model.pwxorder=row["pwxorder"].ToString();
				}
				if(row["pmonery"]!=null && row["pmonery"].ToString()!="")
				{
					model.pmonery=decimal.Parse(row["pmonery"].ToString());
				}
				if(row["pcreatetime"]!=null && row["pcreatetime"].ToString()!="")
				{
					model.pcreatetime=DateTime.Parse(row["pcreatetime"].ToString());
				}
				if(row["povertime"]!=null && row["povertime"].ToString()!="")
				{
					model.povertime=DateTime.Parse(row["povertime"].ToString());
				}
				if(row["popenid"]!=null)
				{
					model.popenid=row["popenid"].ToString();
				}
				if(row["pstatus"]!=null && row["pstatus"].ToString()!="")
				{
					model.pstatus=int.Parse(row["pstatus"].ToString());
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
			strSql.Append("select pid,oid,uuid,porder,pwxorder,pmonery,pcreatetime,povertime,popenid,pstatus ");
			strSql.Append(" FROM ask_order_pay ");
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
			strSql.Append(" pid,oid,uuid,porder,pwxorder,pmonery,pcreatetime,povertime,popenid,pstatus ");
			strSql.Append(" FROM ask_order_pay ");
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
			strSql.Append("select count(1) FROM ask_order_pay ");
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
				strSql.Append("order by T.pid desc");
			}
			strSql.Append(")AS Row, T.*  from ask_order_pay T ");
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
			parameters[0].Value = "ask_order_pay";
			parameters[1].Value = "pid";
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

