using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:t_member_status
	/// </summary>
	public partial class t_member_status
	{
		public t_member_status()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(LW_AskOnline.Model.t_member_status model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_member_status(");
			strSql.Append("tco_uid,tco_send_msg,tco_order_msg,tco_after_tell,tco_before_tell,tco_istijian,tco_report,tco_pay_openid,tco_pay_report_number,tco_befre_tell_msg,tco_remark_msg)");
			strSql.Append(" values (");
			strSql.Append("@tco_uid,@tco_send_msg,@tco_order_msg,@tco_after_tell,@tco_before_tell,@tco_istijian,@tco_report,@tco_pay_openid,@tco_pay_report_number,@tco_befre_tell_msg,@tco_remark_msg)");
			SqlParameter[] parameters = {
					new SqlParameter("@tco_uid", SqlDbType.Int,4),
					new SqlParameter("@tco_send_msg", SqlDbType.TinyInt,1),
					new SqlParameter("@tco_order_msg", SqlDbType.TinyInt,1),
					new SqlParameter("@tco_after_tell", SqlDbType.TinyInt,1),
					new SqlParameter("@tco_before_tell", SqlDbType.TinyInt,1),
					new SqlParameter("@tco_istijian", SqlDbType.TinyInt,1),
					new SqlParameter("@tco_report", SqlDbType.TinyInt,1),
					new SqlParameter("@tco_pay_openid", SqlDbType.NVarChar,500),
					new SqlParameter("@tco_pay_report_number", SqlDbType.NVarChar,500),
					new SqlParameter("@tco_befre_tell_msg", SqlDbType.NVarChar,2000),
					new SqlParameter("@tco_remark_msg", SqlDbType.NVarChar,2000)};
			parameters[0].Value = model.tco_uid;
			parameters[1].Value = model.tco_send_msg;
			parameters[2].Value = model.tco_order_msg;
			parameters[3].Value = model.tco_after_tell;
			parameters[4].Value = model.tco_before_tell;
			parameters[5].Value = model.tco_istijian;
			parameters[6].Value = model.tco_report;
			parameters[7].Value = model.tco_pay_openid;
			parameters[8].Value = model.tco_pay_report_number;
			parameters[9].Value = model.tco_befre_tell_msg;
			parameters[10].Value = model.tco_remark_msg;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(LW_AskOnline.Model.t_member_status model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_member_status set ");
			strSql.Append("tco_uid=@tco_uid,");
			strSql.Append("tco_send_msg=@tco_send_msg,");
			strSql.Append("tco_order_msg=@tco_order_msg,");
			strSql.Append("tco_after_tell=@tco_after_tell,");
			strSql.Append("tco_before_tell=@tco_before_tell,");
			strSql.Append("tco_istijian=@tco_istijian,");
			strSql.Append("tco_report=@tco_report,");
			strSql.Append("tco_pay_openid=@tco_pay_openid,");
			strSql.Append("tco_pay_report_number=@tco_pay_report_number,");
			strSql.Append("tco_befre_tell_msg=@tco_befre_tell_msg,");
			strSql.Append("tco_remark_msg=@tco_remark_msg");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@tco_uid", SqlDbType.Int,4),
					new SqlParameter("@tco_send_msg", SqlDbType.TinyInt,1),
					new SqlParameter("@tco_order_msg", SqlDbType.TinyInt,1),
					new SqlParameter("@tco_after_tell", SqlDbType.TinyInt,1),
					new SqlParameter("@tco_before_tell", SqlDbType.TinyInt,1),
					new SqlParameter("@tco_istijian", SqlDbType.TinyInt,1),
					new SqlParameter("@tco_report", SqlDbType.TinyInt,1),
					new SqlParameter("@tco_pay_openid", SqlDbType.NVarChar,500),
					new SqlParameter("@tco_pay_report_number", SqlDbType.NVarChar,500),
					new SqlParameter("@tco_befre_tell_msg", SqlDbType.NVarChar,2000),
					new SqlParameter("@tco_remark_msg", SqlDbType.NVarChar,2000)};
			parameters[0].Value = model.tco_uid;
			parameters[1].Value = model.tco_send_msg;
			parameters[2].Value = model.tco_order_msg;
			parameters[3].Value = model.tco_after_tell;
			parameters[4].Value = model.tco_before_tell;
			parameters[5].Value = model.tco_istijian;
			parameters[6].Value = model.tco_report;
			parameters[7].Value = model.tco_pay_openid;
			parameters[8].Value = model.tco_pay_report_number;
			parameters[9].Value = model.tco_befre_tell_msg;
			parameters[10].Value = model.tco_remark_msg;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_member_status ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public LW_AskOnline.Model.t_member_status GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 tco_uid,tco_send_msg,tco_order_msg,tco_after_tell,tco_before_tell,tco_istijian,tco_report,tco_pay_openid,tco_pay_report_number,tco_befre_tell_msg,tco_remark_msg from t_member_status ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			LW_AskOnline.Model.t_member_status model=new LW_AskOnline.Model.t_member_status();
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
		public LW_AskOnline.Model.t_member_status DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_member_status model=new LW_AskOnline.Model.t_member_status();
			if (row != null)
			{
				if(row["tco_uid"]!=null && row["tco_uid"].ToString()!="")
				{
					model.tco_uid=int.Parse(row["tco_uid"].ToString());
				}
				if(row["tco_send_msg"]!=null && row["tco_send_msg"].ToString()!="")
				{
					model.tco_send_msg=int.Parse(row["tco_send_msg"].ToString());
				}
				if(row["tco_order_msg"]!=null && row["tco_order_msg"].ToString()!="")
				{
					model.tco_order_msg=int.Parse(row["tco_order_msg"].ToString());
				}
				if(row["tco_after_tell"]!=null && row["tco_after_tell"].ToString()!="")
				{
					model.tco_after_tell=int.Parse(row["tco_after_tell"].ToString());
				}
				if(row["tco_before_tell"]!=null && row["tco_before_tell"].ToString()!="")
				{
					model.tco_before_tell=int.Parse(row["tco_before_tell"].ToString());
				}
				if(row["tco_istijian"]!=null && row["tco_istijian"].ToString()!="")
				{
					model.tco_istijian=int.Parse(row["tco_istijian"].ToString());
				}
				if(row["tco_report"]!=null && row["tco_report"].ToString()!="")
				{
					model.tco_report=int.Parse(row["tco_report"].ToString());
				}
				if(row["tco_pay_openid"]!=null)
				{
					model.tco_pay_openid=row["tco_pay_openid"].ToString();
				}
				if(row["tco_pay_report_number"]!=null)
				{
					model.tco_pay_report_number=row["tco_pay_report_number"].ToString();
				}
				if(row["tco_befre_tell_msg"]!=null)
				{
					model.tco_befre_tell_msg=row["tco_befre_tell_msg"].ToString();
				}
				if(row["tco_remark_msg"]!=null)
				{
					model.tco_remark_msg=row["tco_remark_msg"].ToString();
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
			strSql.Append("select tco_uid,tco_send_msg,tco_order_msg,tco_after_tell,tco_before_tell,tco_istijian,tco_report,tco_pay_openid,tco_pay_report_number,tco_befre_tell_msg,tco_remark_msg ");
			strSql.Append(" FROM t_member_status ");
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
			strSql.Append(" tco_uid,tco_send_msg,tco_order_msg,tco_after_tell,tco_before_tell,tco_istijian,tco_report,tco_pay_openid,tco_pay_report_number,tco_befre_tell_msg,tco_remark_msg ");
			strSql.Append(" FROM t_member_status ");
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
			strSql.Append("select count(1) FROM t_member_status ");
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
			strSql.Append(")AS Row, T.*  from t_member_status T ");
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
			parameters[0].Value = "t_member_status";
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

