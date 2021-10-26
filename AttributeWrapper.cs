using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace IntellVega.CBB.Interfaces
{
    [DataContract]
    public class AttributeWrapper<T>
    {
        public AttributeWrapper(T obj, IEnumerable<Attribute> attributes)
        {
            Content = obj;
            Attributes = attributes;
        }
        [DataMember]
        public T Content { get; private set; }
        public IEnumerable<Attribute> Attributes { get; private set; }
    }
}
