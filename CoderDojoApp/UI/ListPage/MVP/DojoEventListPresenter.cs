using CoderDojoApp.MVP;
using CoderDojoApp.Network.Response;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderDojoApp.UI.MVP.ListPage
{
    public class DojoEventListPresenter : Presenter<IDojoEventListModel, IDojoEventListView>
    {
        IDojoEventListModel model;
        IDojoEventListView view;
        public DojoEventListPresenter(IDojoEventListModel model, IDojoEventListView view) : base(model, view)
        {
            this.model = model;
            this.view = view;
        }

        public void SearchEvents(double lat, double lon, int range)
        {
            var response = model.Search(lat, lon, range);
            List<DojoEvent> events = response.Result;
            view.ShowEvents(events);
        }
    }
}
