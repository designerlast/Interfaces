using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IntellVega.CBB.Interfaces.RuningState
{
    public enum StateType
    {
        [Display(Name = "默认")]
        None = -1,

        [Display(Name = "停止中")]
        Stopping = 0,

        [Display(Name = "运行中")]
        Runing = 1,

        [Display(Name = "暂停")]
        Suspend =2,

        [Display(Name = "错误")]
        Error = 3,

        [Display(Name = "平台Load完成")]
        PlatformLoaded = 4,
    }
}
