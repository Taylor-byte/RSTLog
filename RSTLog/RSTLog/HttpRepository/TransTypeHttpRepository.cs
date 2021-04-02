using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;
using RSTLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace RSTLog.HttpRepository
{
    public class TransTypeHttpRepository : ITransTypeHttpRepository
    {


        private readonly HttpClient _client;
        private readonly NavigationManager _navManager;

        public TransTypeHttpRepository(HttpClient client, NavigationManager navManager)
        {
            _client = client;
            _navManager = navManager;
        }

        public async Task CreateTransType(TransType transType)
             => await _client.PostAsJsonAsync("TransType", transType);


    }
}
