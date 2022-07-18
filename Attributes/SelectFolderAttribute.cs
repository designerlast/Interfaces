using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces.Attributes
{
	public class SelectFolderAttribute:RemarkAttribute
	{
		/// <summary>
		/// 是否只读
		/// </summary>
		public bool ReadOnly { get; private set; }

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name="remarkLocalName">提示文字</param>
		/// <param name="readOnly">是否只读</param>
		/// <param name="isEnabled">是否可用</param>
		public SelectFolderAttribute(string remarkLocalName,
			bool readOnly = true,
			bool isEnabled = true) : base(remarkLocalName, isEnabled)
		{
			ReadOnly = readOnly;
		}
    }
}
