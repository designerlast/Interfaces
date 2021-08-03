using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntellVega.InterfacesLib;

namespace IntellVega.InterfacesLib
{
    public interface ISettingManager : IDataGrabber<ConfiguredAttribute,string>
    { }

    public interface ICalibManager : IDataGrabber<CalibDataAttribute,string>
    { }
}

namespace IntellVega
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    public sealed class ConfiguredAttribute : Attribute
    {
    }
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    public sealed class CalibDataAttribute : Attribute
    {
    }
}
