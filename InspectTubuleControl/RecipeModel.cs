using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IntellVega.CBB.Interfaces.InspectTubuleControl
{
    public class RecipeModel
    {
        /// <summary>
        /// 配方名称
        /// </summary>
        public string Name { get; set; }=String.Empty;

        /// <summary>
        /// 配方说明
        /// </summary>
        public string Description { get; set; } = String.Empty;


        /// <summary>
        /// 与plc对接切换信号关系 通过获取对应的plc判断要处理逻辑
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 运行界面layout路径 xml
        /// </summary>
        public string Layout { get; set; } = String.Empty;

        /// <summary>
        /// 配方路径 xml信息
        /// </summary>
        public string Recipe { get; set; } = String.Empty;

        /// <summary>
        /// 显示相机配方界面名称
        /// </summary>
        public string PadName { get; set; } = String.Empty;

        /// <summary>
        /// 对应的相机名称
        /// </summary>
        public string CameraName { get; set; } = String.Empty;
        /// <summary>
        /// 相机IP
        /// </summary>
        public string CameraIp { get; set; } = String.Empty;
        /// <summary>
        /// 对应的相机端口号
        /// </summary>
        public int CamerPort { get; set; }

        #region 算子相关数据
        /// <summary>
        /// 配方对应的流程图路径集合，顺序执行
        /// </summary>

        public List<string> FlowPathList { get; set; }
        /// <summary>
        /// 配方对应的需要写入plc的开始地址
        /// </summary>
        public int StartLocation { get; set; }
        /// <summary>
        /// 拍照完成地址
        /// </summary>
        public int FinishStation { get; set; }

        /// <summary>
        /// 累计拍照次数
        /// </summary>
        public int ShotTimes { get; set; }
        /// <summary>
        /// 每次拍照的检测结果数量
        /// </summary>
        public int ProductNumbers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int TriggerTimes { get; set; }
        /// <summary>
        /// 一次写入数据所需的照片数量
        /// </summary>
        public int Pictures { get; set; }
        /// <summary>
        /// 配方类型
        /// </summary>
        public RecipeEnum RecipeEnum { get; set; }
        #endregion

    }
}
