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

            var Sresponse = JsonConvert.DeserializeObject<List<LeaderboardUser>>(response.Content);

            var actualUser = Sresponse.Find(x => x.username == username);

            return actualUser != null ? true : false;
        }

        public static void AddUser(string username, int score)
        {

        }

        public static void UpdateUser(string username, int score)
        {

        }
    }
}
