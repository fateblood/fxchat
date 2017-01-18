using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonPropertyTest.RedisModel
{
    /// <summary>
    /// 聊天消息的内容
    /// </summary>
    public class ChatMsgContent
    {
        public ChatMsgContent()
        {
            URL = new List<string>();
        }
        /// <summary>
        /// 聊天消息类型
        /// </summary>
        public ChatMsgType CmType { get; set; }


        /// <summary>
        /// 文本消息字符串 消息格式为
        /// 例：
        /// 1、TXT_IMG:我是一个传说[:IMG],谢谢
        /// 2、TXT:我是一个传说
        /// 3、SOUND:[:SOUND]
        /// 4、IMG:[:IMG]
        /// 5、VIDEO:[:VIDEO]
        /// 6、FILE:[:FILE]
        /// 7、@:[:@]
        /// 8、SHAKE:[:SHAKE] //震动
        /// </summary>
        public string MsgContent { get; set; }

        /// <summary>
        /// 连接的集合,将提供绝对路径
        /// </summary>
        public List<string> URL { get; set; }


        /// <summary>
        /// 图片集合
        /// </summary>
        public List<ChatImage> Images { get; set; }

        /// <summary>
        /// 带毫秒的消息时间
        /// </summary>
        public string LongMsgDateTime { get; set; }

        /// <summary>
        /// 普通日期不带毫秒
        /// </summary>
        public DateTime MsgDateTime { get; set; }

        /// <summary>
        /// 消息唯一ID
        /// </summary>
        public string UniqueIdentification { get; set; }

        /// <summary>
        /// 聊天文件
        /// </summary>
        public ChatFile ChatFile { get; set; }

        /// <summary>
        /// 聊天消息中@的人
        /// </summary>
        public List<Receiver> AtUsers { get; set; }

    }

    /// <summary>
    /// 聊天图片
    /// </summary>
    public class ChatImage
    {
        /// <summary>
        /// 表情包名称
        /// </summary>
        public string EType { get; set; }

        /// <summary>
        /// 表情名称
        /// </summary>
        public string EName { get; set; }
        /// <summary>
        /// 聊天图片的URL
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 图片宽度
        /// </summary>
        public string Width { get; set; }
        /// <summary>
        /// 图片高度
        /// </summary>
        public string Height { get; set; }
        /// <summary>
        /// 是表情还是普通图片
        /// </summary>
        public ChatImageType ImageType { get; set; }
    }


    /// <summary>
    /// 发送聊天文件的处理
    /// </summary>
    public class ChatFile
    {
        /// <summary>
        /// 文件名
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// 文件类型(用文件后缀名进行标识)
        /// </summary>
        public string FileType { get; set; }

        /// <summary>
        /// 文件URL
        /// </summary>
        public string FileUrl { get; set; }
        /// <summary>
        /// 文件的大小（文件大小以字节进行标识）
        /// </summary>
        public int FileSize { get; set; }
        /// <summary>
        /// 已经接收的设备类型
        /// </summary>
        public List<EquipmentType> ReceivedEquipmentTypes { get; set; }
        /// <summary>
        /// 文件MD5校验
        /// </summary>
        public string FileMD5 { get; set; }
    }
}
