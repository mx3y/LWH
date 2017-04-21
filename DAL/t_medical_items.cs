using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:t_medical_items
	/// </summary>
	public partial class t_medical_items
	{
		public t_medical_items()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "t_medical_items"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_medical_items");
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
		public int Add(LW_AskOnline.Model.t_medical_items model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_medical_items(");
			strSql.Append("org_id,item_name,item_code,item_price,base_item_id,item_type,recommend_index,org_name,type_id,usesex,orgitemcode,orgitemname)");
			strSql.Append(" values (");
			strSql.Append("@org_id,@item_name,@item_code,@item_price,@base_item_id,@item_type,@recommend_index,@org_name,@type_id,@usesex,@orgitemcode,@orgitemname)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@org_id", SqlDbType.Int,4),
					new SqlParameter("@item_name", SqlDbType.VarChar,100),
					new SqlParameter("@item_code", SqlDbType.VarChar,50),
					new SqlParameter("@item_price", SqlDbType.Float,8),
					new SqlParameter("@base_item_id", SqlDbType.Int,4),
					new SqlParameter("@item_type", SqlDbType.Int,4),
					new SqlParameter("@recommend_index", SqlDbType.Int,4),
					new SqlParameter("@org_name", SqlDbType.VarChar,100),
					new SqlParameter("@type_id", SqlDbType.Decimal,9),
					new SqlParameter("@usesex", SqlDbType.VarChar,255),
					new SqlParameter("@orgitemcode", SqlDbType.VarChar,255),
					new SqlParameter("@orgitemname", SqlDbType.VarChar,255)};
			parameters[0].Value = model.org_id;
			parameters[1].Value = model.item_name;
			parameters[2].Value = model.item_code;
			parameters[3].Value = model.item_price;
			parameters[4].Value = model.base_item_id;
			parameters[5].Value = model.item_type;
			parameters[6].Value = model.recommend_index;
			parameters[7].Value = model.org_name;
			parameters[8].Value = model.type_id;
			parameters[9].Value = model.usesex;
			parameters[10].Value = model.orgitemcode;
			parameters[11].Value = model.orgitemname;

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
		public bool Update(LW_AskOnline.Model.t_medical_items model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_medical_items set ");
			strSql.Append("org_id=@org_id,");
			strSql.Append("item_name=@item_name,");
			strSql.Append("item_code=@item_code,");
			strSql.Append("item_price=@item_price,");
			strSql.Append("base_item_id=@base_item_id,");
			strSql.Append("item_type=@item_type,");
			strSql.Append("recommend_index=@recommend_index,");
			strSql.Append("org_name=@org_name,");
			strSql.Append("type_id=@type_id,");
			strSql.Append("usesex=@usesex,");
			strSql.Append("orgitemcode=@orgitemcode,");
			strSql.Append("orgitemname=@orgitemname");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@org_id", SqlDbType.Int,4),
					new SqlParameter("@item_name", SqlDbType.VarChar,100),
					new SqlParameter("@item_code", SqlDbType.VarChar,50),
					new SqlParameter("@item_price", SqlDbType.Float,8),
					new SqlParameter("@base_item_id", SqlDbType.Int,4),
					new SqlParameter("@item_type", SqlDbType.Int,4),
					new SqlParameter("@recommend_index", SqlDbType.Int,4),
					new SqlParameter("@org_name", SqlDbType.VarChar,100),
					new SqlParameter("@type_id", SqlDbType.Decimal,9),
					new SqlParameter("@usesex", SqlDbType.VarChar,255),
					new SqlParameter("@orgitemcode", SqlDbType.VarChar,255),
					new SqlParameter("@orgitemname", SqlDbType.VarChar,255),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.org_id;
			parameters[1].Value = model.item_name;
			parameters[2].Value = model.item_code;
			parameters[3].Value = model.item_price;
			parameters[4].Value = model.base_item_id;
			parameters[5].Value = model.item_type;
			parameters[6].Value = model.recommend_index;
			parameters[7].Value = model.org_name;
			parameters[8].Value = model.type_id;
			parameters[9].Value = model.usesex;
			parameters[10].Value = model.orgitemcode;
			parameters[11].Value = model.orgitemname;
			parameters[12].Value = model.id;

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
			strSql.Append("delete from t_medical_items ");
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
			strSql.Append("delete from t_medical_items ");
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
		public LW_AskOnline.Model.t_medical_items GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,org_id,item_name,item_code,item_price,base_item_id,item_type,recommend_index,org_name,type_id,usesex,orgitemcode,orgitemname from t_medical_items ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			LW_AskOnline.Model.t_medical_items model=new LW_AskOnline.Model.t_medical_items();
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
		public LW_AskOnline.Model.t_medical_items DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_medical_items model=new LW_AskOnline.Model.t_medical_items();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["org_id"]!=null && row["org_id"].ToString()!="")
				{
					model.org_id=int.Parse(row["org_id"].ToString());
				}
				if(row["item_name"]!=null)
				{
					model.item_name=row["item_name"].ToString();
				}
				if(row["item_code"]!=null)
				{
					model.item_code=row["item_code"].ToString();
				}
				if(row["item_price"]!=null && row["item_price"].ToString()!="")
				{
					model.item_price=decimal.Parse(row["item_price"].ToString());
				}
				if(row["base_item_id"]!=null && row["base_item_id"].ToString()!="")
				{
					model.base_item_id=int.Parse(row["base_item_id"].ToString());
				}
				if(row["item_type"]!=null && row["item_type"].ToString()!="")
				{
					model.item_type=int.Parse(row["item_type"].ToString());
				}
				if(row["recommend_index"]!=null && row["recommend_index"].ToString()!="")
				{
					model.recommend_index=int.Parse(row["recommend_index"].ToString());
				}
				if(row["org_name"]!=null)
				{
					model.org_name=row["org_name"].ToString();
				}
				if(row["type_id"]!=null && row["type_id"].ToString()!="")
				{
					model.type_id=decimal.Parse(row["type_id"].ToString());
				}
				if(row["usesex"]!=null)
				{
					model.usesex=row["usesex"].ToString();
				}
				if(row["orgitemcode"]!=null)
				{
					model.orgitemcode=row["orgitemcode"].ToString();
				}
				if(row["orgitemname"]!=null)
				{
					model.orgitemname=row["orgitemname"].ToString();
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
			strSql.Append("select id,org_id,item_name,item_code,item_price,base_item_id,item_type,recommend_index,org_name,type_id,usesex,orgitemcode,orgitemname ");
			strSql.Append(" FROM t_medical_items ");
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
			strSql.Append(" id,org_id,item_name,item_code,item_price,base_item_id,item_type,recommend_index,org_name,type_id,usesex,orgitemcode,orgitemname ");
			strSql.Append(" FROM t_medical_items ");
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
			strSql.Append("select count(1) FROM t_medical_items ");
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
			strSql.Append(")AS Row, T.*  from t_medical_items T ");
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
			parameters[0].Value = "t_medical_items";
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

