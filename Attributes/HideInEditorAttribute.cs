using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces
{
    [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed class HideInEditorAttribute : Attribute
    {
        public HideInEditorAttribute()
        {
        }
    }
}
