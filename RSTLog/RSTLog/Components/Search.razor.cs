using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RSTLog.Components
{
    public partial class Search
    {
        public string SearchTerm { get; set; }

        private Timer _timer;

        [Parameter]
        public EventCallback<string> OnSearchChanged { get; set; }

        private void SearchChanged()
        {
            if (_timer != null)
                _timer.Dispose();

            _timer = new Timer(OnTimerElapsed, null, 500, 0);
        }
        //Timer to wait for search typeing to stop to send search reqest to the api
        //If this wasnt implimented then search request would be made on every key press, increasing app load. 
        private void OnTimerElapsed(object sender)
        {
            OnSearchChanged.InvokeAsync(SearchTerm);

            _timer.Dispose();
        }
    }
}
