using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestingPOC.DTO
{
    public class CreateUserDTO
    {
        public string name { get; set; }
        public string job { get; set; }
        public long id { get; set; }
        public DateTimeOffset createdAt { get; set; }
    }
}
 
