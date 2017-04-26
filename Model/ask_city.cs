using System;
namespace LW_AskOnline.Model
{
    /// <summary>
    /// ask_city:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ask_city
    {
        public ask_city()
        { }
        #region Model
        private string _cid;
        private string _cparent_id;
        private string _cregion_grade;
        private string _cregion_name;
        private string _cdistrict_code;
        private string _carea_code;
        private int? _cstatus;
        /// <summary>
        /// 
        /// </summary>
        public string cid
        {
            set { _cid = value; }
            get { return _cid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string cparent_id
        {
            set { _cparent_id = value; }
            get { return _cparent_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string cregion_grade
        {
            set { _cregion_grade = value; }
            get { return _cregion_grade; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string cregion_name
        {
            set { _cregion_name = value; }
            get { return _cregion_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string cdistrict_code
        {
            set { _cdistrict_code = value; }
            get { return _cdistrict_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string carea_code
        {
            set { _carea_code = value; }
            get { return _carea_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? cstatus
        {
            set { _cstatus = value; }
            get { return _cstatus; }
        }
        #endregion Model

    }
}

