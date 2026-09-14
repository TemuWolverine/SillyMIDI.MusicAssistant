using System.Text.Json;

namespace WateryTart.MusicAssistant.Responses;

/// <summary>
/// Represents a command result whose shape is not defined by the available API schema.
/// </summary>
public sealed class JsonElementResponse : ResponseBase<JsonElement>
{
}
