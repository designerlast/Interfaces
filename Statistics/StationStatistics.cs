namespace IntellVega.CBB.Interfaces.Statistics
{
    public class StationStatistics
    {
        /// <summary>
        /// 工位名称
        /// </summary>
        public string StationName { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// OK数
        /// </summary>
        public int OKCount { get; set; }

        /// <summary>
        /// NG数
        /// </summary>
        public int NGCount { get; set; }

        /// <summary>
        /// 良率
        /// </summary>
        public double Yield { get; set; }

        /// <summary>
        /// UPH
        /// </summary>
        public int UPH { get; set; }

        /// <summary>
        /// CT 通量
        /// </summary>
        public int CT { get; set; }
    }
}
