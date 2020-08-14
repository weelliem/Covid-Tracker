using System.Collections.Generic;
using Covid_Tracker.models;

namespace Covid_Tracker.Data {
    public interface ICovid_TrackerRepo {
        IEnumerable<Covid> GetAppCovid_Tracker ();
        Covid GetCovid_TrackerById (int id);
    }
}