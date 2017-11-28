using MobileShop.Domain.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MobileShop.Repository
{
    public class RepositoryBaseRest<P, T> : IRepositoryBaseRest<P, T>
    {
        #region Private Vars

        private HttpRequestMessage requestMessage;
        private const string contentTypeJson = "application/json";

        #endregion

        #region IRepositoryBaseRest implementation

        public async Task<T> ConsumeRestService(P requestObject, string url, HttpMethod method, Dictionary<string, string> headers = null, double timeOutInSeconds = 60)
        {
            Debug.WriteLine("Request Url: " + url);

            requestMessage = new HttpRequestMessage(method, url);
            if (method == HttpMethod.Post || method == HttpMethod.Put)
            {
                SetMessageContent(requestObject);
            }

            var client = new HttpClient();

            client.Timeout = TimeSpan.FromSeconds(timeOutInSeconds);
            if (headers != null)
            {
                foreach (var item in headers)
                {
                    client.DefaultRequestHeaders.Add(item.Key, item.Value);
                }
            }

            HttpResponseMessage response = await client.SendAsync(requestMessage);
            return await ManageResponseMessages(response);
        }

        #endregion

        #region Class Methods

        private void SetMessageContent(P requestObject)
        {
            string serializedRequestObject = JsonConvert.SerializeObject(requestObject);
            Debug.WriteLine("Json Request: " + serializedRequestObject);
            if (typeof(P) == typeof(List<KeyValuePair<string, string>>))
            {
                requestMessage.Content = new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>)requestObject);
            }
            else
            {
                StringContent serializedRequest = new StringContent(serializedRequestObject, Encoding.UTF8, contentTypeJson);
                requestMessage.Content = serializedRequest;
            }
        }

        private async Task<T> ManageResponseMessages(HttpResponseMessage response)
        {
            string responseString = await response.Content.ReadAsStringAsync();
            Debug.WriteLine("Json Response: " + responseString);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<T>(responseString);
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                throw new HttpRequestException(responseString);
            }
            else
            {
                throw new Exception(response.StatusCode.ToString());
            }
        }

        #endregion
    }
}
