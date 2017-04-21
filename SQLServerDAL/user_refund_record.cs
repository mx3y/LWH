using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:user_refund_record
	/// </summary>
	public partial class user_refund_record:Iuser_refund_record
	{
		public user_refund_record()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("urr_id", "user_refund_record"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int urr_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from user_refund_record");
			strSql.Append(" where urr_id=@urr_id");
			SqlParameter[] parameters = {
					new SqlParameter("@urr_id", SqlDbType.Int,4)
			};
			parameters[0].Value = urr_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(LW_AskOnline.Model.user_refund_record model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into user_refund_record(");
			strSql.Append("urr_user_id,urr_order_id,urr_weixin_number,urr_weixin_busseiss_number,urr_monery,urr_state,urr_date)");
			strSql.Append(" values (");
			strSql.Append("@urr_user_id,@urr_order_id,@urr_weixin_number,@urr_weixin_busseiss_number,@urr_monery,@urr_state,@urr_date)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@urr_user_id", SqlDbType.Int,4),
					new SqlParameter("@urr_order_id", SqlDbType.Int,4),
					new SqlParameter("@urr_weixin_number", SqlDbType.NVarChar,2000),
					new SqlParameter("@urr_weixin_busseiss_number", SqlDbType.NVarChar,2000),
					new SqlParameter("@urr_monery", SqlDbType.Decimal,9),
					new SqlParameter("@urr_state", SqlDbType.Int,4),
					new SqlParameter("@urr_date", SqlDbType.DateTime)};
			parameters[0].Value = model.urr_user_id;
			parameters[1].Value = model.urr_order_id;
			parameters[2].Value = model.urr_weixin_number;
			parameters[3].Value = model.urr_weixin_busseiss_number;
			parameters[4].Value = model.urr_monery;
			parameters[5].Value = model.urr_state;
			parameters[6].Value = model.urr_date;

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
		public bool Update(LW_AskOnline.Model.user_refund_record model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update user_refund_record set ");
			strSql.Append("urr_user_id=@urr_user_id,");
			strSql.Append("urr_order_id=@urr_order_id,");
			strSql.Append("urr_weixin_number=@urr_weixin_number,");
			strSql.Append("urr_weixin_busseiss_number=@urr_weixin_busseiss_number,");
			strSql.Append("urr_monery=@urr_monery,");
			strSql.Append("urr_state=@urr_state,");
			strSql.Append("urr_date=@urr_date");
			strSql.Append(" where urr_id=@urr_id");
			SqlParameter[] parameters = {
					new SqlParameter("@urr_user_id", SqlDbType.Int,4),
					new SqlParameter("@urr_order_id", SqlDbType.Int,4),
					new SqlParameter("@urr_weixin_number", SqlDbType.NVarChar,2000),
					new SqlParameter("@urr_weixin_busseiss_number", SqlDbType.NVarChar,2000),
					new SqlParameter("@urr_monery", SqlDbType.Decimal,9),
					new SqlParameter("@urr_state", SqlDbType.Int,4),
					new SqlParameter("@urr_date", SqlDbType.DateTime),
					new SqlParameter("@urr_id", SqlDbType.Int,4)};
			parameters[0].Value = model.urr_user_id;
			parameters[1].Value = model.urr_order_id;
			parameters[2].Value = model.urr_weixin_number;
			parameters[3].Value = model.urr_weixin_busseiss_number;
			parameters[4].Value = model.urr_monery;
			parameters[5].Value = model.urr_state;
			parameters[6].Value = model.urr_date;
			parameters[7].Value = model.urr_id;

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
		public bool Delete(int urr_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from user_refund_record ");
			strSql.Append(" where urr_id=@urr_id");
			SqlParameter[] parameters = {
					new SqlParameter("@urr_id", SqlDbType.Int,4)
			};
			parameters[0].Value = urr_id;

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
		public bool DeleteList(string urr_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from user_refund_record ");
			strSql.Append(" where urr_id in ("+urr_idlist + ")  ");
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
		public LW_AskOnline.Model.user_refund_record GetModel(int urr_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 urr_id,urr_user_id,urr_order_id,urr_weixin_number,urr_weixin_busseiss_number,urr_monery,urr_state,urr_date from user_refund_record ");
			strSql.Append(" where urr_id=@urr_id");
			SqlParameter[] parameters = {
					new SqlParameter("@urr_id", SqlDbType.Int,4)
			};
			parameters[0].Value = urr_id;

			LW_AskOnline.Model.user_refund_record model=new LW_AskOnline.Model.user_refund_record();
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
		public LW_AskOnline.Model.user_refund_record DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.user_refund_record model=new LW_AskOnline.Model.user_refund_record();
			if (row != null)
			{
				if(row["urr_id"]!=null && row["urr_id"].ToString()!="")
				{
					model.urr_id=int.Parse(row["urr_id"].ToString());
				}
				if(row["urr_user_id"]!=null && row["urr_user_id"].ToString()!="")
				{
					model.urr_user_id=int.Parse(row["urr_user_id"].ToString());
				}
				if(row["urr_order_id"]!=null && row["urr_order_id"].ToString()!="")
				{
					model.urr_order_id=int.Parse(row["urr_order_id"].ToString());
				}
				if(row["urr_weixin_number"]!=null)
				{
					model.urr_weixin_number=row["urr_weixin_number"].ToString();
				}
				if(row["urr_weixin_busseiss_number"]!=null)
				{
					model.urr_weixin_busseiss_number=row["urr_weixin_busseiss_number"].ToString();
				}
				if(row["urr_monery"]!=null && row["urr_monery"].ToString()!="")
				{
					model.urr_monery=decimal.Parse(row["urr_monery"].ToString());
				}
				if(row["urr_state"]!=null && row["urr_state"].ToString()!="")
				{
					model.urr_state=int.Parse(row["urr_state"].ToString());
				}
				if(row["urr_date"]!=null && row["urr_date"].ToString()!="")
				{
					model.urr_date=DateTime.Parse(row["urr_date"].ToString());
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
			strSql.Append("select urr_id,urr_user_id,urr_order_id,urr_weixin_number,urr_weixin_busseiss_number,urr_monery,urr_state,urr_date ");
			strSql.Append(" FROM user_refund_record ");
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
			strSql.Append(" urr_id,urr_user_id,urr_order_id,urr_weixin_number,urr_weixin_busseiss_number,urr_monery,urr_state,urr_date ");
			strSql.Append(" FROM user_refund_record ");
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
			strSql.Append("select count(1) FROM user_refund_record ");
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
				strSql.Append("order by T.urr_id desc");
			}
			strSql.Append(")AS Row, T.*  from user_refund_record T ");
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
			parameters[0].Value = "user_refund_record";
			parameters[1].Value = "urr_id";
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

