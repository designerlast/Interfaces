using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntellVega.CBB.Interfaces.Convert
{
    public class ConvertAdapter
    {
        public Type[] SupportedTypes { get; private set; }
        /// <summary>
        /// <see cref="IConvertibleFrom"/>接口需要提供的<see cref="IConvertibleFrom.Adapter"/>属性类型
        /// <example>
        /// <code>
        /// ConvertAdapter Adapter { get; } = new ConvertAdapter(MethodBase.GetCurrentMethod()?.DeclaringType);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="declaringType">实现<see cref="IConvertibleFrom"/>接口的类型，也是该成员变量所在的类。</param>
        public ConvertAdapter(Type declaringType)
        {
            SupportedTypes = ConvertAdapterHelper.EnumSupportedTypes(declaringType)?.ToArray();
        }
    }
    public static class ConvertAdapterHelper
    {
        internal static IEnumerable<Type> EnumSupportedTypes(Type type)
        {
            return type?.GetInterfaces()?.Where(t => t.IsGenericType && t.GetGenericTypeDefinition() == typeof(IConvertibleFrom<>))?.Select(t => t.GetGenericArguments().First());
        }
        public static void ConvertFrom(this IConvertibleFrom obj, Type type, object source)
        {
            if (!type.IsAssignableFrom(source.GetType()))
                throw new InvalidCastException(string.Format("Can't convert type '{0}' to type '{1}'", source.GetType().Name, type.Name));
            if (!obj.Adapter.SupportedTypes.Contains(type))
                throw new InvalidOperationException(string.Format("Type '{0}' is not supported for class '{1}'.", type.Name, obj.GetType().Name));

            var genericType = typeof(IConvertibleFrom<>).MakeGenericType(type);
            var method = genericType.GetMethod(nameof(IConvertibleFrom<int>.ConvertFrom));
            method.Invoke(obj, new object[] { source });
        }
    }
}
