using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.Statistics.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DataSourceBindingAttribute : Attribute
    {
        /// <summary>
        /// 列标题
        /// </summary>
        public string ColumnHeader = "";
        /// <summary>
        /// 宽度 数字 -1=*  | 0=Auto 
        /// </summary>
        public int Width = 0;

        public bool IsShow;

        /// <summary>
        /// 数据源绑定
        /// </summary>
        /// <param name="columnHeader">列标题</param>
        /// <param name="width">宽度 只能是数字 -1=*  | 0=Auto   </param>
        /// <param name="isShow">是否显示 默认是true显示   </param>
        /// 
        public DataSourceBindingAttribute(string columnHeader, int width = -1, bool isShow = true)
        {
            ColumnHeader = columnHeader;
            Width = width;
            IsShow = isShow;
        }
    }

}
