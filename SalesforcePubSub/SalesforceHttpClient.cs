using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace SalesforcePubSub
{
    public class SalesforceHttpClient
    {
        public string LoginEndpoint = "https://login.salesforce.com/services/oauth2/token";
        public string Username = ""; //change with your data
        public string Password = "";//change with your data
        public string Token = "";
        public string ClientId = "";//change with your data
        public string ClientSecret = "";//change with your data
        public string GrantType = "password";

        public readonly HttpClient client;
        public SalesforceHttpClient()
        {
            client = new HttpClient();
        }

        public async Task<AuthResponse> GetToken()
        {
            HttpContent formData = new FormUrlEncodedContent(new Dictionary< string, string>
            {
                { "username",Username },
                { "password", Password },
                { "client_id", ClientId },
                { "client_secret", ClientSecret },
                { "grant_type", GrantType }
            });

            HttpRequestMessage requestMessage = new HttpRequestMessage();
            requestMessage.Content = formData;
            requestMessage.Method = HttpMethod.Post;
            requestMessage.RequestUri = new Uri(LoginEndpoint);

            HttpResponseMessage httpResponse = await client.SendAsync(requestMessage);
            var content = await httpResponse.Content.ReadAsStringAsync();
            AuthResponse authResponse = JsonConvert.DeserializeObject(content) as AuthResponse;

            return authResponse;
        }
    }
}

