using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DavesAutos.Models
{
    public class CarAndCustomerViewModel
    {

        public ApplicationUser UserObj { get; set; }
        public IEnumerable<Car> Cars { get; set; }

    }
}
