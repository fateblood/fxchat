using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonPropertyTest.RedisModel
{
    /// <summary>
    /// 聊天类型
    /// </summary>
    public enum ChatType
    {
        /// <summary>
        /// 个人聊天
        /// </summary>
        PersonChat = 1,
        /// <summary>
        /// 群组聊天
        /// </summary>
        GroupChat = 2,
        /// <summary>
        /// 商城聊天
        /// </summary>
        MallChat = 3,
        /// <summary>
        /// 讨论组聊天
        /// </summary>
        DiscussChat = 4
    }
}
