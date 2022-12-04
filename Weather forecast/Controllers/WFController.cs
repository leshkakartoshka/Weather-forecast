using Microsoft.AspNetCore.Mvc;
using Weather_forecast.data;
using Weather_forecast.Models;

namespace Weather_forecast.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WFController :ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public WFController(ApplicationDbContext db)
        {
            _db = db;
        }

        /// <summary>
        /// Введите начальный и последний элементы списка.
        /// </summary>
        [HttpGet]
        public ActionResult<IEnumerable<WFModel>> GetWFs(int first, int last)
        {
            var days = _db.WFs.ToList();

            WFModel[] partDays = new WFModel[days.Count];
            days.CopyTo(0, partDays, 0, days.Count);

            return Ok(partDays[(first - 1)..last]);
        }
    }
}
