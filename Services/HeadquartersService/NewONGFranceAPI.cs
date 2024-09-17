using Microsoft.Extensions.Options;
using Project.ApiHub.Services.HeadquartersService.Response;
using System.Reflection;

namespace Project.ApiHub.Services.HeadquartersService
{
    internal class NewONGFranceAPI : IHeadquarterAPI
    {
        public NewONGFranceAPI()
        {
        }
        public HubResponse Search()
        {
            // Simulación de la respuesta de NewONG_France
            var franceHeadquarterResponse = SimulateFranceResponse();
            // Convertimos la respuesta de Francia en el formato HUB

            var missionsHub = new List<MissionHubResponse>();

            GetMissionsFranceHQ(franceHeadquarterResponse, missionsHub);

            HubResponse hubResponse = new HubResponse() { Missions = missionsHub };

            return hubResponse;
        }

        private static void GetMissionsFranceHQ(FranceHeadquarterResponse franceHeadquarterResponse, List<MissionHubResponse> missionsHub)
        {
            foreach (var result in franceHeadquarterResponse.Results)
            {
                var volunteers = new List<VolunteerHubResponse>();
                volunteers.Add(new VolunteerHubResponse
                {
                    Name = result.Name,
                    Age = result.Age,
                    HQ = result.HQ
                });

                var mission = new MissionHubResponse()
                {
                    MissionId = result.MissionId,
                    Volunteers = volunteers
                };

                missionsHub.Add(mission);
            }
        }

        private static FranceHeadquarterResponse SimulateFranceResponse()
        {
            return new FranceHeadquarterResponse
            {
                Results = new List<MissionsResponse> { new MissionsResponse { MissionId = 1, Name = "Gerard", Age = 28, HQ = "NewONG_France" } }
            };
        }
    }
}
