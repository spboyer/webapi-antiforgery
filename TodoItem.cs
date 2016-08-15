using Newtonsoft.Json;

namespace webapi_antiforgery
{
    public class TodoItem
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
