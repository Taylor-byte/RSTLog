using Microsoft.AspNetCore.Components;
using RSTLog.HttpRepository;
using RSTLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.Pages
{
    public partial class TransTypes
    {
        //instanciate the transaction type model
        private TransType _transType = new TransType();

        public List<TransType> TransTypeList { get; set; } = new List<TransType>();
        // Inject the Http repository interface for use.
        [Inject]
        public ITransTypeHttpRepository TransTypeRepo { get; set; }

        protected async override Task OnInitializedAsync()
        {

            await GetTransTypes();

        }

        private async Task GetTransTypes()
        {
            //list employees in the table
            TransTypeList = await TransTypeRepo.GetTransTypes();

            foreach (var transType in TransTypeList)
            {
                Console.WriteLine(transType.Trans_Type);
            }
        }

    }
}
