using MediatR;
using System.Text.Json.Serialization;

namespace Project.ApiHub.Controllers.Search
{
    /// <summary>
    /// Device agent reset handler
    /// </summary>
    public class SearchMissionsRequest : IRequest<SearchMissionsResponse>
    {
        /// <summary>
        /// Mission Country
        /// </summary>
        [JsonPropertyName("missionCountry")]
        public string MissionCountry { get; set; }
    }
}
