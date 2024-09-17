using System.Text.Json.Serialization;

namespace Project.ApiHub.Services.HeadquartersService.Response
{
    public class FranceHeadquarterResponse
    {
        [JsonPropertyName("results")]
        public List<MissionsResponse> Results { get; set; }
    }
    public class MissionsResponse
    {
        [JsonPropertyName("mission")]
        public int MissionId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("age")]
        public int Age { get; set; }

        [JsonPropertyName("age")]
        public string HQ { get; set; }
    }
}
