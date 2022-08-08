using System;
using System.Collections.Generic;

namespace IntellVega.CBB.Interfaces.Statistics
{
    public interface IStatistics
    {
        List<StationStatistics> LoadStationStatistics(DateTime start, DateTime end);
    }
}
