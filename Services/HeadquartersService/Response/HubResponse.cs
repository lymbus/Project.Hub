namespace Project.ApiHub.Services.HeadquartersService.Response
{
    /// <summary>
    /// Hub response
    /// </summary>
    public class HubResponse
    {
        /// <summary>
        /// Volunteer Response
        /// </summary>
        public List<MissionHubResponse> Missions { get; set; }
    }
    /// <summary>
    /// Missions hub response
    /// </summary>
    public class MissionHubResponse
    {
        /// <summary>
        /// MissionId
        /// </summary>
        public int MissionId { get; set; }

        /// <summary>
        /// Volunteer Response
        /// </summary>
        public List<VolunteerHubResponse> Volunteers { get; set; }
    }

    /// <summary>
    /// Mission response
    /// </summary>
    public class VolunteerHubResponse
    {
        /// <summary>
        /// Volunteer name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Volunteer age
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// HQ name
        /// </summary>
        public string HQ { get; set; }
    }
}
