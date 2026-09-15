using System;

namespace SillyMIDI.MusicAssistant.Generators.Attributes;

[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class NotifyPropertyChangedAttribute : Attribute
{
}
