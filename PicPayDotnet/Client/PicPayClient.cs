using System.Net.Http.Headers;
using System.Net.Http.Json;
using Microsoft.Extensions.DependencyInjection;
using PicPayDotnet.Interfaces;
using PicPayDotnet.Models;
using PicPayDotnet.Utils;

namespace PicPayDotnet.Client
{
    public class PicPayClient
    {
        private readonly HttpClient? PicPayClientHttp;

        public PicPayClient(ServiceProvider serviceProvider)
        {
            PicPayClientHttp = (serviceProvider.GetService<IHttpClientFactory>() ?? throw new Exception("ServiceProvider is null, build the service first!")).CreateClient("PicPayClient");
        }

        public PicPayClient(IPicPayConfiguration _configuration)
        {
            PicPayClientHttp = new HttpClient()
            {
                BaseAddress = new Uri(_configuration.URL),
            };
            PicPayClientHttp.DefaultRequestHeaders.Add("x-picpay-token", _configuration.PicPayToken);
            PicPayClientHttp.DefaultRequestHeaders.Add("user-agent", JSONExtension.GetUserAgent());
            PicPayClientHttp.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<PicPayPaymentResponse> CreateRequest(PicPayPaymentRequest paymentRequest)
        {
            var endpoint = PicPayClientHttp?.BaseAddress + "payments";

            var response = await PicPayClientHttp.PostAsJsonAsync(endpoint, paymentRequest);

            if (response.IsSuccessStatusCode)
                return JSONExtension.GetJsonObject<PicPayPaymentResponse>(response.Content.ReadAsStringAsync().Result);
            else
            {
                var descricao = JSONExtension.GetJsonObject<PicPayErros>(response.Content.ReadAsStringAsync().Result);

                throw new Exception($"Ocorreu um erro ao gerar o QR Code! Segue abaixo o erro: \n{descricao.Campo}: {descricao.Mensagem}");
            }
        }

        public async Task<PicPayPaymentResponse> GetStatusAsync(string referenceId)
        {
            var endpoint = PicPayClientHttp?.BaseAddress + $"payments/{referenceId}/status";

            return await PicPayClientHttp.GetFromJsonAsync<PicPayPaymentResponse>(endpoint);
        }

        public async Task<PicPayPaymentResponse> CancelRequestAsync(PicPayPaymentRequest paymentRequest)
        {
            var endpoint = PicPayClientHttp.BaseAddress + $"payments/{paymentRequest.ReferenceId}/cancellations";

            var response = await PicPayClientHttp.PostAsJsonAsync(endpoint, paymentRequest);

            if (response.IsSuccessStatusCode)
                return JSONExtension.GetJsonObject<PicPayPaymentResponse>(response.Content.ReadAsStringAsync().Result);
            else
            {
                var descricao = JSONExtension.GetJsonObject<PicPayErros>(response.Content.ReadAsStringAsync().Result);

                throw new Exception($"Ocorreu um erro ao gerar o QR Code! Segue abaixo o erro: \n{descricao.Campo}: {descricao.Mensagem}");
            }
        }
    }
}