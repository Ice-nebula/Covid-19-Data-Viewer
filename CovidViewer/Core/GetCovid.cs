using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CovidViewer.Models;
using Newtonsoft.Json;
namespace CovidViewer.Core
{
    class GetCovid
    {
        private readonly HttpClient Client;

        public GetCovid()
        {
            Client = new HttpClient();

        }

        public async Task<CovidData> GetData(string Country)
        {
            var GetCovid = await Client.GetAsync("https://corona.lmao.ninja/v2/countries/"+Country + "?yesterday&strict&query");
            if (GetCovid.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                var Message = JsonConvert.DeserializeObject<MessageModel>(await GetCovid.Content.ReadAsStringAsync());
                throw new Exception(Message.Message);
            }//end if
            else if (GetCovid.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                throw new Exception("service BadRequest");
            }//end else if
                var CovidJson = await GetCovid.Content.ReadAsStringAsync();
                var DataResault = JsonConvert.DeserializeObject<CovidData>(CovidJson);
            var Epoch = DateTimeOffset.FromUnixTimeMilliseconds(Convert.ToInt64(DataResault.updated));
            DataResault.updated = Epoch.ToString("f");
            return DataResault;
        }//end method.GetData
    }
}
