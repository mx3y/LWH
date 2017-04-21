using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:t_news
	/// </summary>
	public partial class t_news
	{
		public t_news()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long new_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_news");
			strSql.Append(" where new_id=@new_id");
			SqlParameter[] parameters = {
					new SqlParameter("@new_id", SqlDbType.BigInt)
			};
			parameters[0].Value = new_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public long Add(LW_AskOnline.Model.t_news model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_news(");
			strSql.Append("user_id,title,author,release_date,content,create_date,news_type,release_flag,column_id,brief,keyword,subtitle,source,file_path,video_file_path,is_app,is_pc,is_wx)");
			strSql.Append(" values (");
			strSql.Append("@user_id,@title,@author,@release_date,@content,@create_date,@news_type,@release_flag,@column_id,@brief,@keyword,@subtitle,@source,@file_path,@video_file_path,@is_app,@is_pc,@is_wx)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@user_id", SqlDbType.BigInt,8),
					new SqlParameter("@title", SqlDbType.VarChar,200),
					new SqlParameter("@author", SqlDbType.VarChar,40),
					new SqlParameter("@release_date", SqlDbType.VarChar,10),
					new SqlParameter("@content", SqlDbType.Text),
					new SqlParameter("@create_date", SqlDbType.DateTime),
					new SqlParameter("@news_type", SqlDbType.Int,4),
					new SqlParameter("@release_flag", SqlDbType.VarChar,2),
					new SqlParameter("@column_id", SqlDbType.Decimal,9),
					new SqlParameter("@brief", SqlDbType.VarChar,1000),
					new SqlParameter("@keyword", SqlDbType.VarChar,100),
					new SqlParameter("@subtitle", SqlDbType.VarChar,200),
					new SqlParameter("@source", SqlDbType.VarChar,100),
					new SqlParameter("@file_path", SqlDbType.VarChar,500),
					new SqlParameter("@video_file_path", SqlDbType.VarChar,500),
					new SqlParameter("@is_app", SqlDbType.Int,4),
					new SqlParameter("@is_pc", SqlDbType.Int,4),
					new SqlParameter("@is_wx", SqlDbType.Int,4)};
			parameters[0].Value = model.user_id;
			parameters[1].Value = model.title;
			parameters[2].Value = model.author;
			parameters[3].Value = model.release_date;
			parameters[4].Value = model.content;
			parameters[5].Value = model.create_date;
			parameters[6].Value = model.news_type;
			parameters[7].Value = model.release_flag;
			parameters[8].Value = model.column_id;
			parameters[9].Value = model.brief;
			parameters[10].Value = model.keyword;
			parameters[11].Value = model.subtitle;
			parameters[12].Value = model.source;
			parameters[13].Value = model.file_path;
			parameters[14].Value = model.video_file_path;
			parameters[15].Value = model.is_app;
			parameters[16].Value = model.is_pc;
			parameters[17].Value = model.is_wx;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt64(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(LW_AskOnline.Model.t_news model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_news set ");
			strSql.Append("user_id=@user_id,");
			strSql.Append("title=@title,");
			strSql.Append("author=@author,");
			strSql.Append("release_date=@release_date,");
			strSql.Append("content=@content,");
			strSql.Append("create_date=@create_date,");
			strSql.Append("news_type=@news_type,");
			strSql.Append("release_flag=@release_flag,");
			strSql.Append("column_id=@column_id,");
			strSql.Append("brief=@brief,");
			strSql.Append("keyword=@keyword,");
			strSql.Append("subtitle=@subtitle,");
			strSql.Append("source=@source,");
			strSql.Append("file_path=@file_path,");
			strSql.Append("video_file_path=@video_file_path,");
			strSql.Append("is_app=@is_app,");
			strSql.Append("is_pc=@is_pc,");
			strSql.Append("is_wx=@is_wx");
			strSql.Append(" where new_id=@new_id");
			SqlParameter[] parameters = {
					new SqlParameter("@user_id", SqlDbType.BigInt,8),
					new SqlParameter("@title", SqlDbType.VarChar,200),
					new SqlParameter("@author", SqlDbType.VarChar,40),
					new SqlParameter("@release_date", SqlDbType.VarChar,10),
					new SqlParameter("@content", SqlDbType.Text),
					new SqlParameter("@create_date", SqlDbType.DateTime),
					new SqlParameter("@news_type", SqlDbType.Int,4),
					new SqlParameter("@release_flag", SqlDbType.VarChar,2),
					new SqlParameter("@column_id", SqlDbType.Decimal,9),
					new SqlParameter("@brief", SqlDbType.VarChar,1000),
					new SqlParameter("@keyword", SqlDbType.VarChar,100),
					new SqlParameter("@subtitle", SqlDbType.VarChar,200),
					new SqlParameter("@source", SqlDbType.VarChar,100),
					new SqlParameter("@file_path", SqlDbType.VarChar,500),
					new SqlParameter("@video_file_path", SqlDbType.VarChar,500),
					new SqlParameter("@is_app", SqlDbType.Int,4),
					new SqlParameter("@is_pc", SqlDbType.Int,4),
					new SqlParameter("@is_wx", SqlDbType.Int,4),
					new SqlParameter("@new_id", SqlDbType.BigInt,8)};
			parameters[0].Value = model.user_id;
			parameters[1].Value = model.title;
			parameters[2].Value = model.author;
			parameters[3].Value = model.release_date;
			parameters[4].Value = model.content;
			parameters[5].Value = model.create_date;
			parameters[6].Value = model.news_type;
			parameters[7].Value = model.release_flag;
			parameters[8].Value = model.column_id;
			parameters[9].Value = model.brief;
			parameters[10].Value = model.keyword;
			parameters[11].Value = model.subtitle;
			parameters[12].Value = model.source;
			parameters[13].Value = model.file_path;
			parameters[14].Value = model.video_file_path;
			parameters[15].Value = model.is_app;
			parameters[16].Value = model.is_pc;
			parameters[17].Value = model.is_wx;
			parameters[18].Value = model.new_id;

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
		public bool Delete(long new_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_news ");
			strSql.Append(" where new_id=@new_id");
			SqlParameter[] parameters = {
					new SqlParameter("@new_id", SqlDbType.BigInt)
			};
			parameters[0].Value = new_id;

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
		public bool DeleteList(string new_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_news ");
			strSql.Append(" where new_id in ("+new_idlist + ")  ");
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
		public LW_AskOnline.Model.t_news GetModel(long new_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 new_id,user_id,title,author,release_date,content,create_date,news_type,release_flag,column_id,brief,keyword,subtitle,source,file_path,video_file_path,is_app,is_pc,is_wx from t_news ");
			strSql.Append(" where new_id=@new_id");
			SqlParameter[] parameters = {
					new SqlParameter("@new_id", SqlDbType.BigInt)
			};
			parameters[0].Value = new_id;

			LW_AskOnline.Model.t_news model=new LW_AskOnline.Model.t_news();
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
		public LW_AskOnline.Model.t_news DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_news model=new LW_AskOnline.Model.t_news();
			if (row != null)
			{
				if(row["new_id"]!=null && row["new_id"].ToString()!="")
				{
					model.new_id=long.Parse(row["new_id"].ToString());
				}
				if(row["user_id"]!=null && row["user_id"].ToString()!="")
				{
					model.user_id=long.Parse(row["user_id"].ToString());
				}
				if(row["title"]!=null)
				{
					model.title=row["title"].ToString();
				}
				if(row["author"]!=null)
				{
					model.author=row["author"].ToString();
				}
				if(row["release_date"]!=null)
				{
					model.release_date=row["release_date"].ToString();
				}
				if(row["content"]!=null)
				{
					model.content=row["content"].ToString();
				}
				if(row["create_date"]!=null && row["create_date"].ToString()!="")
				{
					model.create_date=DateTime.Parse(row["create_date"].ToString());
				}
				if(row["news_type"]!=null && row["news_type"].ToString()!="")
				{
					model.news_type=int.Parse(row["news_type"].ToString());
				}
				if(row["release_flag"]!=null)
				{
					model.release_flag=row["release_flag"].ToString();
				}
				if(row["column_id"]!=null && row["column_id"].ToString()!="")
				{
					model.column_id=decimal.Parse(row["column_id"].ToString());
				}
				if(row["brief"]!=null)
				{
					model.brief=row["brief"].ToString();
				}
				if(row["keyword"]!=null)
				{
					model.keyword=row["keyword"].ToString();
				}
				if(row["subtitle"]!=null)
				{
					model.subtitle=row["subtitle"].ToString();
				}
				if(row["source"]!=null)
				{
					model.source=row["source"].ToString();
				}
				if(row["file_path"]!=null)
				{
					model.file_path=row["file_path"].ToString();
				}
				if(row["video_file_path"]!=null)
				{
					model.video_file_path=row["video_file_path"].ToString();
				}
				if(row["is_app"]!=null && row["is_app"].ToString()!="")
				{
					model.is_app=int.Parse(row["is_app"].ToString());
				}
				if(row["is_pc"]!=null && row["is_pc"].ToString()!="")
				{
					model.is_pc=int.Parse(row["is_pc"].ToString());
				}
				if(row["is_wx"]!=null && row["is_wx"].ToString()!="")
				{
					model.is_wx=int.Parse(row["is_wx"].ToString());
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
			strSql.Append("select new_id,user_id,title,author,release_date,content,create_date,news_type,release_flag,column_id,brief,keyword,subtitle,source,file_path,video_file_path,is_app,is_pc,is_wx ");
			strSql.Append(" FROM t_news ");
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
			strSql.Append(" new_id,user_id,title,author,release_date,content,create_date,news_type,release_flag,column_id,brief,keyword,subtitle,source,file_path,video_file_path,is_app,is_pc,is_wx ");
			strSql.Append(" FROM t_news ");
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
			strSql.Append("select count(1) FROM t_news ");
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
				strSql.Append("order by T.new_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_news T ");
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
			parameters[0].Value = "t_news";
			parameters[1].Value = "new_id";
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

