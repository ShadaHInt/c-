using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoonProject2
{
    public class JsonClass
    {
        public string email { get; set; }
        public string password { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string[] invalidEmail { get; set; }
        public string[] invalidPass { get; set; }
        public string search1 { get; set; }
        public string search2 { get; set; }
        public string cartsearch { get; set; } 
    }
}
