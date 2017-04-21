using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:t_order_record
	/// </summary>
	public partial class t_order_record:It_order_record
	{
		public t_order_record()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal order_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_order_record");
			strSql.Append(" where order_id=@order_id");
			SqlParameter[] parameters = {
					new SqlParameter("@order_id", SqlDbType.Decimal)
			};
			parameters[0].Value = order_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_order_record model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_order_record(");
			strSql.Append("create_time,order_no,status,total_amount,member_id,address,card_number,city,consignee,county,delivery_way,mobile,payment,phone,province,is_valuation,is_delete,member_type)");
			strSql.Append(" values (");
			strSql.Append("@create_time,@order_no,@status,@total_amount,@member_id,@address,@card_number,@city,@consignee,@county,@delivery_way,@mobile,@payment,@phone,@province,@is_valuation,@is_delete,@member_type)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@create_time", SqlDbType.DateTime),
					new SqlParameter("@order_no", SqlDbType.VarChar,20),
					new SqlParameter("@status", SqlDbType.VarChar,4),
					new SqlParameter("@total_amount", SqlDbType.Float,8),
					new SqlParameter("@member_id", SqlDbType.Decimal,9),
					new SqlParameter("@address", SqlDbType.VarChar,500),
					new SqlParameter("@card_number", SqlDbType.VarChar,40),
					new SqlParameter("@city", SqlDbType.VarChar,65),
					new SqlParameter("@consignee", SqlDbType.VarChar,40),
					new SqlParameter("@county", SqlDbType.VarChar,65),
					new SqlParameter("@delivery_way", SqlDbType.VarChar,20),
					new SqlParameter("@mobile", SqlDbType.VarChar,20),
					new SqlParameter("@payment", SqlDbType.VarChar,10),
					new SqlParameter("@phone", SqlDbType.VarChar,20),
					new SqlParameter("@province", SqlDbType.VarChar,80),
					new SqlParameter("@is_valuation", SqlDbType.Int,4),
					new SqlParameter("@is_delete", SqlDbType.Int,4),
					new SqlParameter("@member_type", SqlDbType.VarChar,255)};
			parameters[0].Value = model.create_time;
			parameters[1].Value = model.order_no;
			parameters[2].Value = model.status;
			parameters[3].Value = model.total_amount;
			parameters[4].Value = model.member_id;
			parameters[5].Value = model.address;
			parameters[6].Value = model.card_number;
			parameters[7].Value = model.city;
			parameters[8].Value = model.consignee;
			parameters[9].Value = model.county;
			parameters[10].Value = model.delivery_way;
			parameters[11].Value = model.mobile;
			parameters[12].Value = model.payment;
			parameters[13].Value = model.phone;
			parameters[14].Value = model.province;
			parameters[15].Value = model.is_valuation;
			parameters[16].Value = model.is_delete;
			parameters[17].Value = model.member_type;

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
		public bool Update(LW_AskOnline.Model.t_order_record model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_order_record set ");
			strSql.Append("create_time=@create_time,");
			strSql.Append("order_no=@order_no,");
			strSql.Append("status=@status,");
			strSql.Append("total_amount=@total_amount,");
			strSql.Append("member_id=@member_id,");
			strSql.Append("address=@address,");
			strSql.Append("card_number=@card_number,");
			strSql.Append("city=@city,");
			strSql.Append("consignee=@consignee,");
			strSql.Append("county=@county,");
			strSql.Append("delivery_way=@delivery_way,");
			strSql.Append("mobile=@mobile,");
			strSql.Append("payment=@payment,");
			strSql.Append("phone=@phone,");
			strSql.Append("province=@province,");
			strSql.Append("is_valuation=@is_valuation,");
			strSql.Append("is_delete=@is_delete,");
			strSql.Append("member_type=@member_type");
			strSql.Append(" where order_id=@order_id");
			SqlParameter[] parameters = {
					new SqlParameter("@create_time", SqlDbType.DateTime),
					new SqlParameter("@order_no", SqlDbType.VarChar,20),
					new SqlParameter("@status", SqlDbType.VarChar,4),
					new SqlParameter("@total_amount", SqlDbType.Float,8),
					new SqlParameter("@member_id", SqlDbType.Decimal,9),
					new SqlParameter("@address", SqlDbType.VarChar,500),
					new SqlParameter("@card_number", SqlDbType.VarChar,40),
					new SqlParameter("@city", SqlDbType.VarChar,65),
					new SqlParameter("@consignee", SqlDbType.VarChar,40),
					new SqlParameter("@county", SqlDbType.VarChar,65),
					new SqlParameter("@delivery_way", SqlDbType.VarChar,20),
					new SqlParameter("@mobile", SqlDbType.VarChar,20),
					new SqlParameter("@payment", SqlDbType.VarChar,10),
					new SqlParameter("@phone", SqlDbType.VarChar,20),
					new SqlParameter("@province", SqlDbType.VarChar,80),
					new SqlParameter("@is_valuation", SqlDbType.Int,4),
					new SqlParameter("@is_delete", SqlDbType.Int,4),
					new SqlParameter("@member_type", SqlDbType.VarChar,255),
					new SqlParameter("@order_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.create_time;
			parameters[1].Value = model.order_no;
			parameters[2].Value = model.status;
			parameters[3].Value = model.total_amount;
			parameters[4].Value = model.member_id;
			parameters[5].Value = model.address;
			parameters[6].Value = model.card_number;
			parameters[7].Value = model.city;
			parameters[8].Value = model.consignee;
			parameters[9].Value = model.county;
			parameters[10].Value = model.delivery_way;
			parameters[11].Value = model.mobile;
			parameters[12].Value = model.payment;
			parameters[13].Value = model.phone;
			parameters[14].Value = model.province;
			parameters[15].Value = model.is_valuation;
			parameters[16].Value = model.is_delete;
			parameters[17].Value = model.member_type;
			parameters[18].Value = model.order_id;

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
		public bool Delete(decimal order_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_order_record ");
			strSql.Append(" where order_id=@order_id");
			SqlParameter[] parameters = {
					new SqlParameter("@order_id", SqlDbType.Decimal)
			};
			parameters[0].Value = order_id;

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
		public bool DeleteList(string order_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_order_record ");
			strSql.Append(" where order_id in ("+order_idlist + ")  ");
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
		public LW_AskOnline.Model.t_order_record GetModel(decimal order_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 order_id,create_time,order_no,status,total_amount,member_id,address,card_number,city,consignee,county,delivery_way,mobile,payment,phone,province,is_valuation,is_delete,member_type from t_order_record ");
			strSql.Append(" where order_id=@order_id");
			SqlParameter[] parameters = {
					new SqlParameter("@order_id", SqlDbType.Decimal)
			};
			parameters[0].Value = order_id;

			LW_AskOnline.Model.t_order_record model=new LW_AskOnline.Model.t_order_record();
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
		public LW_AskOnline.Model.t_order_record DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_order_record model=new LW_AskOnline.Model.t_order_record();
			if (row != null)
			{
				if(row["order_id"]!=null && row["order_id"].ToString()!="")
				{
					model.order_id=decimal.Parse(row["order_id"].ToString());
				}
				if(row["create_time"]!=null && row["create_time"].ToString()!="")
				{
					model.create_time=DateTime.Parse(row["create_time"].ToString());
				}
				if(row["order_no"]!=null)
				{
					model.order_no=row["order_no"].ToString();
				}
				if(row["status"]!=null)
				{
					model.status=row["status"].ToString();
				}
				if(row["total_amount"]!=null && row["total_amount"].ToString()!="")
				{
					model.total_amount=decimal.Parse(row["total_amount"].ToString());
				}
				if(row["member_id"]!=null && row["member_id"].ToString()!="")
				{
					model.member_id=decimal.Parse(row["member_id"].ToString());
				}
				if(row["address"]!=null)
				{
					model.address=row["address"].ToString();
				}
				if(row["card_number"]!=null)
				{
					model.card_number=row["card_number"].ToString();
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
				if(row["delivery_way"]!=null)
				{
					model.delivery_way=row["delivery_way"].ToString();
				}
				if(row["mobile"]!=null)
				{
					model.mobile=row["mobile"].ToString();
				}
				if(row["payment"]!=null)
				{
					model.payment=row["payment"].ToString();
				}
				if(row["phone"]!=null)
				{
					model.phone=row["phone"].ToString();
				}
				if(row["province"]!=null)
				{
					model.province=row["province"].ToString();
				}
				if(row["is_valuation"]!=null && row["is_valuation"].ToString()!="")
				{
					model.is_valuation=int.Parse(row["is_valuation"].ToString());
				}
				if(row["is_delete"]!=null && row["is_delete"].ToString()!="")
				{
					model.is_delete=int.Parse(row["is_delete"].ToString());
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
			strSql.Append("select order_id,create_time,order_no,status,total_amount,member_id,address,card_number,city,consignee,county,delivery_way,mobile,payment,phone,province,is_valuation,is_delete,member_type ");
			strSql.Append(" FROM t_order_record ");
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
			strSql.Append(" order_id,create_time,order_no,status,total_amount,member_id,address,card_number,city,consignee,county,delivery_way,mobile,payment,phone,province,is_valuation,is_delete,member_type ");
			strSql.Append(" FROM t_order_record ");
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
			strSql.Append("select count(1) FROM t_order_record ");
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
				strSql.Append("order by T.order_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_order_record T ");
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
			parameters[0].Value = "t_order_record";
			parameters[1].Value = "order_id";
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

