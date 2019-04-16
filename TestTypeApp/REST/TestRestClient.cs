using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace TestTypeApp.REST
{
    class TestRestClient
    {
        RestClient client;
        public TestRestClient()
        {
            client = new RestClient("http://localhost:8080/socks-web/rest");
        }

        public string DbTest(string someText)
        {
            var request = new RestRequest("dbtest/greeting", Method.GET);

            request.AddParameter("connectionstring", someText); 
            IRestResponse response = client.Execute(request);
            return response.Content; 
        }

    }
}
