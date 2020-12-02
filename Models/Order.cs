using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace asp_net_web_api.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }

        [JsonIgnore]
        public virtual User User { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}