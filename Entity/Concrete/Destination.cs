using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Destination
    {
        public int DestinationId { get; set; }
        public string City { get; set; }
        public string LengthOfStay { get; set; }

        public double Price { get; set; }
        public string Image { get; set; }
        public string DestinationDescription { get; set; }
        public int Capacity { get; set; }
        public bool Status { get; set; }
    }
}
