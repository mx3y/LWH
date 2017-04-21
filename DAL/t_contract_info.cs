using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:t_contract_info
	/// </summary>
	public partial class t_contract_info
	{
		public t_contract_info()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "t_contract_info"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_contract_info");
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
		public int Add(LW_AskOnline.Model.t_contract_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_contract_info(");
			strSql.Append("contract_name,sign_date,start_date,end_date,salesman,amount,link_man,phone,position,status,company_id,org_id,createtime,jctjx,jxbids,kxtjx)");
			strSql.Append(" values (");
			strSql.Append("@contract_name,@sign_date,@start_date,@end_date,@salesman,@amount,@link_man,@phone,@position,@status,@company_id,@org_id,@createtime,@jctjx,@jxbids,@kxtjx)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@contract_name", SqlDbType.VarChar,50),
					new SqlParameter("@sign_date", SqlDbType.DateTime),
					new SqlParameter("@start_date", SqlDbType.DateTime),
					new SqlParameter("@end_date", SqlDbType.DateTime),
					new SqlParameter("@salesman", SqlDbType.VarChar,50),
					new SqlParameter("@amount", SqlDbType.Float,8),
					new SqlParameter("@link_man", SqlDbType.VarChar,50),
					new SqlParameter("@phone", SqlDbType.VarChar,20),
					new SqlParameter("@position", SqlDbType.VarChar,20),
					new SqlParameter("@status", SqlDbType.VarChar,2),
					new SqlParameter("@company_id", SqlDbType.Int,4),
					new SqlParameter("@org_id", SqlDbType.Int,4),
					new SqlParameter("@createtime", SqlDbType.DateTime),
					new SqlParameter("@jctjx", SqlDbType.VarChar,255),
					new SqlParameter("@jxbids", SqlDbType.VarChar,255),
					new SqlParameter("@kxtjx", SqlDbType.VarChar,255)};
			parameters[0].Value = model.contract_name;
			parameters[1].Value = model.sign_date;
			parameters[2].Value = model.start_date;
			parameters[3].Value = model.end_date;
			parameters[4].Value = model.salesman;
			parameters[5].Value = model.amount;
			parameters[6].Value = model.link_man;
			parameters[7].Value = model.phone;
			parameters[8].Value = model.position;
			parameters[9].Value = model.status;
			parameters[10].Value = model.company_id;
			parameters[11].Value = model.org_id;
			parameters[12].Value = model.createtime;
			parameters[13].Value = model.jctjx;
			parameters[14].Value = model.jxbids;
			parameters[15].Value = model.kxtjx;

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
		public bool Update(LW_AskOnline.Model.t_contract_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_contract_info set ");
			strSql.Append("contract_name=@contract_name,");
			strSql.Append("sign_date=@sign_date,");
			strSql.Append("start_date=@start_date,");
			strSql.Append("end_date=@end_date,");
			strSql.Append("salesman=@salesman,");
			strSql.Append("amount=@amount,");
			strSql.Append("link_man=@link_man,");
			strSql.Append("phone=@phone,");
			strSql.Append("position=@position,");
			strSql.Append("status=@status,");
			strSql.Append("company_id=@company_id,");
			strSql.Append("org_id=@org_id,");
			strSql.Append("createtime=@createtime,");
			strSql.Append("jctjx=@jctjx,");
			strSql.Append("jxbids=@jxbids,");
			strSql.Append("kxtjx=@kxtjx");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@contract_name", SqlDbType.VarChar,50),
					new SqlParameter("@sign_date", SqlDbType.DateTime),
					new SqlParameter("@start_date", SqlDbType.DateTime),
					new SqlParameter("@end_date", SqlDbType.DateTime),
					new SqlParameter("@salesman", SqlDbType.VarChar,50),
					new SqlParameter("@amount", SqlDbType.Float,8),
					new SqlParameter("@link_man", SqlDbType.VarChar,50),
					new SqlParameter("@phone", SqlDbType.VarChar,20),
					new SqlParameter("@position", SqlDbType.VarChar,20),
					new SqlParameter("@status", SqlDbType.VarChar,2),
					new SqlParameter("@company_id", SqlDbType.Int,4),
					new SqlParameter("@org_id", SqlDbType.Int,4),
					new SqlParameter("@createtime", SqlDbType.DateTime),
					new SqlParameter("@jctjx", SqlDbType.VarChar,255),
					new SqlParameter("@jxbids", SqlDbType.VarChar,255),
					new SqlParameter("@kxtjx", SqlDbType.VarChar,255),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.contract_name;
			parameters[1].Value = model.sign_date;
			parameters[2].Value = model.start_date;
			parameters[3].Value = model.end_date;
			parameters[4].Value = model.salesman;
			parameters[5].Value = model.amount;
			parameters[6].Value = model.link_man;
			parameters[7].Value = model.phone;
			parameters[8].Value = model.position;
			parameters[9].Value = model.status;
			parameters[10].Value = model.company_id;
			parameters[11].Value = model.org_id;
			parameters[12].Value = model.createtime;
			parameters[13].Value = model.jctjx;
			parameters[14].Value = model.jxbids;
			parameters[15].Value = model.kxtjx;
			parameters[16].Value = model.id;

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
			strSql.Append("delete from t_contract_info ");
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
			strSql.Append("delete from t_contract_info ");
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
		public LW_AskOnline.Model.t_contract_info GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,contract_name,sign_date,start_date,end_date,salesman,amount,link_man,phone,position,status,company_id,org_id,createtime,jctjx,jxbids,kxtjx from t_contract_info ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			LW_AskOnline.Model.t_contract_info model=new LW_AskOnline.Model.t_contract_info();
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
		public LW_AskOnline.Model.t_contract_info DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_contract_info model=new LW_AskOnline.Model.t_contract_info();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["contract_name"]!=null)
				{
					model.contract_name=row["contract_name"].ToString();
				}
				if(row["sign_date"]!=null && row["sign_date"].ToString()!="")
				{
					model.sign_date=DateTime.Parse(row["sign_date"].ToString());
				}
				if(row["start_date"]!=null && row["start_date"].ToString()!="")
				{
					model.start_date=DateTime.Parse(row["start_date"].ToString());
				}
				if(row["end_date"]!=null && row["end_date"].ToString()!="")
				{
					model.end_date=DateTime.Parse(row["end_date"].ToString());
				}
				if(row["salesman"]!=null)
				{
					model.salesman=row["salesman"].ToString();
				}
				if(row["amount"]!=null && row["amount"].ToString()!="")
				{
					model.amount=decimal.Parse(row["amount"].ToString());
				}
				if(row["link_man"]!=null)
				{
					model.link_man=row["link_man"].ToString();
				}
				if(row["phone"]!=null)
				{
					model.phone=row["phone"].ToString();
				}
				if(row["position"]!=null)
				{
					model.position=row["position"].ToString();
				}
				if(row["status"]!=null)
				{
					model.status=row["status"].ToString();
				}
				if(row["company_id"]!=null && row["company_id"].ToString()!="")
				{
					model.company_id=int.Parse(row["company_id"].ToString());
				}
				if(row["org_id"]!=null && row["org_id"].ToString()!="")
				{
					model.org_id=int.Parse(row["org_id"].ToString());
				}
				if(row["createtime"]!=null && row["createtime"].ToString()!="")
				{
					model.createtime=DateTime.Parse(row["createtime"].ToString());
				}
				if(row["jctjx"]!=null)
				{
					model.jctjx=row["jctjx"].ToString();
				}
				if(row["jxbids"]!=null)
				{
					model.jxbids=row["jxbids"].ToString();
				}
				if(row["kxtjx"]!=null)
				{
					model.kxtjx=row["kxtjx"].ToString();
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
			strSql.Append("select id,contract_name,sign_date,start_date,end_date,salesman,amount,link_man,phone,position,status,company_id,org_id,createtime,jctjx,jxbids,kxtjx ");
			strSql.Append(" FROM t_contract_info ");
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
			strSql.Append(" id,contract_name,sign_date,start_date,end_date,salesman,amount,link_man,phone,position,status,company_id,org_id,createtime,jctjx,jxbids,kxtjx ");
			strSql.Append(" FROM t_contract_info ");
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
			strSql.Append("select count(1) FROM t_contract_info ");
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
			strSql.Append(")AS Row, T.*  from t_contract_info T ");
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
			parameters[0].Value = "t_contract_info";
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

