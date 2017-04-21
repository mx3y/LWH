using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:sys_dict
	/// </summary>
	public partial class sys_dict
	{
		public sys_dict()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string dict_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sys_dict");
			strSql.Append(" where dict_id=@dict_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@dict_id", SqlDbType.VarChar,100)			};
			parameters[0].Value = dict_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(LW_AskOnline.Model.sys_dict model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sys_dict(");
			strSql.Append("dict_id,dict_code,order_no,param_name,param_remark,type_id)");
			strSql.Append(" values (");
			strSql.Append("@dict_id,@dict_code,@order_no,@param_name,@param_remark,@type_id)");
			SqlParameter[] parameters = {
					new SqlParameter("@dict_id", SqlDbType.VarChar,100),
					new SqlParameter("@dict_code", SqlDbType.VarChar,32),
					new SqlParameter("@order_no", SqlDbType.Int,4),
					new SqlParameter("@param_name", SqlDbType.VarChar,50),
					new SqlParameter("@param_remark", SqlDbType.VarChar,100),
					new SqlParameter("@type_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.dict_id;
			parameters[1].Value = model.dict_code;
			parameters[2].Value = model.order_no;
			parameters[3].Value = model.param_name;
			parameters[4].Value = model.param_remark;
			parameters[5].Value = model.type_id;

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
		public bool Update(LW_AskOnline.Model.sys_dict model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sys_dict set ");
			strSql.Append("dict_code=@dict_code,");
			strSql.Append("order_no=@order_no,");
			strSql.Append("param_name=@param_name,");
			strSql.Append("param_remark=@param_remark,");
			strSql.Append("type_id=@type_id");
			strSql.Append(" where dict_id=@dict_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@dict_code", SqlDbType.VarChar,32),
					new SqlParameter("@order_no", SqlDbType.Int,4),
					new SqlParameter("@param_name", SqlDbType.VarChar,50),
					new SqlParameter("@param_remark", SqlDbType.VarChar,100),
					new SqlParameter("@type_id", SqlDbType.Decimal,9),
					new SqlParameter("@dict_id", SqlDbType.VarChar,100)};
			parameters[0].Value = model.dict_code;
			parameters[1].Value = model.order_no;
			parameters[2].Value = model.param_name;
			parameters[3].Value = model.param_remark;
			parameters[4].Value = model.type_id;
			parameters[5].Value = model.dict_id;

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
		public bool Delete(string dict_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_dict ");
			strSql.Append(" where dict_id=@dict_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@dict_id", SqlDbType.VarChar,100)			};
			parameters[0].Value = dict_id;

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
		public bool DeleteList(string dict_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_dict ");
			strSql.Append(" where dict_id in ("+dict_idlist + ")  ");
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
		public LW_AskOnline.Model.sys_dict GetModel(string dict_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 dict_id,dict_code,order_no,param_name,param_remark,type_id from sys_dict ");
			strSql.Append(" where dict_id=@dict_id ");
			SqlParameter[] parameters = {
					new SqlParameter("@dict_id", SqlDbType.VarChar,100)			};
			parameters[0].Value = dict_id;

			LW_AskOnline.Model.sys_dict model=new LW_AskOnline.Model.sys_dict();
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
		public LW_AskOnline.Model.sys_dict DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.sys_dict model=new LW_AskOnline.Model.sys_dict();
			if (row != null)
			{
				if(row["dict_id"]!=null)
				{
					model.dict_id=row["dict_id"].ToString();
				}
				if(row["dict_code"]!=null)
				{
					model.dict_code=row["dict_code"].ToString();
				}
				if(row["order_no"]!=null && row["order_no"].ToString()!="")
				{
					model.order_no=int.Parse(row["order_no"].ToString());
				}
				if(row["param_name"]!=null)
				{
					model.param_name=row["param_name"].ToString();
				}
				if(row["param_remark"]!=null)
				{
					model.param_remark=row["param_remark"].ToString();
				}
				if(row["type_id"]!=null && row["type_id"].ToString()!="")
				{
					model.type_id=decimal.Parse(row["type_id"].ToString());
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
			strSql.Append("select dict_id,dict_code,order_no,param_name,param_remark,type_id ");
			strSql.Append(" FROM sys_dict ");
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
			strSql.Append(" dict_id,dict_code,order_no,param_name,param_remark,type_id ");
			strSql.Append(" FROM sys_dict ");
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
			strSql.Append("select count(1) FROM sys_dict ");
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
				strSql.Append("order by T.dict_id desc");
			}
			strSql.Append(")AS Row, T.*  from sys_dict T ");
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
			parameters[0].Value = "sys_dict";
			parameters[1].Value = "dict_id";
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

