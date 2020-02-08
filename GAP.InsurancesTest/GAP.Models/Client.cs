using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Document { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Insurance> Insurance { get; set; }
    }
}
