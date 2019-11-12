using Newtonsoft.Json;
using System;

namespace Model
{
    public class TestModel
    {
        [JsonProperty(PropertyName = "message")]
        public string TestProperty { get; set; }
    }
}
