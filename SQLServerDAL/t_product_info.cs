using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:t_product_info
	/// </summary>
	public partial class t_product_info:It_product_info
	{
		public t_product_info()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal goods_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_product_info");
			strSql.Append(" where goods_id=@goods_id");
			SqlParameter[] parameters = {
					new SqlParameter("@goods_id", SqlDbType.Decimal)
			};
			parameters[0].Value = goods_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_product_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_product_info(");
			strSql.Append("app_scope,brand,description,end_period,face_value,feature,for_disease,goods_code,goods_name,goods_type,market_price,picture,price,remark,shelf_time,shelves_time,start_period,status,card_type,special_purpose,index_picture,is_index)");
			strSql.Append(" values (");
			strSql.Append("@app_scope,@brand,@description,@end_period,@face_value,@feature,@for_disease,@goods_code,@goods_name,@goods_type,@market_price,@picture,@price,@remark,@shelf_time,@shelves_time,@start_period,@status,@card_type,@special_purpose,@index_picture,@is_index)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@app_scope", SqlDbType.VarChar,500),
					new SqlParameter("@brand", SqlDbType.VarChar,200),
					new SqlParameter("@description", SqlDbType.Text),
					new SqlParameter("@end_period", SqlDbType.VarChar,50),
					new SqlParameter("@face_value", SqlDbType.VarChar,20),
					new SqlParameter("@feature", SqlDbType.VarChar,500),
					new SqlParameter("@for_disease", SqlDbType.VarChar,500),
					new SqlParameter("@goods_code", SqlDbType.VarChar,50),
					new SqlParameter("@goods_name", SqlDbType.VarChar,100),
					new SqlParameter("@goods_type", SqlDbType.VarChar,32),
					new SqlParameter("@market_price", SqlDbType.Float,8),
					new SqlParameter("@picture", SqlDbType.VarChar,200),
					new SqlParameter("@price", SqlDbType.Float,8),
					new SqlParameter("@remark", SqlDbType.VarChar,500),
					new SqlParameter("@shelf_time", SqlDbType.VarChar,10),
					new SqlParameter("@shelves_time", SqlDbType.VarChar,10),
					new SqlParameter("@start_period", SqlDbType.VarChar,50),
					new SqlParameter("@status", SqlDbType.VarChar,2),
					new SqlParameter("@card_type", SqlDbType.VarChar,50),
					new SqlParameter("@special_purpose", SqlDbType.VarChar,50),
					new SqlParameter("@index_picture", SqlDbType.VarChar,200),
					new SqlParameter("@is_index", SqlDbType.Int,4)};
			parameters[0].Value = model.app_scope;
			parameters[1].Value = model.brand;
			parameters[2].Value = model.description;
			parameters[3].Value = model.end_period;
			parameters[4].Value = model.face_value;
			parameters[5].Value = model.feature;
			parameters[6].Value = model.for_disease;
			parameters[7].Value = model.goods_code;
			parameters[8].Value = model.goods_name;
			parameters[9].Value = model.goods_type;
			parameters[10].Value = model.market_price;
			parameters[11].Value = model.picture;
			parameters[12].Value = model.price;
			parameters[13].Value = model.remark;
			parameters[14].Value = model.shelf_time;
			parameters[15].Value = model.shelves_time;
			parameters[16].Value = model.start_period;
			parameters[17].Value = model.status;
			parameters[18].Value = model.card_type;
			parameters[19].Value = model.special_purpose;
			parameters[20].Value = model.index_picture;
			parameters[21].Value = model.is_index;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToDecimal(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(LW_AskOnline.Model.t_product_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_product_info set ");
			strSql.Append("app_scope=@app_scope,");
			strSql.Append("brand=@brand,");
			strSql.Append("description=@description,");
			strSql.Append("end_period=@end_period,");
			strSql.Append("face_value=@face_value,");
			strSql.Append("feature=@feature,");
			strSql.Append("for_disease=@for_disease,");
			strSql.Append("goods_code=@goods_code,");
			strSql.Append("goods_name=@goods_name,");
			strSql.Append("goods_type=@goods_type,");
			strSql.Append("market_price=@market_price,");
			strSql.Append("picture=@picture,");
			strSql.Append("price=@price,");
			strSql.Append("remark=@remark,");
			strSql.Append("shelf_time=@shelf_time,");
			strSql.Append("shelves_time=@shelves_time,");
			strSql.Append("start_period=@start_period,");
			strSql.Append("status=@status,");
			strSql.Append("card_type=@card_type,");
			strSql.Append("special_purpose=@special_purpose,");
			strSql.Append("index_picture=@index_picture,");
			strSql.Append("is_index=@is_index");
			strSql.Append(" where goods_id=@goods_id");
			SqlParameter[] parameters = {
					new SqlParameter("@app_scope", SqlDbType.VarChar,500),
					new SqlParameter("@brand", SqlDbType.VarChar,200),
					new SqlParameter("@description", SqlDbType.Text),
					new SqlParameter("@end_period", SqlDbType.VarChar,50),
					new SqlParameter("@face_value", SqlDbType.VarChar,20),
					new SqlParameter("@feature", SqlDbType.VarChar,500),
					new SqlParameter("@for_disease", SqlDbType.VarChar,500),
					new SqlParameter("@goods_code", SqlDbType.VarChar,50),
					new SqlParameter("@goods_name", SqlDbType.VarChar,100),
					new SqlParameter("@goods_type", SqlDbType.VarChar,32),
					new SqlParameter("@market_price", SqlDbType.Float,8),
					new SqlParameter("@picture", SqlDbType.VarChar,200),
					new SqlParameter("@price", SqlDbType.Float,8),
					new SqlParameter("@remark", SqlDbType.VarChar,500),
					new SqlParameter("@shelf_time", SqlDbType.VarChar,10),
					new SqlParameter("@shelves_time", SqlDbType.VarChar,10),
					new SqlParameter("@start_period", SqlDbType.VarChar,50),
					new SqlParameter("@status", SqlDbType.VarChar,2),
					new SqlParameter("@card_type", SqlDbType.VarChar,50),
					new SqlParameter("@special_purpose", SqlDbType.VarChar,50),
					new SqlParameter("@index_picture", SqlDbType.VarChar,200),
					new SqlParameter("@is_index", SqlDbType.Int,4),
					new SqlParameter("@goods_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.app_scope;
			parameters[1].Value = model.brand;
			parameters[2].Value = model.description;
			parameters[3].Value = model.end_period;
			parameters[4].Value = model.face_value;
			parameters[5].Value = model.feature;
			parameters[6].Value = model.for_disease;
			parameters[7].Value = model.goods_code;
			parameters[8].Value = model.goods_name;
			parameters[9].Value = model.goods_type;
			parameters[10].Value = model.market_price;
			parameters[11].Value = model.picture;
			parameters[12].Value = model.price;
			parameters[13].Value = model.remark;
			parameters[14].Value = model.shelf_time;
			parameters[15].Value = model.shelves_time;
			parameters[16].Value = model.start_period;
			parameters[17].Value = model.status;
			parameters[18].Value = model.card_type;
			parameters[19].Value = model.special_purpose;
			parameters[20].Value = model.index_picture;
			parameters[21].Value = model.is_index;
			parameters[22].Value = model.goods_id;

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
		public bool Delete(decimal goods_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_product_info ");
			strSql.Append(" where goods_id=@goods_id");
			SqlParameter[] parameters = {
					new SqlParameter("@goods_id", SqlDbType.Decimal)
			};
			parameters[0].Value = goods_id;

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
		public bool DeleteList(string goods_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_product_info ");
			strSql.Append(" where goods_id in ("+goods_idlist + ")  ");
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
		public LW_AskOnline.Model.t_product_info GetModel(decimal goods_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 goods_id,app_scope,brand,description,end_period,face_value,feature,for_disease,goods_code,goods_name,goods_type,market_price,picture,price,remark,shelf_time,shelves_time,start_period,status,card_type,special_purpose,index_picture,is_index from t_product_info ");
			strSql.Append(" where goods_id=@goods_id");
			SqlParameter[] parameters = {
					new SqlParameter("@goods_id", SqlDbType.Decimal)
			};
			parameters[0].Value = goods_id;

			LW_AskOnline.Model.t_product_info model=new LW_AskOnline.Model.t_product_info();
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
		public LW_AskOnline.Model.t_product_info DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_product_info model=new LW_AskOnline.Model.t_product_info();
			if (row != null)
			{
				if(row["goods_id"]!=null && row["goods_id"].ToString()!="")
				{
					model.goods_id=decimal.Parse(row["goods_id"].ToString());
				}
				if(row["app_scope"]!=null)
				{
					model.app_scope=row["app_scope"].ToString();
				}
				if(row["brand"]!=null)
				{
					model.brand=row["brand"].ToString();
				}
				if(row["description"]!=null)
				{
					model.description=row["description"].ToString();
				}
				if(row["end_period"]!=null)
				{
					model.end_period=row["end_period"].ToString();
				}
				if(row["face_value"]!=null)
				{
					model.face_value=row["face_value"].ToString();
				}
				if(row["feature"]!=null)
				{
					model.feature=row["feature"].ToString();
				}
				if(row["for_disease"]!=null)
				{
					model.for_disease=row["for_disease"].ToString();
				}
				if(row["goods_code"]!=null)
				{
					model.goods_code=row["goods_code"].ToString();
				}
				if(row["goods_name"]!=null)
				{
					model.goods_name=row["goods_name"].ToString();
				}
				if(row["goods_type"]!=null)
				{
					model.goods_type=row["goods_type"].ToString();
				}
				if(row["market_price"]!=null && row["market_price"].ToString()!="")
				{
					model.market_price=decimal.Parse(row["market_price"].ToString());
				}
				if(row["picture"]!=null)
				{
					model.picture=row["picture"].ToString();
				}
				if(row["price"]!=null && row["price"].ToString()!="")
				{
					model.price=decimal.Parse(row["price"].ToString());
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
				}
				if(row["shelf_time"]!=null)
				{
					model.shelf_time=row["shelf_time"].ToString();
				}
				if(row["shelves_time"]!=null)
				{
					model.shelves_time=row["shelves_time"].ToString();
				}
				if(row["start_period"]!=null)
				{
					model.start_period=row["start_period"].ToString();
				}
				if(row["status"]!=null)
				{
					model.status=row["status"].ToString();
				}
				if(row["card_type"]!=null)
				{
					model.card_type=row["card_type"].ToString();
				}
				if(row["special_purpose"]!=null)
				{
					model.special_purpose=row["special_purpose"].ToString();
				}
				if(row["index_picture"]!=null)
				{
					model.index_picture=row["index_picture"].ToString();
				}
				if(row["is_index"]!=null && row["is_index"].ToString()!="")
				{
					model.is_index=int.Parse(row["is_index"].ToString());
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
			strSql.Append("select goods_id,app_scope,brand,description,end_period,face_value,feature,for_disease,goods_code,goods_name,goods_type,market_price,picture,price,remark,shelf_time,shelves_time,start_period,status,card_type,special_purpose,index_picture,is_index ");
			strSql.Append(" FROM t_product_info ");
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
			strSql.Append(" goods_id,app_scope,brand,description,end_period,face_value,feature,for_disease,goods_code,goods_name,goods_type,market_price,picture,price,remark,shelf_time,shelves_time,start_period,status,card_type,special_purpose,index_picture,is_index ");
			strSql.Append(" FROM t_product_info ");
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
			strSql.Append("select count(1) FROM t_product_info ");
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
				strSql.Append("order by T.goods_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_product_info T ");
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
			parameters[0].Value = "t_product_info";
			parameters[1].Value = "goods_id";
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

