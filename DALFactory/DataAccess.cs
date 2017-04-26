using System;
using System.Reflection;
using System.Configuration;
namespace LW_AskOnline.DALFactory
{
    /// <summary>
    /// Abstract Factory pattern to create the DAL。
    /// 如果在这里创建对象报错，请检查web.config里是否修改了<add key="DAL" value="Maticsoft.SQLServerDAL" />。
    /// </summary>
    public sealed class DataAccess
    {
        private static readonly string AssemblyPath = ConfigurationManager.AppSettings["DAL"];
        public DataAccess()
        { }

        #region CreateObject

        //不使用缓存
        private static object CreateObjectNoCache(string AssemblyPath, string classNamespace)
        {
            try
            {
                object objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);
                return objType;
            }
            catch//(System.Exception ex)
            {
                //string str=ex.Message;// 记录错误日志
                return null;
            }

        }
        //使用缓存
        private static object CreateObject(string AssemblyPath, string classNamespace)
        {
            object objType = DataCache.GetCache(classNamespace);
            if (objType == null)
            {
                try
                {
                    objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);
                    DataCache.SetCache(classNamespace, objType);// 写入缓存
                }
                catch//(System.Exception ex)
                {
                    //string str=ex.Message;// 记录错误日志
                }
            }
            return objType;
        }
        #endregion

        #region 泛型生成
        ///// <summary>
        ///// 创建数据层接口。
        ///// </summary>
        //public static t Create(string ClassName)
        //{

        //    string ClassNamespace = AssemblyPath +"."+ ClassName;
        //    object objType = CreateObject(AssemblyPath, ClassNamespace);
        //    return (t)objType;
        //}
        #endregion

        #region CreateSysManage
        public static LW_AskOnline.IDAL.ISysManage CreateSysManage()
        {
            //方式1			
            //return (LW_AskOnline.IDAL.ISysManage)Assembly.Load(AssemblyPath).CreateInstance(AssemblyPath+".SysManage");

            //方式2 			
            string classNamespace = AssemblyPath + ".SysManage";
            object objType = CreateObject(AssemblyPath, classNamespace);
            return (LW_AskOnline.IDAL.ISysManage)objType;
        }
        #endregion



        /// <summary>
        /// 创建ask_city数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Iask_city Createask_city()
        {

            string ClassNamespace = AssemblyPath + ".ask_city";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Iask_city)objType;
        }


        /// <summary>
        /// 创建ask_dept数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Iask_dept Createask_dept()
        {

            string ClassNamespace = AssemblyPath + ".ask_dept";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Iask_dept)objType;
        }


        /// <summary>
        /// 创建ask_doctor_list数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Iask_doctor_list Createask_doctor_list()
        {

            string ClassNamespace = AssemblyPath + ".ask_doctor_list";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Iask_doctor_list)objType;
        }


        /// <summary>
        /// 创建ask_hospital数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Iask_hospital Createask_hospital()
        {

            string ClassNamespace = AssemblyPath + ".ask_hospital";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Iask_hospital)objType;
        }


        /// <summary>
        /// 创建ask_illpersion数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Iask_illpersion Createask_illpersion()
        {

            string ClassNamespace = AssemblyPath + ".ask_illpersion";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Iask_illpersion)objType;
        }


        /// <summary>
        /// 创建ask_master数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Iask_master Createask_master()
        {

            string ClassNamespace = AssemblyPath + ".ask_master";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Iask_master)objType;
        }


        /// <summary>
        /// 创建ask_msg_check数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Iask_msg_check Createask_msg_check()
        {

            string ClassNamespace = AssemblyPath + ".ask_msg_check";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Iask_msg_check)objType;
        }


        /// <summary>
        /// 创建ask_order数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Iask_order Createask_order()
        {

            string ClassNamespace = AssemblyPath + ".ask_order";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Iask_order)objType;
        }


        /// <summary>
        /// 创建ask_order_pay数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Iask_order_pay Createask_order_pay()
        {

            string ClassNamespace = AssemblyPath + ".ask_order_pay";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Iask_order_pay)objType;
        }


        /// <summary>
        /// 创建ask_order_reply数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Iask_order_reply Createask_order_reply()
        {

            string ClassNamespace = AssemblyPath + ".ask_order_reply";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Iask_order_reply)objType;
        }


        /// <summary>
        /// 创建ask_test_bill数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Iask_test_bill Createask_test_bill()
        {

            string ClassNamespace = AssemblyPath + ".ask_test_bill";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Iask_test_bill)objType;
        }


        /// <summary>
        /// 创建ask_ucpaas数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Iask_ucpaas Createask_ucpaas()
        {

            string ClassNamespace = AssemblyPath + ".ask_ucpaas";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Iask_ucpaas)objType;
        }


        /// <summary>
        /// 创建ask_user数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Iask_user Createask_user()
        {

            string ClassNamespace = AssemblyPath + ".ask_user";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Iask_user)objType;
        }


        /// <summary>
        /// 创建jichang数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Ijichang Createjichang()
        {

            string ClassNamespace = AssemblyPath + ".jichang";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Ijichang)objType;
        }


        /// <summary>
        /// 创建jichang_org数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Ijichang_org Createjichang_org()
        {

            string ClassNamespace = AssemblyPath + ".jichang_org";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Ijichang_org)objType;
        }


        /// <summary>
        /// 创建log_dispatch数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Ilog_dispatch Createlog_dispatch()
        {

            string ClassNamespace = AssemblyPath + ".log_dispatch";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Ilog_dispatch)objType;
        }


        /// <summary>
        /// 创建log_exception数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Ilog_exception Createlog_exception()
        {

            string ClassNamespace = AssemblyPath + ".log_exception";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Ilog_exception)objType;
        }


        /// <summary>
        /// 创建log_login数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Ilog_login Createlog_login()
        {

            string ClassNamespace = AssemblyPath + ".log_login";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Ilog_login)objType;
        }


        /// <summary>
        /// 创建log_use数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Ilog_use Createlog_use()
        {

            string ClassNamespace = AssemblyPath + ".log_use";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Ilog_use)objType;
        }


        /// <summary>
        /// 创建norecord数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Inorecord Createnorecord()
        {

            string ClassNamespace = AssemblyPath + ".norecord";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Inorecord)objType;
        }


        /// <summary>
        /// 创建sj_fuchas数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Isj_fuchas Createsj_fuchas()
        {

            string ClassNamespace = AssemblyPath + ".sj_fuchas";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Isj_fuchas)objType;
        }


        /// <summary>
        /// 创建sj_fuchas_main数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Isj_fuchas_main Createsj_fuchas_main()
        {

            string ClassNamespace = AssemblyPath + ".sj_fuchas_main";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Isj_fuchas_main)objType;
        }


        /// <summary>
        /// 创建sj_tjdj数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Isj_tjdj Createsj_tjdj()
        {

            string ClassNamespace = AssemblyPath + ".sj_tjdj";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Isj_tjdj)objType;
        }


        /// <summary>
        /// 创建sj_tjhz数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Isj_tjhz Createsj_tjhz()
        {

            string ClassNamespace = AssemblyPath + ".sj_tjhz";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Isj_tjhz)objType;
        }


        /// <summary>
        /// 创建sj_tjjg数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Isj_tjjg Createsj_tjjg()
        {

            string ClassNamespace = AssemblyPath + ".sj_tjjg";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Isj_tjjg)objType;
        }


        /// <summary>
        /// 创建sj_tjjg1数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Isj_tjjg1 Createsj_tjjg1()
        {

            string ClassNamespace = AssemblyPath + ".sj_tjjg1";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Isj_tjjg1)objType;
        }


        /// <summary>
        /// 创建sj_zhibiaos数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Isj_zhibiaos Createsj_zhibiaos()
        {

            string ClassNamespace = AssemblyPath + ".sj_zhibiaos";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Isj_zhibiaos)objType;
        }


        /// <summary>
        /// 创建sms_record数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Isms_record Createsms_record()
        {

            string ClassNamespace = AssemblyPath + ".sms_record";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Isms_record)objType;
        }


        /// <summary>
        /// 创建sys_dict数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Isys_dict Createsys_dict()
        {

            string ClassNamespace = AssemblyPath + ".sys_dict";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Isys_dict)objType;
        }


        /// <summary>
        /// 创建sys_dict_type数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Isys_dict_type Createsys_dict_type()
        {

            string ClassNamespace = AssemblyPath + ".sys_dict_type";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Isys_dict_type)objType;
        }


        /// <summary>
        /// 创建sys_func数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Isys_func Createsys_func()
        {

            string ClassNamespace = AssemblyPath + ".sys_func";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Isys_func)objType;
        }


        /// <summary>
        /// 创建sys_param数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Isys_param Createsys_param()
        {

            string ClassNamespace = AssemblyPath + ".sys_param";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Isys_param)objType;
        }


        /// <summary>
        /// 创建sys_platform数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Isys_platform Createsys_platform()
        {

            string ClassNamespace = AssemblyPath + ".sys_platform";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Isys_platform)objType;
        }


        /// <summary>
        /// 创建sys_role数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Isys_role Createsys_role()
        {

            string ClassNamespace = AssemblyPath + ".sys_role";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Isys_role)objType;
        }


        /// <summary>
        /// 创建sys_role_func数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Isys_role_func Createsys_role_func()
        {

            string ClassNamespace = AssemblyPath + ".sys_role_func";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Isys_role_func)objType;
        }


        /// <summary>
        /// 创建sys_seq数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Isys_seq Createsys_seq()
        {

            string ClassNamespace = AssemblyPath + ".sys_seq";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Isys_seq)objType;
        }


        /// <summary>
        /// 创建sys_user数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Isys_user Createsys_user()
        {

            string ClassNamespace = AssemblyPath + ".sys_user";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Isys_user)objType;
        }


        /// <summary>
        /// 创建sys_user_role数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Isys_user_role Createsys_user_role()
        {

            string ClassNamespace = AssemblyPath + ".sys_user_role";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Isys_user_role)objType;
        }


        /// <summary>
        /// 创建t_base_item_info数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_base_item_info Createt_base_item_info()
        {

            string ClassNamespace = AssemblyPath + ".t_base_item_info";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_base_item_info)objType;
        }


        /// <summary>
        /// 创建t_base_item_relation数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_base_item_relation Createt_base_item_relation()
        {

            string ClassNamespace = AssemblyPath + ".t_base_item_relation";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_base_item_relation)objType;
        }


        /// <summary>
        /// 创建t_base_item_type_info数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_base_item_type_info Createt_base_item_type_info()
        {

            string ClassNamespace = AssemblyPath + ".t_base_item_type_info";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_base_item_type_info)objType;
        }


        /// <summary>
        /// 创建t_base_jxb_info数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_base_jxb_info Createt_base_jxb_info()
        {

            string ClassNamespace = AssemblyPath + ".t_base_jxb_info";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_base_jxb_info)objType;
        }


        /// <summary>
        /// 创建t_case_annex数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_case_annex Createt_case_annex()
        {

            string ClassNamespace = AssemblyPath + ".t_case_annex";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_case_annex)objType;
        }


        /// <summary>
        /// 创建t_case_info数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_case_info Createt_case_info()
        {

            string ClassNamespace = AssemblyPath + ".t_case_info";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_case_info)objType;
        }


        /// <summary>
        /// 创建t_check_ordered数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_check_ordered Createt_check_ordered()
        {

            string ClassNamespace = AssemblyPath + ".t_check_ordered";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_check_ordered)objType;
        }


        /// <summary>
        /// 创建t_check_package数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_check_package Createt_check_package()
        {

            string ClassNamespace = AssemblyPath + ".t_check_package";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_check_package)objType;
        }


        /// <summary>
        /// 创建t_check_package_item数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_check_package_item Createt_check_package_item()
        {

            string ClassNamespace = AssemblyPath + ".t_check_package_item";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_check_package_item)objType;
        }


        /// <summary>
        /// 创建t_check_people_record数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_check_people_record Createt_check_people_record()
        {

            string ClassNamespace = AssemblyPath + ".t_check_people_record";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_check_people_record)objType;
        }


        /// <summary>
        /// 创建t_check_project_item数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_check_project_item Createt_check_project_item()
        {

            string ClassNamespace = AssemblyPath + ".t_check_project_item";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_check_project_item)objType;
        }


        /// <summary>
        /// 创建t_company数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_company Createt_company()
        {

            string ClassNamespace = AssemblyPath + ".t_company";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_company)objType;
        }


        /// <summary>
        /// 创建t_contract_info数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_contract_info Createt_contract_info()
        {

            string ClassNamespace = AssemblyPath + ".t_contract_info";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_contract_info)objType;
        }


        /// <summary>
        /// 创建t_delivery_info数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_delivery_info Createt_delivery_info()
        {

            string ClassNamespace = AssemblyPath + ".t_delivery_info";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_delivery_info)objType;
        }


        /// <summary>
        /// 创建t_environment数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_environment Createt_environment()
        {

            string ClassNamespace = AssemblyPath + ".t_environment";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_environment)objType;
        }


        /// <summary>
        /// 创建t_evaluation_info数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_evaluation_info Createt_evaluation_info()
        {

            string ClassNamespace = AssemblyPath + ".t_evaluation_info";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_evaluation_info)objType;
        }


        /// <summary>
        /// 创建t_evaluation_schedule数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_evaluation_schedule Createt_evaluation_schedule()
        {

            string ClassNamespace = AssemblyPath + ".t_evaluation_schedule";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_evaluation_schedule)objType;
        }


        /// <summary>
        /// 创建t_expert_doctor数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_expert_doctor Createt_expert_doctor()
        {

            string ClassNamespace = AssemblyPath + ".t_expert_doctor";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_expert_doctor)objType;
        }


        /// <summary>
        /// 创建t_medical_addres数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_medical_addres Createt_medical_addres()
        {

            string ClassNamespace = AssemblyPath + ".t_medical_addres";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_medical_addres)objType;
        }


        /// <summary>
        /// 创建t_medical_examination数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_medical_examination Createt_medical_examination()
        {

            string ClassNamespace = AssemblyPath + ".t_medical_examination";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_medical_examination)objType;
        }


        /// <summary>
        /// 创建t_medical_items数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_medical_items Createt_medical_items()
        {

            string ClassNamespace = AssemblyPath + ".t_medical_items";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_medical_items)objType;
        }


        /// <summary>
        /// 创建t_medical_org数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_medical_org Createt_medical_org()
        {

            string ClassNamespace = AssemblyPath + ".t_medical_org";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_medical_org)objType;
        }


        /// <summary>
        /// 创建t_medical_report数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_medical_report Createt_medical_report()
        {

            string ClassNamespace = AssemblyPath + ".t_medical_report";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_medical_report)objType;
        }


        /// <summary>
        /// 创建t_member数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_member Createt_member()
        {

            string ClassNamespace = AssemblyPath + ".t_member";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_member)objType;
        }


        /// <summary>
        /// 创建t_member_account数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_member_account Createt_member_account()
        {

            string ClassNamespace = AssemblyPath + ".t_member_account";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_member_account)objType;
        }


        /// <summary>
        /// 创建t_member_base_info数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_member_base_info Createt_member_base_info()
        {

            string ClassNamespace = AssemblyPath + ".t_member_base_info";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_member_base_info)objType;
        }


        /// <summary>
        /// 创建t_member_card数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_member_card Createt_member_card()
        {

            string ClassNamespace = AssemblyPath + ".t_member_card";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_member_card)objType;
        }


        /// <summary>
        /// 创建t_member_copy数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_member_copy Createt_member_copy()
        {

            string ClassNamespace = AssemblyPath + ".t_member_copy";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_member_copy)objType;
        }


        /// <summary>
        /// 创建t_member_info数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_member_info Createt_member_info()
        {

            string ClassNamespace = AssemblyPath + ".t_member_info";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_member_info)objType;
        }


        /// <summary>
        /// 创建t_member_level数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_member_level Createt_member_level()
        {

            string ClassNamespace = AssemblyPath + ".t_member_level";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_member_level)objType;
        }


        /// <summary>
        /// 创建t_member_package_rel数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_member_package_rel Createt_member_package_rel()
        {

            string ClassNamespace = AssemblyPath + ".t_member_package_rel";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_member_package_rel)objType;
        }


        /// <summary>
        /// 创建t_member_status数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_member_status Createt_member_status()
        {

            string ClassNamespace = AssemblyPath + ".t_member_status";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_member_status)objType;
        }


        /// <summary>
        /// 创建t_message数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_message Createt_message()
        {

            string ClassNamespace = AssemblyPath + ".t_message";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_message)objType;
        }


        /// <summary>
        /// 创建t_message_record数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_message_record Createt_message_record()
        {

            string ClassNamespace = AssemblyPath + ".t_message_record";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_message_record)objType;
        }


        /// <summary>
        /// 创建t_message_template数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_message_template Createt_message_template()
        {

            string ClassNamespace = AssemblyPath + ".t_message_template";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_message_template)objType;
        }


        /// <summary>
        /// 创建t_news数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_news Createt_news()
        {

            string ClassNamespace = AssemblyPath + ".t_news";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_news)objType;
        }


        /// <summary>
        /// 创建t_news_column数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_news_column Createt_news_column()
        {

            string ClassNamespace = AssemblyPath + ".t_news_column";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_news_column)objType;
        }


        /// <summary>
        /// 创建t_notice数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_notice Createt_notice()
        {

            string ClassNamespace = AssemblyPath + ".t_notice";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_notice)objType;
        }


        /// <summary>
        /// 创建t_office_status_record数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_office_status_record Createt_office_status_record()
        {

            string ClassNamespace = AssemblyPath + ".t_office_status_record";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_office_status_record)objType;
        }


        /// <summary>
        /// 创建t_order_detail数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_order_detail Createt_order_detail()
        {

            string ClassNamespace = AssemblyPath + ".t_order_detail";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_order_detail)objType;
        }


        /// <summary>
        /// 创建t_order_record数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_order_record Createt_order_record()
        {

            string ClassNamespace = AssemblyPath + ".t_order_record";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_order_record)objType;
        }


        /// <summary>
        /// 创建t_ordered_datechange数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_ordered_datechange Createt_ordered_datechange()
        {

            string ClassNamespace = AssemblyPath + ".t_ordered_datechange";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_ordered_datechange)objType;
        }


        /// <summary>
        /// 创建t_org_base_packages数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_org_base_packages Createt_org_base_packages()
        {

            string ClassNamespace = AssemblyPath + ".t_org_base_packages";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_org_base_packages)objType;
        }


        /// <summary>
        /// 创建t_org_contract_rel数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_org_contract_rel Createt_org_contract_rel()
        {

            string ClassNamespace = AssemblyPath + ".t_org_contract_rel";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_org_contract_rel)objType;
        }


        /// <summary>
        /// 创建t_pay_transaction_record数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_pay_transaction_record Createt_pay_transaction_record()
        {

            string ClassNamespace = AssemblyPath + ".t_pay_transaction_record";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_pay_transaction_record)objType;
        }


        /// <summary>
        /// 创建t_product_info数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_product_info Createt_product_info()
        {

            string ClassNamespace = AssemblyPath + ".t_product_info";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_product_info)objType;
        }


        /// <summary>
        /// 创建t_product_schedule数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_product_schedule Createt_product_schedule()
        {

            string ClassNamespace = AssemblyPath + ".t_product_schedule";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_product_schedule)objType;
        }


        /// <summary>
        /// 创建t_repair_picture数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_repair_picture Createt_repair_picture()
        {

            string ClassNamespace = AssemblyPath + ".t_repair_picture";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_repair_picture)objType;
        }


        /// <summary>
        /// 创建t_repair_record数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_repair_record Createt_repair_record()
        {

            string ClassNamespace = AssemblyPath + ".t_repair_record";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_repair_record)objType;
        }


        /// <summary>
        /// 创建t_reservation_office数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_reservation_office Createt_reservation_office()
        {

            string ClassNamespace = AssemblyPath + ".t_reservation_office";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_reservation_office)objType;
        }


        /// <summary>
        /// 创建t_reservation_record数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_reservation_record Createt_reservation_record()
        {

            string ClassNamespace = AssemblyPath + ".t_reservation_record";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_reservation_record)objType;
        }


        /// <summary>
        /// 创建t_shopping_cart数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_shopping_cart Createt_shopping_cart()
        {

            string ClassNamespace = AssemblyPath + ".t_shopping_cart";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_shopping_cart)objType;
        }


        /// <summary>
        /// 创建t_suggestion_record数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_suggestion_record Createt_suggestion_record()
        {

            string ClassNamespace = AssemblyPath + ".t_suggestion_record";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_suggestion_record)objType;
        }


        /// <summary>
        /// 创建t_system_message数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_system_message Createt_system_message()
        {

            string ClassNamespace = AssemblyPath + ".t_system_message";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_system_message)objType;
        }


        /// <summary>
        /// 创建t_temp_post_user数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_temp_post_user Createt_temp_post_user()
        {

            string ClassNamespace = AssemblyPath + ".t_temp_post_user";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_temp_post_user)objType;
        }


        /// <summary>
        /// 创建t_trading_account_record数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_trading_account_record Createt_trading_account_record()
        {

            string ClassNamespace = AssemblyPath + ".t_trading_account_record";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_trading_account_record)objType;
        }


        /// <summary>
        /// 创建t_webchat_message数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_webchat_message Createt_webchat_message()
        {

            string ClassNamespace = AssemblyPath + ".t_webchat_message";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_webchat_message)objType;
        }


        /// <summary>
        /// 创建t_wechat_menu数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.It_wechat_menu Createt_wechat_menu()
        {

            string ClassNamespace = AssemblyPath + ".t_wechat_menu";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.It_wechat_menu)objType;
        }


        /// <summary>
        /// 创建user_refund_record数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Iuser_refund_record Createuser_refund_record()
        {

            string ClassNamespace = AssemblyPath + ".user_refund_record";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Iuser_refund_record)objType;
        }


        /// <summary>
        /// 创建view_member数据层接口。
        /// </summary>
        public static LW_AskOnline.IDAL.Iview_member Createview_member()
        {

            string ClassNamespace = AssemblyPath + ".view_member";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (LW_AskOnline.IDAL.Iview_member)objType;
        }

    }
}