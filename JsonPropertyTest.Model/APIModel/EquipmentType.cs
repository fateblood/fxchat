using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonPropertyTest.APIModel
{
    /// <summary>
    /// 设备类型
    /// </summary>
    public enum EquipmentType : int
    {
        /// <summary>
        /// 苹果
        /// </summary>
        IOS = 1,
        /// <summary>
        /// 安卓
        /// </summary>
        Android = 2,
        /// <summary>
        /// 电脑桌面
        /// </summary>
        WPC = 3,
        /// <summary>
        /// 网页端
        /// </summary>
        Web = 4
    }
}
