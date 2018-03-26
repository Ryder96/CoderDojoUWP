using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderDojoApp.MVP
{
    public class Presenter<MODEL,VIEW>
    {
        private MODEL model;
        private VIEW view;
        public Presenter(MODEL model, VIEW view)
        {
            this.model = model;
            this.view = view;
        }
    }
}
