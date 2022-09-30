using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Lybrary.Models
{
    public class Cars
    {
        public int Id { get; set; }
        [JsonProperty("Brand_Factory")]
        public string Brand { get; set; }
        public string Model { get; set; }

    }
}