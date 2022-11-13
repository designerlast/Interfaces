using IntellVega.CBB.Interfaces.Enums;
using System;
using System.Collections.Generic;

namespace IntellVega.CBB.Interfaces.Statistics
{
    public interface IStatistics
    {
        /// <summary>
        /// 获取工位名称列表
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> LoadStationNames();

        /// <summary>
        /// 加载统计数据
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        List<StationStatistics> LoadStationStatistics(DateTime start, DateTime end);

        /// <summary>
        /// 获取查询报表数据
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stations"></param>
        /// <param name="checkResult"></param>
        /// <returns></returns>
        IEnumerable<T> SearchRecords<T>(DateTime? startTime, DateTime? endTime, IEnumerable<string> stations, DetectionResult checkResult) where T:BaseRecord;

        /// <summary>
        /// 获取程序集下所有继承baserecord的类型中特性CameraDataBaseModel定义的名称。
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> GetDatabaseModeNames();
        /// <summary>
        /// 通过名称获取对应的类型
        /// </summary>
        /// <param name="camera"></param>
        /// <returns></returns>
        Type GetModelTypeByCmaeraName(string camera);
    }
}