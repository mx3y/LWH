using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:sys_dict_type
	/// </summary>
	public partial class sys_dict_type
	{
		public sys_dict_type()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal type_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sys_dict_type");
			strSql.Append(" where type_id=@type_id");
			SqlParameter[] parameters = {
					new SqlParameter("@type_id", SqlDbType.Decimal)
			};
			parameters[0].Value = type_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.sys_dict_type model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sys_dict_type(");
			strSql.Append("remark,type_code,type_name)");
			strSql.Append(" values (");
			strSql.Append("@remark,@type_code,@type_name)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@remark", SqlDbType.VarChar,100),
					new SqlParameter("@type_code", SqlDbType.VarChar,32),
					new SqlParameter("@type_name", SqlDbType.VarChar,100)};
			parameters[0].Value = model.remark;
			parameters[1].Value = model.type_code;
			parameters[2].Value = model.type_name;

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
		public bool Update(LW_AskOnline.Model.sys_dict_type model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sys_dict_type set ");
			strSql.Append("remark=@remark,");
			strSql.Append("type_code=@type_code,");
			strSql.Append("type_name=@type_name");
			strSql.Append(" where type_id=@type_id");
			SqlParameter[] parameters = {
					new SqlParameter("@remark", SqlDbType.VarChar,100),
					new SqlParameter("@type_code", SqlDbType.VarChar,32),
					new SqlParameter("@type_name", SqlDbType.VarChar,100),
					new SqlParameter("@type_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.remark;
			parameters[1].Value = model.type_code;
			parameters[2].Value = model.type_name;
			parameters[3].Value = model.type_id;

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
		public bool Delete(decimal type_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_dict_type ");
			strSql.Append(" where type_id=@type_id");
			SqlParameter[] parameters = {
					new SqlParameter("@type_id", SqlDbType.Decimal)
			};
			parameters[0].Value = type_id;

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
		public bool DeleteList(string type_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_dict_type ");
			strSql.Append(" where type_id in ("+type_idlist + ")  ");
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
		public LW_AskOnline.Model.sys_dict_type GetModel(decimal type_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 type_id,remark,type_code,type_name from sys_dict_type ");
			strSql.Append(" where type_id=@type_id");
			SqlParameter[] parameters = {
					new SqlParameter("@type_id", SqlDbType.Decimal)
			};
			parameters[0].Value = type_id;

			LW_AskOnline.Model.sys_dict_type model=new LW_AskOnline.Model.sys_dict_type();
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
		public LW_AskOnline.Model.sys_dict_type DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.sys_dict_type model=new LW_AskOnline.Model.sys_dict_type();
			if (row != null)
			{
				if(row["type_id"]!=null && row["type_id"].ToString()!="")
				{
					model.type_id=decimal.Parse(row["type_id"].ToString());
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
				}
				if(row["type_code"]!=null)
				{
					model.type_code=row["type_code"].ToString();
				}
				if(row["type_name"]!=null)
				{
					model.type_name=row["type_name"].ToString();
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
			strSql.Append("select type_id,remark,type_code,type_name ");
			strSql.Append(" FROM sys_dict_type ");
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
			strSql.Append(" type_id,remark,type_code,type_name ");
			strSql.Append(" FROM sys_dict_type ");
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
			strSql.Append("select count(1) FROM sys_dict_type ");
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
				strSql.Append("order by T.type_id desc");
			}
			strSql.Append(")AS Row, T.*  from sys_dict_type T ");
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
			parameters[0].Value = "sys_dict_type";
			parameters[1].Value = "type_id";
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

