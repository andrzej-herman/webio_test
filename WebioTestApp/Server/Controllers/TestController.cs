using Microsoft.AspNetCore.Mvc;
using WebioTestApp.Server.Database.Repository;
using WebioTestApp.Shared;
using WebioTestApp.Shared.Dtos;

namespace WebioTestApp.Server.Controllers
{
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IDataRepository _repo;

        public TestController(IDataRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("api/data")]
        public async Task<IEnumerable<DataDto>> GetDataAsync([FromQuery] int count, [FromQuery] int offset)
        {
            return await _repo.GetDataAsync(count, offset);
        }
    }
}