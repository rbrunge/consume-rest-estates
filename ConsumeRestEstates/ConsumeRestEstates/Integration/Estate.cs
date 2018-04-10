namespace ConsumeRestEstates.Integration
{
    using Newtonsoft.Json;

    public partial class Estate
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("estateTypeName")]
        public string EstateTypeName { get; set; }

        [JsonProperty("estateType")]
        public string EstateType { get; set; }

        [JsonProperty("postalCode")]
        public long PostalCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("photoUrl")]
        public string PhotoUrl { get; set; }

        [JsonProperty("rooms")]
        public long Rooms { get; set; }

        [JsonProperty("floors")]
        public long Floors { get; set; }

        [JsonProperty("floor")]
        public long Floor { get; set; }

        [JsonProperty("lot")]
        public long Lot { get; set; }

        [JsonProperty("basement")]
        public long Basement { get; set; }

        [JsonProperty("area")]
        public long Area { get; set; }

        [JsonProperty("year")]
        public long Year { get; set; }

        [JsonProperty("energyClass")]
        public string EnergyClass { get; set; }

        [JsonProperty("price")]
        public long Price { get; set; }

        [JsonProperty("ownerExpenses")]
        public long OwnerExpenses { get; set; }

        [JsonProperty("latitude")]
        public long Latitude { get; set; }

        [JsonProperty("longitude")]
        public long Longitude { get; set; }
    }

    public static class Serialize
    {
        public static string ToJson(this Estate[] self) => JsonConvert.SerializeObject(self, ConsumeRestEstates.Integration.Converter.Settings);
    }
}