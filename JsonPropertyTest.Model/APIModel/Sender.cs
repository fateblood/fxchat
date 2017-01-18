using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonPropertyTest.APIModel
{
    public class Sender
    {
        /// <summary>
        /// 接收方的 ID
        /// </summary>
        public string SenderID { get; set; }

        /// <summary>
        /// 接收方类型
        /// </summary>
        public ClientType SenderType { get; set; }



        /// <summary>
        /// 发送者主要ID（商城聊天类型 将使用 交易商ID，群聊天类型 将使用 群ID)
        /// </summary>
        public string SenderMainID { get; set; }
        /// <summary>
        /// 发送者的现实名称
        /// </summary>
        public string SenderName { get; set; }

        public string SenderImg { get; set; }


    }
}
