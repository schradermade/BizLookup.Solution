using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace BizLookupMvc.Models
{
    public class Business
    {
      public int BusinessId { get; set; }
      
      [StringLength(50)]
      public string Name { get; set; }
    
      [StringLength (50)]
      public string Industry { get; set; }
      
      [StringLength (50)]
        // [Range(0, 200, ErrorMessage = "Industry must be between 0 and 200.")]
      public string Address { get; set; }
      
      public string Hours { get; set; }
      public string URL { get; set; }
      
      [Range(10, 10, ErrorMessage = "Phone number must be exactly 10 digits.")]
      public string Phone { get; set; }

      public static List<Business> GetBusinesses()
      {
        var apiCallTask = ApiHelper.GetAll();
        var result = apiCallTask.Result;

        JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
        List<Business> businessList = JsonConvert.DeserializeObject<List<Business>>(jsonResponse.ToString());

        return businessList;
      }

      public static async Task<Business> GetDetails(int id)
      {
        string result = await ApiHelper.Get(id);

        JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
        Business business = JsonConvert.DeserializeObject<Business>(jsonResponse.ToString());

        return business;
      }

      public static async Task PostBiz(Business business)
      {
        string jsonBusiness = JsonConvert.SerializeObject(business);
        await ApiHelper.Post(jsonBusiness);
      }

      public static void Put(Business business)
      {
        string jsonBusiness = JsonConvert.SerializeObject(business);
        var apiCallTask = ApiHelper.Put(business.BusinessId, jsonBusiness);
      }

      public static void Delete(int id)
      {
        var apiCallTask = ApiHelper.Delete(id);
      }

    }
}