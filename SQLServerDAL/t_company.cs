using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:t_company
	/// </summary>
	public partial class t_company:It_company
	{
		public t_company()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "t_company"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_company");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(LW_AskOnline.Model.t_company model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_company(");
			strSql.Append("company_name,address,logo,weixin_name,province,city,area,create_date,update_time,platform_id,platform_name,company_img,company_info,platform_img,platform_info)");
			strSql.Append(" values (");
			strSql.Append("@company_name,@address,@logo,@weixin_name,@province,@city,@area,@create_date,@update_time,@platform_id,@platform_name,@company_img,@company_info,@platform_img,@platform_info)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@company_name", SqlDbType.VarChar,100),
					new SqlParameter("@address", SqlDbType.VarChar,500),
					new SqlParameter("@logo", SqlDbType.VarChar,500),
					new SqlParameter("@weixin_name", SqlDbType.VarChar,100),
					new SqlParameter("@province", SqlDbType.VarChar,100),
					new SqlParameter("@city", SqlDbType.VarChar,100),
					new SqlParameter("@area", SqlDbType.VarChar,100),
					new SqlParameter("@create_date", SqlDbType.DateTime),
					new SqlParameter("@update_time", SqlDbType.DateTime),
					new SqlParameter("@platform_id", SqlDbType.Int,4),
					new SqlParameter("@platform_name", SqlDbType.VarChar,255),
					new SqlParameter("@company_img", SqlDbType.VarChar,255),
					new SqlParameter("@company_info", SqlDbType.VarChar,1000),
					new SqlParameter("@platform_img", SqlDbType.VarChar,255),
					new SqlParameter("@platform_info", SqlDbType.VarChar,255)};
			parameters[0].Value = model.company_name;
			parameters[1].Value = model.address;
			parameters[2].Value = model.logo;
			parameters[3].Value = model.weixin_name;
			parameters[4].Value = model.province;
			parameters[5].Value = model.city;
			parameters[6].Value = model.area;
			parameters[7].Value = model.create_date;
			parameters[8].Value = model.update_time;
			parameters[9].Value = model.platform_id;
			parameters[10].Value = model.platform_name;
			parameters[11].Value = model.company_img;
			parameters[12].Value = model.company_info;
			parameters[13].Value = model.platform_img;
			parameters[14].Value = model.platform_info;

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
		public bool Update(LW_AskOnline.Model.t_company model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_company set ");
			strSql.Append("company_name=@company_name,");
			strSql.Append("address=@address,");
			strSql.Append("logo=@logo,");
			strSql.Append("weixin_name=@weixin_name,");
			strSql.Append("province=@province,");
			strSql.Append("city=@city,");
			strSql.Append("area=@area,");
			strSql.Append("create_date=@create_date,");
			strSql.Append("update_time=@update_time,");
			strSql.Append("platform_id=@platform_id,");
			strSql.Append("platform_name=@platform_name,");
			strSql.Append("company_img=@company_img,");
			strSql.Append("company_info=@company_info,");
			strSql.Append("platform_img=@platform_img,");
			strSql.Append("platform_info=@platform_info");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@company_name", SqlDbType.VarChar,100),
					new SqlParameter("@address", SqlDbType.VarChar,500),
					new SqlParameter("@logo", SqlDbType.VarChar,500),
					new SqlParameter("@weixin_name", SqlDbType.VarChar,100),
					new SqlParameter("@province", SqlDbType.VarChar,100),
					new SqlParameter("@city", SqlDbType.VarChar,100),
					new SqlParameter("@area", SqlDbType.VarChar,100),
					new SqlParameter("@create_date", SqlDbType.DateTime),
					new SqlParameter("@update_time", SqlDbType.DateTime),
					new SqlParameter("@platform_id", SqlDbType.Int,4),
					new SqlParameter("@platform_name", SqlDbType.VarChar,255),
					new SqlParameter("@company_img", SqlDbType.VarChar,255),
					new SqlParameter("@company_info", SqlDbType.VarChar,1000),
					new SqlParameter("@platform_img", SqlDbType.VarChar,255),
					new SqlParameter("@platform_info", SqlDbType.VarChar,255),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.company_name;
			parameters[1].Value = model.address;
			parameters[2].Value = model.logo;
			parameters[3].Value = model.weixin_name;
			parameters[4].Value = model.province;
			parameters[5].Value = model.city;
			parameters[6].Value = model.area;
			parameters[7].Value = model.create_date;
			parameters[8].Value = model.update_time;
			parameters[9].Value = model.platform_id;
			parameters[10].Value = model.platform_name;
			parameters[11].Value = model.company_img;
			parameters[12].Value = model.company_info;
			parameters[13].Value = model.platform_img;
			parameters[14].Value = model.platform_info;
			parameters[15].Value = model.id;

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
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_company ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
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
			strSql.Append("delete from t_company ");
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
		public LW_AskOnline.Model.t_company GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,company_name,address,logo,weixin_name,province,city,area,create_date,update_time,platform_id,platform_name,company_img,company_info,platform_img,platform_info from t_company ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			LW_AskOnline.Model.t_company model=new LW_AskOnline.Model.t_company();
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
		public LW_AskOnline.Model.t_company DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_company model=new LW_AskOnline.Model.t_company();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["company_name"]!=null)
				{
					model.company_name=row["company_name"].ToString();
				}
				if(row["address"]!=null)
				{
					model.address=row["address"].ToString();
				}
				if(row["logo"]!=null)
				{
					model.logo=row["logo"].ToString();
				}
				if(row["weixin_name"]!=null)
				{
					model.weixin_name=row["weixin_name"].ToString();
				}
				if(row["province"]!=null)
				{
					model.province=row["province"].ToString();
				}
				if(row["city"]!=null)
				{
					model.city=row["city"].ToString();
				}
				if(row["area"]!=null)
				{
					model.area=row["area"].ToString();
				}
				if(row["create_date"]!=null && row["create_date"].ToString()!="")
				{
					model.create_date=DateTime.Parse(row["create_date"].ToString());
				}
				if(row["update_time"]!=null && row["update_time"].ToString()!="")
				{
					model.update_time=DateTime.Parse(row["update_time"].ToString());
				}
				if(row["platform_id"]!=null && row["platform_id"].ToString()!="")
				{
					model.platform_id=int.Parse(row["platform_id"].ToString());
				}
				if(row["platform_name"]!=null)
				{
					model.platform_name=row["platform_name"].ToString();
				}
				if(row["company_img"]!=null)
				{
					model.company_img=row["company_img"].ToString();
				}
				if(row["company_info"]!=null)
				{
					model.company_info=row["company_info"].ToString();
				}
				if(row["platform_img"]!=null)
				{
					model.platform_img=row["platform_img"].ToString();
				}
				if(row["platform_info"]!=null)
				{
					model.platform_info=row["platform_info"].ToString();
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
			strSql.Append("select id,company_name,address,logo,weixin_name,province,city,area,create_date,update_time,platform_id,platform_name,company_img,company_info,platform_img,platform_info ");
			strSql.Append(" FROM t_company ");
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
			strSql.Append(" id,company_name,address,logo,weixin_name,province,city,area,create_date,update_time,platform_id,platform_name,company_img,company_info,platform_img,platform_info ");
			strSql.Append(" FROM t_company ");
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
			strSql.Append("select count(1) FROM t_company ");
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
			strSql.Append(")AS Row, T.*  from t_company T ");
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
			parameters[0].Value = "t_company";
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

