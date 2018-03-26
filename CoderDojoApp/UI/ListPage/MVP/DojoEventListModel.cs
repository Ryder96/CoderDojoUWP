using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoderDojoApp.Network.API;
using CoderDojoApp.Network.Response;

namespace CoderDojoApp.UI.MVP.ListPage
{
    public class DojoEventListModel : IDojoEventListModel
    {
        private DojoAPI api;
        public DojoEventListModel(DojoAPI api)
        {
            this.api = api;
        }
        public Task<List<DojoEvent>> Search(double latitude, double longitude, int range)
        {
            return api.SearchEvent(latitude, longitude, range);
        }
    }
}
