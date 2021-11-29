using System.Text.Json.Serialization;

namespace TailSpin.SpaceGame.Web.Models
{
    /// <summary>
    /// Base class for data models.
    /// </summary>
    public abstract class Model
    {
        // The value that uniquely identifies this object.
        [JsonPropertyName("id")]
        public string Id { get; set; }

            // The game style (difficulty) the score is associated with.
        [JsonPropertyName("gameStyle")]
        public string GameStyle { get; set; }
    }

}