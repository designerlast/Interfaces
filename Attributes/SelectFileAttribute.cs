using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces
{
	public class SelectFileAttribute:RemarkAttribute
	{
		/// <summary>
		/// 是否只读
		/// </summary>
		public bool ReadOnly { get; private set; }

		/// <summary>
		/// 文件过滤器
		/// </summary>
		public string Filter { get; private set; }

		/// <summary>
		/// 对话框标题
		/// </summary>
		public string Title { get; private set; }

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name="remarkLocalName">提示文字</param>
		/// <param name="filter">文件过滤器</param>
		/// <param name="title">对话框标题</param>
		/// <param name="readOnly">是否只读</param>
		/// <param name="isEnabled">是否可用</param>
		public SelectFileAttribute(string remarkLocalName,
			string filter,
			string title,
			bool readOnly = true,
			bool isEnabled = true) : base(remarkLocalName, isEnabled)
		{
			ReadOnly = readOnly;
			Filter = filter;
			Title = title;
		}
    }
}
