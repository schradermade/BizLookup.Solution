using System.ComponentModel.DataAnnotations;

namespace BizLookupMvc.Models
{
    public class Business
    {
      public int BusinessId { get; set; }
      [Required]
      [StringLength(50)]
      public string Name { get; set; }
      [Required]
      [StringLength (50)]
      public string Industry { get; set; }
      [Required]
      [StringLength (50)]
        // [Range(0, 200, ErrorMessage = "Industry must be between 0 and 200.")]
      public string Address { get; set; }
      [Required]
      public string Hours { get; set; }

      public static List<Business> GetBusinesses()
      {
        var apiCallTask = ApiHelper.GetAll();
        var result = apiCallTask.Result;

        JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
        List<Business> businessList = JsonConvert.DeserializeObject<List<Business>>(jsonResponse.ToString());

        return businessList;
      }

      public static Business GetDetails(int id)
      {
        var apiCallTask = ApiHelper.Get(id);
        var result = apiCallTask.Result;

        JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
        Business Business = JsonConvert.DeserializeObject<Business>(jsonResponse.ToString());

        return Business;
      }

      public static void Post(Business business)
      {
        string jsonBusiness = JsonConvert.SerializeObject(business);
        var apiCallTask = ApiHelper.Post(jsonBusiness);
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