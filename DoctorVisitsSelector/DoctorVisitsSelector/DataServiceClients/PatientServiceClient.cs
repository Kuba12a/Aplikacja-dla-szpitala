using DoctorVisitsSelector.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace DoctorVisitsSelector.DataServiceClients
{
    public class PatientServiceClient : IPatientServiceClient
    {
        public IHttpClientFactory clientFactory;
        public PatientServiceClient(IHttpClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public async Task<IEnumerable<PatientDto>> GetAllPatients()
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
           $"https://localhost:44310/Person/Patients");
            request.Headers.Add("Accept", "application/json");

            var client = clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            using var responseStream = await response.Content.ReadAsStreamAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
            responseStream.Position = 0;
            return await JsonSerializer.DeserializeAsync<IEnumerable<PatientDto>>(responseStream, options);
            responseStream.Position = 0;
        }
    }
}
