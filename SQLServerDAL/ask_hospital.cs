using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:ask_hospital
	/// </summary>
	public partial class ask_hospital:Iask_hospital
	{
		public ask_hospital()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("hid", "ask_hospital"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int hid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ask_hospital");
			strSql.Append(" where hid=@hid");
			SqlParameter[] parameters = {
					new SqlParameter("@hid", SqlDbType.Int,4)
			};
			parameters[0].Value = hid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(LW_AskOnline.Model.ask_hospital model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ask_hospital(");
			strSql.Append("hcityid,hcity,hname,himage,hlevel,haddress,hcontent,hstatus)");
			strSql.Append(" values (");
			strSql.Append("@hcityid,@hcity,@hname,@himage,@hlevel,@haddress,@hcontent,@hstatus)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@hcityid", SqlDbType.Int,4),
					new SqlParameter("@hcity", SqlDbType.NVarChar,50),
					new SqlParameter("@hname", SqlDbType.NVarChar,50),
					new SqlParameter("@himage", SqlDbType.NVarChar,200),
					new SqlParameter("@hlevel", SqlDbType.NVarChar,50),
					new SqlParameter("@haddress", SqlDbType.NVarChar,50),
					new SqlParameter("@hcontent", SqlDbType.NVarChar,50),
					new SqlParameter("@hstatus", SqlDbType.TinyInt,1)};
			parameters[0].Value = model.hcityid;
			parameters[1].Value = model.hcity;
			parameters[2].Value = model.hname;
			parameters[3].Value = model.himage;
			parameters[4].Value = model.hlevel;
			parameters[5].Value = model.haddress;
			parameters[6].Value = model.hcontent;
			parameters[7].Value = model.hstatus;

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
		public bool Update(LW_AskOnline.Model.ask_hospital model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ask_hospital set ");
			strSql.Append("hcityid=@hcityid,");
			strSql.Append("hcity=@hcity,");
			strSql.Append("hname=@hname,");
			strSql.Append("himage=@himage,");
			strSql.Append("hlevel=@hlevel,");
			strSql.Append("haddress=@haddress,");
			strSql.Append("hcontent=@hcontent,");
			strSql.Append("hstatus=@hstatus");
			strSql.Append(" where hid=@hid");
			SqlParameter[] parameters = {
					new SqlParameter("@hcityid", SqlDbType.Int,4),
					new SqlParameter("@hcity", SqlDbType.NVarChar,50),
					new SqlParameter("@hname", SqlDbType.NVarChar,50),
					new SqlParameter("@himage", SqlDbType.NVarChar,200),
					new SqlParameter("@hlevel", SqlDbType.NVarChar,50),
					new SqlParameter("@haddress", SqlDbType.NVarChar,50),
					new SqlParameter("@hcontent", SqlDbType.NVarChar,50),
					new SqlParameter("@hstatus", SqlDbType.TinyInt,1),
					new SqlParameter("@hid", SqlDbType.Int,4)};
			parameters[0].Value = model.hcityid;
			parameters[1].Value = model.hcity;
			parameters[2].Value = model.hname;
			parameters[3].Value = model.himage;
			parameters[4].Value = model.hlevel;
			parameters[5].Value = model.haddress;
			parameters[6].Value = model.hcontent;
			parameters[7].Value = model.hstatus;
			parameters[8].Value = model.hid;

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
		public bool Delete(int hid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ask_hospital ");
			strSql.Append(" where hid=@hid");
			SqlParameter[] parameters = {
					new SqlParameter("@hid", SqlDbType.Int,4)
			};
			parameters[0].Value = hid;

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
		public bool DeleteList(string hidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ask_hospital ");
			strSql.Append(" where hid in ("+hidlist + ")  ");
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
		public LW_AskOnline.Model.ask_hospital GetModel(int hid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 hid,hcityid,hcity,hname,himage,hlevel,haddress,hcontent,hstatus from ask_hospital ");
			strSql.Append(" where hid=@hid");
			SqlParameter[] parameters = {
					new SqlParameter("@hid", SqlDbType.Int,4)
			};
			parameters[0].Value = hid;

			LW_AskOnline.Model.ask_hospital model=new LW_AskOnline.Model.ask_hospital();
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
		public LW_AskOnline.Model.ask_hospital DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.ask_hospital model=new LW_AskOnline.Model.ask_hospital();
			if (row != null)
			{
				if(row["hid"]!=null && row["hid"].ToString()!="")
				{
					model.hid=int.Parse(row["hid"].ToString());
				}
				if(row["hcityid"]!=null && row["hcityid"].ToString()!="")
				{
					model.hcityid=int.Parse(row["hcityid"].ToString());
				}
				if(row["hcity"]!=null)
				{
					model.hcity=row["hcity"].ToString();
				}
				if(row["hname"]!=null)
				{
					model.hname=row["hname"].ToString();
				}
				if(row["himage"]!=null)
				{
					model.himage=row["himage"].ToString();
				}
				if(row["hlevel"]!=null)
				{
					model.hlevel=row["hlevel"].ToString();
				}
				if(row["haddress"]!=null)
				{
					model.haddress=row["haddress"].ToString();
				}
				if(row["hcontent"]!=null)
				{
					model.hcontent=row["hcontent"].ToString();
				}
				if(row["hstatus"]!=null && row["hstatus"].ToString()!="")
				{
					model.hstatus=int.Parse(row["hstatus"].ToString());
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
			strSql.Append("select hid,hcityid,hcity,hname,himage,hlevel,haddress,hcontent,hstatus ");
			strSql.Append(" FROM ask_hospital ");
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
			strSql.Append(" hid,hcityid,hcity,hname,himage,hlevel,haddress,hcontent,hstatus ");
			strSql.Append(" FROM ask_hospital ");
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
			strSql.Append("select count(1) FROM ask_hospital ");
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
				strSql.Append("order by T.hid desc");
			}
			strSql.Append(")AS Row, T.*  from ask_hospital T ");
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
			parameters[0].Value = "ask_hospital";
			parameters[1].Value = "hid";
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

