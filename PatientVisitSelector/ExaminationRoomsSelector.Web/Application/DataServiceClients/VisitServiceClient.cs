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

    public class VisitServiceClient : IVisitServiceClient
    {
        public IHttpClientFactory clientFactory;
        public VisitServiceClient(IHttpClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public async Task<IEnumerable<VisitDto>> GetAllPatientVisitsAsync(int id)
        {
            string strId = id.ToString();
            
            //Mam nadzieje ze tak zadziala ten request z id 
            string requestWithId = String.Format("https://localhost:44323/GetVisits-ByPatientId?id={0}", strId);


            var request = new HttpRequestMessage(HttpMethod.Get, requestWithId);

            request.Headers.Add("Accept", "application/json");

            

            var client = clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            using var responseStream = await response.Content.ReadAsStreamAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
            responseStream.Position = 0;

            return await JsonSerializer.DeserializeAsync<IEnumerable<VisitDto>>(responseStream, options);

            responseStream.Position = 0;
        }

        public async Task<IEnumerable<VisitDto>> GetAllPatientVisitsByDateAsync(string date, int id)
        {
            string strId = id.ToString();

            string requestWithId = String.Format("https://localhost:44323/GetVisits-ByDateNPatientId?date={0}&id={1}", date, strId);


            var request = new HttpRequestMessage(HttpMethod.Get, requestWithId);

            request.Headers.Add("Accept", "application/json");

            var client = clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            using var responseStream = await response.Content.ReadAsStreamAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
            responseStream.Position = 0;

            return await JsonSerializer.DeserializeAsync<IEnumerable<VisitDto>>(responseStream, options);

            responseStream.Position = 0;
        }
        public async Task<IEnumerable<VisitDto>> GetAllPatientVisitsByClinicAsync(string clinicAdress, int id)
        {
            string strId = id.ToString();

            string requestWithId = String.Format("https://localhost:44323/GetVisits-ByClinicNPatientId?clinic={0}&id={1}", clinicAdress, strId);


            var request = new HttpRequestMessage(HttpMethod.Get, requestWithId);

            request.Headers.Add("Accept", "application/json");

            var client = clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            using var responseStream = await response.Content.ReadAsStreamAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
            responseStream.Position = 0;

            return await JsonSerializer.DeserializeAsync<IEnumerable<VisitDto>>(responseStream, options);

            responseStream.Position = 0;
        }
    }
}

