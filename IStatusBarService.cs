using IntellVega.CBB.Interfaces.Enums;

namespace IntellVega.CBB.Interfaces
{
    public interface IStatusBarService
    {
        //bool Visible { get; set; }

        /// <summary>
        /// Sets the caret position shown in the status bar.
        /// </summary>
        /// <param name="x">column number</param>
        /// <param name="y">line number</param>
        /// <param name="charOffset">character number</param>
        void SetCaretPosition(int x, int y, int charOffset);
        //void SetInsertMode(bool insertMode);

        /// <summary>
        /// Sets the selection length in the status bar.
        /// </summary>
        /// <param name="length">selection length</param>
        void SetSelectionSingle(int length);

        /// <summary>
        /// Sets rect selection size in the status bar.
        /// </summary>
        /// <param name="rows">vertical size of selecion</param>
        /// <param name="cols">horizontal size of selection</param>
        void SetSelectionMulti(int rows, int cols);

        /// <summary>
        /// 设置状态栏消息
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="status">消息状态（文字颜色） Normal：黑色 Success：绿色 Fail：红色 Error：红色 Warning：橙色</param>
        void SetMessage(string message, SystemStatus status = SystemStatus.Normal);

        /// <summary>
        /// Set mode status bar, location at rightest
        /// </summary>
        /// <param name="content"></param>
        void SetModeStatusBar(object content);

        /// <summary>
        /// Creates a new <see cref="IProgressMonitor"/> that can be used to report
        /// progress to the status bar.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use for
        /// <see cref="IProgressMonitor.CancellationToken"/></param>
        /// <returns>The new IProgressMonitor instance. This return value must be disposed
        /// once the background task has completed.</returns>
        //IProgressMonitor CreateProgressMonitor(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Shows progress for the specified ProgressCollector in the status bar.
        /// </summary>
        //void AddProgress(ProgressCollector progress);
    }
}
