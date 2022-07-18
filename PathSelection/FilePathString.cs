using System;
using System.Collections.Generic;
using System.Text;
using IntellVega.CBB.Interfaces.Attributes;

namespace IntellVega.CBB.Interfaces.PathSelection
{
	public class FilePathString
	{
		[SelectFile("inFilePath","","路径选择",false)]
		public string Path { get; set; }
	}
}
