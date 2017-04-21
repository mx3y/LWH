using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:t_base_item_info
	/// </summary>
	public partial class t_base_item_info
	{
		public t_base_item_info()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "t_base_item_info"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_base_item_info");
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
		public int Add(LW_AskOnline.Model.t_base_item_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_base_item_info(");
			strSql.Append("item_code,item_name,guide_price,type_id,remark,usesex,recindex,create_time,details,recommend_age_end,recommend_age_start)");
			strSql.Append(" values (");
			strSql.Append("@item_code,@item_name,@guide_price,@type_id,@remark,@usesex,@recindex,@create_time,@details,@recommend_age_end,@recommend_age_start)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@item_code", SqlDbType.NVarChar,50),
					new SqlParameter("@item_name", SqlDbType.NVarChar,100),
					new SqlParameter("@guide_price", SqlDbType.Decimal,9),
					new SqlParameter("@type_id", SqlDbType.NVarChar,20),
					new SqlParameter("@remark", SqlDbType.VarChar,255),
					new SqlParameter("@usesex", SqlDbType.VarChar,255),
					new SqlParameter("@recindex", SqlDbType.VarChar,50),
					new SqlParameter("@create_time", SqlDbType.DateTime),
					new SqlParameter("@details", SqlDbType.VarChar,255),
					new SqlParameter("@recommend_age_end", SqlDbType.VarChar,255),
					new SqlParameter("@recommend_age_start", SqlDbType.VarChar,255)};
			parameters[0].Value = model.item_code;
			parameters[1].Value = model.item_name;
			parameters[2].Value = model.guide_price;
			parameters[3].Value = model.type_id;
			parameters[4].Value = model.remark;
			parameters[5].Value = model.usesex;
			parameters[6].Value = model.recindex;
			parameters[7].Value = model.create_time;
			parameters[8].Value = model.details;
			parameters[9].Value = model.recommend_age_end;
			parameters[10].Value = model.recommend_age_start;

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
		public bool Update(LW_AskOnline.Model.t_base_item_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_base_item_info set ");
			strSql.Append("item_code=@item_code,");
			strSql.Append("item_name=@item_name,");
			strSql.Append("guide_price=@guide_price,");
			strSql.Append("type_id=@type_id,");
			strSql.Append("remark=@remark,");
			strSql.Append("usesex=@usesex,");
			strSql.Append("recindex=@recindex,");
			strSql.Append("create_time=@create_time,");
			strSql.Append("details=@details,");
			strSql.Append("recommend_age_end=@recommend_age_end,");
			strSql.Append("recommend_age_start=@recommend_age_start");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@item_code", SqlDbType.NVarChar,50),
					new SqlParameter("@item_name", SqlDbType.NVarChar,100),
					new SqlParameter("@guide_price", SqlDbType.Decimal,9),
					new SqlParameter("@type_id", SqlDbType.NVarChar,20),
					new SqlParameter("@remark", SqlDbType.VarChar,255),
					new SqlParameter("@usesex", SqlDbType.VarChar,255),
					new SqlParameter("@recindex", SqlDbType.VarChar,50),
					new SqlParameter("@create_time", SqlDbType.DateTime),
					new SqlParameter("@details", SqlDbType.VarChar,255),
					new SqlParameter("@recommend_age_end", SqlDbType.VarChar,255),
					new SqlParameter("@recommend_age_start", SqlDbType.VarChar,255),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.item_code;
			parameters[1].Value = model.item_name;
			parameters[2].Value = model.guide_price;
			parameters[3].Value = model.type_id;
			parameters[4].Value = model.remark;
			parameters[5].Value = model.usesex;
			parameters[6].Value = model.recindex;
			parameters[7].Value = model.create_time;
			parameters[8].Value = model.details;
			parameters[9].Value = model.recommend_age_end;
			parameters[10].Value = model.recommend_age_start;
			parameters[11].Value = model.id;

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
			strSql.Append("delete from t_base_item_info ");
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
			strSql.Append("delete from t_base_item_info ");
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
		public LW_AskOnline.Model.t_base_item_info GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,item_code,item_name,guide_price,type_id,remark,usesex,recindex,create_time,details,recommend_age_end,recommend_age_start from t_base_item_info ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			LW_AskOnline.Model.t_base_item_info model=new LW_AskOnline.Model.t_base_item_info();
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
		public LW_AskOnline.Model.t_base_item_info DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_base_item_info model=new LW_AskOnline.Model.t_base_item_info();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["item_code"]!=null)
				{
					model.item_code=row["item_code"].ToString();
				}
				if(row["item_name"]!=null)
				{
					model.item_name=row["item_name"].ToString();
				}
				if(row["guide_price"]!=null && row["guide_price"].ToString()!="")
				{
					model.guide_price=decimal.Parse(row["guide_price"].ToString());
				}
				if(row["type_id"]!=null)
				{
					model.type_id=row["type_id"].ToString();
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
				}
				if(row["usesex"]!=null)
				{
					model.usesex=row["usesex"].ToString();
				}
				if(row["recindex"]!=null)
				{
					model.recindex=row["recindex"].ToString();
				}
				if(row["create_time"]!=null && row["create_time"].ToString()!="")
				{
					model.create_time=DateTime.Parse(row["create_time"].ToString());
				}
				if(row["details"]!=null)
				{
					model.details=row["details"].ToString();
				}
				if(row["recommend_age_end"]!=null)
				{
					model.recommend_age_end=row["recommend_age_end"].ToString();
				}
				if(row["recommend_age_start"]!=null)
				{
					model.recommend_age_start=row["recommend_age_start"].ToString();
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
			strSql.Append("select id,item_code,item_name,guide_price,type_id,remark,usesex,recindex,create_time,details,recommend_age_end,recommend_age_start ");
			strSql.Append(" FROM t_base_item_info ");
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
			strSql.Append(" id,item_code,item_name,guide_price,type_id,remark,usesex,recindex,create_time,details,recommend_age_end,recommend_age_start ");
			strSql.Append(" FROM t_base_item_info ");
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
			strSql.Append("select count(1) FROM t_base_item_info ");
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
			strSql.Append(")AS Row, T.*  from t_base_item_info T ");
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
			parameters[0].Value = "t_base_item_info";
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

