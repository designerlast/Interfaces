using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace IntellVega.CBB.Interfaces.Dataflow
{
    public interface IDataflowEditor
    {
        /// <summary>
        /// 设置显示的流程图
        /// </summary>
        /// <param name="key">流程图名称</param>
        void SetListGraph(string key);

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
    }
}
