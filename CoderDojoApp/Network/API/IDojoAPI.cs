using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoderDojoApp.Network.Response;

namespace CoderDojoApp.Network.API
{
    public class DojoParams
    {
        [AliasAs("lat")]
        public double Latitude { set; get; }
        [AliasAs("lon")]
        public double Longitude { set; get; }
        [AliasAs("range")]
        public int Range { set; get; } = 150;

    }
    public interface IDojoAPI
    {
        [Get("/api/v1/events")]
        Task<List<DojoEvent>> Search(DojoParams myParams);
    }
}
