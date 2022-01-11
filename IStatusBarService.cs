using System;
using System.Collections.Generic;
using System.Text;

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
        /// Sets the message shown in the left-most pane in the status bar.
        /// </summary>
        /// <param name="message">The message text.</param>
        /// <param name="highlighted">Whether to highlight the text</param>
        /// <param name="icon">Icon to show next to the text</param>
        void SetMessage(string message, bool highlighted = false);

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
