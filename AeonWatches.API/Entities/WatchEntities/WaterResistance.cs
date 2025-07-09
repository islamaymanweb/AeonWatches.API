using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace AeonWatches.API.Entities.WatchEntities;

[ExcludeFromCodeCoverage]
public class WaterResistance
{
    public int Id { get; set; }
    public int Resistance { get; set; }
    [JsonIgnore]
    public List<Watch> Watches { get; set; } = new();
}