using System.Threading.Tasks;
using RestSharp;

namespace Bookworm.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("https://localhost:5001/api/Books");
      //https://localhost:5001/api/Books
  
      RestRequest request = new RestRequest($"books", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}