using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XmlDatabase;

namespace AgentWinform.Model
{
    public class UserInfo : XmlEntity
    {
        /// <summary>
        /// 编号ID（非主键）
        /// </summary>
        public string Name { set; get; }
        public string WeixinNo { set; get; }

        public string Area{ set; get; }

        public string City { get; set; }

        public string AreaName { set; get; }

        public string CityName { get; set; }

        public string Level { set; get; }

        public string LevelName { set; get; }

        public string TaobaoName { set; get; }

        public DateTime AuthStart { set; get; }

        public DateTime AuthEnd { set; get; }

        public DateTime AuthNow { set; get; }

        public string AuthNo { set; get; }

        public string NameNo { set; get; }

        public string photoPath { get; set; }

        public string AuthPhotoPath { get; set; }
    }
}
