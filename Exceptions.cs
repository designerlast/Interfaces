using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellVega.CBB.Interfaces
{
    public static class ExceptionHelper
    {
        public static string ExpandExceptionMessage(this Exception ex) => string.Join('\n', ex.Message, ex.InnerException?.ExpandExceptionMessage() ?? null);
    }
    [Serializable]
    public class DeviceInitFailedException : Exception
    {
        public DeviceInitFailedException() { }
        public DeviceInitFailedException(string message) : base(message) { }
        public DeviceInitFailedException(string message, Exception inner) : base(message, inner) { }
        protected DeviceInitFailedException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    [Serializable]
    public class DeviceNotReadyException : Exception
    {
        public DeviceNotReadyException() { }
        public DeviceNotReadyException(string message) : base(message) { }
        public DeviceNotReadyException(string message, Exception inner) : base(message, inner) { }
        protected DeviceNotReadyException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class DeviceCloseFailedException : Exception
    {
        public DeviceCloseFailedException() { }
        public DeviceCloseFailedException(string message) : base(message) { }
        public DeviceCloseFailedException(string message, Exception inner) : base(message, inner) { }
        protected DeviceCloseFailedException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
    [Serializable]
    public class UnexpectedException : Exception
    {
        public UnexpectedException() { }
        public UnexpectedException(string message) : base(message) { }
        public UnexpectedException(string message, Exception inner) : base(message, inner) { }
        protected UnexpectedException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
    [Serializable]
    public class TypeMismatchException : Exception
    {
        public TypeMismatchException() { }
        public TypeMismatchException(string message) : base(message) { }
        public TypeMismatchException(string message, Exception inner) : base(message, inner) { }
        protected TypeMismatchException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
    [Serializable]
    public class NotInitializedException : Exception
    {
        public NotInitializedException() { }
        public NotInitializedException(string message) : base(message) { }
        public NotInitializedException(string message, Exception inner) : base(message, inner) { }
        protected NotInitializedException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }


    [Serializable]
    public class ServiceNotFoundException : Exception
    {
        public ServiceNotFoundException() { }
        public ServiceNotFoundException(string message) : base(message) { }
        public ServiceNotFoundException(string message, Exception inner) : base(message, inner) { }
        protected ServiceNotFoundException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        public ServiceNotFoundException(Type serviceType) : base("Required service not found: " + serviceType.FullName)
        { }
    }


    [Serializable]
    public class ConfigurationException : Exception
    {
        public ConfigurationException() { }
        public ConfigurationException(string message) : base(message) { }
        public ConfigurationException(string message, Exception inner) : base(message, inner) { }
        protected ConfigurationException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    [Serializable]
    public class UndefinedException : Exception
    {
        public string ArgumentName { get; private set; }
        public UndefinedException() { }
        //public UndefinedException(string message) : base(message) { }
        public UndefinedException(string message, string argName) : base(message) { ArgumentName = argName; }
        public UndefinedException(string message, Exception inner) : base(message, inner) { }
        protected UndefinedException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    [Serializable]
    public class AlgorithmException : Exception
    {
        public AlgorithmException() { }
        public AlgorithmException(string message) : base(message) { }
        public AlgorithmException(string message, Exception inner) : base(message, inner) { }
        protected AlgorithmException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
