using RA.Kernel.Exceptions;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace RA.WindowsConnector.Helpers
{
    public static class HttpClientHelper
    {
        public static T Get<T>(string path)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(HttpClientConstant.BASE_ADDRESS);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(HttpClientConstant.MEDIA_TYPE));
                HttpResponseMessage httpResponse = client.GetAsync(path).Result;
                if (httpResponse.IsSuccessStatusCode)
                    return httpResponse.Content.ReadAsAsync<T>().Result;
                else
                    throw new ApiException(httpResponse.Content.ReadAsStringAsync().Result, (short)httpResponse.StatusCode);
            }
        }

        public static T Post<T>(string path, T input)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(HttpClientConstant.BASE_ADDRESS);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(HttpClientConstant.MEDIA_TYPE));
                HttpResponseMessage httpResponse = client.PostAsJsonAsync(path, input).Result;
                if (httpResponse.IsSuccessStatusCode)
                    return httpResponse.Content.ReadAsAsync<T>().Result;
                else
                    throw new ApiException(httpResponse.Content.ReadAsStringAsync().Result, (short)httpResponse.StatusCode);
            }
        }

        public static bool Delete(string path, int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(HttpClientConstant.BASE_ADDRESS);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(HttpClientConstant.MEDIA_TYPE));
                HttpResponseMessage httpResponse = client.DeleteAsync(string.Concat(path, id)).Result;
                return httpResponse.IsSuccessStatusCode;
            }
        }
    }

    public static class HttpClientConstant
    {
        public const string MEDIA_TYPE = "application/json";
        public const string BASE_ADDRESS = "http://localhost:9999/";
    }
}