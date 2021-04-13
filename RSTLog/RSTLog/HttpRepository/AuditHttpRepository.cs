using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;
using RSTLog.Features;
using RSTLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace RSTLog.HttpRepository
{
    public class AuditHttpRepository : IAuditHttpRepository
    {

        private readonly HttpClient _client;
        private readonly NavigationManager _navManager;
        private readonly JsonSerializerOptions _options =
           new JsonSerializerOptions { PropertyNameCaseInsensitive = true, };

        public AuditHttpRepository(HttpClient client, NavigationManager navManager)
        {
            _client = client;
            _navManager = navManager;
        }

        public async Task CreateAudit(Audit audit)
            => await _client.PostAsJsonAsync("Audit", audit);

        public async Task<Audit> GetAudit(int id)
        {
            var audit = await _client.GetFromJsonAsync<Audit>($"Audit/{id}");

            return audit;
        }

        public async Task<List<Audit>> GetAudits()
        {
            var audit = await _client.GetFromJsonAsync<List<Audit>>("Audit");

            return audit;
        }

        public async Task<PagingResponse<Audit>> GetAudits(RequestParams requestParams)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                //["totalCount"] = requestParams.TotalCount.ToString(),
                ["pageNumber"] = requestParams.PageNumber.ToString(),
                //["currentPage"] = requestParams.CurrentPage.ToString(),
                ["pageSize"] = requestParams.PageSize.ToString(),
                ["searchTerm"] = requestParams.SearchTerm == null ? "" : requestParams.SearchTerm,
                ["orderBy"] = requestParams.OrderBy == null ? "" : requestParams.OrderBy


            };

            //$"customer?pageNumber={requestParams.PageNumber}"
            var response = await _client.GetAsync(QueryHelpers.AddQueryString("Audit", queryStringParam));

            var content = await response.Content.ReadAsStringAsync();

            var pagingResponse = new PagingResponse<Audit>
            {
                Items = JsonSerializer.Deserialize<List<Audit>>(content, _options),
                MetaData = JsonSerializer.Deserialize<MetaData>(
                    response.Headers.GetValues("X-Pagination").First(), _options)
            };

            return pagingResponse;
        }
    }
}
