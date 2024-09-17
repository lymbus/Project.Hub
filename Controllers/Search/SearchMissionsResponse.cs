namespace Project.ApiHub.Controllers.Search
{
    /// <summary>
    /// Search missions response
    /// </summary>
    public class SearchMissionsResponse
    {
        /// <summary>
        /// MissionId
        /// </summary>
        public List<MissionResponse> Country { get; set; }
    }

    /// <summary>
    /// Mission response
    /// </summary>
    public class MissionResponse
    {
        /// <summary>
        /// MissionId
        /// </summary>
        public int MissionId { get; set; }

        /// <summary>
        /// Volunteer Response
        /// </summary>
        public List<VolunteerResponse> Volunteers { get; set; }
    }

    /// <summary>
    /// Mission response
    /// </summary>
    public class VolunteerResponse
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
