using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.Components
{
    public partial class PageSizeDropdown
    {
        [Parameter]
        public EventCallback<int> SelectedPageSize { get; set; }

        //logic for changeing page size from 10 to 20 etc
        private async Task OnPageSizeChange(ChangeEventArgs eventArgs)
        {
            await SelectedPageSize.InvokeAsync(Int32.Parse(eventArgs.Value.ToString()));


        }


    }
}
