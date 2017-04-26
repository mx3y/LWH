using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:ask_master
	/// </summary>
	public partial class ask_master:Iask_master
	{
		public ask_master()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("mid", "ask_master"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int mid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ask_master");
			strSql.Append(" where mid=@mid");
			SqlParameter[] parameters = {
					new SqlParameter("@mid", SqlDbType.Int,4)
			};
			parameters[0].Value = mid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(LW_AskOnline.Model.ask_master model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ask_master(");
			strSql.Append("mnumber,mpassword,mPurview,memail,mtell,mregdate,mname,msex,maddress,mlastlogintime,mlastip,mstate,mlogincount,mremark)");
			strSql.Append(" values (");
			strSql.Append("@mnumber,@mpassword,@mPurview,@memail,@mtell,@mregdate,@mname,@msex,@maddress,@mlastlogintime,@mlastip,@mstate,@mlogincount,@mremark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@mnumber", SqlDbType.NVarChar,50),
					new SqlParameter("@mpassword", SqlDbType.NVarChar,50),
					new SqlParameter("@mPurview", SqlDbType.NVarChar,500),
					new SqlParameter("@memail", SqlDbType.NVarChar,50),
					new SqlParameter("@mtell", SqlDbType.NVarChar,50),
					new SqlParameter("@mregdate", SqlDbType.DateTime),
					new SqlParameter("@mname", SqlDbType.NVarChar,20),
					new SqlParameter("@msex", SqlDbType.NVarChar,10),
					new SqlParameter("@maddress", SqlDbType.NVarChar,200),
					new SqlParameter("@mlastlogintime", SqlDbType.DateTime),
					new SqlParameter("@mlastip", SqlDbType.NVarChar,200),
					new SqlParameter("@mstate", SqlDbType.TinyInt,1),
					new SqlParameter("@mlogincount", SqlDbType.Int,4),
					new SqlParameter("@mremark", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.mnumber;
			parameters[1].Value = model.mpassword;
			parameters[2].Value = model.mPurview;
			parameters[3].Value = model.memail;
			parameters[4].Value = model.mtell;
			parameters[5].Value = model.mregdate;
			parameters[6].Value = model.mname;
			parameters[7].Value = model.msex;
			parameters[8].Value = model.maddress;
			parameters[9].Value = model.mlastlogintime;
			parameters[10].Value = model.mlastip;
			parameters[11].Value = model.mstate;
			parameters[12].Value = model.mlogincount;
			parameters[13].Value = model.mremark;

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
		public bool Update(LW_AskOnline.Model.ask_master model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ask_master set ");
			strSql.Append("mnumber=@mnumber,");
			strSql.Append("mpassword=@mpassword,");
			strSql.Append("mPurview=@mPurview,");
			strSql.Append("memail=@memail,");
			strSql.Append("mtell=@mtell,");
			strSql.Append("mregdate=@mregdate,");
			strSql.Append("mname=@mname,");
			strSql.Append("msex=@msex,");
			strSql.Append("maddress=@maddress,");
			strSql.Append("mlastlogintime=@mlastlogintime,");
			strSql.Append("mlastip=@mlastip,");
			strSql.Append("mstate=@mstate,");
			strSql.Append("mlogincount=@mlogincount,");
			strSql.Append("mremark=@mremark");
			strSql.Append(" where mid=@mid");
			SqlParameter[] parameters = {
					new SqlParameter("@mnumber", SqlDbType.NVarChar,50),
					new SqlParameter("@mpassword", SqlDbType.NVarChar,50),
					new SqlParameter("@mPurview", SqlDbType.NVarChar,500),
					new SqlParameter("@memail", SqlDbType.NVarChar,50),
					new SqlParameter("@mtell", SqlDbType.NVarChar,50),
					new SqlParameter("@mregdate", SqlDbType.DateTime),
					new SqlParameter("@mname", SqlDbType.NVarChar,20),
					new SqlParameter("@msex", SqlDbType.NVarChar,10),
					new SqlParameter("@maddress", SqlDbType.NVarChar,200),
					new SqlParameter("@mlastlogintime", SqlDbType.DateTime),
					new SqlParameter("@mlastip", SqlDbType.NVarChar,200),
					new SqlParameter("@mstate", SqlDbType.TinyInt,1),
					new SqlParameter("@mlogincount", SqlDbType.Int,4),
					new SqlParameter("@mremark", SqlDbType.NVarChar,200),
					new SqlParameter("@mid", SqlDbType.Int,4)};
			parameters[0].Value = model.mnumber;
			parameters[1].Value = model.mpassword;
			parameters[2].Value = model.mPurview;
			parameters[3].Value = model.memail;
			parameters[4].Value = model.mtell;
			parameters[5].Value = model.mregdate;
			parameters[6].Value = model.mname;
			parameters[7].Value = model.msex;
			parameters[8].Value = model.maddress;
			parameters[9].Value = model.mlastlogintime;
			parameters[10].Value = model.mlastip;
			parameters[11].Value = model.mstate;
			parameters[12].Value = model.mlogincount;
			parameters[13].Value = model.mremark;
			parameters[14].Value = model.mid;

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
		public bool Delete(int mid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ask_master ");
			strSql.Append(" where mid=@mid");
			SqlParameter[] parameters = {
					new SqlParameter("@mid", SqlDbType.Int,4)
			};
			parameters[0].Value = mid;

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
		public bool DeleteList(string midlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ask_master ");
			strSql.Append(" where mid in ("+midlist + ")  ");
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
		public LW_AskOnline.Model.ask_master GetModel(int mid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 mid,mnumber,mpassword,mPurview,memail,mtell,mregdate,mname,msex,maddress,mlastlogintime,mlastip,mstate,mlogincount,mremark from ask_master ");
			strSql.Append(" where mid=@mid");
			SqlParameter[] parameters = {
					new SqlParameter("@mid", SqlDbType.Int,4)
			};
			parameters[0].Value = mid;

			LW_AskOnline.Model.ask_master model=new LW_AskOnline.Model.ask_master();
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
		public LW_AskOnline.Model.ask_master DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.ask_master model=new LW_AskOnline.Model.ask_master();
			if (row != null)
			{
				if(row["mid"]!=null && row["mid"].ToString()!="")
				{
					model.mid=int.Parse(row["mid"].ToString());
				}
				if(row["mnumber"]!=null)
				{
					model.mnumber=row["mnumber"].ToString();
				}
				if(row["mpassword"]!=null)
				{
					model.mpassword=row["mpassword"].ToString();
				}
				if(row["mPurview"]!=null)
				{
					model.mPurview=row["mPurview"].ToString();
				}
				if(row["memail"]!=null)
				{
					model.memail=row["memail"].ToString();
				}
				if(row["mtell"]!=null)
				{
					model.mtell=row["mtell"].ToString();
				}
				if(row["mregdate"]!=null && row["mregdate"].ToString()!="")
				{
					model.mregdate=DateTime.Parse(row["mregdate"].ToString());
				}
				if(row["mname"]!=null)
				{
					model.mname=row["mname"].ToString();
				}
				if(row["msex"]!=null)
				{
					model.msex=row["msex"].ToString();
				}
				if(row["maddress"]!=null)
				{
					model.maddress=row["maddress"].ToString();
				}
				if(row["mlastlogintime"]!=null && row["mlastlogintime"].ToString()!="")
				{
					model.mlastlogintime=DateTime.Parse(row["mlastlogintime"].ToString());
				}
				if(row["mlastip"]!=null)
				{
					model.mlastip=row["mlastip"].ToString();
				}
				if(row["mstate"]!=null && row["mstate"].ToString()!="")
				{
					model.mstate=int.Parse(row["mstate"].ToString());
				}
				if(row["mlogincount"]!=null && row["mlogincount"].ToString()!="")
				{
					model.mlogincount=int.Parse(row["mlogincount"].ToString());
				}
				if(row["mremark"]!=null)
				{
					model.mremark=row["mremark"].ToString();
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
			strSql.Append("select mid,mnumber,mpassword,mPurview,memail,mtell,mregdate,mname,msex,maddress,mlastlogintime,mlastip,mstate,mlogincount,mremark ");
			strSql.Append(" FROM ask_master ");
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
			strSql.Append(" mid,mnumber,mpassword,mPurview,memail,mtell,mregdate,mname,msex,maddress,mlastlogintime,mlastip,mstate,mlogincount,mremark ");
			strSql.Append(" FROM ask_master ");
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
			strSql.Append("select count(1) FROM ask_master ");
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
				strSql.Append("order by T.mid desc");
			}
			strSql.Append(")AS Row, T.*  from ask_master T ");
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
			parameters[0].Value = "ask_master";
			parameters[1].Value = "mid";
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

