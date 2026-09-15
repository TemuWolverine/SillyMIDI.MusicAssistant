namespace SillyMIDI.MusicAssistant.Messages;

public class Auth : MessageBase
{
    public Auth() : base(Commands.Auth)
    {
    }
}