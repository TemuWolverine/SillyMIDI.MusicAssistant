using SillyMIDI.MusicAssistant.Generators.Attributes;
using SillyMIDI.MusicAssistant.Messages;
using SillyMIDI.MusicAssistant.Models;
using SillyMIDI.MusicAssistant.Models.Enums;
using SillyMIDI.MusicAssistant.Responses;

namespace SillyMIDI.MusicAssistant.WsExtensions;

public static partial class MusicAssistantClientWsExtensions
{
    [ToRpc]
    public static async Task<GenresResponse> GetGenresLibraryItemsAsync(this MusicAssistantClientWs c, int? limit = null, int? offset = null, string? search = null, OrderBy orderby = OrderBy.Unknown, bool favourite = false, bool hide_empty = true)
    {
        var m = new Message(Commands.GenresLibraryItems)
        {
            Args = new Dictionary<string, object>()
                {
                    { "favorite_only", favourite },
                    { "hide_empty", hide_empty },
                }
        };

        if (limit.HasValue)
        {
            m.Args["limit"] = limit.Value.ToString();
        }
        if (offset.HasValue)
        {
            m.Args["offset"] = offset.Value.ToString();
        }
        if (!string.IsNullOrEmpty(search))
        {
            m.Args["search"] = search;
        }
        if (orderby != OrderBy.Unknown)
        {
            m.Args["order_by"] = orderby;
        }
        return await SendAsync<GenresResponse>(c, m);
    }

    public static async Task<GenreResponse> GetGenreAsync(this MusicAssistantClientWs c, string genreId, string providerInstanceIdOrDomain)
    {
        return await SendAsync<GenreResponse>(c, ClientHelpers.IdAndProvider(Commands.GenresGet, genreId, providerInstanceIdOrDomain));
    }

    [ToRpc]
    public static async Task<GenreOverviewResponse> GetGenreOverviewAsync(this MusicAssistantClientWs c, string genreId)
    {
        return await SendAsync<GenreOverviewResponse>(c, ClientHelpers.JustId(Commands.GenresGetOverview, genreId));
    }
}