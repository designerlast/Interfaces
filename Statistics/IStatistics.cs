using IntellVega.CBB.Interfaces.Enums;
using System;
using System.Collections.Generic;

namespace IntellVega.CBB.Interfaces.Statistics
{
    public interface IStatistics
    {
        List<StationStatistics> LoadStationStatistics(DateTime start, DateTime end);

        List<RunRecord> SearchRecords(DateTime? startTime, DateTime? endTime, IEnumerable<string> stations, DetectionResult checkResult);
    }
}