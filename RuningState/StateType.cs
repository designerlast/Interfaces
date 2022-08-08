using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IntellVega.CBB.Interfaces.RuningState
{
    public enum StateType
    {
        /// <summary>
        /// 默认
        /// </summary>
        [Display(Name = "默认")]
        None = -1,

        /// <summary>
        /// 停止中
        /// </summary>
        [Display(Name = "停止中")]
        Stopping = 0,

        /// <summary>
        /// 运行中
        /// </summary>
        [Display(Name = "运行中")]
        Runing = 1,

        /// <summary>
        /// 暂停
        /// </summary>
        [Display(Name = "暂停")]
        Suspend =2,

        /// <summary>
        /// 错误
        /// </summary>
        [Display(Name = "错误")]
        Error = 3,

        /// <summary>
        /// 平台Load完成
        /// </summary>
        [Display(Name = "平台Load完成")]
        PlatformLoaded = 4,
    }
}
