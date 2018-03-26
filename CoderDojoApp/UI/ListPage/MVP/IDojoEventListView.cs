using CoderDojoApp.Network.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderDojoApp.UI.MVP.ListPage
{
    public interface IDojoEventListView
    {
        void ShowEvents(List<DojoEvent> events);
        void RequestUserPrefs();
        void ShowError(Exception ex);
    }
}
