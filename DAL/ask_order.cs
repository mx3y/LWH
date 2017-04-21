using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:ask_order
	/// </summary>
	public partial class ask_order
	{
		public ask_order()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("oid", "ask_order"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int oid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ask_order");
			strSql.Append(" where oid=@oid");
			SqlParameter[] parameters = {
					new SqlParameter("@oid", SqlDbType.Int,4)
			};
			parameters[0].Value = oid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(LW_AskOnline.Model.ask_order model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ask_order(");
			strSql.Append("ouid,odid,otype,oresult,ostate,ocreatetime,ocommittime,opublicmonery,oprivatemonery,ototalmonery,otransid,ocallresult,ocallid,ocalldate)");
			strSql.Append(" values (");
			strSql.Append("@ouid,@odid,@otype,@oresult,@ostate,@ocreatetime,@ocommittime,@opublicmonery,@oprivatemonery,@ototalmonery,@otransid,@ocallresult,@ocallid,@ocalldate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ouid", SqlDbType.Int,4),
					new SqlParameter("@odid", SqlDbType.Int,4),
					new SqlParameter("@otype", SqlDbType.Int,4),
					new SqlParameter("@oresult", SqlDbType.TinyInt,1),
					new SqlParameter("@ostate", SqlDbType.TinyInt,1),
					new SqlParameter("@ocreatetime", SqlDbType.DateTime),
					new SqlParameter("@ocommittime", SqlDbType.DateTime),
					new SqlParameter("@opublicmonery", SqlDbType.Decimal,9),
					new SqlParameter("@oprivatemonery", SqlDbType.Decimal,9),
					new SqlParameter("@ototalmonery", SqlDbType.Decimal,9),
					new SqlParameter("@otransid", SqlDbType.Int,4),
					new SqlParameter("@ocallresult", SqlDbType.NVarChar,50),
					new SqlParameter("@ocallid", SqlDbType.NVarChar,50),
					new SqlParameter("@ocalldate", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.ouid;
			parameters[1].Value = model.odid;
			parameters[2].Value = model.otype;
			parameters[3].Value = model.oresult;
			parameters[4].Value = model.ostate;
			parameters[5].Value = model.ocreatetime;
			parameters[6].Value = model.ocommittime;
			parameters[7].Value = model.opublicmonery;
			parameters[8].Value = model.oprivatemonery;
			parameters[9].Value = model.ototalmonery;
			parameters[10].Value = model.otransid;
			parameters[11].Value = model.ocallresult;
			parameters[12].Value = model.ocallid;
			parameters[13].Value = model.ocalldate;

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
		public bool Update(LW_AskOnline.Model.ask_order model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ask_order set ");
			strSql.Append("ouid=@ouid,");
			strSql.Append("odid=@odid,");
			strSql.Append("otype=@otype,");
			strSql.Append("oresult=@oresult,");
			strSql.Append("ostate=@ostate,");
			strSql.Append("ocreatetime=@ocreatetime,");
			strSql.Append("ocommittime=@ocommittime,");
			strSql.Append("opublicmonery=@opublicmonery,");
			strSql.Append("oprivatemonery=@oprivatemonery,");
			strSql.Append("ototalmonery=@ototalmonery,");
			strSql.Append("otransid=@otransid,");
			strSql.Append("ocallresult=@ocallresult,");
			strSql.Append("ocallid=@ocallid,");
			strSql.Append("ocalldate=@ocalldate");
			strSql.Append(" where oid=@oid");
			SqlParameter[] parameters = {
					new SqlParameter("@ouid", SqlDbType.Int,4),
					new SqlParameter("@odid", SqlDbType.Int,4),
					new SqlParameter("@otype", SqlDbType.Int,4),
					new SqlParameter("@oresult", SqlDbType.TinyInt,1),
					new SqlParameter("@ostate", SqlDbType.TinyInt,1),
					new SqlParameter("@ocreatetime", SqlDbType.DateTime),
					new SqlParameter("@ocommittime", SqlDbType.DateTime),
					new SqlParameter("@opublicmonery", SqlDbType.Decimal,9),
					new SqlParameter("@oprivatemonery", SqlDbType.Decimal,9),
					new SqlParameter("@ototalmonery", SqlDbType.Decimal,9),
					new SqlParameter("@otransid", SqlDbType.Int,4),
					new SqlParameter("@ocallresult", SqlDbType.NVarChar,50),
					new SqlParameter("@ocallid", SqlDbType.NVarChar,50),
					new SqlParameter("@ocalldate", SqlDbType.NVarChar,50),
					new SqlParameter("@oid", SqlDbType.Int,4)};
			parameters[0].Value = model.ouid;
			parameters[1].Value = model.odid;
			parameters[2].Value = model.otype;
			parameters[3].Value = model.oresult;
			parameters[4].Value = model.ostate;
			parameters[5].Value = model.ocreatetime;
			parameters[6].Value = model.ocommittime;
			parameters[7].Value = model.opublicmonery;
			parameters[8].Value = model.oprivatemonery;
			parameters[9].Value = model.ototalmonery;
			parameters[10].Value = model.otransid;
			parameters[11].Value = model.ocallresult;
			parameters[12].Value = model.ocallid;
			parameters[13].Value = model.ocalldate;
			parameters[14].Value = model.oid;

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
		public bool Delete(int oid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ask_order ");
			strSql.Append(" where oid=@oid");
			SqlParameter[] parameters = {
					new SqlParameter("@oid", SqlDbType.Int,4)
			};
			parameters[0].Value = oid;

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
		public bool DeleteList(string oidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ask_order ");
			strSql.Append(" where oid in ("+oidlist + ")  ");
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
		public LW_AskOnline.Model.ask_order GetModel(int oid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 oid,ouid,odid,otype,oresult,ostate,ocreatetime,ocommittime,opublicmonery,oprivatemonery,ototalmonery,otransid,ocallresult,ocallid,ocalldate from ask_order ");
			strSql.Append(" where oid=@oid");
			SqlParameter[] parameters = {
					new SqlParameter("@oid", SqlDbType.Int,4)
			};
			parameters[0].Value = oid;

			LW_AskOnline.Model.ask_order model=new LW_AskOnline.Model.ask_order();
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
		public LW_AskOnline.Model.ask_order DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.ask_order model=new LW_AskOnline.Model.ask_order();
			if (row != null)
			{
				if(row["oid"]!=null && row["oid"].ToString()!="")
				{
					model.oid=int.Parse(row["oid"].ToString());
				}
				if(row["ouid"]!=null && row["ouid"].ToString()!="")
				{
					model.ouid=int.Parse(row["ouid"].ToString());
				}
				if(row["odid"]!=null && row["odid"].ToString()!="")
				{
					model.odid=int.Parse(row["odid"].ToString());
				}
				if(row["otype"]!=null && row["otype"].ToString()!="")
				{
					model.otype=int.Parse(row["otype"].ToString());
				}
				if(row["oresult"]!=null && row["oresult"].ToString()!="")
				{
					model.oresult=int.Parse(row["oresult"].ToString());
				}
				if(row["ostate"]!=null && row["ostate"].ToString()!="")
				{
					model.ostate=int.Parse(row["ostate"].ToString());
				}
				if(row["ocreatetime"]!=null && row["ocreatetime"].ToString()!="")
				{
					model.ocreatetime=DateTime.Parse(row["ocreatetime"].ToString());
				}
				if(row["ocommittime"]!=null && row["ocommittime"].ToString()!="")
				{
					model.ocommittime=DateTime.Parse(row["ocommittime"].ToString());
				}
				if(row["opublicmonery"]!=null && row["opublicmonery"].ToString()!="")
				{
					model.opublicmonery=decimal.Parse(row["opublicmonery"].ToString());
				}
				if(row["oprivatemonery"]!=null && row["oprivatemonery"].ToString()!="")
				{
					model.oprivatemonery=decimal.Parse(row["oprivatemonery"].ToString());
				}
				if(row["ototalmonery"]!=null && row["ototalmonery"].ToString()!="")
				{
					model.ototalmonery=decimal.Parse(row["ototalmonery"].ToString());
				}
				if(row["otransid"]!=null && row["otransid"].ToString()!="")
				{
					model.otransid=int.Parse(row["otransid"].ToString());
				}
				if(row["ocallresult"]!=null)
				{
					model.ocallresult=row["ocallresult"].ToString();
				}
				if(row["ocallid"]!=null)
				{
					model.ocallid=row["ocallid"].ToString();
				}
				if(row["ocalldate"]!=null)
				{
					model.ocalldate=row["ocalldate"].ToString();
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
			strSql.Append("select oid,ouid,odid,otype,oresult,ostate,ocreatetime,ocommittime,opublicmonery,oprivatemonery,ototalmonery,otransid,ocallresult,ocallid,ocalldate ");
			strSql.Append(" FROM ask_order ");
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
			strSql.Append(" oid,ouid,odid,otype,oresult,ostate,ocreatetime,ocommittime,opublicmonery,oprivatemonery,ototalmonery,otransid,ocallresult,ocallid,ocalldate ");
			strSql.Append(" FROM ask_order ");
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
			strSql.Append("select count(1) FROM ask_order ");
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
				strSql.Append("order by T.oid desc");
			}
			strSql.Append(")AS Row, T.*  from ask_order T ");
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
			parameters[0].Value = "ask_order";
			parameters[1].Value = "oid";
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

