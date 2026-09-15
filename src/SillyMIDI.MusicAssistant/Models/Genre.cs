using System.Text.Json.Serialization;
using SillyMIDI.MusicAssistant.Generators.Attributes;

namespace SillyMIDI.MusicAssistant.Models
{
    [NotifyPropertyChanged]
    public partial class Genre : MediaItemBase
    {
        [JsonPropertyName("date_added")]
        public DateTime? DateAdded;

        [JsonPropertyName("genre_aliases")]
        public List<string> GenreAliases;
    }


}
