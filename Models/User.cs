using System.Collections.Generic;

namespace asp_net_web_api.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}