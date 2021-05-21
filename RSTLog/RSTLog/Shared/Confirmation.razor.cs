using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.Shared
{
    public partial class Confirmation
    {
        private string _modalDisplay;
        //backdrop so users cant click behind
        private bool _showBackdrop;

        [Parameter]
        public string BodyMessage { get; set; }

        //event callback for clicking Ok button on modal
        [Parameter]
        public EventCallback OnOkClicked { get; set; }

        public void Show()
        {
            _modalDisplay = "block;";
            _showBackdrop = true;
            //rerender page
            StateHasChanged();
        }

        public void Hide()
        {
            _modalDisplay = "none;";
            _showBackdrop = false;
            StateHasChanged();
        }

        //<InputDate @bind-Value="transaction.Date" class="form-control" />
    }
}
