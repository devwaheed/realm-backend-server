using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace realm_backend_server
{
    public class RemTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Complete { get; set; }
        public DateTime CompletedDate { get; set; }

        
    }


}
