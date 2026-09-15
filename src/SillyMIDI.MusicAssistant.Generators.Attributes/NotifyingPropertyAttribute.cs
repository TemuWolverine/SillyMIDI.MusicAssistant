using System;

namespace SillyMIDI.MusicAssistant.Generators.Attributes;

[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
public sealed class NotifyingPropertyAttribute : Attribute
{
}
