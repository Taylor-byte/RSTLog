using Microsoft.AspNetCore.Components;
using RSTLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace RSTLog.HttpRepository
{
    public class AuditHttpRepository : IAuditHttpRepository
    {

        private readonly HttpClient _client;
        private readonly NavigationManager _navManager;

        public AuditHttpRepository(HttpClient client, NavigationManager navManager)
        {
            _client = client;
            _navManager = navManager;
        }
        public Task<Audit> GetAudit(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Audit>> GetAudits()
        {
            var audit = await _client.GetFromJsonAsync<List<Audit>>("Audit");

            return audit;
        }
    }
}
