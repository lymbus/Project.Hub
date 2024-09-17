using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project.ApiHub.Controllers.Search;
using System.Threading;

namespace Project.Hub.Controllers
{
    [ApiController]
    [Route("api/search")]
    public class HubController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HubController(IMediator mediator)
        {
            this._mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        /// <summary>
        /// Get all missions searching by mission code
        /// </summary>
        /// <param name="SearchMissionsRequest">Filtering data</param>
        /// <returns>Return list of filtered zones</returns>
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Search(SearchMissionsRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
    }
}