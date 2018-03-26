using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoderDojoApp.Network.Response;
namespace CoderDojoApp.UI.MVP.ListPage
{
    public interface IDojoEventListModel
    {
        Task<List<DojoEvent>> Search(double latitude, double longitude, int range);
    }
}
