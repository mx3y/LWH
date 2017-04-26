using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:ask_illpersion
	/// </summary>
	public partial class ask_illpersion:Iask_illpersion
	{
		public ask_illpersion()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("iid", "ask_illpersion"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int iid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ask_illpersion");
			strSql.Append(" where iid=@iid");
			SqlParameter[] parameters = {
					new SqlParameter("@iid", SqlDbType.Int,4)
			};
			parameters[0].Value = iid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(LW_AskOnline.Model.ask_illpersion model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ask_illpersion(");
			strSql.Append("uid,iname,iphone,icardtype,icard,isex,ibirthday,iaddress)");
			strSql.Append(" values (");
			strSql.Append("@uid,@iname,@iphone,@icardtype,@icard,@isex,@ibirthday,@iaddress)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@uid", SqlDbType.Int,4),
					new SqlParameter("@iname", SqlDbType.NVarChar,200),
					new SqlParameter("@iphone", SqlDbType.NVarChar,200),
					new SqlParameter("@icardtype", SqlDbType.NVarChar,200),
					new SqlParameter("@icard", SqlDbType.NVarChar,200),
					new SqlParameter("@isex", SqlDbType.NVarChar,200),
					new SqlParameter("@ibirthday", SqlDbType.DateTime),
					new SqlParameter("@iaddress", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.uid;
			parameters[1].Value = model.iname;
			parameters[2].Value = model.iphone;
			parameters[3].Value = model.icardtype;
			parameters[4].Value = model.icard;
			parameters[5].Value = model.isex;
			parameters[6].Value = model.ibirthday;
			parameters[7].Value = model.iaddress;

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
		public bool Update(LW_AskOnline.Model.ask_illpersion model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ask_illpersion set ");
			strSql.Append("uid=@uid,");
			strSql.Append("iname=@iname,");
			strSql.Append("iphone=@iphone,");
			strSql.Append("icardtype=@icardtype,");
			strSql.Append("icard=@icard,");
			strSql.Append("isex=@isex,");
			strSql.Append("ibirthday=@ibirthday,");
			strSql.Append("iaddress=@iaddress");
			strSql.Append(" where iid=@iid");
			SqlParameter[] parameters = {
					new SqlParameter("@uid", SqlDbType.Int,4),
					new SqlParameter("@iname", SqlDbType.NVarChar,200),
					new SqlParameter("@iphone", SqlDbType.NVarChar,200),
					new SqlParameter("@icardtype", SqlDbType.NVarChar,200),
					new SqlParameter("@icard", SqlDbType.NVarChar,200),
					new SqlParameter("@isex", SqlDbType.NVarChar,200),
					new SqlParameter("@ibirthday", SqlDbType.DateTime),
					new SqlParameter("@iaddress", SqlDbType.NVarChar,200),
					new SqlParameter("@iid", SqlDbType.Int,4)};
			parameters[0].Value = model.uid;
			parameters[1].Value = model.iname;
			parameters[2].Value = model.iphone;
			parameters[3].Value = model.icardtype;
			parameters[4].Value = model.icard;
			parameters[5].Value = model.isex;
			parameters[6].Value = model.ibirthday;
			parameters[7].Value = model.iaddress;
			parameters[8].Value = model.iid;

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
		public bool Delete(int iid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ask_illpersion ");
			strSql.Append(" where iid=@iid");
			SqlParameter[] parameters = {
					new SqlParameter("@iid", SqlDbType.Int,4)
			};
			parameters[0].Value = iid;

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
		public bool DeleteList(string iidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ask_illpersion ");
			strSql.Append(" where iid in ("+iidlist + ")  ");
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
		public LW_AskOnline.Model.ask_illpersion GetModel(int iid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 iid,uid,iname,iphone,icardtype,icard,isex,ibirthday,iaddress from ask_illpersion ");
			strSql.Append(" where iid=@iid");
			SqlParameter[] parameters = {
					new SqlParameter("@iid", SqlDbType.Int,4)
			};
			parameters[0].Value = iid;

			LW_AskOnline.Model.ask_illpersion model=new LW_AskOnline.Model.ask_illpersion();
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
		public LW_AskOnline.Model.ask_illpersion DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.ask_illpersion model=new LW_AskOnline.Model.ask_illpersion();
			if (row != null)
			{
				if(row["iid"]!=null && row["iid"].ToString()!="")
				{
					model.iid=int.Parse(row["iid"].ToString());
				}
				if(row["uid"]!=null && row["uid"].ToString()!="")
				{
					model.uid=int.Parse(row["uid"].ToString());
				}
				if(row["iname"]!=null)
				{
					model.iname=row["iname"].ToString();
				}
				if(row["iphone"]!=null)
				{
					model.iphone=row["iphone"].ToString();
				}
				if(row["icardtype"]!=null)
				{
					model.icardtype=row["icardtype"].ToString();
				}
				if(row["icard"]!=null)
				{
					model.icard=row["icard"].ToString();
				}
				if(row["isex"]!=null)
				{
					model.isex=row["isex"].ToString();
				}
				if(row["ibirthday"]!=null && row["ibirthday"].ToString()!="")
				{
					model.ibirthday=DateTime.Parse(row["ibirthday"].ToString());
				}
				if(row["iaddress"]!=null)
				{
					model.iaddress=row["iaddress"].ToString();
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
			strSql.Append("select iid,uid,iname,iphone,icardtype,icard,isex,ibirthday,iaddress ");
			strSql.Append(" FROM ask_illpersion ");
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
			strSql.Append(" iid,uid,iname,iphone,icardtype,icard,isex,ibirthday,iaddress ");
			strSql.Append(" FROM ask_illpersion ");
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
			strSql.Append("select count(1) FROM ask_illpersion ");
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
				strSql.Append("order by T.iid desc");
			}
			strSql.Append(")AS Row, T.*  from ask_illpersion T ");
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
			parameters[0].Value = "ask_illpersion";
			parameters[1].Value = "iid";
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

