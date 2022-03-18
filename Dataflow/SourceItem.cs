using System.Collections.ObjectModel;

namespace IntellVega.CBB.Interfaces.Dataflow
{
    public class SourceItem
    {
        /// <summary>
        /// id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 父级id
        /// </summary>
        public string ParentId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 类型 0：主流程 1：子流程  2：变量
        /// </summary>
        public SourceType Type { get; set; }

        /// <summary>
        /// 使用次数
        /// </summary>
        public int UseCount { get; set; }

        /// <summary>
        /// 是否绑定界面
        /// </summary>
        public bool IsBindHMI { get; set; }

        /// <summary>
        /// 子流程集合
        /// </summary>
        public ObservableCollection<SourceItem> ChildElements { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Remark { get; set; }
    }

    public enum SourceType
    {
        /// <summary>
        /// 主流程
        /// </summary>
        Main = 0,

        /// <summary>
        /// 子流程
        /// </summary>
        Subfunction = 1,

        /// <summary>
        /// 全局变量
        /// </summary>
        GlobalVariable = 2
    }
}
