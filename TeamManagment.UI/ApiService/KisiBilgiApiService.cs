using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TeamManagment.UI.Models.DTO;

namespace TeamManagment.UI.ApiService
{
    public class KisiBilgiApiService
    {
        private readonly HttpClient _client;
        public KisiBilgiApiService(HttpClient client)
        {
            _client = client;
        }
        public async Task<List<KisiBilgiDTO>> KisileriListele()
        {
            List<KisiBilgiDTO> kisiListesi = null;
            var donenDeger = await _client.GetAsync("api/kisiDetay");
            if (donenDeger.IsSuccessStatusCode)
            {
                kisiListesi = JsonConvert.DeserializeObject<List<KisiBilgiDTO>>(await donenDeger.Content.ReadAsStringAsync());
            }
            return kisiListesi;
        }

        public async Task<bool> KisiEkle(KisiDTO data)
        {
            var content = new StringContent(JsonConvert.SerializeObject(data));
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            bool responseContent = false;
            try
            {
                var donenCevap = await _client.PostAsync("api/kisiEkle", content);
                if (donenCevap.IsSuccessStatusCode)
                {
                    // responseContent = await donenCevap.Content.ReadAsStringAsync();
                    responseContent = true;
                }
            }
            catch (Exception ex)
            {
                // responseContent = "bir hata oluştu." + ex.Message;
                responseContent = false;
            }
            return responseContent;
        }
    }
}
