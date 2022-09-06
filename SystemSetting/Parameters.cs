namespace IntellVega.CBB.Interfaces.SystemSetting
{
    public class Parameters
    {
        [Remark("启动设置")]
        public StartupSettings StartupSettings { get; set; }

        [Remark("图片保存与清理")]
        public ProjectImageSettings ProjectImageSettings { get; set; }

        [Remark("日志保存设置")]
        public LogSettings LogSettings { get; set; }
    }

    public class StartupSettings
    {
        [Remark("开机自启动")]
        public bool AutoStartup { get; set; }

        [Remark("自动切换到生产界面")]
        public bool AutoSwitchToProject { get; set; }

        [Remark("自动加载最近的配方")]
        public bool AutoLoadRecentRecipes { get; set; }
    }

    public class ProjectImageSettings
    {
        /// <summary>
        /// 图片导出路径
        /// </summary>
        [Remark("图片保存路径")]
        public string ImageExportPath { get; set; }

        /// <summary>
        /// 是否保存图片
        /// </summary>
        [Remark("是否保存图片")]
        public bool SaveImage { get; set; } = true;

        /// <summary>
        /// 图像保留天数
        /// </summary>
        [Remark("图像保留天数")]
        public int ImageRetentionDays { get; set; } = 10;

        /// <summary>
        /// 是否自动清理
        /// </summary>
        [Remark("自动清理")]
        public bool AutoClear { get; set; }
    }

    public class LogSettings
    {
        /// <summary>
        /// 日志保留天数
        /// </summary>
        [Remark("日志保留天数")]
        public int LogRetentionDays { get; set; } = 30;

        /// <summary>
        /// 是否保存Debug日志
        /// </summary>
        [Remark("是否保存Debug日志")]
        public bool AutoSaveDebug { get; set; }
    }
}
