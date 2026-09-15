using System;

namespace SillyMIDI.MusicAssistant.Generators.Attributes
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public sealed class ToRpcAttribute : Attribute
    {
    }
}
