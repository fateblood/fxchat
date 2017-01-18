using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonPropertyTest.APIModel
{
    /// <summary>
    /// 发送聊天消息
    /// </summary>
    public class JsonChatMessage
    {
        /// <summary>
        /// 聊天类型
        /// </summary>
        public ChatType CType { get; set; }

        /// <summary>
        /// 发送者ID
        /// </summary>
        public Sender Sender { get; set; }

        /// <summary>
        /// 聊天消息的发送时间
        /// </summary>
        public DateTime SendDateTime { get; set; }

        /// <summary>
        /// 消息内容 不同的消息类型不同的消息体类型，用Json表述
        /// </summary>
        public ChatMsgContent ChatMsgContent { get; set; }

        /// <summary>
        /// 消息唯一标识
        /// </summary>
        public string UniqueIdentification { get; set; }


        /// <summary>
        /// 带有毫秒时间数据
        /// </summary>
        public string LongSendDateTime { get; set; }

        /// <summary>
        /// 是否在聊天记录中显示时间
        /// </summary>
        public bool IsDisplayDate { get; set; }

        /// <summary>
        /// 最近显示时间的时间戳
        /// </summary>
        public long NearestDisplayDate { get; set; }
        /// <summary>
        /// 接收者
        /// </summary>
        public Receiver Receiver { get; set; }


        /// <summary>
        /// 聊天的时间戳
        /// </summary>
        public long ChatMsgTimestamp { get; set; }
    }
}
