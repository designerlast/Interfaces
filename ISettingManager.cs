using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntellVega.CBB.Interfaces;

namespace IntellVega.CBB.Interfaces
{
    public interface ISettingManager : IDataGrabber<ConfiguredAttribute,string>
    { }

    public interface ICalibManager : IDataGrabber<CalibDataAttribute,string>
    { }

    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    public sealed class ConfiguredAttribute : Attribute
    {
    }
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    public sealed class CalibDataAttribute : Attribute
    {
    }
}
