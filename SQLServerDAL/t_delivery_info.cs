using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:t_delivery_info
	/// </summary>
	public partial class t_delivery_info:It_delivery_info
	{
		public t_delivery_info()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal delivery_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_delivery_info");
			strSql.Append(" where delivery_id=@delivery_id");
			SqlParameter[] parameters = {
					new SqlParameter("@delivery_id", SqlDbType.Decimal)
			};
			parameters[0].Value = delivery_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_delivery_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_delivery_info(");
			strSql.Append("address,city,consignee,county,is_default,mobile,phone,province,member_id,member_type)");
			strSql.Append(" values (");
			strSql.Append("@address,@city,@consignee,@county,@is_default,@mobile,@phone,@province,@member_id,@member_type)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@address", SqlDbType.VarChar,500),
					new SqlParameter("@city", SqlDbType.VarChar,65),
					new SqlParameter("@consignee", SqlDbType.VarChar,40),
					new SqlParameter("@county", SqlDbType.VarChar,65),
					new SqlParameter("@is_default", SqlDbType.Int,4),
					new SqlParameter("@mobile", SqlDbType.VarChar,20),
					new SqlParameter("@phone", SqlDbType.VarChar,20),
					new SqlParameter("@province", SqlDbType.VarChar,80),
					new SqlParameter("@member_id", SqlDbType.Decimal,9),
					new SqlParameter("@member_type", SqlDbType.VarChar,10)};
			parameters[0].Value = model.address;
			parameters[1].Value = model.city;
			parameters[2].Value = model.consignee;
			parameters[3].Value = model.county;
			parameters[4].Value = model.is_default;
			parameters[5].Value = model.mobile;
			parameters[6].Value = model.phone;
			parameters[7].Value = model.province;
			parameters[8].Value = model.member_id;
			parameters[9].Value = model.member_type;

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
		public bool Update(LW_AskOnline.Model.t_delivery_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_delivery_info set ");
			strSql.Append("address=@address,");
			strSql.Append("city=@city,");
			strSql.Append("consignee=@consignee,");
			strSql.Append("county=@county,");
			strSql.Append("is_default=@is_default,");
			strSql.Append("mobile=@mobile,");
			strSql.Append("phone=@phone,");
			strSql.Append("province=@province,");
			strSql.Append("member_id=@member_id,");
			strSql.Append("member_type=@member_type");
			strSql.Append(" where delivery_id=@delivery_id");
			SqlParameter[] parameters = {
					new SqlParameter("@address", SqlDbType.VarChar,500),
					new SqlParameter("@city", SqlDbType.VarChar,65),
					new SqlParameter("@consignee", SqlDbType.VarChar,40),
					new SqlParameter("@county", SqlDbType.VarChar,65),
					new SqlParameter("@is_default", SqlDbType.Int,4),
					new SqlParameter("@mobile", SqlDbType.VarChar,20),
					new SqlParameter("@phone", SqlDbType.VarChar,20),
					new SqlParameter("@province", SqlDbType.VarChar,80),
					new SqlParameter("@member_id", SqlDbType.Decimal,9),
					new SqlParameter("@member_type", SqlDbType.VarChar,10),
					new SqlParameter("@delivery_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.address;
			parameters[1].Value = model.city;
			parameters[2].Value = model.consignee;
			parameters[3].Value = model.county;
			parameters[4].Value = model.is_default;
			parameters[5].Value = model.mobile;
			parameters[6].Value = model.phone;
			parameters[7].Value = model.province;
			parameters[8].Value = model.member_id;
			parameters[9].Value = model.member_type;
			parameters[10].Value = model.delivery_id;

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
		public bool Delete(decimal delivery_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_delivery_info ");
			strSql.Append(" where delivery_id=@delivery_id");
			SqlParameter[] parameters = {
					new SqlParameter("@delivery_id", SqlDbType.Decimal)
			};
			parameters[0].Value = delivery_id;

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
		public bool DeleteList(string delivery_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_delivery_info ");
			strSql.Append(" where delivery_id in ("+delivery_idlist + ")  ");
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
		public LW_AskOnline.Model.t_delivery_info GetModel(decimal delivery_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 delivery_id,address,city,consignee,county,is_default,mobile,phone,province,member_id,member_type from t_delivery_info ");
			strSql.Append(" where delivery_id=@delivery_id");
			SqlParameter[] parameters = {
					new SqlParameter("@delivery_id", SqlDbType.Decimal)
			};
			parameters[0].Value = delivery_id;

			LW_AskOnline.Model.t_delivery_info model=new LW_AskOnline.Model.t_delivery_info();
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
		public LW_AskOnline.Model.t_delivery_info DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_delivery_info model=new LW_AskOnline.Model.t_delivery_info();
			if (row != null)
			{
				if(row["delivery_id"]!=null && row["delivery_id"].ToString()!="")
				{
					model.delivery_id=decimal.Parse(row["delivery_id"].ToString());
				}
				if(row["address"]!=null)
				{
					model.address=row["address"].ToString();
				}
				if(row["city"]!=null)
				{
					model.city=row["city"].ToString();
				}
				if(row["consignee"]!=null)
				{
					model.consignee=row["consignee"].ToString();
				}
				if(row["county"]!=null)
				{
					model.county=row["county"].ToString();
				}
				if(row["is_default"]!=null && row["is_default"].ToString()!="")
				{
					model.is_default=int.Parse(row["is_default"].ToString());
				}
				if(row["mobile"]!=null)
				{
					model.mobile=row["mobile"].ToString();
				}
				if(row["phone"]!=null)
				{
					model.phone=row["phone"].ToString();
				}
				if(row["province"]!=null)
				{
					model.province=row["province"].ToString();
				}
				if(row["member_id"]!=null && row["member_id"].ToString()!="")
				{
					model.member_id=decimal.Parse(row["member_id"].ToString());
				}
				if(row["member_type"]!=null)
				{
					model.member_type=row["member_type"].ToString();
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
			strSql.Append("select delivery_id,address,city,consignee,county,is_default,mobile,phone,province,member_id,member_type ");
			strSql.Append(" FROM t_delivery_info ");
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
			strSql.Append(" delivery_id,address,city,consignee,county,is_default,mobile,phone,province,member_id,member_type ");
			strSql.Append(" FROM t_delivery_info ");
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
			strSql.Append("select count(1) FROM t_delivery_info ");
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
				strSql.Append("order by T.delivery_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_delivery_info T ");
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
			parameters[0].Value = "t_delivery_info";
			parameters[1].Value = "delivery_id";
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

