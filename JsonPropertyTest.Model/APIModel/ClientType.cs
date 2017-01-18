using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonPropertyTest.APIModel
{
    /// <summary>
    /// 连接类型
    /// </summary>
    public enum ClientType
    {
        /// <summary>
        /// 交易商/商城
        /// </summary>
        Broker = 1,
        /// <summary>
        /// 会员
        /// </summary>
        Member = 2,
        /// <summary>
        /// 游客
        /// </summary>
        Guest = 3,
        /// <summary>
        /// 官方
        /// </summary>
        Admin = 4,
        /// <summary>
        /// 群组
        /// </summary>
        Group = 5,
        /// <summary>
        /// 讨论组
        /// </summary>
        Discuss = 6
    }
}
