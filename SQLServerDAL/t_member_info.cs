using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:t_member_info
	/// </summary>
	public partial class t_member_info:It_member_info
	{
		public t_member_info()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_member_info");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.BigInt)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public long Add(LW_AskOnline.Model.t_member_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_member_info(");
			strSql.Append("name,sex,age,mobile,card,company_id,level_id,email,password,office,member_type,open_id,createtime,platfrom_id)");
			strSql.Append(" values (");
			strSql.Append("@name,@sex,@age,@mobile,@card,@company_id,@level_id,@email,@password,@office,@member_type,@open_id,@createtime,@platfrom_id)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@sex", SqlDbType.VarChar,5),
					new SqlParameter("@age", SqlDbType.Int,4),
					new SqlParameter("@mobile", SqlDbType.VarChar,50),
					new SqlParameter("@card", SqlDbType.VarChar,50),
					new SqlParameter("@company_id", SqlDbType.Int,4),
					new SqlParameter("@level_id", SqlDbType.BigInt,8),
					new SqlParameter("@email", SqlDbType.VarChar,50),
					new SqlParameter("@password", SqlDbType.VarChar,50),
					new SqlParameter("@office", SqlDbType.VarChar,50),
					new SqlParameter("@member_type", SqlDbType.VarChar,20),
					new SqlParameter("@open_id", SqlDbType.VarChar,100),
					new SqlParameter("@createtime", SqlDbType.DateTime),
					new SqlParameter("@platfrom_id", SqlDbType.VarChar,30)};
			parameters[0].Value = model.name;
			parameters[1].Value = model.sex;
			parameters[2].Value = model.age;
			parameters[3].Value = model.mobile;
			parameters[4].Value = model.card;
			parameters[5].Value = model.company_id;
			parameters[6].Value = model.level_id;
			parameters[7].Value = model.email;
			parameters[8].Value = model.password;
			parameters[9].Value = model.office;
			parameters[10].Value = model.member_type;
			parameters[11].Value = model.open_id;
			parameters[12].Value = model.createtime;
			parameters[13].Value = model.platfrom_id;

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
		public bool Update(LW_AskOnline.Model.t_member_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_member_info set ");
			strSql.Append("name=@name,");
			strSql.Append("sex=@sex,");
			strSql.Append("age=@age,");
			strSql.Append("mobile=@mobile,");
			strSql.Append("card=@card,");
			strSql.Append("company_id=@company_id,");
			strSql.Append("level_id=@level_id,");
			strSql.Append("email=@email,");
			strSql.Append("password=@password,");
			strSql.Append("office=@office,");
			strSql.Append("member_type=@member_type,");
			strSql.Append("open_id=@open_id,");
			strSql.Append("createtime=@createtime,");
			strSql.Append("platfrom_id=@platfrom_id");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@sex", SqlDbType.VarChar,5),
					new SqlParameter("@age", SqlDbType.Int,4),
					new SqlParameter("@mobile", SqlDbType.VarChar,50),
					new SqlParameter("@card", SqlDbType.VarChar,50),
					new SqlParameter("@company_id", SqlDbType.Int,4),
					new SqlParameter("@level_id", SqlDbType.BigInt,8),
					new SqlParameter("@email", SqlDbType.VarChar,50),
					new SqlParameter("@password", SqlDbType.VarChar,50),
					new SqlParameter("@office", SqlDbType.VarChar,50),
					new SqlParameter("@member_type", SqlDbType.VarChar,20),
					new SqlParameter("@open_id", SqlDbType.VarChar,100),
					new SqlParameter("@createtime", SqlDbType.DateTime),
					new SqlParameter("@platfrom_id", SqlDbType.VarChar,30),
					new SqlParameter("@id", SqlDbType.BigInt,8)};
			parameters[0].Value = model.name;
			parameters[1].Value = model.sex;
			parameters[2].Value = model.age;
			parameters[3].Value = model.mobile;
			parameters[4].Value = model.card;
			parameters[5].Value = model.company_id;
			parameters[6].Value = model.level_id;
			parameters[7].Value = model.email;
			parameters[8].Value = model.password;
			parameters[9].Value = model.office;
			parameters[10].Value = model.member_type;
			parameters[11].Value = model.open_id;
			parameters[12].Value = model.createtime;
			parameters[13].Value = model.platfrom_id;
			parameters[14].Value = model.id;

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
		public bool Delete(long id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_member_info ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.BigInt)
			};
			parameters[0].Value = id;

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
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_member_info ");
			strSql.Append(" where id in ("+idlist + ")  ");
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
		public LW_AskOnline.Model.t_member_info GetModel(long id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,name,sex,age,mobile,card,company_id,level_id,email,password,office,member_type,open_id,createtime,platfrom_id from t_member_info ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.BigInt)
			};
			parameters[0].Value = id;

			LW_AskOnline.Model.t_member_info model=new LW_AskOnline.Model.t_member_info();
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
		public LW_AskOnline.Model.t_member_info DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_member_info model=new LW_AskOnline.Model.t_member_info();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=long.Parse(row["id"].ToString());
				}
				if(row["name"]!=null)
				{
					model.name=row["name"].ToString();
				}
				if(row["sex"]!=null)
				{
					model.sex=row["sex"].ToString();
				}
				if(row["age"]!=null && row["age"].ToString()!="")
				{
					model.age=int.Parse(row["age"].ToString());
				}
				if(row["mobile"]!=null)
				{
					model.mobile=row["mobile"].ToString();
				}
				if(row["card"]!=null)
				{
					model.card=row["card"].ToString();
				}
				if(row["company_id"]!=null && row["company_id"].ToString()!="")
				{
					model.company_id=int.Parse(row["company_id"].ToString());
				}
				if(row["level_id"]!=null && row["level_id"].ToString()!="")
				{
					model.level_id=long.Parse(row["level_id"].ToString());
				}
				if(row["email"]!=null)
				{
					model.email=row["email"].ToString();
				}
				if(row["password"]!=null)
				{
					model.password=row["password"].ToString();
				}
				if(row["office"]!=null)
				{
					model.office=row["office"].ToString();
				}
				if(row["member_type"]!=null)
				{
					model.member_type=row["member_type"].ToString();
				}
				if(row["open_id"]!=null)
				{
					model.open_id=row["open_id"].ToString();
				}
				if(row["createtime"]!=null && row["createtime"].ToString()!="")
				{
					model.createtime=DateTime.Parse(row["createtime"].ToString());
				}
				if(row["platfrom_id"]!=null)
				{
					model.platfrom_id=row["platfrom_id"].ToString();
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
			strSql.Append("select id,name,sex,age,mobile,card,company_id,level_id,email,password,office,member_type,open_id,createtime,platfrom_id ");
			strSql.Append(" FROM t_member_info ");
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
			strSql.Append(" id,name,sex,age,mobile,card,company_id,level_id,email,password,office,member_type,open_id,createtime,platfrom_id ");
			strSql.Append(" FROM t_member_info ");
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
			strSql.Append("select count(1) FROM t_member_info ");
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
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from t_member_info T ");
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
			parameters[0].Value = "t_member_info";
			parameters[1].Value = "id";
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

