using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonPropertyTest.RedisModel
{
    /// <summary>
    /// 聊天消息类型
    /// </summary>
    public enum ChatMsgType : int
    {
        /// <summary>
        /// 纯文本，中会包含表情
        /// </summary>
        TXT = 1,
        /// <summary>
        /// 文本加图片
        /// </summary>
        TXT_IMG = 2,
        /// <summary>
        /// 纯图片
        /// </summary>
        IMG = 3,
        /// <summary>
        /// 春声音
        /// </summary>
        SOUND = 4,
        /// <summary>
        /// 文件
        /// </summary>
        FILE = 5,
        /// <summary>
        /// 视频
        /// </summary>
        VIDEO = 6,

        /// <summary>
        /// 通知
        /// </summary>
        NOTICE = 7,
        /// <summary>
        /// 添加相册相片通知
        /// </summary>
        AlbumNotice = 8,
        /// <summary>
        /// 群公告
        /// </summary>
        GroupNotice = 9,
        /// <summary>
        /// 群文件
        /// </summary>
        GroupFile = 10,

        /// <summary>
        /// 抖动枚举
        /// </summary>
        Shake = 11,
        /// <summary>
        /// 赠金枚举
        /// </summary>
        Bouns = 12
    }
}
