using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoderDojoApp.Network.Response;
using Refit;

namespace CoderDojoApp.Network.API
{
    public class DojoAPI
    {
        public Task<List<DojoEvent>> SearchEvent(double lat,double lon,int range)
        {
            var api = RestService.For<IDojoAPI>("https://dojo.garu.pizza/");
            DojoParams dojoParams = new DojoParams
            {
                Latitude = lat,
                Longitude = lon,
                Range = range
            };

            Debug.WriteLine(api.ToString());
            return api.Search(dojoParams);
        } 
    }
}
