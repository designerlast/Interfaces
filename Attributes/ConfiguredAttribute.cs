using System;
using System.Collections.Generic;
using System.Text;

namespace IntellVega.CBB.Interfaces
{
    [System.AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    public sealed class ConfiguredAttribute : Attribute
    {
    }
    [System.AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false, AllowMultiple = true)]
    public sealed class NotConfiguredAttribute : Attribute
    {
    }
}
