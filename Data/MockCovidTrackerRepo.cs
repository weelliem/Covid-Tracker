using System.Collections.Generic;
using Covid_Tracker.models;

namespace Covid_Tracker.Data {
    public class MockCovid_TrackerReop : ICovid_TrackerRepo {
        public IEnumerable<Covid> GetAppCovid_Tracker () {
            var covid = new List<Covid> {
                new Covid { Id = 0, Location = "Sydney", Date = "14/8/2020", Number = 20 },
                new Covid { Id = 1, Location = "Paramatta", Date = "11/8/2020", Number = 14 },
                new Covid { Id = 2, Location = "Noth Ryde", Date = "12/8/2020", Number = 15 }
            };

            return covid;
        }

        public Covid GetCovid_TrackerById (int id) {
            return new Covid { Id = 0, Location = "Sydney", Date = "14/8/2020", Number = 20 };
        }
    }
}