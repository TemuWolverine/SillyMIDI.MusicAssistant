using System.Text.Json;

namespace SillyMIDI.MusicAssistant.Responses;

/// <summary>
/// Authentication providers returned by <c>auth/providers</c>.
/// Provider objects are schema-extensible, so each provider is preserved as JSON.
/// </summary>
public sealed class AuthProvidersResponse : ResponseBase<List<JsonElement>>
{
}
