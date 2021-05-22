namespace ExaminationRoomsSelector.Web.Application.DataServiceClients
{
    using ExaminationRoomsSelector.Web.Application.Dtos;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Text.Json;
    using System.Threading.Tasks;
    using WebApp.Application;

    public class DoctorsServiceClient : IDoctorsServiceClient
    {

        public IHttpClientFactory clientFactory;
        public DoctorsServiceClient(IHttpClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public async Task<IEnumerable<DoctorDto>> GetAllDoctors()
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
           $"https://localhost:44310/Person/Doctors");
            request.Headers.Add("Accept", "application/json");

            var client = clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            using var responseStream = await response.Content.ReadAsStreamAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
            responseStream.Position = 0;
            return await JsonSerializer.DeserializeAsync<IEnumerable<DoctorDto>>(responseStream, options);
            responseStream.Position = 0;
        }
    }
}
