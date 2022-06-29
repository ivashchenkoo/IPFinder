using Newtonsoft.Json;

namespace IPFinder.Models
{
    public class IPConfig : BaseVM
    {
        public string Query { get; set; }

        public string Status { get; set; }

        public string Continent { get; set; }

        public string ContinentCode { get; set; }

        public string Country { get; set; }

        public string CountryCode { get; set; }

        public string Region { get; set; }

        public string RegionName { get; set; }

        public string City { get; set; }

        public string District { get; set; }

        [JsonProperty("zip")]
        public int? PostCode { get; set; }

        [JsonProperty("lat")]
        public double? Latitude { get; set; }

        [JsonProperty("lon")]
        public double? Longitude { get; set; }

        public string Timezone { get; set; }

        public string Currency { get; set; }

        [JsonProperty("isp")]
        public string ProviderDescription { get; set; }

        [JsonProperty("org")]
        public string ProviderName { get; set; }
    }
}
