namespace WateryTart.MusicAssistant.Messages;

public static partial class Commands
{
    public const string Auth = "auth";
    public const string AuthLogin = "auth/login";
    public const string AuthMe = "auth/me";
    public const string AuthProviders = "auth/providers";
    public const string AuthTokenCreate = "auth/token/create";
    public const string AuthTokens = "auth/tokens";
           
    public const string AuthAuthorizationUrl = "auth/authorization_url";
    public const string AuthJoinCodeExchange = "auth/join_code/exchange";
    public const string AuthJoinCodeRevoke = "auth/join_code/revoke";
    public const string AuthJoinCodes = "auth/join_codes";
    public const string AuthLogout = "auth/logout";
    public const string AuthScopes = "auth/scopes";
    public const string AuthTokenRevoke = "auth/token/revoke";

    public const string AuthUser = "auth/user";
    public const string AuthUserCreate = "auth/user/create";
    public const string AuthUserDelete = "auth/user/delete";
    public const string AuthUserDisable = "auth/user/disable";
    public const string AuthUserEnable = "auth/user/enable";
    public const string AuthUserProviders = "auth/user/providers";
    public const string AuthUserUnlinkProvider = "auth/user/unlink_provider";
    public const string AuthUserUpdate = "auth/user/update";
    public const string AuthUsers = "auth/users";
}

