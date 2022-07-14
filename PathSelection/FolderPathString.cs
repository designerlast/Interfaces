using System;
using System.Collections.Generic;
using System.Text;
using IntellVega.CBB.Interfaces.Attributes;

namespace IntellVega.CBB.Interfaces.PathSelection
{
	public class FolderPathString
	{
		[SelectFolder("inFolderPath",false)]
		public string Path { get; set; }
	}
}
