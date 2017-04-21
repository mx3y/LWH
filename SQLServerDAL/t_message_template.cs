using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:t_message_template
	/// </summary>
	public partial class t_message_template:It_message_template
	{
		public t_message_template()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_message_template");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Decimal)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_message_template model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_message_template(");
			strSql.Append("lastupdatetime,msg_content,msg_name,msg_start_using,msg_type,remark,status)");
			strSql.Append(" values (");
			strSql.Append("@lastupdatetime,@msg_content,@msg_name,@msg_start_using,@msg_type,@remark,@status)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@lastupdatetime", SqlDbType.DateTime),
					new SqlParameter("@msg_content", SqlDbType.VarChar,255),
					new SqlParameter("@msg_name", SqlDbType.VarChar,255),
					new SqlParameter("@msg_start_using", SqlDbType.VarChar,255),
					new SqlParameter("@msg_type", SqlDbType.VarChar,255),
					new SqlParameter("@remark", SqlDbType.VarChar,255),
					new SqlParameter("@status", SqlDbType.VarChar,255)};
			parameters[0].Value = model.lastupdatetime;
			parameters[1].Value = model.msg_content;
			parameters[2].Value = model.msg_name;
			parameters[3].Value = model.msg_start_using;
			parameters[4].Value = model.msg_type;
			parameters[5].Value = model.remark;
			parameters[6].Value = model.status;

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
		public bool Update(LW_AskOnline.Model.t_message_template model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_message_template set ");
			strSql.Append("lastupdatetime=@lastupdatetime,");
			strSql.Append("msg_content=@msg_content,");
			strSql.Append("msg_name=@msg_name,");
			strSql.Append("msg_start_using=@msg_start_using,");
			strSql.Append("msg_type=@msg_type,");
			strSql.Append("remark=@remark,");
			strSql.Append("status=@status");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@lastupdatetime", SqlDbType.DateTime),
					new SqlParameter("@msg_content", SqlDbType.VarChar,255),
					new SqlParameter("@msg_name", SqlDbType.VarChar,255),
					new SqlParameter("@msg_start_using", SqlDbType.VarChar,255),
					new SqlParameter("@msg_type", SqlDbType.VarChar,255),
					new SqlParameter("@remark", SqlDbType.VarChar,255),
					new SqlParameter("@status", SqlDbType.VarChar,255),
					new SqlParameter("@id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.lastupdatetime;
			parameters[1].Value = model.msg_content;
			parameters[2].Value = model.msg_name;
			parameters[3].Value = model.msg_start_using;
			parameters[4].Value = model.msg_type;
			parameters[5].Value = model.remark;
			parameters[6].Value = model.status;
			parameters[7].Value = model.id;

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
		public bool Delete(decimal id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_message_template ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Decimal)
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
			strSql.Append("delete from t_message_template ");
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
		public LW_AskOnline.Model.t_message_template GetModel(decimal id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,lastupdatetime,msg_content,msg_name,msg_start_using,msg_type,remark,status from t_message_template ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Decimal)
			};
			parameters[0].Value = id;

			LW_AskOnline.Model.t_message_template model=new LW_AskOnline.Model.t_message_template();
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
		public LW_AskOnline.Model.t_message_template DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_message_template model=new LW_AskOnline.Model.t_message_template();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=decimal.Parse(row["id"].ToString());
				}
				if(row["lastupdatetime"]!=null && row["lastupdatetime"].ToString()!="")
				{
					model.lastupdatetime=DateTime.Parse(row["lastupdatetime"].ToString());
				}
				if(row["msg_content"]!=null)
				{
					model.msg_content=row["msg_content"].ToString();
				}
				if(row["msg_name"]!=null)
				{
					model.msg_name=row["msg_name"].ToString();
				}
				if(row["msg_start_using"]!=null)
				{
					model.msg_start_using=row["msg_start_using"].ToString();
				}
				if(row["msg_type"]!=null)
				{
					model.msg_type=row["msg_type"].ToString();
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
				}
				if(row["status"]!=null)
				{
					model.status=row["status"].ToString();
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
			strSql.Append("select id,lastupdatetime,msg_content,msg_name,msg_start_using,msg_type,remark,status ");
			strSql.Append(" FROM t_message_template ");
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
			strSql.Append(" id,lastupdatetime,msg_content,msg_name,msg_start_using,msg_type,remark,status ");
			strSql.Append(" FROM t_message_template ");
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
			strSql.Append("select count(1) FROM t_message_template ");
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
			strSql.Append(")AS Row, T.*  from t_message_template T ");
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
			parameters[0].Value = "t_message_template";
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

