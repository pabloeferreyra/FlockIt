﻿using FlockIt.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FlockIt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvincesController : ControllerBase
    {
        private readonly ILogger<ProvincesController> _logger;
        private readonly IConfiguration _config;
        static HttpClient client = new HttpClient();
        public ProvincesController(ILogger<ProvincesController> logger,
            IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        [HttpGet]
        public async Task<string> GetAsync(string name)
        {
            var api = _config.GetValue<string>("api");
            api = api + name;
            HttpResponseMessage response = await client.GetAsync(api);
            var content = await response.Content.ReadAsStringAsync();
            GeoRef? province = JsonSerializer.Deserialize<GeoRef>(content);
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
            return JsonSerializer.Serialize(province.provincias.FirstOrDefault().centroide);
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
        }
    }
}
