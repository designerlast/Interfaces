using System.Collections.Generic;

namespace IntellVega.CBB.Interfaces.DeepLearning
{
    public interface IGetParameters
    {
        /// <summary>
        /// 获取训练参数
        /// </summary>
        /// <returns></returns>
        Dictionary<string, object> GetTrainParameters();

        /// <summary>
        /// 获取推理参数
        /// </summary>
        /// <returns></returns>
        Dictionary<string, object> GetReasonParameters();
    }
}
