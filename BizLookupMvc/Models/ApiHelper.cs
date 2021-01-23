using System.Threading.Tasks;
using RestSharp;
using System;

namespace BizLookupMvc.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"businesses", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(int id)
      {
        RestClient client = new RestClient("http://localhost:5000/api");
        RestRequest request = new RestRequest($"businesses/{id}", Method.GET);
        var response = await client.ExecuteTaskAsync(request);
        return response.Content;
      }

    public static async Task Post(string newBusiness)
    {
      RestClient client = new RestClient("http://locahost:5000/api");
      RestRequest request = new RestRequest($"businesses", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newBusiness);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Put(int id, string newBusiness)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"businesses/{id}", Method.PUT);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newBusiness);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Delete(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"businesses/{id}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      var response = await client.ExecuteTaskAsync(request);
    }

    
  }
}