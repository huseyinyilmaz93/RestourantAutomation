using RA.Kernel.Common;
using RA.Kernel.Exceptions;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RA.WindowsConnector.Helpers
{
    public static class HttpClientHelper
    {
        public static Response<T> Get<T>(string path)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(HttpClientConstant.BASE_ADDRESS);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(HttpClientConstant.MEDIA_TYPE));
                try
                {
                    HttpResponseMessage httpResponse = client.GetAsync(path).Result;
                    if (httpResponse.IsSuccessStatusCode)
                        return new Response<T>() { HasError = false, Result = httpResponse.Content.ReadAsAsync<T>().Result };
                    else
                        return new Response<T>() { HasError = true, StatusCode = (short)httpResponse.StatusCode, Message = httpResponse.Content.ReadAsStringAsync().Result };
                }
                catch (AggregateException)
                {
                    return new Response<T>() { HasError = true, Message = "Sunucuya bağlanılamadı." };
                }
            }
        }

        public static Response<T> Post<T>(string path, T input)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(HttpClientConstant.BASE_ADDRESS);
                client.Timeout = new TimeSpan(0, 0, 5);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(HttpClientConstant.MEDIA_TYPE));
                try
                {
                    HttpResponseMessage httpResponse = client.PostAsJsonAsync(path, input).Result;
                    if (httpResponse.IsSuccessStatusCode)
                        return new Response<T>() { HasError = false, Result = httpResponse.Content.ReadAsAsync<T>().Result };
                    else
                        return new Response<T>() { HasError = true, StatusCode = (short)httpResponse.StatusCode, Message = httpResponse.Content.ReadAsStringAsync().Result };
                }
                catch (AggregateException)
                {
                    return new Response<T>() { HasError = true, Message = "Sunucuya bağlanılamadı." };
                }
            }
        }

        public static Response<bool> Delete(string path, int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(HttpClientConstant.BASE_ADDRESS);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(HttpClientConstant.MEDIA_TYPE));

                try
                {
                    HttpResponseMessage httpResponse = client.DeleteAsync(string.Concat(path, id)).Result;
                    if (httpResponse.IsSuccessStatusCode)
                        return new Response<bool>() { HasError = false, Result = true };
                    else
                        return new Response<bool>() { HasError = true, StatusCode = (short)httpResponse.StatusCode, Message = httpResponse.Content.ReadAsStringAsync().Result };
                }
                catch (AggregateException)
                {
                    return new Response<bool>() { HasError = true, Result = false, Message = "Sunucuya bağlanılamadı." };
                }

            }
        }
    }

    public static class HttpClientConstant
    {
        public const string MEDIA_TYPE = "application/json";
        public const string BASE_ADDRESS = "http://localhost:9999/";
    }
}