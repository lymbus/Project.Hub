using MediatR;
using Project.ApiHub.Services.HeadquartersService;
using Project.ApiHub.Services.HeadquartersService.Response;

namespace Project.ApiHub.Controllers.Search
{
    /// <summary>
    /// Search missions handler
    /// </summary>
    public class SearchMissionsHandler : IRequestHandler<SearchMissionsRequest, SearchMissionsResponse>
    {
        private readonly IHeadquarterAPI _headQuarterApi;

        public SearchMissionsHandler(IHeadquarterAPI headQuarterApi)
        {
            _headQuarterApi = headQuarterApi;
        }

        /// <summary>
        /// Search misions of all HQ
        /// </summary>
        /// <param name="request">Motion area data</param>
        /// <returns>Return unit value</returns>
        public async Task<SearchMissionsResponse> Handle(SearchMissionsRequest request, CancellationToken cancellationToken)
        {
            var responseFranceHQ = _headQuarterApi.Search();
            var response = new SearchMissionsResponse();

            if (responseFranceHQ != null && responseFranceHQ.Missions.Any())
            {
                var missionListResponse = new List<MissionResponse>();

                MapResponseFranceHQ(responseFranceHQ, missionListResponse);

                response.Country.AddRange(missionListResponse);
            }

            return response;
        }

        private static void MapResponseFranceHQ(HubResponse responseFranceHQ, List<MissionResponse> missionListResponse)
        {
            foreach (var mission in responseFranceHQ.Missions)
            {
                var volunteers = new List<VolunteerResponse>();

                if (mission.Volunteers.Any())
                {
                    volunteers.Add(new VolunteerResponse
                    {
                        Name = mission.Volunteers.FirstOrDefault().Name,
                        Age = mission.Volunteers.FirstOrDefault().Age,
                        HQ = mission.Volunteers.FirstOrDefault().HQ
                    });
                }

                var missionResponse = new MissionResponse()
                {
                    MissionId = mission.MissionId,
                    Volunteers = volunteers
                };

                missionListResponse.Add(missionResponse);
            }
        }
    }
}