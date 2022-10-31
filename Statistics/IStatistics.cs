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
        List<string> LoadStationNames();

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
        List<RunRecord> SearchRecords(DateTime? startTime, DateTime? endTime, IEnumerable<string> stations, DetectionResult checkResult);
    }
}