using System.Collections.Generic;
using Covid_Tracker.Data;
using Covid_Tracker.models;
using Microsoft.AspNetCore.Mvc;

namespace Covid_Tracker.Controllers {
    [Route ("api/covid_trackers")]
    [ApiController]
    public class Covid_TrackersController : ControllerBase {
        private readonly MockCovid_TrackerReop _repository = new MockCovid_TrackerReop ();
        //GET api/covid_trackers
        [HttpGet]
        public ActionResult<IEnumerable<Covid>> GetAllCovid_Tracker () {

            var CovidItems = _repository.GetAppCovid_Tracker ();

            return Ok (CovidItems);

        }

        //Get api/covid_trackers/{id}
        [HttpGet ("{id}")]
        public ActionResult<Covid> GetCovid_TrackerById (int id) {

            var CovidItems = _repository.GetCovid_TrackerById (id);

            return Ok (CovidItems);

        }

    }
}