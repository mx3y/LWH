using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:sys_user
	/// </summary>
	public partial class sys_user
	{
		public sys_user()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long user_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sys_user");
			strSql.Append(" where user_id=@user_id");
			SqlParameter[] parameters = {
					new SqlParameter("@user_id", SqlDbType.BigInt)
			};
			parameters[0].Value = user_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public long Add(LW_AskOnline.Model.sys_user model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sys_user(");
			strSql.Append("user_name,tel,email,del_flag,create_date,create_man,login_name,login_pwd,user_code,is_admin)");
			strSql.Append(" values (");
			strSql.Append("@user_name,@tel,@email,@del_flag,@create_date,@create_man,@login_name,@login_pwd,@user_code,@is_admin)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@user_name", SqlDbType.NVarChar,65),
					new SqlParameter("@tel", SqlDbType.NVarChar,15),
					new SqlParameter("@email", SqlDbType.NVarChar,35),
					new SqlParameter("@del_flag", SqlDbType.NVarChar,2),
					new SqlParameter("@create_date", SqlDbType.DateTime),
					new SqlParameter("@create_man", SqlDbType.NVarChar,35),
					new SqlParameter("@login_name", SqlDbType.NVarChar,35),
					new SqlParameter("@login_pwd", SqlDbType.NVarChar,35),
					new SqlParameter("@user_code", SqlDbType.NVarChar,20),
					new SqlParameter("@is_admin", SqlDbType.VarChar,2)};
			parameters[0].Value = model.user_name;
			parameters[1].Value = model.tel;
			parameters[2].Value = model.email;
			parameters[3].Value = model.del_flag;
			parameters[4].Value = model.create_date;
			parameters[5].Value = model.create_man;
			parameters[6].Value = model.login_name;
			parameters[7].Value = model.login_pwd;
			parameters[8].Value = model.user_code;
			parameters[9].Value = model.is_admin;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt64(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(LW_AskOnline.Model.sys_user model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sys_user set ");
			strSql.Append("user_name=@user_name,");
			strSql.Append("tel=@tel,");
			strSql.Append("email=@email,");
			strSql.Append("del_flag=@del_flag,");
			strSql.Append("create_date=@create_date,");
			strSql.Append("create_man=@create_man,");
			strSql.Append("login_name=@login_name,");
			strSql.Append("login_pwd=@login_pwd,");
			strSql.Append("user_code=@user_code,");
			strSql.Append("is_admin=@is_admin");
			strSql.Append(" where user_id=@user_id");
			SqlParameter[] parameters = {
					new SqlParameter("@user_name", SqlDbType.NVarChar,65),
					new SqlParameter("@tel", SqlDbType.NVarChar,15),
					new SqlParameter("@email", SqlDbType.NVarChar,35),
					new SqlParameter("@del_flag", SqlDbType.NVarChar,2),
					new SqlParameter("@create_date", SqlDbType.DateTime),
					new SqlParameter("@create_man", SqlDbType.NVarChar,35),
					new SqlParameter("@login_name", SqlDbType.NVarChar,35),
					new SqlParameter("@login_pwd", SqlDbType.NVarChar,35),
					new SqlParameter("@user_code", SqlDbType.NVarChar,20),
					new SqlParameter("@is_admin", SqlDbType.VarChar,2),
					new SqlParameter("@user_id", SqlDbType.BigInt,8)};
			parameters[0].Value = model.user_name;
			parameters[1].Value = model.tel;
			parameters[2].Value = model.email;
			parameters[3].Value = model.del_flag;
			parameters[4].Value = model.create_date;
			parameters[5].Value = model.create_man;
			parameters[6].Value = model.login_name;
			parameters[7].Value = model.login_pwd;
			parameters[8].Value = model.user_code;
			parameters[9].Value = model.is_admin;
			parameters[10].Value = model.user_id;

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
		public bool Delete(long user_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_user ");
			strSql.Append(" where user_id=@user_id");
			SqlParameter[] parameters = {
					new SqlParameter("@user_id", SqlDbType.BigInt)
			};
			parameters[0].Value = user_id;

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
		public bool DeleteList(string user_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_user ");
			strSql.Append(" where user_id in ("+user_idlist + ")  ");
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
		public LW_AskOnline.Model.sys_user GetModel(long user_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 user_id,user_name,tel,email,del_flag,create_date,create_man,login_name,login_pwd,user_code,is_admin from sys_user ");
			strSql.Append(" where user_id=@user_id");
			SqlParameter[] parameters = {
					new SqlParameter("@user_id", SqlDbType.BigInt)
			};
			parameters[0].Value = user_id;

			LW_AskOnline.Model.sys_user model=new LW_AskOnline.Model.sys_user();
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
		public LW_AskOnline.Model.sys_user DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.sys_user model=new LW_AskOnline.Model.sys_user();
			if (row != null)
			{
				if(row["user_id"]!=null && row["user_id"].ToString()!="")
				{
					model.user_id=long.Parse(row["user_id"].ToString());
				}
				if(row["user_name"]!=null)
				{
					model.user_name=row["user_name"].ToString();
				}
				if(row["tel"]!=null)
				{
					model.tel=row["tel"].ToString();
				}
				if(row["email"]!=null)
				{
					model.email=row["email"].ToString();
				}
				if(row["del_flag"]!=null)
				{
					model.del_flag=row["del_flag"].ToString();
				}
				if(row["create_date"]!=null && row["create_date"].ToString()!="")
				{
					model.create_date=DateTime.Parse(row["create_date"].ToString());
				}
				if(row["create_man"]!=null)
				{
					model.create_man=row["create_man"].ToString();
				}
				if(row["login_name"]!=null)
				{
					model.login_name=row["login_name"].ToString();
				}
				if(row["login_pwd"]!=null)
				{
					model.login_pwd=row["login_pwd"].ToString();
				}
				if(row["user_code"]!=null)
				{
					model.user_code=row["user_code"].ToString();
				}
				if(row["is_admin"]!=null)
				{
					model.is_admin=row["is_admin"].ToString();
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
			strSql.Append("select user_id,user_name,tel,email,del_flag,create_date,create_man,login_name,login_pwd,user_code,is_admin ");
			strSql.Append(" FROM sys_user ");
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
			strSql.Append(" user_id,user_name,tel,email,del_flag,create_date,create_man,login_name,login_pwd,user_code,is_admin ");
			strSql.Append(" FROM sys_user ");
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
			strSql.Append("select count(1) FROM sys_user ");
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
				strSql.Append("order by T.user_id desc");
			}
			strSql.Append(")AS Row, T.*  from sys_user T ");
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
			parameters[0].Value = "sys_user";
			parameters[1].Value = "user_id";
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

