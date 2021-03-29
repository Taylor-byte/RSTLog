using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.Components
{
    public partial class Sort
    {
        [Parameter]
        public EventCallback<string> OnSortChange { get; set; }

        private async Task ApplySort(ChangeEventArgs eventArgs)
        {
            if (eventArgs.Value.ToString() == "-1")
                return;

            await OnSortChange.InvokeAsync(eventArgs.Value.ToString());
        }




    }
}
