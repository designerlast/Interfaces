using System.Collections.ObjectModel;
using System.Reflection;

namespace IntellVega.CBB.Interfaces.Dataflow
{
    public interface IApplicationDataflow
    {
        /// <summary>
        /// 流程新增元素
        /// </summary>
        /// <param name="item"></param>
        void AddSourceItem(SourceItem item);

        /// <summary>
        /// 获取流程图元素集合（子函数、变量、事件）
        /// </summary>
        /// <returns></returns>
        ObservableCollection<SourceItem> GetListSource();

        /// <summary>
        /// 绑定事件处理程序
        /// </summary>
        /// <param name="link">窗口的链接（Pad名和ViewModel类名）</param>
        /// <param name="eventInfo">事件对象</param>
        /// <param name="funcName">数据流中的子程序名</param>
        void BindEventHandler(ViewMappingLink link, EventInfo eventInfo, string funcName);
    }
}