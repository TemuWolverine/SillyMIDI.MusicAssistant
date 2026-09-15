using WateryTart.MusicAssistant.Generators.Attributes;
using WateryTart.MusicAssistant.Messages;
using WateryTart.MusicAssistant.Models;
using WateryTart.MusicAssistant.Models.Enums;
using WateryTart.MusicAssistant.Responses;

namespace WateryTart.MusicAssistant.WsExtensions;

public static partial class MusicAssistantClientWsExtensions
{
    /// <summary>
    /// Add provider mapping to the given library item.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> MusicAddProviderMappingAsync(this MusicAssistantClientWs c, string mediaType, string dbId, object mapping)
    {
        var m = new Message(Commands.MusicAddProviderMapping)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("media_type", mediaType);
        m.Args.Add("db_id", dbId);
        m.Args.Add("mapping", mapping);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Return all versions of an album we can find on all providers.
    /// </summary>
    [ToRpc]
    public static async Task<AlbumsResponse> MusicAlbumsAlbumVersionsAsync(this MusicAssistantClientWs c, string itemId, string providerInstanceIdOrDomain)
    {
        var m = new Message(Commands.MusicAlbumsAlbumVersions)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        m.Args.Add("provider_instance_id_or_domain", providerInstanceIdOrDomain);
        return await SendAsync<AlbumsResponse>(c, m);
    }

    /// <summary>
    /// Get the first library item for the given external id, if present.
    /// </summary>
    [ToRpc]
    public static async Task<AlbumResponse> MusicAlbumsGetByExternalIdAsync(this MusicAssistantClientWs c, string externalId, object? externalIdType = null)
    {
        var m = new Message(Commands.MusicAlbumsGetByExternalId)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("external_id", externalId);
        if (externalIdType != null)
            m.Args.Add("external_id_type", externalIdType);
        return await SendAsync<AlbumResponse>(c, m);
    }

    /// <summary>
    /// Get a single collection.
    /// </summary>
    [ToRpc]
    public static async Task<MediaCollectionResponse> MusicAlbumsGetCollectionAsync(this MusicAssistantClientWs c, string itemId, string? user = null)
    {
        var m = new Message(Commands.MusicAlbumsGetCollection)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        if (user != null)
            m.Args.Add("user", user);
        return await SendAsync<MediaCollectionResponse>(c, m);
    }

    /// <summary>
    /// Delete item from the library(database).
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> MusicAlbumsRemoveAsync(this MusicAssistantClientWs c, string itemId, bool? recursive = null)
    {
        var m = new Message(Commands.MusicAlbumsRemove)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        if (recursive != null)
            m.Args.Add("recursive", recursive);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Update existing library record in the library database.
    /// </summary>
    [ToRpc]
    public static async Task<AlbumResponse> MusicAlbumsUpdateAsync(this MusicAssistantClientWs c, string itemId, Album update, bool? overwrite = null)
    {
        var m = new Message(Commands.MusicAlbumsUpdate)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        m.Args.Add("update", update);
        if (overwrite != null)
            m.Args.Add("overwrite", overwrite);
        return await SendAsync<AlbumResponse>(c, m);
    }

    /// <summary>
    /// Return audiobooks for an artist.
    /// </summary>
    [ToRpc]
    public static async Task<AudiobooksResponse> MusicArtistsArtistAudiobooksAsync(this MusicAssistantClientWs c, string itemId, string providerInstanceIdOrDomain, string? artistType = null, bool? inLibraryOnly = null, bool? collapseCollections = null)
    {
        var m = new Message(Commands.MusicArtistsArtistAudiobooks)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        m.Args.Add("provider_instance_id_or_domain", providerInstanceIdOrDomain);
        if (artistType != null)
            m.Args.Add("artist_type", artistType);
        if (inLibraryOnly != null)
            m.Args.Add("in_library_only", inLibraryOnly);
        if (collapseCollections != null)
            m.Args.Add("collapse_collections", collapseCollections);
        return await SendAsync<AudiobooksResponse>(c, m);
    }

    /// <summary>
    /// Return the tracks for a artist.
    /// </summary>
    [ToRpc]
    public static async Task<TracksResponse> MusicArtistsArtistTracksAsync(this MusicAssistantClientWs c, string itemId, string providerInstanceIdOrDomain, string? providerFilter = null)
    {
        var m = new Message(Commands.MusicArtistsArtistTracks)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        m.Args.Add("provider_instance_id_or_domain", providerInstanceIdOrDomain);
        if (providerFilter != null)
            m.Args.Add("provider_filter", providerFilter);
        return await SendAsync<TracksResponse>(c, m);
    }

    /// <summary>
    /// Get the first library item for the given external id, if present.
    /// </summary>
    [ToRpc]
    public static async Task<ArtistResponse> MusicArtistsGetByExternalIdAsync(this MusicAssistantClientWs c, string externalId, object? externalIdType = null)
    {
        var m = new Message(Commands.MusicArtistsGetByExternalId)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("external_id", externalId);
        if (externalIdType != null)
            m.Args.Add("external_id_type", externalIdType);
        return await SendAsync<ArtistResponse>(c, m);
    }

    /// <summary>
    /// Get a single collection.
    /// </summary>
    [ToRpc]
    public static async Task<MediaCollectionResponse> MusicArtistsGetCollectionAsync(this MusicAssistantClientWs c, string itemId, string? user = null)
    {
        var m = new Message(Commands.MusicArtistsGetCollection)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        if (user != null)
            m.Args.Add("user", user);
        return await SendAsync<MediaCollectionResponse>(c, m);
    }

    /// <summary>
    /// Get all supported in-library artist types.
    /// </summary>
    [ToRpc]
    public static async Task<ArtistsResponse> MusicArtistsLibraryArtistTypesAsync(this MusicAssistantClientWs c)
    {
        var m = new Message(Commands.MusicArtistsLibraryArtistTypes);
        return await SendAsync<ArtistsResponse>(c, m);
    }

    /// <summary>
    /// Get in-database (album) artists.
    /// </summary>
    [ToRpc]
    public static async Task<ArtistsResponse> MusicArtistsLibraryItemsAsync(this MusicAssistantClientWs c, object kwargs, bool? favorite = null, string? search = null, int? limit = null, int? offset = null, string? orderBy = null, List<string>? provider = null, List<object>? genre = null, bool? playedOnly = null, bool? albumArtistsOnly = null, Artist? artistType = null, bool? summary = null, List<string>? reachableVia = null, string? user = null)
    {
        var m = new Message(Commands.MusicArtistsLibraryItems)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("kwargs", kwargs);
        if (favorite != null)
            m.Args.Add("favorite", favorite);
        if (search != null)
            m.Args.Add("search", search);
        if (limit != null)
            m.Args.Add("limit", limit);
        if (offset != null)
            m.Args.Add("offset", offset);
        if (orderBy != null)
            m.Args.Add("order_by", orderBy);
        if (provider != null)
            m.Args.Add("provider", provider);
        if (genre != null)
            m.Args.Add("genre", genre);
        if (playedOnly != null)
            m.Args.Add("played_only", playedOnly);
        if (albumArtistsOnly != null)
            m.Args.Add("album_artists_only", albumArtistsOnly);
        if (artistType != null)
            m.Args.Add("artist_type", artistType);
        if (summary != null)
            m.Args.Add("summary", summary);
        if (reachableVia != null)
            m.Args.Add("reachable_via", reachableVia);
        if (user != null)
            m.Args.Add("user", user);
        return await SendAsync<ArtistsResponse>(c, m);
    }

    /// <summary>
    /// Delete record from the database.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> MusicArtistsRemoveAsync(this MusicAssistantClientWs c, string itemId, bool? recursive = null)
    {
        var m = new Message(Commands.MusicArtistsRemove)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        if (recursive != null)
            m.Args.Add("recursive", recursive);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Return similar artists for an artist.
    /// </summary>
    [ToRpc]
    public static async Task<ArtistsResponse> MusicArtistsSimilarArtistsAsync(this MusicAssistantClientWs c, string itemId, string providerInstanceIdOrDomain, string? providerFilter = null, int? limit = null)
    {
        var m = new Message(Commands.MusicArtistsSimilarArtists)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        m.Args.Add("provider_instance_id_or_domain", providerInstanceIdOrDomain);
        if (providerFilter != null)
            m.Args.Add("provider_filter", providerFilter);
        if (limit != null)
            m.Args.Add("limit", limit);
        return await SendAsync<ArtistsResponse>(c, m);
    }

    /// <summary>
    /// Return the top/featured albums for an artist.
    /// </summary>
    [ToRpc]
    public static async Task<AlbumsResponse> MusicArtistsTopAlbumsAsync(this MusicAssistantClientWs c, string itemId, string providerInstanceIdOrDomain, string? providerFilter = null)
    {
        var m = new Message(Commands.MusicArtistsTopAlbums)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        m.Args.Add("provider_instance_id_or_domain", providerInstanceIdOrDomain);
        if (providerFilter != null)
            m.Args.Add("provider_filter", providerFilter);
        return await SendAsync<AlbumsResponse>(c, m);
    }

    /// <summary>
    /// Return the top/featured tracks for an artist.
    /// </summary>
    [ToRpc]
    public static async Task<TracksResponse> MusicArtistsTopTracksAsync(this MusicAssistantClientWs c, string itemId, string providerInstanceIdOrDomain, string? providerFilter = null)
    {
        var m = new Message(Commands.MusicArtistsTopTracks)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        m.Args.Add("provider_instance_id_or_domain", providerInstanceIdOrDomain);
        if (providerFilter != null)
            m.Args.Add("provider_filter", providerFilter);
        return await SendAsync<TracksResponse>(c, m);
    }

    /// <summary>
    /// Update existing library record in the library database.
    /// </summary>
    [ToRpc]
    public static async Task<ArtistResponse> MusicArtistsUpdateAsync(this MusicAssistantClientWs c, string itemId, Artist update, bool? overwrite = null)
    {
        var m = new Message(Commands.MusicArtistsUpdate)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        m.Args.Add("update", update);
        if (overwrite != null)
            m.Args.Add("overwrite", overwrite);
        return await SendAsync<ArtistResponse>(c, m);
    }

    /// <summary>
    /// Return all versions of an audiobook we can find on all providers.
    /// </summary>
    [ToRpc]
    public static async Task<AudiobooksResponse> MusicAudiobooksAudiobookVersionsAsync(this MusicAssistantClientWs c, string itemId, string providerInstanceIdOrDomain)
    {
        var m = new Message(Commands.MusicAudiobooksAudiobookVersions)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        m.Args.Add("provider_instance_id_or_domain", providerInstanceIdOrDomain);
        return await SendAsync<AudiobooksResponse>(c, m);
    }

    /// <summary>
    /// Return (full) details for a single media item.
    /// </summary>
    [ToRpc]
    public static async Task<AudiobookResponse> MusicAudiobooksGetAsync(this MusicAssistantClientWs c, string itemId, string providerInstanceIdOrDomain, bool? allowUpdateMetadata = null)
    {
        var m = new Message(Commands.MusicAudiobooksGet)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        m.Args.Add("provider_instance_id_or_domain", providerInstanceIdOrDomain);
        if (allowUpdateMetadata != null)
            m.Args.Add("allow_update_metadata", allowUpdateMetadata);
        return await SendAsync<AudiobookResponse>(c, m);
    }

    /// <summary>
    /// Get the first library item for the given external id, if present.
    /// </summary>
    [ToRpc]
    public static async Task<AudiobookResponse> MusicAudiobooksGetByExternalIdAsync(this MusicAssistantClientWs c, string externalId, object? externalIdType = null)
    {
        var m = new Message(Commands.MusicAudiobooksGetByExternalId)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("external_id", externalId);
        if (externalIdType != null)
            m.Args.Add("external_id_type", externalIdType);
        return await SendAsync<AudiobookResponse>(c, m);
    }

    /// <summary>
    /// Get a single collection.
    /// </summary>
    [ToRpc]
    public static async Task<MediaCollectionResponse> MusicAudiobooksGetCollectionAsync(this MusicAssistantClientWs c, string itemId, string? user = null)
    {
        var m = new Message(Commands.MusicAudiobooksGetCollection)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        if (user != null)
            m.Args.Add("user", user);
        return await SendAsync<MediaCollectionResponse>(c, m);
    }

    /// <summary>
    /// Get in-database audiobooks.
    /// </summary>
    [ToRpc]
    public static async Task<AudiobooksResponse> MusicAudiobooksLibraryItemsAsync(this MusicAssistantClientWs c, object kwargs, bool? favorite = null, string? search = null, int? limit = null, int? offset = null, string? orderBy = null, List<string>? provider = null, List<object>? genre = null, bool? playedOnly = null, bool? summary = null, bool? collapseCollections = null, List<string>? reachableVia = null, string? user = null)
    {
        var m = new Message(Commands.MusicAudiobooksLibraryItems)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("kwargs", kwargs);
        if (favorite != null)
            m.Args.Add("favorite", favorite);
        if (search != null)
            m.Args.Add("search", search);
        if (limit != null)
            m.Args.Add("limit", limit);
        if (offset != null)
            m.Args.Add("offset", offset);
        if (orderBy != null)
            m.Args.Add("order_by", orderBy);
        if (provider != null)
            m.Args.Add("provider", provider);
        if (genre != null)
            m.Args.Add("genre", genre);
        if (playedOnly != null)
            m.Args.Add("played_only", playedOnly);
        if (summary != null)
            m.Args.Add("summary", summary);
        if (collapseCollections != null)
            m.Args.Add("collapse_collections", collapseCollections);
        if (reachableVia != null)
            m.Args.Add("reachable_via", reachableVia);
        if (user != null)
            m.Args.Add("user", user);
        return await SendAsync<AudiobooksResponse>(c, m);
    }

    /// <summary>
    /// Delete item from the library(database).
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> MusicAudiobooksRemoveAsync(this MusicAssistantClientWs c, string itemId, bool? recursive = null)
    {
        var m = new Message(Commands.MusicAudiobooksRemove)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        if (recursive != null)
            m.Args.Add("recursive", recursive);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Update existing library record in the library database.
    /// </summary>
    [ToRpc]
    public static async Task<AudiobookResponse> MusicAudiobooksUpdateAsync(this MusicAssistantClientWs c, string itemId, Audiobook update, bool? overwrite = null)
    {
        var m = new Message(Commands.MusicAudiobooksUpdate)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        m.Args.Add("update", update);
        if (overwrite != null)
            m.Args.Add("overwrite", overwrite);
        return await SendAsync<AudiobookResponse>(c, m);
    }

    /// <summary>
    /// Browse Music providers.
    /// </summary>
    [ToRpc]
    public static async Task<MediaCollectionResponse> MusicBrowseAsync(this MusicAssistantClientWs c, string? path = null, string? playerId = null)
    {
        var m = new Message(Commands.MusicBrowse)
        {
            Args = new Dictionary<string, object>()
        };
        if (path != null)
            m.Args.Add("path", path);
        if (playerId != null)
            m.Args.Add("player_id", playerId);
        return await SendAsync<MediaCollectionResponse>(c, m);
    }

    /// <summary>
    /// Add item to library and return the new (or updated) database item.
    /// </summary>
    [ToRpc]
    public static async Task<JsonElementResponse> MusicGenresAddAsync(this MusicAssistantClientWs c, object item, bool? overwriteExisting = null)
    {
        var m = new Message(Commands.MusicGenresAdd)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item", item);
        if (overwriteExisting != null)
            m.Args.Add("overwrite_existing", overwriteExisting);
        return await SendAsync<JsonElementResponse>(c, m);
    }

    /// <summary>
    /// Add an alias string to a genre.
    /// </summary>
    [ToRpc]
    public static async Task<JsonElementResponse> MusicGenresAddAliasAsync(this MusicAssistantClientWs c, string genreId, string alias)
    {
        var m = new Message(Commands.MusicGenresAddAlias)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("genre_id", genreId);
        m.Args.Add("alias", alias);
        return await SendAsync<JsonElementResponse>(c, m);
    }

    /// <summary>
    /// Map a media item to a genre.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> MusicGenresAddMediaMappingAsync(this MusicAssistantClientWs c, string genreId, string mediaType, string mediaId, string? alias = null)
    {
        var m = new Message(Commands.MusicGenresAddMediaMapping)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("genre_id", genreId);
        m.Args.Add("media_type", mediaType);
        m.Args.Add("media_id", mediaId);
        if (alias != null)
            m.Args.Add("alias", alias);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Return the albums mapped to a genre.
    /// </summary>
    [ToRpc]
    public static async Task<AlbumsResponse> MusicGenresAlbumsAsync(this MusicAssistantClientWs c, string itemId, int? limit = null, int? offset = null, string? orderBy = null)
    {
        var m = new Message(Commands.MusicGenresAlbums)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        if (limit != null)
            m.Args.Add("limit", limit);
        if (offset != null)
            m.Args.Add("offset", offset);
        if (orderBy != null)
            m.Args.Add("order_by", orderBy);
        return await SendAsync<AlbumsResponse>(c, m);
    }

    /// <summary>
    /// Return the total number of genres in the library.
    /// </summary>
    [ToRpc]
    public static async Task<CountResponse> MusicGenresCountAsync(this MusicAssistantClientWs c, bool? favoriteOnly = null)
    {
        var m = new Message(Commands.MusicGenresCount)
        {
            Args = new Dictionary<string, object>()
        };
        if (favoriteOnly != null)
            m.Args.Add("favorite_only", favoriteOnly);
        return await SendAsync<CountResponse>(c, m);
    }

    /// <summary>
    /// Permanently exclude a genre from being mapped to a media item.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> MusicGenresExcludeGenreFromMediaItemAsync(this MusicAssistantClientWs c, string genreId, string mediaType, string mediaId)
    {
        var m = new Message(Commands.MusicGenresExcludeGenreFromMediaItem)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("genre_id", genreId);
        m.Args.Add("media_type", mediaType);
        m.Args.Add("media_id", mediaId);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Return all genres excluded from a given media item.
    /// </summary>
    [ToRpc]
    public static async Task<JsonElementResponse> MusicGenresGenreExclusionsForMediaItemAsync(this MusicAssistantClientWs c, string mediaType, string mediaId)
    {
        var m = new Message(Commands.MusicGenresGenreExclusionsForMediaItem)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("media_type", mediaType);
        m.Args.Add("media_id", mediaId);
        return await SendAsync<JsonElementResponse>(c, m);
    }

    /// <summary>
    /// Return all genres mapped to a given media item.
    /// </summary>
    [ToRpc]
    public static async Task<JsonElementResponse> MusicGenresGenresForMediaItemAsync(this MusicAssistantClientWs c, string mediaType, string mediaId)
    {
        var m = new Message(Commands.MusicGenresGenresForMediaItem)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("media_type", mediaType);
        m.Args.Add("media_id", mediaId);
        return await SendAsync<JsonElementResponse>(c, m);
    }

    /// <summary>
    /// Return (full) details for a single media item.
    /// </summary>
    [ToRpc]
    public static async Task<JsonElementResponse> MusicGenresGetAsync(this MusicAssistantClientWs c, string itemId, string providerInstanceIdOrDomain, bool? allowUpdateMetadata = null)
    {
        var m = new Message(Commands.MusicGenresGet)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        m.Args.Add("provider_instance_id_or_domain", providerInstanceIdOrDomain);
        if (allowUpdateMetadata != null)
            m.Args.Add("allow_update_metadata", allowUpdateMetadata);
        return await SendAsync<JsonElementResponse>(c, m);
    }

    /// <summary>
    /// Get the first library item for the given external id, if present.
    /// </summary>
    [ToRpc]
    public static async Task<JsonElementResponse> MusicGenresGetByExternalIdAsync(this MusicAssistantClientWs c, string externalId, object? externalIdType = null)
    {
        var m = new Message(Commands.MusicGenresGetByExternalId)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("external_id", externalId);
        if (externalIdType != null)
            m.Args.Add("external_id_type", externalIdType);
        return await SendAsync<JsonElementResponse>(c, m);
    }

    /// <summary>
    /// Get a single collection.
    /// </summary>
    [ToRpc]
    public static async Task<MediaCollectionResponse> MusicGenresGetCollectionAsync(this MusicAssistantClientWs c, string itemId, string? user = null)
    {
        var m = new Message(Commands.MusicGenresGetCollection)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        if (user != null)
            m.Args.Add("user", user);
        return await SendAsync<MediaCollectionResponse>(c, m);
    }

    /// <summary>
    /// Return all globally excluded genres.
    /// </summary>
    [ToRpc]
    public static async Task<StringArrayResponse> MusicGenresGlobalExclusionsAsync(this MusicAssistantClientWs c)
    {
        var m = new Message(Commands.MusicGenresGlobalExclusions);
        return await SendAsync<StringArrayResponse>(c, m);
    }

    /// <summary>
    /// Get genres in the library.
    /// </summary>
    [ToRpc]
    public static async Task<JsonElementResponse> MusicGenresLibraryItemsAsync(this MusicAssistantClientWs c, object kwargs, bool? favorite = null, string? search = null, int? limit = null, int? offset = null, string? orderBy = null, List<string>? provider = null, List<object>? genre = null, bool? playedOnly = null, bool? hideEmpty = null, MediaType? mediaType = null, string? contentType = null, bool? summary = null, string? user = null)
    {
        var m = new Message(Commands.MusicGenresLibraryItems)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("kwargs", kwargs);
        if (favorite != null)
            m.Args.Add("favorite", favorite);
        if (search != null)
            m.Args.Add("search", search);
        if (limit != null)
            m.Args.Add("limit", limit);
        if (offset != null)
            m.Args.Add("offset", offset);
        if (orderBy != null)
            m.Args.Add("order_by", orderBy);
        if (provider != null)
            m.Args.Add("provider", provider);
        if (genre != null)
            m.Args.Add("genre", genre);
        if (playedOnly != null)
            m.Args.Add("played_only", playedOnly);
        if (hideEmpty != null)
            m.Args.Add("hide_empty", hideEmpty);
        if (mediaType != null)
            m.Args.Add("media_type", mediaType);
        if (contentType != null)
            m.Args.Add("content_type", contentType);
        if (summary != null)
            m.Args.Add("summary", summary);
        if (user != null)
            m.Args.Add("user", user);
        return await SendAsync<JsonElementResponse>(c, m);
    }

    /// <summary>
    /// Return media item counts per media type for each requested genre.
    /// </summary>
    [ToRpc]
    public static async Task<JsonElementResponse> MusicGenresMediaCountsAsync(this MusicAssistantClientWs c, List<string> genreIds)
    {
        var m = new Message(Commands.MusicGenresMediaCounts)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("genre_ids", genreIds);
        return await SendAsync<JsonElementResponse>(c, m);
    }

    /// <summary>
    /// Merge one or more genres into a target genre.
    /// </summary>
    [ToRpc]
    public static async Task<JsonElementResponse> MusicGenresMergeAsync(this MusicAssistantClientWs c, string genreIds, string targetGenreId)
    {
        var m = new Message(Commands.MusicGenresMerge)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("genre_ids", genreIds);
        m.Args.Add("target_genre_id", targetGenreId);
        return await SendAsync<JsonElementResponse>(c, m);
    }

    /// <summary>
    /// Return overview rows for a genre (all media types).
    /// </summary>
    [ToRpc]
    public static async Task<JsonElementResponse> MusicGenresOverviewAsync(this MusicAssistantClientWs c, string itemId, string? providerInstanceIdOrDomain = null, int? limit = null)
    {
        var m = new Message(Commands.MusicGenresOverview)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        if (providerInstanceIdOrDomain != null)
            m.Args.Add("provider_instance_id_or_domain", providerInstanceIdOrDomain);
        if (limit != null)
            m.Args.Add("limit", limit);
        return await SendAsync<JsonElementResponse>(c, m);
    }

    /// <summary>
    /// Promote an alias to become a standalone genre.
    /// </summary>
    [ToRpc]
    public static async Task<JsonElementResponse> MusicGenresPromoteAliasAsync(this MusicAssistantClientWs c, string genreId, string alias)
    {
        var m = new Message(Commands.MusicGenresPromoteAlias)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("genre_id", genreId);
        m.Args.Add("alias", alias);
        return await SendAsync<JsonElementResponse>(c, m);
    }

    /// <summary>
    /// Delete genre record from the database.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> MusicGenresRemoveAsync(this MusicAssistantClientWs c, string itemId, bool? recursive = null, bool? excludeGlobally = null)
    {
        var m = new Message(Commands.MusicGenresRemove)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        if (recursive != null)
            m.Args.Add("recursive", recursive);
        if (excludeGlobally != null)
            m.Args.Add("exclude_globally", excludeGlobally);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Remove an alias string from a genre.
    /// </summary>
    [ToRpc]
    public static async Task<JsonElementResponse> MusicGenresRemoveAliasAsync(this MusicAssistantClientWs c, string genreId, string alias)
    {
        var m = new Message(Commands.MusicGenresRemoveAlias)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("genre_id", genreId);
        m.Args.Add("alias", alias);
        return await SendAsync<JsonElementResponse>(c, m);
    }

    /// <summary>
    /// Remove a genre exclusion, allowing the scanner to re-map it on the next run.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> MusicGenresRemoveGenreExclusionAsync(this MusicAssistantClientWs c, string genreId, string mediaType, string mediaId)
    {
        var m = new Message(Commands.MusicGenresRemoveGenreExclusion)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("genre_id", genreId);
        m.Args.Add("media_type", mediaType);
        m.Args.Add("media_id", mediaId);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Lift a global genre exclusion, making the genre visible and scannable again.
    /// </summary>
    [ToRpc]
    public static async Task<JsonElementResponse> MusicGenresRemoveGlobalExclusionAsync(this MusicAssistantClientWs c, int genreId)
    {
        var m = new Message(Commands.MusicGenresRemoveGlobalExclusion)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("genre_id", genreId);
        return await SendAsync<JsonElementResponse>(c, m);
    }

    /// <summary>
    /// Remove a media item mapping from a genre.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> MusicGenresRemoveMediaMappingAsync(this MusicAssistantClientWs c, string genreId, string mediaType, string mediaId)
    {
        var m = new Message(Commands.MusicGenresRemoveMediaMapping)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("genre_id", genreId);
        m.Args.Add("media_type", mediaType);
        m.Args.Add("media_id", mediaId);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Restore default genres for one or every taxonomy (music, podcast, audiobook).
    /// </summary>
    [ToRpc]
    public static async Task<JsonElementResponse> MusicGenresRestoreDefaultsAsync(this MusicAssistantClientWs c, bool? fullRestore = null, string? contentType = null)
    {
        var m = new Message(Commands.MusicGenresRestoreDefaults)
        {
            Args = new Dictionary<string, object>()
        };
        if (fullRestore != null)
            m.Args.Add("full_restore", fullRestore);
        if (contentType != null)
            m.Args.Add("content_type", contentType);
        return await SendAsync<JsonElementResponse>(c, m);
    }

    /// <summary>
    /// Manually trigger a genre mapping scan (admin only).
    /// </summary>
    [ToRpc]
    public static async Task<JsonElementResponse> MusicGenresScanMappingsAsync(this MusicAssistantClientWs c)
    {
        var m = new Message(Commands.MusicGenresScanMappings);
        return await SendAsync<JsonElementResponse>(c, m);
    }

    /// <summary>
    /// Get status of the genre mapping background scanner.
    /// </summary>
    [ToRpc]
    public static async Task<JsonElementResponse> MusicGenresScannerStatusAsync(this MusicAssistantClientWs c)
    {
        var m = new Message(Commands.MusicGenresScannerStatus);
        return await SendAsync<JsonElementResponse>(c, m);
    }

    /// <summary>
    /// Return the tracks mapped to a genre.
    /// </summary>
    [ToRpc]
    public static async Task<TracksResponse> MusicGenresTracksAsync(this MusicAssistantClientWs c, string itemId, int? limit = null, int? offset = null, string? orderBy = null)
    {
        var m = new Message(Commands.MusicGenresTracks)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        if (limit != null)
            m.Args.Add("limit", limit);
        if (offset != null)
            m.Args.Add("offset", offset);
        if (orderBy != null)
            m.Args.Add("order_by", orderBy);
        return await SendAsync<TracksResponse>(c, m);
    }

    /// <summary>
    /// Update existing library record in the library database.
    /// </summary>
    [ToRpc]
    public static async Task<JsonElementResponse> MusicGenresUpdateAsync(this MusicAssistantClientWs c, string itemId, object update, bool? overwrite = null)
    {
        var m = new Message(Commands.MusicGenresUpdate)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        m.Args.Add("update", update);
        if (overwrite != null)
            m.Args.Add("overwrite", overwrite);
        return await SendAsync<JsonElementResponse>(c, m);
    }

    /// <summary>
    /// Return a list of the Audiobooks and PodcastEpisodes that are in progress.
    /// </summary>
    [ToRpc]
    public static async Task<JsonElementResponse> MusicInProgressItemsAsync(this MusicAssistantClientWs c, int? limit = null, bool? allUsers = null, List<string>? providers = null)
    {
        var m = new Message(Commands.MusicInProgressItems)
        {
            Args = new Dictionary<string, object>()
        };
        if (limit != null)
            m.Args.Add("limit", limit);
        if (allUsers != null)
            m.Args.Add("all_users", allUsers);
        if (providers != null)
            m.Args.Add("providers", providers);
        return await SendAsync<JsonElementResponse>(c, m);
    }

    /// <summary>
    /// Get single music item by id and media type.
    /// </summary>
    [ToRpc]
    public static async Task<MediaCollectionResponse> MusicItemAsync(this MusicAssistantClientWs c, string mediaType, string itemId, string providerInstanceIdOrDomain, bool? allowUpdateMetadata = null)
    {
        var m = new Message(Commands.MusicItem)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("media_type", mediaType);
        m.Args.Add("item_id", itemId);
        m.Args.Add("provider_instance_id_or_domain", providerInstanceIdOrDomain);
        if (allowUpdateMetadata != null)
            m.Args.Add("allow_update_metadata", allowUpdateMetadata);
        return await SendAsync<MediaCollectionResponse>(c, m);
    }

    /// <summary>
    /// Try to find a media item (such as a playlist) by name.
    /// </summary>
    [ToRpc]
    public static async Task<MediaCollectionResponse> MusicItemByNameAsync(this MusicAssistantClientWs c, string name, string? artist = null, string? album = null, MediaType? mediaType = null, string? user = null)
    {
        var m = new Message(Commands.MusicItemByName)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("name", name);
        if (artist != null)
            m.Args.Add("artist", artist);
        if (album != null)
            m.Args.Add("album", album);
        if (mediaType != null)
            m.Args.Add("media_type", mediaType);
        if (user != null)
            m.Args.Add("user", user);
        return await SendAsync<MediaCollectionResponse>(c, m);
    }

    /// <summary>
    /// Fetch MediaItem by uri.
    /// </summary>
    [ToRpc]
    public static async Task<MediaCollectionResponse> MusicItemByUriAsync(this MusicAssistantClientWs c, string uri, bool? allowUpdateMetadata = null)
    {
        var m = new Message(Commands.MusicItemByUri)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("uri", uri);
        if (allowUpdateMetadata != null)
            m.Args.Add("allow_update_metadata", allowUpdateMetadata);
        return await SendAsync<MediaCollectionResponse>(c, m);
    }

    /// <summary>
    /// Add item (uri or mediaitem) to the library.
    /// </summary>
    [ToRpc]
    public static async Task<MediaCollectionResponse> MusicLibraryAddItemAsync(this MusicAssistantClientWs c, string item, bool? overwriteExisting = null)
    {
        var m = new Message(Commands.MusicLibraryAddItem)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item", item);
        if (overwriteExisting != null)
            m.Args.Add("overwrite_existing", overwriteExisting);
        return await SendAsync<MediaCollectionResponse>(c, m);
    }

    /// <summary>
    /// Remove item from the library.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> MusicLibraryRemoveItemAsync(this MusicAssistantClientWs c, string mediaType, string libraryItemId, bool? recursive = null)
    {
        var m = new Message(Commands.MusicLibraryRemoveItem)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("media_type", mediaType);
        m.Args.Add("library_item_id", libraryItemId);
        if (recursive != null)
            m.Args.Add("recursive", recursive);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Mark item as played in playlog.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> MusicMarkPlayedAsync(this MusicAssistantClientWs c, Track mediaItem, bool? fullyPlayed = null, int? secondsPlayed = null, bool? isPlaying = null, string? userid = null, string? queueId = null, bool? userInitiated = null, List<string>? skipArtistIds = null, double? playbackSpeed = null)
    {
        var m = new Message(Commands.MusicMarkPlayed)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("media_item", mediaItem);
        if (fullyPlayed != null)
            m.Args.Add("fully_played", fullyPlayed);
        if (secondsPlayed != null)
            m.Args.Add("seconds_played", secondsPlayed);
        if (isPlaying != null)
            m.Args.Add("is_playing", isPlaying);
        if (userid != null)
            m.Args.Add("userid", userid);
        if (queueId != null)
            m.Args.Add("queue_id", queueId);
        if (userInitiated != null)
            m.Args.Add("user_initiated", userInitiated);
        if (skipArtistIds != null)
            m.Args.Add("skip_artist_ids", skipArtistIds);
        if (playbackSpeed != null)
            m.Args.Add("playback_speed", playbackSpeed);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Mark item as unplayed in playlog.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> MusicMarkUnplayedAsync(this MusicAssistantClientWs c, Track mediaItem, string? userid = null)
    {
        var m = new Message(Commands.MusicMarkUnplayed)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("media_item", mediaItem);
        if (userid != null)
            m.Args.Add("userid", userid);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Search for mappings on all providers for the given library item.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> MusicMatchProvidersAsync(this MusicAssistantClientWs c, string mediaType, string dbId)
    {
        var m = new Message(Commands.MusicMatchProviders)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("media_type", mediaType);
        m.Args.Add("db_id", dbId);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Queue adding items to a playlist.
    /// </summary>
    [ToRpc]
    public static async Task<BackgroundTaskResponse> MusicPlaylistsAddPlaylistTracksAsync(this MusicAssistantClientWs c, string dbPlaylistId, List<string> uris)
    {
        var m = new Message(Commands.MusicPlaylistsAddPlaylistTracks)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("db_playlist_id", dbPlaylistId);
        m.Args.Add("uris", uris);
        return await SendAsync<BackgroundTaskResponse>(c, m);
    }

    /// <summary>
    /// Create new playlist.
    /// </summary>
    [ToRpc]
    public static async Task<PlaylistResponse> MusicPlaylistsCreatePlaylistAsync(this MusicAssistantClientWs c, string name, List<object>? mediaTypes = null, string? providerInstanceOrDomain = null)
    {
        var m = new Message(Commands.MusicPlaylistsCreatePlaylist)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("name", name);
        if (mediaTypes != null)
            m.Args.Add("media_types", mediaTypes);
        if (providerInstanceOrDomain != null)
            m.Args.Add("provider_instance_or_domain", providerInstanceOrDomain);
        return await SendAsync<PlaylistResponse>(c, m);
    }

    /// <summary>
    /// Export a playlist to M3U8 format.
    /// </summary>
    [ToRpc]
    public static async Task<StringResponse> MusicPlaylistsExportPlaylistAsync(this MusicAssistantClientWs c, string dbPlaylistId)
    {
        var m = new Message(Commands.MusicPlaylistsExportPlaylist)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("db_playlist_id", dbPlaylistId);
        return await SendAsync<StringResponse>(c, m);
    }

    /// <summary>
    /// Get the first library item for the given external id, if present.
    /// </summary>
    [ToRpc]
    public static async Task<PlaylistResponse> MusicPlaylistsGetByExternalIdAsync(this MusicAssistantClientWs c, string externalId, object? externalIdType = null)
    {
        var m = new Message(Commands.MusicPlaylistsGetByExternalId)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("external_id", externalId);
        if (externalIdType != null)
            m.Args.Add("external_id_type", externalIdType);
        return await SendAsync<PlaylistResponse>(c, m);
    }

    /// <summary>
    /// Get a single collection.
    /// </summary>
    [ToRpc]
    public static async Task<MediaCollectionResponse> MusicPlaylistsGetCollectionAsync(this MusicAssistantClientWs c, string itemId, string? user = null)
    {
        var m = new Message(Commands.MusicPlaylistsGetCollection)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        if (user != null)
            m.Args.Add("user", user);
        return await SendAsync<MediaCollectionResponse>(c, m);
    }

    /// <summary>
    /// Import a playlist from M3U8 format.
    /// </summary>
    [ToRpc]
    public static async Task<PlaylistResponse> MusicPlaylistsImportPlaylistAsync(this MusicAssistantClientWs c, string m3uData, bool? libraryMatching = null, List<string>? matchProviders = null)
    {
        var m = new Message(Commands.MusicPlaylistsImportPlaylist)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("m3u_data", m3uData);
        if (libraryMatching != null)
            m.Args.Add("library_matching", libraryMatching);
        if (matchProviders != null)
            m.Args.Add("match_providers", matchProviders);
        return await SendAsync<PlaylistResponse>(c, m);
    }

    /// <summary>
    /// Delete library record from the database.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> MusicPlaylistsRemoveAsync(this MusicAssistantClientWs c, string itemId, bool? recursive = null)
    {
        var m = new Message(Commands.MusicPlaylistsRemove)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        if (recursive != null)
            m.Args.Add("recursive", recursive);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Queue removing items from a playlist.
    /// </summary>
    [ToRpc]
    public static async Task<BackgroundTaskResponse> MusicPlaylistsRemovePlaylistTracksAsync(this MusicAssistantClientWs c, string dbPlaylistId, List<object> positionsToRemove)
    {
        var m = new Message(Commands.MusicPlaylistsRemovePlaylistTracks)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("db_playlist_id", dbPlaylistId);
        m.Args.Add("positions_to_remove", positionsToRemove);
        return await SendAsync<BackgroundTaskResponse>(c, m);
    }

    /// <summary>
    /// Update existing library record in the library database.
    /// </summary>
    [ToRpc]
    public static async Task<PlaylistResponse> MusicPlaylistsUpdateAsync(this MusicAssistantClientWs c, string itemId, Playlist update, bool? overwrite = null)
    {
        var m = new Message(Commands.MusicPlaylistsUpdate)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        m.Args.Add("update", update);
        if (overwrite != null)
            m.Args.Add("overwrite", overwrite);
        return await SendAsync<PlaylistResponse>(c, m);
    }

    /// <summary>
    /// Return (full) details for a single media item.
    /// </summary>
    [ToRpc]
    public static async Task<PodcastResponse> MusicPodcastsGetAsync(this MusicAssistantClientWs c, string itemId, string providerInstanceIdOrDomain, bool? allowUpdateMetadata = null)
    {
        var m = new Message(Commands.MusicPodcastsGet)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        m.Args.Add("provider_instance_id_or_domain", providerInstanceIdOrDomain);
        if (allowUpdateMetadata != null)
            m.Args.Add("allow_update_metadata", allowUpdateMetadata);
        return await SendAsync<PodcastResponse>(c, m);
    }

    /// <summary>
    /// Get the first library item for the given external id, if present.
    /// </summary>
    [ToRpc]
    public static async Task<PodcastResponse> MusicPodcastsGetByExternalIdAsync(this MusicAssistantClientWs c, string externalId, object? externalIdType = null)
    {
        var m = new Message(Commands.MusicPodcastsGetByExternalId)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("external_id", externalId);
        if (externalIdType != null)
            m.Args.Add("external_id_type", externalIdType);
        return await SendAsync<PodcastResponse>(c, m);
    }

    /// <summary>
    /// Get a single collection.
    /// </summary>
    [ToRpc]
    public static async Task<MediaCollectionResponse> MusicPodcastsGetCollectionAsync(this MusicAssistantClientWs c, string itemId, string? user = null)
    {
        var m = new Message(Commands.MusicPodcastsGetCollection)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        if (user != null)
            m.Args.Add("user", user);
        return await SendAsync<MediaCollectionResponse>(c, m);
    }

    /// <summary>
    /// Get in-database podcasts.
    /// </summary>
    [ToRpc]
    public static async Task<PodcastsResponse> MusicPodcastsLibraryItemsAsync(this MusicAssistantClientWs c, object kwargs, bool? favorite = null, string? search = null, int? limit = null, int? offset = null, string? orderBy = null, List<string>? provider = null, List<object>? genre = null, bool? playedOnly = null, bool? summary = null, List<string>? reachableVia = null, string? user = null)
    {
        var m = new Message(Commands.MusicPodcastsLibraryItems)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("kwargs", kwargs);
        if (favorite != null)
            m.Args.Add("favorite", favorite);
        if (search != null)
            m.Args.Add("search", search);
        if (limit != null)
            m.Args.Add("limit", limit);
        if (offset != null)
            m.Args.Add("offset", offset);
        if (orderBy != null)
            m.Args.Add("order_by", orderBy);
        if (provider != null)
            m.Args.Add("provider", provider);
        if (genre != null)
            m.Args.Add("genre", genre);
        if (playedOnly != null)
            m.Args.Add("played_only", playedOnly);
        if (summary != null)
            m.Args.Add("summary", summary);
        if (reachableVia != null)
            m.Args.Add("reachable_via", reachableVia);
        if (user != null)
            m.Args.Add("user", user);
        return await SendAsync<PodcastsResponse>(c, m);
    }

    /// <summary>
    /// Return single podcast episode by the given provider podcast id.
    /// </summary>
    [ToRpc]
    public static async Task<PodcastEpisodeResponse> MusicPodcastsPodcastEpisodeAsync(this MusicAssistantClientWs c, string itemId, string providerInstanceIdOrDomain)
    {
        var m = new Message(Commands.MusicPodcastsPodcastEpisode)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        m.Args.Add("provider_instance_id_or_domain", providerInstanceIdOrDomain);
        return await SendAsync<PodcastEpisodeResponse>(c, m);
    }

    /// <summary>
    /// Return podcast episodes for the given provider podcast id.
    /// </summary>
    [ToRpc]
    public static async Task<JsonElementResponse> MusicPodcastsPodcastEpisodesAsync(this MusicAssistantClientWs c, string itemId, string providerInstanceIdOrDomain)
    {
        var m = new Message(Commands.MusicPodcastsPodcastEpisodes)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        m.Args.Add("provider_instance_id_or_domain", providerInstanceIdOrDomain);
        return await SendAsync<JsonElementResponse>(c, m);
    }

    /// <summary>
    /// Return all versions of an podcast we can find on all providers.
    /// </summary>
    [ToRpc]
    public static async Task<PodcastsResponse> MusicPodcastsPodcastVersionsAsync(this MusicAssistantClientWs c, string itemId, string providerInstanceIdOrDomain)
    {
        var m = new Message(Commands.MusicPodcastsPodcastVersions)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        m.Args.Add("provider_instance_id_or_domain", providerInstanceIdOrDomain);
        return await SendAsync<PodcastsResponse>(c, m);
    }

    /// <summary>
    /// Delete library record from the database.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> MusicPodcastsRemoveAsync(this MusicAssistantClientWs c, string itemId, bool? recursive = null)
    {
        var m = new Message(Commands.MusicPodcastsRemove)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        if (recursive != null)
            m.Args.Add("recursive", recursive);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Update existing library record in the library database.
    /// </summary>
    [ToRpc]
    public static async Task<PodcastResponse> MusicPodcastsUpdateAsync(this MusicAssistantClientWs c, string itemId, Podcast update, bool? overwrite = null)
    {
        var m = new Message(Commands.MusicPodcastsUpdate)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        m.Args.Add("update", update);
        if (overwrite != null)
            m.Args.Add("overwrite", overwrite);
        return await SendAsync<PodcastResponse>(c, m);
    }

    /// <summary>
    /// Export all library radio stations to M3U8 format.
    /// </summary>
    [ToRpc]
    public static async Task<StringResponse> MusicRadiosExportRadiosAsync(this MusicAssistantClientWs c)
    {
        var m = new Message(Commands.MusicRadiosExportRadios);
        return await SendAsync<StringResponse>(c, m);
    }

    /// <summary>
    /// Return (full) details for a single media item.
    /// </summary>
    [ToRpc]
    public static async Task<RadioResponse> MusicRadiosGetAsync(this MusicAssistantClientWs c, string itemId, string providerInstanceIdOrDomain, bool? allowUpdateMetadata = null)
    {
        var m = new Message(Commands.MusicRadiosGet)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        m.Args.Add("provider_instance_id_or_domain", providerInstanceIdOrDomain);
        if (allowUpdateMetadata != null)
            m.Args.Add("allow_update_metadata", allowUpdateMetadata);
        return await SendAsync<RadioResponse>(c, m);
    }

    /// <summary>
    /// Get the first library item for the given external id, if present.
    /// </summary>
    [ToRpc]
    public static async Task<RadioResponse> MusicRadiosGetByExternalIdAsync(this MusicAssistantClientWs c, string externalId, object? externalIdType = null)
    {
        var m = new Message(Commands.MusicRadiosGetByExternalId)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("external_id", externalId);
        if (externalIdType != null)
            m.Args.Add("external_id_type", externalIdType);
        return await SendAsync<RadioResponse>(c, m);
    }

    /// <summary>
    /// Get a single collection.
    /// </summary>
    [ToRpc]
    public static async Task<MediaCollectionResponse> MusicRadiosGetCollectionAsync(this MusicAssistantClientWs c, string itemId, string? user = null)
    {
        var m = new Message(Commands.MusicRadiosGetCollection)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        if (user != null)
            m.Args.Add("user", user);
        return await SendAsync<MediaCollectionResponse>(c, m);
    }

    /// <summary>
    /// Queue importing radio stations from M3U8 format.
    /// </summary>
    [ToRpc]
    public static async Task<BackgroundTaskResponse> MusicRadiosImportRadiosAsync(this MusicAssistantClientWs c, string m3uData)
    {
        var m = new Message(Commands.MusicRadiosImportRadios)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("m3u_data", m3uData);
        return await SendAsync<BackgroundTaskResponse>(c, m);
    }

    /// <summary>
    /// Get the library items for this mediatype.
    /// </summary>
    [ToRpc]
    public static async Task<JsonElementResponse> MusicRadiosLibraryItemsAsync(this MusicAssistantClientWs c, object kwargs, bool? favorite = null, string? search = null, int? limit = null, int? offset = null, string? orderBy = null, List<string>? provider = null, List<object>? genre = null, bool? playedOnly = null, bool? summary = null, bool? collapseCollections = null, List<string>? reachableVia = null, string? user = null)
    {
        var m = new Message(Commands.MusicRadiosLibraryItems)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("kwargs", kwargs);
        if (favorite != null)
            m.Args.Add("favorite", favorite);
        if (search != null)
            m.Args.Add("search", search);
        if (limit != null)
            m.Args.Add("limit", limit);
        if (offset != null)
            m.Args.Add("offset", offset);
        if (orderBy != null)
            m.Args.Add("order_by", orderBy);
        if (provider != null)
            m.Args.Add("provider", provider);
        if (genre != null)
            m.Args.Add("genre", genre);
        if (playedOnly != null)
            m.Args.Add("played_only", playedOnly);
        if (summary != null)
            m.Args.Add("summary", summary);
        if (collapseCollections != null)
            m.Args.Add("collapse_collections", collapseCollections);
        if (reachableVia != null)
            m.Args.Add("reachable_via", reachableVia);
        if (user != null)
            m.Args.Add("user", user);
        return await SendAsync<JsonElementResponse>(c, m);
    }

    /// <summary>
    /// Return a fresh batch of tracks for a dynamic radio station.
    /// </summary>
    [ToRpc]
    public static async Task<TracksResponse> MusicRadiosRadioTracksAsync(this MusicAssistantClientWs c, string itemId, string providerInstanceIdOrDomain)
    {
        var m = new Message(Commands.MusicRadiosRadioTracks)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        m.Args.Add("provider_instance_id_or_domain", providerInstanceIdOrDomain);
        return await SendAsync<TracksResponse>(c, m);
    }

    /// <summary>
    /// Return all versions of a radio station we can find on all providers.
    /// </summary>
    [ToRpc]
    public static async Task<RadiosResponse> MusicRadiosRadioVersionsAsync(this MusicAssistantClientWs c, string itemId, string providerInstanceIdOrDomain)
    {
        var m = new Message(Commands.MusicRadiosRadioVersions)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        m.Args.Add("provider_instance_id_or_domain", providerInstanceIdOrDomain);
        return await SendAsync<RadiosResponse>(c, m);
    }

    /// <summary>
    /// Delete library record from the database.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> MusicRadiosRemoveAsync(this MusicAssistantClientWs c, string itemId, bool? recursive = null)
    {
        var m = new Message(Commands.MusicRadiosRemove)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        if (recursive != null)
            m.Args.Add("recursive", recursive);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Update existing library record in the library database.
    /// </summary>
    [ToRpc]
    public static async Task<RadioResponse> MusicRadiosUpdateAsync(this MusicAssistantClientWs c, string itemId, Radio update, bool? overwrite = null)
    {
        var m = new Message(Commands.MusicRadiosUpdate)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        m.Args.Add("update", update);
        if (overwrite != null)
            m.Args.Add("overwrite", overwrite);
        return await SendAsync<RadioResponse>(c, m);
    }

    /// <summary>
    /// Get the items for a single recommendation row.
    /// </summary>
    [ToRpc]
    public static async Task<TracksResponse> MusicRecommendationsItemsAsync(this MusicAssistantClientWs c, string provider, string itemId, List<string>? providers = null)
    {
        var m = new Message(Commands.MusicRecommendationsItems)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("provider", provider);
        m.Args.Add("item_id", itemId);
        if (providers != null)
            m.Args.Add("providers", providers);
        return await SendAsync<TracksResponse>(c, m);
    }

    /// <summary>
    /// Try to refresh a mediaitem by requesting it's full object or search for substitutes.
    /// </summary>
    [ToRpc]
    public static async Task<MediaCollectionResponse> MusicRefreshItemAsync(this MusicAssistantClientWs c, string mediaItem)
    {
        var m = new Message(Commands.MusicRefreshItem)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("media_item", mediaItem);
        return await SendAsync<MediaCollectionResponse>(c, m);
    }

    /// <summary>
    /// Remove provider mapping from the given library item.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> MusicRemoveProviderMappingAsync(this MusicAssistantClientWs c, string mediaType, string dbId, object mapping)
    {
        var m = new Message(Commands.MusicRemoveProviderMapping)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("media_type", mediaType);
        m.Args.Add("db_id", dbId);
        m.Args.Add("mapping", mapping);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Return all sound effect items from providers supporting them.
    /// </summary>
    [ToRpc]
    public static async Task<SoundEffectsResponse> MusicSoundEffectsAsync(this MusicAssistantClientWs c)
    {
        var m = new Message(Commands.MusicSoundEffects);
        return await SendAsync<SoundEffectsResponse>(c, m);
    }

    /// <summary>
    /// Start running the sync of (all or selected) musicproviders.
    /// </summary>
    [ToRpc]
    public static async Task<BackgroundTasksResponse> MusicSyncAsync(this MusicAssistantClientWs c, List<object>? mediaTypes = null, List<string>? providers = null)
    {
        var m = new Message(Commands.MusicSync)
        {
            Args = new Dictionary<string, object>()
        };
        if (mediaTypes != null)
            m.Args.Add("media_types", mediaTypes);
        if (providers != null)
            m.Args.Add("providers", providers);
        return await SendAsync<BackgroundTasksResponse>(c, m);
    }

    /// <summary>
    /// Get a track by its name, optionally with artist and album.
    /// </summary>
    [ToRpc]
    public static async Task<TrackResponse> MusicTrackByNameAsync(this MusicAssistantClientWs c, string trackName, string? artistName = null, string? albumName = null, string? trackVersion = null)
    {
        var m = new Message(Commands.MusicTrackByName)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("track_name", trackName);
        if (artistName != null)
            m.Args.Add("artist_name", artistName);
        if (albumName != null)
            m.Args.Add("album_name", albumName);
        if (trackVersion != null)
            m.Args.Add("track_version", trackVersion);
        return await SendAsync<TrackResponse>(c, m);
    }

    /// <summary>
    /// Return (full) details for a single media item.
    /// </summary>
    [ToRpc]
    public static async Task<TrackResponse> MusicTracksGetAsync(this MusicAssistantClientWs c, string itemId, string providerInstanceIdOrDomain, bool? allowUpdateMetadata = null, bool? recursive = null, string? albumUri = null)
    {
        var m = new Message(Commands.MusicTracksGet)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        m.Args.Add("provider_instance_id_or_domain", providerInstanceIdOrDomain);
        if (allowUpdateMetadata != null)
            m.Args.Add("allow_update_metadata", allowUpdateMetadata);
        if (recursive != null)
            m.Args.Add("recursive", recursive);
        if (albumUri != null)
            m.Args.Add("album_uri", albumUri);
        return await SendAsync<TrackResponse>(c, m);
    }

    /// <summary>
    /// Get the first library item for the given external id, if present.
    /// </summary>
    [ToRpc]
    public static async Task<TrackResponse> MusicTracksGetByExternalIdAsync(this MusicAssistantClientWs c, string externalId, object? externalIdType = null)
    {
        var m = new Message(Commands.MusicTracksGetByExternalId)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("external_id", externalId);
        if (externalIdType != null)
            m.Args.Add("external_id_type", externalIdType);
        return await SendAsync<TrackResponse>(c, m);
    }

    /// <summary>
    /// Get a single collection.
    /// </summary>
    [ToRpc]
    public static async Task<MediaCollectionResponse> MusicTracksGetCollectionAsync(this MusicAssistantClientWs c, string itemId, string? user = null)
    {
        var m = new Message(Commands.MusicTracksGetCollection)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        if (user != null)
            m.Args.Add("user", user);
        return await SendAsync<MediaCollectionResponse>(c, m);
    }

    /// <summary>
    /// Return url to short preview sample.
    /// </summary>
    [ToRpc]
    public static async Task<StringResponse> MusicTracksPreviewAsync(this MusicAssistantClientWs c, string providerInstanceIdOrDomain, string itemId)
    {
        var m = new Message(Commands.MusicTracksPreview)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("provider_instance_id_or_domain", providerInstanceIdOrDomain);
        m.Args.Add("item_id", itemId);
        return await SendAsync<StringResponse>(c, m);
    }

    /// <summary>
    /// Delete record from the database.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> MusicTracksRemoveAsync(this MusicAssistantClientWs c, string itemId, bool? recursive = null)
    {
        var m = new Message(Commands.MusicTracksRemove)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        if (recursive != null)
            m.Args.Add("recursive", recursive);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Return all versions of a track we can find on all providers.
    /// </summary>
    [ToRpc]
    public static async Task<TracksResponse> MusicTracksTrackVersionsAsync(this MusicAssistantClientWs c, string itemId, string providerInstanceIdOrDomain)
    {
        var m = new Message(Commands.MusicTracksTrackVersions)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        m.Args.Add("provider_instance_id_or_domain", providerInstanceIdOrDomain);
        return await SendAsync<TracksResponse>(c, m);
    }

    /// <summary>
    /// Update existing library record in the library database.
    /// </summary>
    [ToRpc]
    public static async Task<TrackResponse> MusicTracksUpdateAsync(this MusicAssistantClientWs c, string itemId, Track update, bool? overwrite = null)
    {
        var m = new Message(Commands.MusicTracksUpdate)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("item_id", itemId);
        m.Args.Add("update", update);
        if (overwrite != null)
            m.Args.Add("overwrite", overwrite);
        return await SendAsync<TrackResponse>(c, m);
    }

    /// <summary>
    /// Verify whether a uri points to a valid, accessible item.
    /// </summary>
    [ToRpc]
    public static async Task<BooleanResponse> MusicVerifyItemUriAsync(this MusicAssistantClientWs c, string uri, string? user = null)
    {
        var m = new Message(Commands.MusicVerifyItemUri)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("uri", uri);
        if (user != null)
            m.Args.Add("user", user);
        return await SendAsync<BooleanResponse>(c, m);
    }

}