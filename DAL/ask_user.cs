using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:ask_user
	/// </summary>
	public partial class ask_user
	{
		public ask_user()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("uuid", "ask_user"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int uuid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ask_user");
			strSql.Append(" where uuid=@uuid");
			SqlParameter[] parameters = {
					new SqlParameter("@uuid", SqlDbType.Int,4)
			};
			parameters[0].Value = uuid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(LW_AskOnline.Model.ask_user model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ask_user(");
			strSql.Append("utijtid,ucompanymonery,umonery,uaccount,upassword,ucardnumber,uopenid,umail,ubrithday,usex,ucompanyid,uregisterdatetime,uregisterip,ulastdatetime,ulastip,ustate)");
			strSql.Append(" values (");
			strSql.Append("@utijtid,@ucompanymonery,@umonery,@uaccount,@upassword,@ucardnumber,@uopenid,@umail,@ubrithday,@usex,@ucompanyid,@uregisterdatetime,@uregisterip,@ulastdatetime,@ulastip,@ustate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@utijtid", SqlDbType.Int,4),
					new SqlParameter("@ucompanymonery", SqlDbType.Decimal,9),
					new SqlParameter("@umonery", SqlDbType.Decimal,9),
					new SqlParameter("@uaccount", SqlDbType.NVarChar,50),
					new SqlParameter("@upassword", SqlDbType.NVarChar,200),
					new SqlParameter("@ucardnumber", SqlDbType.NVarChar,50),
					new SqlParameter("@uopenid", SqlDbType.NVarChar,200),
					new SqlParameter("@umail", SqlDbType.NVarChar,200),
					new SqlParameter("@ubrithday", SqlDbType.DateTime),
					new SqlParameter("@usex", SqlDbType.NVarChar,20),
					new SqlParameter("@ucompanyid", SqlDbType.Int,4),
					new SqlParameter("@uregisterdatetime", SqlDbType.DateTime),
					new SqlParameter("@uregisterip", SqlDbType.NVarChar,20),
					new SqlParameter("@ulastdatetime", SqlDbType.DateTime),
					new SqlParameter("@ulastip", SqlDbType.NVarChar,20),
					new SqlParameter("@ustate", SqlDbType.TinyInt,1)};
			parameters[0].Value = model.utijtid;
			parameters[1].Value = model.ucompanymonery;
			parameters[2].Value = model.umonery;
			parameters[3].Value = model.uaccount;
			parameters[4].Value = model.upassword;
			parameters[5].Value = model.ucardnumber;
			parameters[6].Value = model.uopenid;
			parameters[7].Value = model.umail;
			parameters[8].Value = model.ubrithday;
			parameters[9].Value = model.usex;
			parameters[10].Value = model.ucompanyid;
			parameters[11].Value = model.uregisterdatetime;
			parameters[12].Value = model.uregisterip;
			parameters[13].Value = model.ulastdatetime;
			parameters[14].Value = model.ulastip;
			parameters[15].Value = model.ustate;

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
		public bool Update(LW_AskOnline.Model.ask_user model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ask_user set ");
			strSql.Append("utijtid=@utijtid,");
			strSql.Append("ucompanymonery=@ucompanymonery,");
			strSql.Append("umonery=@umonery,");
			strSql.Append("uaccount=@uaccount,");
			strSql.Append("upassword=@upassword,");
			strSql.Append("ucardnumber=@ucardnumber,");
			strSql.Append("uopenid=@uopenid,");
			strSql.Append("umail=@umail,");
			strSql.Append("ubrithday=@ubrithday,");
			strSql.Append("usex=@usex,");
			strSql.Append("ucompanyid=@ucompanyid,");
			strSql.Append("uregisterdatetime=@uregisterdatetime,");
			strSql.Append("uregisterip=@uregisterip,");
			strSql.Append("ulastdatetime=@ulastdatetime,");
			strSql.Append("ulastip=@ulastip,");
			strSql.Append("ustate=@ustate");
			strSql.Append(" where uuid=@uuid");
			SqlParameter[] parameters = {
					new SqlParameter("@utijtid", SqlDbType.Int,4),
					new SqlParameter("@ucompanymonery", SqlDbType.Decimal,9),
					new SqlParameter("@umonery", SqlDbType.Decimal,9),
					new SqlParameter("@uaccount", SqlDbType.NVarChar,50),
					new SqlParameter("@upassword", SqlDbType.NVarChar,200),
					new SqlParameter("@ucardnumber", SqlDbType.NVarChar,50),
					new SqlParameter("@uopenid", SqlDbType.NVarChar,200),
					new SqlParameter("@umail", SqlDbType.NVarChar,200),
					new SqlParameter("@ubrithday", SqlDbType.DateTime),
					new SqlParameter("@usex", SqlDbType.NVarChar,20),
					new SqlParameter("@ucompanyid", SqlDbType.Int,4),
					new SqlParameter("@uregisterdatetime", SqlDbType.DateTime),
					new SqlParameter("@uregisterip", SqlDbType.NVarChar,20),
					new SqlParameter("@ulastdatetime", SqlDbType.DateTime),
					new SqlParameter("@ulastip", SqlDbType.NVarChar,20),
					new SqlParameter("@ustate", SqlDbType.TinyInt,1),
					new SqlParameter("@uuid", SqlDbType.Int,4)};
			parameters[0].Value = model.utijtid;
			parameters[1].Value = model.ucompanymonery;
			parameters[2].Value = model.umonery;
			parameters[3].Value = model.uaccount;
			parameters[4].Value = model.upassword;
			parameters[5].Value = model.ucardnumber;
			parameters[6].Value = model.uopenid;
			parameters[7].Value = model.umail;
			parameters[8].Value = model.ubrithday;
			parameters[9].Value = model.usex;
			parameters[10].Value = model.ucompanyid;
			parameters[11].Value = model.uregisterdatetime;
			parameters[12].Value = model.uregisterip;
			parameters[13].Value = model.ulastdatetime;
			parameters[14].Value = model.ulastip;
			parameters[15].Value = model.ustate;
			parameters[16].Value = model.uuid;

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
		public bool Delete(int uuid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ask_user ");
			strSql.Append(" where uuid=@uuid");
			SqlParameter[] parameters = {
					new SqlParameter("@uuid", SqlDbType.Int,4)
			};
			parameters[0].Value = uuid;

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
		public bool DeleteList(string uuidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ask_user ");
			strSql.Append(" where uuid in ("+uuidlist + ")  ");
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
		public LW_AskOnline.Model.ask_user GetModel(int uuid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 uuid,utijtid,ucompanymonery,umonery,uaccount,upassword,ucardnumber,uopenid,umail,ubrithday,usex,ucompanyid,uregisterdatetime,uregisterip,ulastdatetime,ulastip,ustate from ask_user ");
			strSql.Append(" where uuid=@uuid");
			SqlParameter[] parameters = {
					new SqlParameter("@uuid", SqlDbType.Int,4)
			};
			parameters[0].Value = uuid;

			LW_AskOnline.Model.ask_user model=new LW_AskOnline.Model.ask_user();
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
		public LW_AskOnline.Model.ask_user DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.ask_user model=new LW_AskOnline.Model.ask_user();
			if (row != null)
			{
				if(row["uuid"]!=null && row["uuid"].ToString()!="")
				{
					model.uuid=int.Parse(row["uuid"].ToString());
				}
				if(row["utijtid"]!=null && row["utijtid"].ToString()!="")
				{
					model.utijtid=int.Parse(row["utijtid"].ToString());
				}
				if(row["ucompanymonery"]!=null && row["ucompanymonery"].ToString()!="")
				{
					model.ucompanymonery=decimal.Parse(row["ucompanymonery"].ToString());
				}
				if(row["umonery"]!=null && row["umonery"].ToString()!="")
				{
					model.umonery=decimal.Parse(row["umonery"].ToString());
				}
				if(row["uaccount"]!=null)
				{
					model.uaccount=row["uaccount"].ToString();
				}
				if(row["upassword"]!=null)
				{
					model.upassword=row["upassword"].ToString();
				}
				if(row["ucardnumber"]!=null)
				{
					model.ucardnumber=row["ucardnumber"].ToString();
				}
				if(row["uopenid"]!=null)
				{
					model.uopenid=row["uopenid"].ToString();
				}
				if(row["umail"]!=null)
				{
					model.umail=row["umail"].ToString();
				}
				if(row["ubrithday"]!=null && row["ubrithday"].ToString()!="")
				{
					model.ubrithday=DateTime.Parse(row["ubrithday"].ToString());
				}
				if(row["usex"]!=null)
				{
					model.usex=row["usex"].ToString();
				}
				if(row["ucompanyid"]!=null && row["ucompanyid"].ToString()!="")
				{
					model.ucompanyid=int.Parse(row["ucompanyid"].ToString());
				}
				if(row["uregisterdatetime"]!=null && row["uregisterdatetime"].ToString()!="")
				{
					model.uregisterdatetime=DateTime.Parse(row["uregisterdatetime"].ToString());
				}
				if(row["uregisterip"]!=null)
				{
					model.uregisterip=row["uregisterip"].ToString();
				}
				if(row["ulastdatetime"]!=null && row["ulastdatetime"].ToString()!="")
				{
					model.ulastdatetime=DateTime.Parse(row["ulastdatetime"].ToString());
				}
				if(row["ulastip"]!=null)
				{
					model.ulastip=row["ulastip"].ToString();
				}
				if(row["ustate"]!=null && row["ustate"].ToString()!="")
				{
					model.ustate=int.Parse(row["ustate"].ToString());
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
			strSql.Append("select uuid,utijtid,ucompanymonery,umonery,uaccount,upassword,ucardnumber,uopenid,umail,ubrithday,usex,ucompanyid,uregisterdatetime,uregisterip,ulastdatetime,ulastip,ustate ");
			strSql.Append(" FROM ask_user ");
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
			strSql.Append(" uuid,utijtid,ucompanymonery,umonery,uaccount,upassword,ucardnumber,uopenid,umail,ubrithday,usex,ucompanyid,uregisterdatetime,uregisterip,ulastdatetime,ulastip,ustate ");
			strSql.Append(" FROM ask_user ");
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
			strSql.Append("select count(1) FROM ask_user ");
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
				strSql.Append("order by T.uuid desc");
			}
			strSql.Append(")AS Row, T.*  from ask_user T ");
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
			parameters[0].Value = "ask_user";
			parameters[1].Value = "uuid";
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

