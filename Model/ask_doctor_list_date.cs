using System;
namespace LW_AskOnline.Model
{
    /// <summary>
    /// ask_doctor_list_date:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ask_doctor_list_date
    {
        public ask_doctor_list_date()
        { }
        #region Model
        private int _dateid;
        private int _did;
        private string _datetag;
        private string _data_tag;
        /// <summary>
        /// 
        /// </summary>
        public int dateid
        {
            set { _dateid = value; }
            get { return _dateid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int did
        {
            set { _did = value; }
            get { return _did; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string datetag
        {
            set { _datetag = value; }
            get { return _datetag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string data_tag
        {
            set { _data_tag = value; }
            get { return _data_tag; }
        }
        #endregion Model

    }
}

