using Codility_Task_3.Model;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codility_Task_3.Helpers
{
    public static class LeaderboardHelper
    {
        public static bool CheckUserExists(string username)
        {
            string accessToken = "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJrZXkiOiJUaW5ndGluZyIsImVtYWlsIjoiYmFrZXJ3aWxzb25uekBnbWFpbC5jb20iLCJpYXQiOjE2NTg3MDM5OTQsImV4cCI6MTY1ODk2MzE5NH0.Rgfp0qctwOGJf-GnZWY6NQl710Y2M4Alc41p4nNvz1qDaqxFfkFs1RzTMUhektnDVfdiVvXsbMAY4T213EjXYQ";
            var client = new RestClient("https://supervillain.herokuapp.com/v1/user");
            var request = new RestRequest(Method.GET);
            request.AddHeader("content-type", "application/json");
            request.AddHeader("Authorization", accessToken);
            IRestResponse response = client.Execute(request);

            // Deserialise response into list of custom model object
            var Sresponse = JsonConvert.DeserializeObject<List<LeaderboardUser>>(response.Content);

            // See if there are any entries with the correct username
            var actualUser = Sresponse.Find(x => x.username == username);

            // If not null then user exists, otherwise they don't
            return actualUser != null ? true : false;
        }

        public static void AddUser(string username, string score)
        {
            string jsonBody = "{\"username\":\"" + username + "\",\"score\":" + score + "}";

            string accessToken = "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJrZXkiOiJUaW5ndGluZyIsImVtYWlsIjoiYmFrZXJ3aWxzb25uekBnbWFpbC5jb20iLCJpYXQiOjE2NTg3MDM5OTQsImV4cCI6MTY1ODk2MzE5NH0.Rgfp0qctwOGJf-GnZWY6NQl710Y2M4Alc41p4nNvz1qDaqxFfkFs1RzTMUhektnDVfdiVvXsbMAY4T213EjXYQ";
            var client = new RestClient("https://supervillain.herokuapp.com/v1/user");
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddHeader("Authorization", accessToken);
            request.AddParameter("text/json", jsonBody, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
        }

        public static void UpdateUser(string username, string score)
        {
            string jsonBody = "{\"username\":\"" + username + "\",\"score\":" + score + "}";

            string accessToken = "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJrZXkiOiJUaW5ndGluZyIsImVtYWlsIjoiYmFrZXJ3aWxzb25uekBnbWFpbC5jb20iLCJpYXQiOjE2NTg3MDM5OTQsImV4cCI6MTY1ODk2MzE5NH0.Rgfp0qctwOGJf-GnZWY6NQl710Y2M4Alc41p4nNvz1qDaqxFfkFs1RzTMUhektnDVfdiVvXsbMAY4T213EjXYQ";
            var client = new RestClient("https://supervillain.herokuapp.com/v1/user");
            var request = new RestRequest(Method.PUT);
            request.AddHeader("content-type", "application/json");
            request.AddHeader("Authorization", accessToken);
            request.AddParameter("text/json", jsonBody, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
        }
    }
}
