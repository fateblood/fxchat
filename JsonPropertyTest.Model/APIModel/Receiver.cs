using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonPropertyTest.APIModel
{
    public class Receiver
    {
        /// <summary>
        /// 接收方的 ID
        /// </summary>
        public string ReceiverID { get; set; }

        /// <summary>
        /// 接收方类型
        /// </summary>
        public ClientType ReceiverType { get; set; }

        /// <summary>
        /// 接收方主ID（商城聊天类型 将使用 交易商ID，群聊天类型 将使用 群ID)
        /// </summary>
        public string ReceiverMainID { get; set; }

        /// <summary>
        /// 接收者的显示名称
        /// </summary>
        public string ReceiverName { get; set; }

        /// <summary>
        /// 接收者的显示图像
        /// </summary>

        public string ReceiverImg { get; set; }


    }
}
