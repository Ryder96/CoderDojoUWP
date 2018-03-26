using CoderDojoApp.Network.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderDojoApp.UI.EventPage.MVP
{
    public interface IEventDetailView
    {
        void showEvent(DojoEvent dojoEvent);
        void showError(Exception ex);
    }
}
